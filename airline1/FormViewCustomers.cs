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
    public partial class FormViewCustomers : Form
    {
        db_airlineEntities db;
        public FormViewCustomers()
        {
            InitializeComponent();
        }

        private void obinput_Click(object sender, EventArgs e)
        {
            FormCustomer input = new FormCustomer(null);
            input.ShowDialog();
        }
        
        void LoadTable()
        {
            db = new db_airlineEntities();
            odcustomers.DataSource = db.tbl_costumerdetails.ToList();
        }
        private void otsearch_TextChanged(object sender, EventArgs e)
        {
            if (otsearch.Text != string.Empty)
            {
                odcustomers.DataSource = db.tbl_costumerdetails.Where(a => a.costumer_id.EndsWith(otsearch.Text) || a.name.StartsWith(otsearch.Text)).ToList();
            }
            else
            {
                LoadTable();
            }
        }

        private void FormViewCustomers_Activated(object sender, EventArgs e)
        {
            LoadTable();

            otsearch.Text = string.Empty;

            cdupdate.FlatStyle = FlatStyle.Popup;
            cdupdate.DefaultCellStyle.BackColor = Color.Blue;
            cdupdate.DefaultCellStyle.ForeColor = Color.White;

            cddelete.FlatStyle = FlatStyle.Popup;
            cddelete.DefaultCellStyle.BackColor = Color.Red;
            cddelete.DefaultCellStyle.ForeColor = Color.White;
        }

        private void odcustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (odcustomers.Columns[e.ColumnIndex].HeaderText == "Action 1" && e.RowIndex >= 0)
            {
                string id = odcustomers.Rows[e.RowIndex].Cells["cdcostumerid"].Value.ToString();
                FormCustomer update = new FormCustomer(id);
                update.ShowDialog();
            }
            if (odcustomers.Columns[e.ColumnIndex].HeaderText == "Action 2" && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin Menghapus Data ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string deleteid = odcustomers.Rows[e.RowIndex].Cells["cdcostumerid"].Value.ToString();
                    var costumer = db.tbl_costumerdetails.Where(a => a.costumer_id == deleteid).FirstOrDefault();
                    db.tbl_costumerdetails.Remove(costumer);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil dihapus");
                }
                
            }
        }
    }
}
