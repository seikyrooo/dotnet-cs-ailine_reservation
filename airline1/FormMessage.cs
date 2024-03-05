using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static airline1.GLobalClass;

namespace airline1
{
    public partial class FormMessage : Form
    {
        db_airlineEntities db;
        public FormMessage()
        {
            InitializeComponent();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            db = new db_airlineEntities();
            dmessage.DataSource = db.tbl_message.Where(a => a.penerima == vuserid).ToList();
            dmessage.Columns[3].Visible = false;
        }

        private void dmessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tmessage.Text = dmessage.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void bkirimpesan_Click(object sender, EventArgs e)
        {
            FormKirimPesan fkp = new FormKirimPesan();
            fkp.ShowDialog();
        }
    }
}
