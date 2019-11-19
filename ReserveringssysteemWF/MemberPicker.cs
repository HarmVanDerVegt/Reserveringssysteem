using Reserveringssysteem;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private readonly List<Member> members = new List<Member>();
        private BindingList<Member> displayMembers = new BindingList<Member>();

        public Member SelectedMember { get; set; }

        public MemberPicker()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SelectedMember = (Member)memberListBox.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void UserPicker_Load(object sender, EventArgs e)
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (User user in context.Users)
                    if (user.GetType() == typeof(Member))
                        members.Add((Member)user);

            filterTextBox_TextChanged(this, new EventArgs());

            memberListBox.DataSource = displayMembers;
            memberListBox.DisplayMember = "Name";
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            displayMembers.Clear();
            foreach (Member member in members)
            {
                if (string.IsNullOrWhiteSpace(filterTextBox.Text) || member.Name.ToLower().Contains(filterTextBox.Text.ToLower()))
                    displayMembers.Add(member);
            }

            memberListBox_SelectedIndexChanged(this, new EventArgs());
        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = memberListBox.SelectedIndex != -1;
        }
    }
}
