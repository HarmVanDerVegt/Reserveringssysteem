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
    public partial class Form_RemoveBoatFromUse : Form
    {
        public Form_RemoveBoatFromUse()
        {
            InitializeComponent();
            Datagrid_RemoveBoatFromUse1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagrid_RemoveBoatFromUse2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
