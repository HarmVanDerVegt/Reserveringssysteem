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
    public partial class MatchCreatorDialog : Form
    {
        private BindingList<Team> members = new BindingList<Team>();
        public MatchCreatorDialog()
        {
            InitializeComponent();
        }

        private void MatchCreatorDialog_Load(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            TeamDialog teamDialog = new TeamDialog();
            teamDialog.ShowDialog();


        }
    }
}
