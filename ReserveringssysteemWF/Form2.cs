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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }

        private void FillComboBox()
        {
            using (var db = new ReserveringssysteemContext())
            {
                var query = from boatType in db.BoatTypes
                            select boatType.Name;

                foreach (var item in query)
                {
                    Cb_AddBoats.Items.AddRange(item);
                }
            }
        }

        private void Bt_Add_AddBoats_Click(object sender, EventArgs e)
        {
            foreach(BoatType boatType in BoatType.Fleet)
            {
                if (boatType.Name == (string)Cb_AddBoats.SelectedItem)
                {
                    Boat boat = new Boat(boatType);
                    Dispose();
                }
            }
        }

        private void Bt_Cancel_AddBoats_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
