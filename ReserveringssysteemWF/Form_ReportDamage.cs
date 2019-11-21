using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            Datagrid_ReportDamage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowReservationBoats();
        }

        private void ShowReservationBoats()
        {
            Datagrid_ReportDamage.Rows.Clear();
            using (var db = new ReserveringssysteemContext()) {

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
            using (var db = new ReserveringssysteemContext())
            {
                foreach (DataGridViewRow row in Datagrid_ReportDamage.SelectedRows)
                {
                    string typeName = (string)row.Cells[0].Value;

                    var SelectedReservationBoats = from b in db.Boats
                                                   where b.BoatType.Name == typeName
                                                   select b;

                    foreach (var boat in SelectedReservationBoats)
                    {
                        boat.BoatStatus = BoatStatus.Notified;
                    }
                }

                string messageBoxText = "De schade is succesvol gemeld";
                string caption = "Schade gemeld";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result;
                result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

                if (result == MessageBoxResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
