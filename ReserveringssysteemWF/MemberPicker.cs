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

        private void MemberPicker_Load(object sender, EventArgs e)
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (User user in context.Users)
                    if (user.GetType().IsEquivalentTo(typeof(Member)))
                        members.Add((Member)user);

            memberListBox.DataSource = displayMembers;
            memberListBox.DisplayMember = "Name";
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            displayMembers.Clear();

            foreach (Member member in members)
                if (string.IsNullOrWhiteSpace(filterTextBox.Text) || member.Name.Contains(filterTextBox.Text))
                    displayMembers.Add(member);  
        }
    }
}
