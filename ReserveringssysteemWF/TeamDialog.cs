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

namespace ReserveringssysteemWF
{
    public partial class TeamDialog : Form
    {
        public MatchTeam SelectedTeam { get; set; }
        public TeamDialog()
        {
            InitializeComponent();
        }

        private void TeamDialog_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            teamsListBox.Items.Clear();
            using (var db = new ReserveringssysteemContext())
            {
                var query = from teams in db.MatchTeams
                            select teams;

                foreach (var item in query)
                {
                    if (string.IsNullOrWhiteSpace(filterTextBox.Text) || item.Name.ToLower().Contains(filterTextBox.Text.ToLower()))
                        teamsListBox.Items.Add(item);
                }
                teamsListBox.DisplayMember = "Name";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SelectedTeam = (MatchTeam)teamsListBox.SelectedItem;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
