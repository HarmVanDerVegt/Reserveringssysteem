﻿using System;
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
            FillComboBox();
        }

        private void FillComboBox()
        {
            using (var db = new ReserveringssysteemContext())
            {
                var query = from boatType in db.BoatTypes
                            select boatType.Name;

                foreach (var item in query)
                {
                    Cb_AddBoats.Items.Add(item);
                }
            }
        }

        private void Bt_Add_AddBoats_Click(object sender, EventArgs e)
        {
            Boat boat = null;
            using(var db = new ReserveringssysteemContext())
            {
                var boatTypes = from boatType in db.BoatTypes
                                where boatType.Name == (string)Cb_AddBoats.SelectedItem
                                select boatType;

                foreach (var boatType in boatTypes)
                {
                    boat = new Boat(boatType);
                }
                db.SaveChanges();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cb_AddBoats.Text = "Skiff";
        }
    }
}
