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
        private BindingList<Member> members = new BindingList<Member>();

        private List<BoatType> boatTypes = new List<BoatType>();
        private List<Certificate> certificates = new List<Certificate>();

        private BindingList<BoatType> displayBoatTypes = new BindingList<BoatType>();

        private BindingList<Member> coxswains = new BindingList<Member>();

        private BindingList<DateTime> startTimes = new BindingList<DateTime>();

        private TimeSpan duration;

        private void UpdateDisplay()
        {
            // Show available boats based on the team
            displayBoatTypes.Clear();
            foreach (BoatType boatType in boatTypes)
                if (boatType.Size + (boatType.HasCoxswain ? 1 : 0) == members.Count)
                {
                    bool available = true;

                    foreach (Member member in members)
                        if (member.Levels == null || !member.Levels.Select(c => c.ID).ToList().Contains(boatType.ID))
                        {
                            //MessageBox.Show(member.Levels == null ? "null" : "not null");
                            available = false;
                            break;
                        }

                    if (available)
                        displayBoatTypes.Add(boatType);
                }

            // Show available coxswains based on the team
            coxswains.Clear();
            Certificate coxswainCertificate = certificates.Find(c => c.Name == "Certificate Stuurman");
            foreach (Member member in members)
                if (member.Levels != null && coxswainCertificate != null && member.Levels.Select(c => c.ID).ToList().Contains(coxswainCertificate.ID))
                    coxswains.Add(member);

            if ((BoatType)boatTypeComboBox.SelectedItem != null)
                coxswainComboBox.Enabled = ((BoatType)boatTypeComboBox.SelectedItem).HasCoxswain;
            else
                coxswainComboBox.Enabled = false;

            removeMemberButton.Enabled = teamListBox.SelectedIndex != -1;
            boatTypeComboBox.Enabled = displayBoatTypes.Count > 0;

            // Show available starttimes
            startTimes.Clear();

            DateTime s = datePicker.SelectionStart;
            TimeSpan ts = new TimeSpan(0, 0, 0);
            s = s.Date + ts;

            DateTime item = s.AddHours(12); // 12:00:00
            while (item <= s.AddHours(17)) // 17:00:00
            {
                // TODO: if there is a boat available at this time
                startTimes.Add(item);

                item = item.AddMinutes(15);
            }

            startTimeComboBox.Items.Clear();
            foreach (DateTime dateTime in startTimes)
            {
                startTimeComboBox.Items.Add(dateTime.ToShortTimeString());
            }
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

            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
            {
                foreach (BoatType boatType in context.BoatTypes)
                    boatTypes.Add(boatType);

                foreach (Certificate certificate in context.Certificates)
                    certificates.Add(certificate);
            }

            for (int i = 15; i <= 120; i += 15)
            {
                durationComboBox.Items.Add(i + " minuten");
            }

            durationComboBox.SelectedIndex = 0;

            datePicker.MinDate = DateTime.Now.AddDays(2);
            datePicker.MaxDate = DateTime.Now.AddDays(14);

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

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            duration = new TimeSpan(0, int.Parse(durationComboBox.Text.Substring(0, durationComboBox.Text.Length - 8)), 0);
        }
    }
}
