using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reserveringssysteem;

namespace ReserveringssysteemWF
{
    public partial class Form_Login : Form
    {
        private Form_Mainscreen Mainscreen;
        public Form_Login(Form_Mainscreen mainscreen)
        {
            Mainscreen = mainscreen;
            InitializeComponent();
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            MailAddress Email = new MailAddress(Tb_Login.Text);
            string Password = Tb_Password.Text;
            
            if (Member.Login(Convert.ToString(Email), Password))
            {
                Close();
                Mainscreen.LoginScreen();
            }
            else
            {
                Lb_ErrorMessageLogin.Text = "Email en wachtwoord komen niet overeen.";
            }
        }
    }
}
