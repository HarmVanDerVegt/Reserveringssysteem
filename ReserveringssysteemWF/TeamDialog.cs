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
        private List<MatchTeam> teams = new List<MatchTeam>();
        public TeamDialog()
        {
            InitializeComponent();
        }

        private void TeamDialog_Load(object sender, EventArgs e)
        {
            teamsListBox.Items.Add(teams.Count());
            //UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            teamsListBox.Items.Clear();
            foreach (MatchTeam team in teams)
            {
                teamsListBox.Items.Add(team.Name);
                teamsListBox.Items.Add("1 found");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
