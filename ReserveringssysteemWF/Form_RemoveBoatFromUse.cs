using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reserveringssysteem;

namespace ReserveringssysteemWF
{
    public partial class Form_RemoveBoatFromUse : Form
    {
        public Form_RemoveBoatFromUse()
        {
            InitializeComponent();
            Datagrid_RemoveBoatFromUse1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_RemoveBoatFromUse2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowBrokenBoats();
            ShowBoatsInMaintenance();
        }

        private void ShowBrokenBoats()
        {
            Datagrid_RemoveBoatFromUse2.Rows.Clear();
            using (var db = new ReserveringssysteemContext())
            {
                var sortBoats = (from b in db.Boats
                                 orderby b.BoatType.Size, b.BoatType.HasCoxswain, b.BoatType.Name
                                 select b);

                foreach (var b in sortBoats.Include(b => b.BoatType))
                {
                    if (b.BoatStatus == BoatStatus.Maintenance)
                        Datagrid_RemoveBoatFromUse1.Rows.Add(b.BoatType.Name, b.BoatStatus.Description());
                }
            }
        }

        private void ShowBoatsInMaintenance()
        {
            using (var db = new ReserveringssysteemContext())
            {
                var sortBoats = (from b in db.Boats
                                 orderby b.BoatType.Size, b.BoatType.HasCoxswain, b.BoatType.Name
                                 select b);

                foreach (var b in sortBoats.Include(b => b.BoatType))
                {
                    if (b.BoatStatus == BoatStatus.Broken)
                        Datagrid_RemoveBoatFromUse2.Rows.Add(b.BoatType.Name, b.BoatStatus.Description());
                }
            }
        }

        private void Bt_RemoveBoatFromUse_Click(object sender, EventArgs e)
        {
            using (var db = new ReserveringssysteemContext())
            {
                foreach (DataGridViewRow row in Datagrid_RemoveBoatFromUse2.SelectedRows)
                {
                    string typeName = (string)row.Cells[0].Value;

                    var boats = (from b in db.Boats
                                 where b.BoatType.Name == typeName && b.BoatStatus == BoatStatus.Broken
                                 select b);

                    foreach (var boat in boats)
                    {
                        boat.BoatStatus = BoatStatus.Maintenance;
                    }

                    db.SaveChanges();
                }
            }
            ShowBoatsInMaintenance();
            ShowBrokenBoats();
        }
    }
}
