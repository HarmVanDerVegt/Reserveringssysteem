using System;
using Reserveringssysteem;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ReserveringssysteemWF
{
    public partial class MatchCreatorDialog : Form
    {
        private List<MatchTeam> teams = new List<MatchTeam>();
        public MatchCreatorDialog()
        {
            InitializeComponent();
            UpdateStartTime();
        }

        private void MatchCreatorDialog_Load(object sender, EventArgs e)
        {
            using (var db = new ReserveringssysteemContext())
            {
                var query = from boattype in db.BoatTypes.Include(b => b.Certificate)
                            select boattype;

                foreach (var item in query)
                {
                    boatTypeList.Items.Add(item);
                }

                //    boatTypeList.DisplayMember = "Name";
            }
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            TeamDialog teamDialog = new TeamDialog();
            if (teamDialog.ShowDialog() == DialogResult.OK)
            {
                if (!teams.Select(m => m.ID).ToList().Contains(teamDialog.SelectedTeam.ID))
                    teams.Add(teamDialog.SelectedTeam);
                else
                    MessageBox.Show("Dit team is al ingeschreven!", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateDialog();
        }


        private void UpdateDialog()
        {
            teamListBox.Items.Clear();
            foreach (MatchTeam mteam in teams)
            {
                teamListBox.Items.Add(mteam);
                teamListBox.DisplayMember = "Name";
            }
        }

        public void UpdateStartTime()
        {
            using (var db = new ReserveringssysteemContext())
            {
                startTimeComboBox.Items.Clear();
                endTimeComboBox.Items.Clear();
                DateTime dateTime = datePickerMatch.SelectionStart;
                DateTime startTime = dateTime.AddHours(12);

                //Get all existing matches
                var query = from Match in db.Matches
                            select Match;

                //Continue to offer times with steps of 15m untill 17h has been reached, minimal duration of 30m
                while (startTime <= dateTime.AddHours(16).AddMinutes(30))
                {
                    if (TimeIsAvaible(startTime, query.ToList(), 30))
                    {
                        startTimeComboBox.Items.Add(startTime.TimeOfDay);
                    }
                    startTime += new TimeSpan(0, 15, 0);
                }
            }
        }
        public bool TimeIsAvaible(DateTime startTime, List<Match> query, int Margin)
        {
            foreach (var item in query)
            {
                //If the time collides with the time of an existing match, escape with false.
                if (startTime < item.DateTime + item.Duration && startTime.AddMinutes(Margin) > item.DateTime)
                {
                    return false;
                }
            }
            return true;
        }

        public void UpdateEndTime()
        {
            using (var db = new ReserveringssysteemContext())
            {

                var query = from Match in db.Matches
                            select Match;
                DateTime dateTime = datePickerMatch.SelectionStart;
                DateTime startTime = dateTime.AddHours(12);
                //From starttime (combobox) continue offering endtimes with steps of 15m until 17h has been reached
                endTimeComboBox.Items.Clear();

                while (startTime <= dateTime.AddHours(17).AddMinutes(00))
                {
                    DateTime date = datePickerMatch.SelectionStart;
                    date = date.Date + (TimeSpan)startTimeComboBox.SelectedItem;

                    if (TimeIsAvaible(startTime, query.ToList(), 0))
                    {
                        if (startTime >= date.AddMinutes(30)) { endTimeComboBox.Items.Add(startTime.TimeOfDay); }
                    }
                    else
                    {
                        if (startTime >= date.AddMinutes(30)) { break; }
                    }
                    startTime += new TimeSpan(0, 15, 0); 

                }
            }

        }

        private void RemoveMemberButton_Click(object sender, EventArgs e)
        {
            teams.Remove((MatchTeam)teamListBox.SelectedItem);
            UpdateDialog();
        }

        private void DistanceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check whether key pressed is a number.
            if (System.Text.RegularExpressions.Regex.IsMatch(DistanceTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("U kunt alleen cijfers invoeren");
                DistanceTextBox.Text = DistanceTextBox.Text.Remove(DistanceTextBox.Text.Length - 1);
            }
        }

        private void DatePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateStartTime();
        }

        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }
        private bool Checkvalues()
        {
            bool checkteams = teams.Count > 1 ? true : false;
            bool checkboattype = (BoatType)boatTypeList.SelectedItem != null ? true : false;
            bool checkstarttime = (startTimeComboBox.SelectedIndex > -1) ? true : false;
            bool checkendtime = (endTimeComboBox.SelectedIndex > -1) ? true : false;

            if (checkteams && checkboattype && checkstarttime && checkendtime)
            {
                return true;
            }
            return false;


        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Checkvalues())
            {
                // Retrieve input data for export
                DateTime date = datePickerMatch.SelectionStart;
                date = date.Date + (TimeSpan)startTimeComboBox.SelectedItem;
                int distance = Int32.Parse(DistanceTextBox.Text);
                TimeSpan duration = (TimeSpan)endTimeComboBox.SelectedItem - (TimeSpan)startTimeComboBox.SelectedItem;
                BoatType boattype = (BoatType)boatTypeList.SelectedItem;

                using (var db = new ReserveringssysteemContext())
                {
                    BoatType type = (from bt in db.BoatTypes
                                     where bt.ID == boattype.ID
                                     select bt).Single();

                    Match match = new Match() { DateTime = date, Distance = distance, Duration = duration, Type = type, /*Participants = teams*/ };
                    db.Matches.Add(match);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Er kon geen wedstrijd worden aangemaakt. Controleer of ieder veld is ingevuld", "Wedstrijd kon niet worden gemaakt",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
