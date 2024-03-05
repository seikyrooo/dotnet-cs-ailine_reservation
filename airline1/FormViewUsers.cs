using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline1
{
    public partial class FormViewUsers : Form
    {
        db_airlineEntities db;
        public FormViewUsers()
        {
            InitializeComponent();

        }
        void loadtable()
        {
            db = new db_airlineEntities();
            odusers.DataSource = db.tbl_user.ToList();
        }
        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void otsearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_airlineEntities();
            var table = db.tbl_user.Where(a=>a.user_id.EndsWith(otsearch.Text) || a.user_name .StartsWith(otsearch.Text)).ToList();
            if (table!= null)
            {
                odusers.DataSource = table;

            }
            else
            {
                loadtable();
            }
        }

        private void obinput_Click(object sender, EventArgs e)
        {
            FormUsers fu = new FormUsers(null);
            fu.ShowDialog();
        }

        private void odusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && odusers.Columns[e.RowIndex].HeaderText == "Action 1")
            {
                string id = odusers.Rows[e.RowIndex].Cells["cuserid"].Value.ToString();
                FormUsers update = new FormUsers(id);
                update.ShowDialog();
                loadtable();
            }
            if ( e.RowIndex >= 0 && odusers.Columns[e.ColumnIndex].HeaderText == "Action 2")
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db = new db_airlineEntities();
                    string deleteid = odusers.Rows[e.RowIndex].Cells["cuserid"].Value.ToString();
                    var user = db.tbl_user.Where(a=>a.user_id == deleteid).FirstOrDefault();
                    db.tbl_user.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di hapus");
                    loadtable();

                }
            }
        }

        private void FormViewUsers_Activated(object sender, EventArgs e)
        {
            loadtable();
            otsearch.Text = string.Empty;
            cdupdate.FlatStyle = FlatStyle.Popup;
            cdupdate.DefaultCellStyle.BackColor = Color.Blue;
            cdupdate.DefaultCellStyle.ForeColor = Color.White;

            cddelete.FlatStyle = FlatStyle.Popup;
            cddelete.DefaultCellStyle.BackColor = Color.Red;
            cddelete.DefaultCellStyle.ForeColor = Color.White;
        }
    }
}
