using Reserveringssysteem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReserveringssysteemWF
{
    public partial class ReservationDialog : Form
    {
        private List<BoatType> boatTypes = new List<BoatType>();
        private List<Certificate> certificates = new List<Certificate>();

        private BindingList<Member> members = new BindingList<Member>();
        private BindingList<BoatType> displayBoatTypes = new BindingList<BoatType>();
        private BindingList<Member> coxswains = new BindingList<Member>();
        private BindingList<DateTime> startTimes = new BindingList<DateTime>();
        private BindingList<TimeSpan> durations = new BindingList<TimeSpan>();

        private void UpdateDisplayBoatTypes()
        {
            displayBoatTypes.Clear();
            foreach (BoatType boatType in boatTypes)
                if (boatType.Size + (boatType.HasCoxswain ? 1 : 0) == members.Count)
                {
                    bool available = true;

                    foreach (Member member in members)
                        if (member.Levels == null || !member.Levels.Select(c => c.ID).ToList().Contains(boatType.ID))
                        {
                            available = false;
                            break;
                        }

                    if (available)
                        displayBoatTypes.Add(boatType);
                }
        }

        private void UpdateCoxswain()
        {
            coxswains.Clear();
            Certificate coxswainCertificate = certificates.Find(c => c.Name == "Certificate Stuurman");
            foreach (Member member in members)
                if (member.Levels != null && coxswainCertificate != null && member.Levels.Select(c => c.ID).ToList().Contains(coxswainCertificate.ID))
                    coxswains.Add(member);
        }

        private void UpdateStartTimes()
        {
            startTimes.Clear();

            DateTime dateTime = datePicker.SelectionStart;
            dateTime = dateTime.Date + new TimeSpan(0, 0, 0);

            DateTime startTime = dateTime.AddHours(12);

            while (startTime <= dateTime.AddHours(17))
            {
                bool available = true;

                if (boatTypeComboBox.SelectedItem != null)
                    foreach (Boat boat in ((BoatType)boatTypeComboBox.SelectedItem).Boats)
                        foreach (Reservation reservation in boat.Reservations)
                        {
                            DateTime aStart = reservation.DateTime;
                            DateTime aEnd = reservation.DateTime + reservation.Duration + new TimeSpan(0, 15, 0);
                            DateTime bStart = startTime;
                            DateTime bEnd = startTime + (TimeSpan)durationComboBox.SelectedItem;

                            available = !(aStart < bEnd && bStart < aEnd);
                            break;
                        }

                if (available)
                    startTimes.Add(startTime);

                startTime += new TimeSpan(0, 15, 0);
            }
        }

        private void UpdateDisplay()
        {
            // Show available boats based on the team
            UpdateDisplayBoatTypes();

            // Show available coxswains based on the team
            UpdateCoxswain();

            // Show available starttimes
            UpdateStartTimes();

            coxswainComboBox.Enabled = (BoatType)boatTypeComboBox.SelectedItem != null && ((BoatType)boatTypeComboBox.SelectedItem).HasCoxswain;
            removeMemberButton.Enabled = teamListBox.SelectedIndex != -1;
            boatTypeComboBox.Enabled = displayBoatTypes.Count > 0;
        }

        public ReservationDialog()
        {
            InitializeComponent();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            MemberPicker memberPicker = new MemberPicker();
            if (memberPicker.ShowDialog() == DialogResult.OK)
            {
                if (!members.Select(m => m.ID).ToList().Contains(memberPicker.SelectedMember.ID))
                    members.Add(memberPicker.SelectedMember);
                else
                    MessageBox.Show("Dit lid zit al in uw team!", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateDisplay();
        }

        private void ReservationDialog_Load(object sender, EventArgs e)
        {
            teamListBox.DataSource = members;
            teamListBox.DisplayMember = "Name";

            boatTypeComboBox.DataSource = displayBoatTypes;
            boatTypeComboBox.DisplayMember = "Name";

            coxswainComboBox.DataSource = coxswains;
            coxswainComboBox.DisplayMember = "Name";

            durationComboBox.DataSource = durations;
            startTimeComboBox.DataSource = startTimes;

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                foreach (BoatType boatType in context.BoatTypes.Include("Boats.Reservations"))
                    boatTypes.Add(boatType);

                foreach (Certificate certificate in context.Certificates)
                    certificates.Add(certificate);
            }

            datePicker.MinDate = DateTime.Now.AddDays(2);
            datePicker.MaxDate = DateTime.Now.AddDays(14);

            TimeSpan timeSpan = new TimeSpan(0, 15, 0);

            while (timeSpan <= new TimeSpan(2, 0, 0))
            {
                durations.Add(timeSpan);
                timeSpan += new TimeSpan(0, 15, 0);
            }

            UpdateDisplay();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            members.Remove((Member)teamListBox.SelectedItem);
            UpdateDisplay();
        }

        private void datePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDisplay();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            RecreationalTeam recreationalTeam = new RecreationalTeam();
            recreationalTeam.Users = new List<User>();

            foreach (Member member in members)
                recreationalTeam.Users.Add(member);

            recreationalTeam.Coxswain = (User)coxswainComboBox.SelectedItem;

            reservation.Team = recreationalTeam;
            reservation.Boat = ((BoatType)boatTypeComboBox.SelectedItem).Boats.First();
            reservation.DateTime = (DateTime)startTimeComboBox.SelectedItem;
            reservation.Duration = (TimeSpan)durationComboBox.SelectedItem;

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                context.Reservations.Add(reservation);

                foreach (var foo in context.GetValidationErrors())
                {
                    foreach (var bar in foo.ValidationErrors)
                    {
                        MessageBox.Show(bar.PropertyName + " " + bar.ErrorMessage);
                    }
                }

                context.SaveChanges();
            }
        }
    }
}
