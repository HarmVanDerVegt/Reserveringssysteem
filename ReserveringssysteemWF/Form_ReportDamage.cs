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
    public partial class Form_ReportDamage : Form
    {
        public Form_ReportDamage()
        {
            InitializeComponent();
        }

        private void Form_ReportDamage_Load(object sender, EventArgs e)
        {
            ShowReservationBoats();
        }

        private void ShowReservationBoats()
        {
            Datagrid_ReportDamage.Rows.Clear();
            using (var db = new ReserveringssysteemContext())
            {

                var ReservationBoats = from b in db.Reservations.Include(r => r.Team).Include(r => r.Boat.BoatType)
                                       select b;

                foreach (var a in ReservationBoats)
                {
                    Datagrid_ReportDamage.Rows.Add(a.DateTime, a.Boat.BoatType.Name);
                }
            }
        }
        private void Bt_ReportDamagedBoat_Click(object sender, EventArgs e)
        {
            Boat SelectedReservationboat = null;
            using (var db = new ReserveringssysteemContext())
            {
                foreach (DataGridViewRow row in Datagrid_ReportDamage.SelectedRows)
                {
                    string typeName = (string)row.Cells[1].Value;

                    SelectedReservationboat = (from b in db.Boats
                                               where b.BoatType.Name == typeName
                                               select b).First();

                    Console.WriteLine($"boatstatus: {SelectedReservationboat.BoatStatus.ToString()}");
                    SelectedReservationboat.BoatStatus = BoatStatus.Notified;
                    Console.WriteLine($"boatstatus: {SelectedReservationboat.BoatStatus.ToString()}");
                }
            }

            if (SelectedReservationboat.BoatStatus == BoatStatus.Notified)
            {
                string messageBoxText = "De schade is succesvol gemeld";
                string caption = "Schade gemeld";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon);

                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                string messageBoxText = "Schade melden is mislukt";
                string caption = "Melden mislukt";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon);

                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}


