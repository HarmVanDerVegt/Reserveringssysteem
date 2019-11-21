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
            CreateBoatDialog.ShowDialog();
            ShowBoatsTable();
        }

        public void ShowBoatsTable()
        {
            Datagrid_Boats.Rows.Clear();

            string hasCoxswain = "";
            using (var db = new ReserveringssysteemContext())
            {
                var sortBoats = (from b in db.Boats
                                 orderby b.BoatType.Size, b.BoatType.HasCoxswain, b.BoatType.Name
                                 select b);

                foreach (var b in sortBoats.Include(b => b.BoatType))
                {
                    if (b.BoatType.HasCoxswain)
                        hasCoxswain = "ja";
                    else
                        hasCoxswain = "nee";

                    for (int i = 0; i < Datagrid_Boats.Rows.Count; i++)
                    {
                        if ((string)Datagrid_Boats.Rows[i].Cells[0].Value == b.BoatType.Name)
                        {
                            Datagrid_Boats.Rows.RemoveAt(i);
                        }
                    }
                    if(b.BoatStatus == BoatStatus.Whole)
                    Datagrid_Boats.Rows.Add(b.BoatType.Name, b.BoatType.Size, hasCoxswain, AmountOfBoats(b));
                }
            }
        }

        private int AmountOfBoats(Boat boat)
        {
            return boat.BoatType.Boats.Count;
        }

        private void Bt_DeleteBoat_Click(object sender, EventArgs e)
        {
            using (var db = new ReserveringssysteemContext())
            {
                foreach (DataGridViewRow row in Datagrid_Boats.SelectedRows)
                {
                    string typeName = (string)row.Cells[0].Value;

                    db.Boats.Remove(
                        db.Boats.Include(b => b.BoatType).Where(b => b.BoatType.Name == typeName).First()
                        );

                    db.SaveChanges();

                    ShowBoatsTable();
                }
            }
        }
    }
}
