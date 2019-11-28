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
            startTimeComboBox.Items.Clear();

            foreach (TimeSpan timeSpan in Match.GetAvaibleTime(datePickerMatch.SelectionStart.Date, false, new TimeSpan(0,0,0)))
            {
                startTimeComboBox.Items.Add(timeSpan);
            }
        }
        public void UpdateEndTime()
        {
            endTimeComboBox.Items.Clear();
            TimeSpan selectStart = (TimeSpan)startTimeComboBox.SelectedItem - Reservation.ReservationStartTime;
            foreach (TimeSpan timeSpan in Match.GetAvaibleTime(datePickerMatch.SelectionStart.Date, true, selectStart))
            {
                endTimeComboBox.Items.Add(timeSpan);
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


        private void Button1_Click(object sender, EventArgs e)
        {
            if (Match.CheckGivenInputValue(teams, (BoatType)boatTypeList.SelectedItem, startTimeComboBox.SelectedIndex, endTimeComboBox.SelectedIndex))
            {
                // Retrieve input data for export
                DateTime date = datePickerMatch.SelectionStart;
                date = date.Date + (TimeSpan)startTimeComboBox.SelectedItem;
                int distance = Int32.Parse(DistanceTextBox.Text);
                TimeSpan duration = (TimeSpan)endTimeComboBox.SelectedItem - (TimeSpan)startTimeComboBox.SelectedItem;
                BoatType boattype = (BoatType)boatTypeList.SelectedItem;

                Match.AddMatch(date, distance, duration, boattype);
            }
            else
            {
                MessageBox.Show("Er kon geen wedstrijd worden aangemaakt. Controleer of ieder veld is ingevuld", "Wedstrijd kon niet worden gemaakt",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
