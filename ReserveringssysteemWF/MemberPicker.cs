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
    public partial class MemberPicker : Form
    {
        public MemberPicker()
        {
            InitializeComponent();
        }

        private List<Member> members = new List<Member>();
        private BindingList<Member> displayMembers = new BindingList<Member>();

        public Member SelectedMember { get; set; }

        private void UpdateDisplayMembers()
        {
            displayMembers.Clear();

            foreach (Member member in members)
                if (string.IsNullOrWhiteSpace(filterTextBox.Text) || member.Name.ToLower().Contains(filterTextBox.Text.ToLower()))
                    displayMembers.Add(member);

            pickButton.Enabled = memberListBox.SelectedIndex != -1;
        }

        private void MemberPicker_Load(object sender, EventArgs e)
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (Member member in context.Members.Include("Levels").Include("Address"))
                        members.Add(member);

            memberListBox.DataSource = displayMembers;
            memberListBox.DisplayMember = "Name";

            UpdateDisplayMembers();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayMembers();
        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pickButton.Enabled = memberListBox.SelectedIndex != -1;
        }

        private void memberListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            pickButton.Enabled = memberListBox.SelectedIndex != -1;
        }

        private void pickButton_Click(object sender, EventArgs e)
        {
            SelectedMember = (Member)memberListBox.SelectedItem;
        }
    }
}
