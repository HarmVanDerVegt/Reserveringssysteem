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
        private BindingList<Member> members = new BindingList<Member>();
        private BindingList<BoatType> displayBoatTypes = new BindingList<BoatType>();
        private BindingList<Member> coxswains = new BindingList<Member>();
        private BindingList<DateTime> startTimes = new BindingList<DateTime>();
        private BindingList<TimeSpan> durations = new BindingList<TimeSpan>();


        /// <summary>
        /// Algorithm to show all available start times based on the boat type boats availability (start time & duration).
        /// </summary>
        private void UpdateStartTimes()
        {
            startTimes.Clear();

            DateTime dateTime = datePicker.SelectionStart;
            dateTime = dateTime.Date + new TimeSpan(0, 0, 0);

            DateTime startTime = dateTime.AddHours(12); // Start enumerating from 12:00 ...

            while (startTime <= dateTime.AddHours(17)) // ... to 17:00
            {
                bool available = true;

                // Current time range.
                DateTime aStart = startTime;
                DateTime aEnd = startTime + (TimeSpan)durationComboBox.SelectedItem;

                // Check if a boat type is selected and has boats associated with it.
                if (boatTypeComboBox.SelectedItem != null && ((BoatType)boatTypeComboBox.SelectedItem).Boats.Count > 0)
                    foreach (Boat boat in ((BoatType)boatTypeComboBox.SelectedItem).Boats)
                        if (available)
                            foreach (Reservation reservation in boat.Reservations)
                            {
                                // Time range of the current reservation
                                DateTime bStart = reservation.DateTime;
                                DateTime bEnd = reservation.DateTime + reservation.Duration;

                                // Check if the current time range (from the enumeration) conflicts the time range of the current reservation.
                                if (aStart <= bEnd && bStart <= aEnd)
                                {
                                    // If it does then don't show the current start time.
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
                context.SaveChanges();
            }
        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStartTimes();
        }
    }
}
