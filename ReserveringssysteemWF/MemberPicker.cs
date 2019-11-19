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
        public Member SelectedMember;

        public MemberPicker()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UserPicker_Load(object sender, EventArgs e)
        {
            using (ReserveringssysteemContext context = new ReserveringssysteemContext())
                foreach (User user in context.Users)
                    if (user.GetType() == typeof(Member))
                        memberListBox.Items.Add(user.Name);
        }
    }
}
