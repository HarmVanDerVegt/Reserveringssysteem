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
        BindingList<Member> teamData = new BindingList<Member>();
        BindingList<Member> coxswainData = new BindingList<Member>();

        public ReservationDialog()
        {
            InitializeComponent();
        }

        private void ReservationDialog_Load(object sender, EventArgs e)
        {
            datePicker.MinDate = DateTime.Today.AddDays(2);
            datePicker.MaxDate = DateTime.Today.AddDays(14);

            coxswainComboBox.DataSource = coxswainData;
            coxswainComboBox.DisplayMember = "Name";

            teamListBox.DataSource = teamData;
            teamListBox.DisplayMember = "Name";
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            MemberPicker userPicker = new MemberPicker();
            userPicker.ShowDialog();

            if (userPicker.DialogResult == DialogResult.OK)
            {
                coxswainData.Add(userPicker.SelectedMember);
                teamData.Add(userPicker.SelectedMember);
            }

            teamListBox_SelectedIndexChanged(this, new EventArgs());
        }

        private void RemoveMemberButton_Click(object sender, EventArgs e)
        {
            coxswainData.Remove((Member)teamListBox.SelectedItem);
            teamData.Remove((Member)teamListBox.SelectedItem);

            teamListBox_SelectedIndexChanged(this, new EventArgs());
        }

        private void teamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeMemberButton.Enabled = teamListBox.SelectedIndex != -1;
            coxswainComboBox.Enabled = teamData.Count > 0;
        }
    }
}
