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
        private List<int> idlist = new List<int>();
        public RemoveMatchDialog(DataGridViewSelectedRowCollection rows)
        {
            InitializeComponent();
            Rows = rows;
            foreach (DataGridViewRow removerow in Rows)
            {
                Remove_Datagrid_Games.Rows.Add(removerow.Cells[0].Value, removerow.Cells[1].Value, removerow.Cells[2].Value, removerow.Cells[3].Value, removerow.Cells[4].Value, removerow.Cells[5].Value, removerow.Cells[6].Value);
                idlist.Add((int)removerow.Cells[6].Value);
                Console.WriteLine((int)removerow.Cells[6].Value);
            }
        }

  

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new ReserveringssysteemContext())
            {
                foreach (int id in idlist)
                {
                    Match query = (from item in db.Matches where item.ID == id select item).Single();
                    db.Matches.Remove(query);
                }

                db.SaveChanges();
            }
        }
    }
}
