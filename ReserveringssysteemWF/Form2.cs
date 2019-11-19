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
            foreach (BoatType boatType in BoatType.Fleet)
            {
                Cb_AddBoats.Items.Add(boatType.Name);
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
