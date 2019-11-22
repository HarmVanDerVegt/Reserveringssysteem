using Reserveringssysteem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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

                DateTime aStart = startTime;
                DateTime aEnd = startTime + (TimeSpan)durationComboBox.SelectedItem;

                if (boatTypeComboBox.SelectedItem != null && ((BoatType)boatTypeComboBox.SelectedItem).Boats.Count > 0)
                    foreach (Boat boat in ((BoatType)boatTypeComboBox.SelectedItem).Boats)
                        if (available)
                            foreach (Reservation reservation in boat.Reservations)
                            {
                                DateTime bStart = reservation.DateTime;
                                DateTime bEnd = reservation.DateTime + reservation.Duration;

                                if (aStart <= bEnd && bStart <= aEnd)
                                {
                                    available = false;
                                    break;
                                }
                            }
                        else
                            break;
                else
                    available = false;

                if (available)
                    startTimes.Add(startTime);

                startTime += new TimeSpan(0, 15, 0);
            }

            startTimeComboBox.Enabled = startTimes.Count > 0;
            reserveButton.Enabled = startTimeComboBox.SelectedIndex != -1;
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
            reserveButton.Enabled = startTimeComboBox.SelectedIndex != -1;
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
            UpdateStartTimes();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                Reservation reservation = new Reservation();
                RecreationalTeam recreationalTeam = new RecreationalTeam();
                recreationalTeam.Users = new List<User>();

                foreach (Member member in members)
                    recreationalTeam.Users.Add(context.Members.Find(member.ID));

                if (coxswainComboBox.SelectedItem != null)
                    recreationalTeam.Coxswain = context.Members.Find(((Member)coxswainComboBox.SelectedItem).ID);

                reservation.Team = recreationalTeam;
                reservation.Boat = context.Boats.Find(1);
                reservation.DateTime = (DateTime)startTimeComboBox.SelectedItem;
                reservation.Duration = (TimeSpan)durationComboBox.SelectedItem;

                context.Reservations.AddOrUpdate(reservation);
                context.SaveChanges();
            }
        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStartTimes();
        }

        private void startTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
