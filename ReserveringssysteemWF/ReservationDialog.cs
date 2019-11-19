using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReserveringssysteemWF
{
    public partial class ReservationDialog : Form
    {
        public ReservationDialog()
        {
            InitializeComponent();
        }

        private void ReservationDialog_Load(object sender, EventArgs e)
        {
            datePicker.MinDate = DateTime.Today.AddDays(2);
            datePicker.MaxDate = DateTime.Today.AddDays(14);
            coxswainComboBox.Text = "Geen stuurman";
            teamListBox.Items.Add("Beau ter Ham");
        }
    }
}
