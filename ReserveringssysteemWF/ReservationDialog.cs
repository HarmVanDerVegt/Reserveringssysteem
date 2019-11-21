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
        private BindingList<BoatType> displayBoatTypes = new BindingList<BoatType>();

        private void UpdateDisplay()
        {
            displayBoatTypes.Clear();

            // Show available boats based on the team
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

            if ((BoatType)boatTypeComboBox.SelectedItem != null)
                coxswainComboBox.Enabled = ((BoatType)boatTypeComboBox.SelectedItem).HasCoxswain;
            else
                coxswainComboBox.Enabled = false;

            removeMemberButton.Enabled = teamListBox.SelectedIndex != -1;
            boatTypeComboBox.Enabled = displayBoatTypes.Count > 0;
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



            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (BoatType boatType in context.BoatTypes)
                    boatTypes.Add(boatType);

            UpdateDisplay();
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            members.Remove((Member)teamListBox.SelectedItem);
            UpdateDisplay();
        }
    }
}
