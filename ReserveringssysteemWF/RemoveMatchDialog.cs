using Reserveringssysteem;
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
    public partial class RemoveMatchDialog : Form
    {
        private DataGridViewSelectedRowCollection Rows { get; set; }
        public RemoveMatchDialog(DataGridViewSelectedRowCollection rows)
        {
            InitializeComponent();
            Rows = rows;
            foreach (DataGridViewRow removerow in Rows)
            {
                Remove_Datagrid_Games.Rows.Add(removerow.Cells[0].Value, removerow.Cells[1].Value, removerow.Cells[2].Value, removerow.Cells[3].Value, removerow.Cells[4].Value, removerow.Cells[5].Value, removerow.Cells[6].Value);
                Match.SetIDList((int)removerow.Cells[6].Value);
            }

            if (Rows.Count > 1)
            {
                ContextMessage_Label.Text = "Weet je zeker dat je de volgende wedstrijden wilt verwijderen?";
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Match.RemoveMatch();
        }

    }
}
