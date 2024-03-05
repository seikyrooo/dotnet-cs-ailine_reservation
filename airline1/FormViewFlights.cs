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
    public partial class FormViewFlights : Form
    {
        db_airlineEntities db;
        public FormViewFlights()
        {
            InitializeComponent();
        }

        private void obinput_Click(object sender, EventArgs e)
        {
            FormFlight input = new FormFlight(null);
            input.ShowDialog();
        }
        void LoadTable()
        {
            db = new db_airlineEntities();
            odflights.DataSource = db.tbl_flight.ToList();
        }
        private void FormViewFlights_Activated(object sender, EventArgs e)
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

        private void otsearch_TextChanged(object sender, EventArgs e)
        {
            if(otsearch.Text != string.Empty)
            {
                odflights.DataSource = db.tbl_flight.Where(a=>a.flight_id.EndsWith(otsearch.Text) || a.flight_name.StartsWith(otsearch.Text)).ToList();
            }
            else
            {
                LoadTable();
            }
        }

        private void odflights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (odflights.Columns[e.ColumnIndex].HeaderText == "Action 1" && e.RowIndex >= 0)
            {
                string id = odflights.Rows[e.RowIndex].Cells["cdflightid"].Value.ToString();

                FormFlight update = new FormFlight(id);
                update.ShowDialog();
            }
            if(odflights.Columns[e.ColumnIndex].HeaderText == "Action 2" && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin Menghapus Data ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string deleteid = odflights.Rows[e.RowIndex].Cells["cdflightid"].Value.ToString();
                    var flight = db.tbl_flight.Where(a=>a.flight_id == deleteid).FirstOrDefault();
                    db.tbl_flight.Remove(flight);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil dihapus");
                }
            }
        }
    }
}
