using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reserveringssysteem;

namespace ReserveringssysteemWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BoatType.CreateBoatTypes();
            this.MinimumSize = new Size(600, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //Resize Title column. Nieuws pagina
            Datagrid_News.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_Boats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_Reservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_Games.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_Profiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_Members.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_Teams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void Bt_AddBoat_Click(object sender, EventArgs e)
        {
            ShowCreateBoatDialog();
        }

        private void ShowCreateBoatDialog()
        {
            Form2 CreateBoatDialog = new Form2();
            CreateBoatDialog.Show();
        }

        public void ShowBoatsTable(Boat boat)
        {
            //Datagrid_Boats[0]
        }
    }
}
