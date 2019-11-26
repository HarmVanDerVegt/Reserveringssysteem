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
        private RecreationalTeam recreationalTeam = new RecreationalTeam() { Users = new List<User>() };
        private bool coxswainRequired = false;
        private Boat reservedBoat = null;

        private void UpdateDisplay()
        {
            teamListBox.DataSource = null;
            teamListBox.DataSource = recreationalTeam.Users;
            teamListBox.DisplayMember = "Name";

            boatTypeComboBox.DataSource = null;
            boatTypeComboBox.DataSource = recreationalTeam.GetAvailableBoatTypes();
            boatTypeComboBox.DisplayMember = "Name";

            coxswainComboBox.DataSource = null;
            coxswainRequired = boatTypeComboBox.SelectedValue != null && ((BoatType)boatTypeComboBox.SelectedValue).HasCoxswain;

            if (coxswainRequired)
                coxswainComboBox.DataSource = recreationalTeam.GetAvailableCoxswains();

            removeMemberButton.Enabled = teamListBox.Items.Count > 0;
            boatTypeComboBox.Enabled = boatTypeComboBox.Items.Count > 0;
            coxswainComboBox.Enabled = coxswainComboBox.Items.Count > 0;

            UpdateStartTimes();
        }

        private void UpdateStartTimes()
        {
            startTimeComboBox.DataSource = null;

            BoatType boatType = (BoatType)boatTypeComboBox.SelectedItem;
            DateTime date = datePicker.SelectionStart.Date;
            TimeSpan duration = (TimeSpan)durationComboBox.SelectedItem;

            startTimeComboBox.DataSource = Reservation.GetAvailableBoatStartTimes(boatType, date, duration, out reservedBoat);

            startTimeComboBox.Enabled = startTimeComboBox.Items.Count > 0;

            if (coxswainRequired)
                reserveButton.Enabled = startTimeComboBox.SelectedIndex != -1 && coxswainComboBox.SelectedIndex != -1;
            else
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
                if (!recreationalTeam.Users.Select(u => u.ID).Contains(memberPicker.SelectedMember.ID))
                    recreationalTeam.Users.Add(memberPicker.SelectedMember);
                else
                    MessageBox.Show("Deze gebruiker is al toegevoegd aan uw team!", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateDisplay();
        }

        private void ReservationDialog_Load(object sender, EventArgs e)
        {
            List<TimeSpan> durations = new List<TimeSpan>();

            for (TimeSpan duration = new TimeSpan(0, 15, 0); duration <= new TimeSpan(2, 0, 0); duration += new TimeSpan(0, 15, 0))
                durations.Add(duration);

            durationComboBox.DataSource = durations.ToArray();

            datePicker.MinDate = DateTime.Now.AddDays(2);
            datePicker.MaxDate = DateTime.Now.AddDays(14);

            UpdateDisplay();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            recreationalTeam.Users.Remove((User)teamListBox.SelectedItem);
            UpdateDisplay();
        }

        private void datePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateStartTimes();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {

        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStartTimes();
        }
    }
}
