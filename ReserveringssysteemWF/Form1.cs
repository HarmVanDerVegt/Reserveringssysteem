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
using System.Data.Entity;

namespace ReserveringssysteemWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            ShowBoatsTable();


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

        private void ShowBoatsTable()
        {
            string hasCoxswain = "";
            using (var db = new ReserveringssysteemContext())
            {        
                foreach (var boat in db.Boats.Include(b => b.BoatType))
                {
                    if (boat.BoatType.HasCoxswain)
                    {
                        hasCoxswain = "ja";
                    }
                    else
                    {
                        hasCoxswain = "nee";
                    }
                    Datagrid_Boats.Rows.Add(boat.BoatType.Name, boat.BoatType.Size, hasCoxswain, AmountOfBoats(boat));
                }
            }
        }

        private int AmountOfBoats(Boat boat)
        {
            return boat.BoatType.Boats.Count;
        }

        private void Bt_AddReservation_Click(object sender, EventArgs e)
        {
            new ReservationDialog().ShowDialog();
        }

        private void Bt_AddGame_Click(object sender, EventArgs e)
        {
            new MatchCreatorDialog().ShowDialog();
        }
    }
}
