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

        private void UpdateDisplay()
        {

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
            teamListBox.DataSource = recreationalTeam.Users;
            teamListBox.DisplayMember = "Name";

            UpdateDisplay();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void datePicker_DateChanged(object sender, DateRangeEventArgs e)
        {

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

        }
    }
}
