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
    public partial class FormSeats : Form
    {
        db_airlineEntities db;
        string vid;
        DateTime vdoj;
        public FormSeats(string id, DateTime doj)
        {
            InitializeComponent();
            vid = id;
            vdoj = doj;
        }

        private void FormSeats_Load(object sender, EventArgs e)
        {
            otflightid.Text = vid;
            oddateofjourney.Value = vdoj;
            db = new db_airlineEntities();
            var flight = db.tbl_flight.Where(a=>a.flight_id == vid).FirstOrDefault();
            int totalseat = Convert.ToInt32(flight.seats);
            for (int i = 1; i <= totalseat; i++)
            {
                odseatno.Rows.Add(i, "Select");

            }
            cdselect.FlatStyle = FlatStyle.Popup;
            cdselect.DefaultCellStyle.BackColor = Color.Green;
            cdselect.DefaultCellStyle.ForeColor= Color.White;
            foreach (DataGridViewRow row in odseatno.Rows)
            {
                int seatno = Convert.ToInt32(row.Cells["cdseatno"].Value.ToString());
                var book = db.tbl_booking.Where(a => a.seat_no == seatno && a.flight_id == otflightid.Text && a.dateofjourney.Value == oddateofjourney.Value.Date).FirstOrDefault();
                if (book != null)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    totalseat -= 1;
                }
                else
                {
                    row.DefaultCellStyle.BackColor= Color.Green;
                }
                row.DefaultCellStyle.ForeColor= Color.White;
                olseattersedia.Text = totalseat.ToString();
                if (totalseat == 0)
                {
                    MessageBox.Show("Seat pada jadwal ini sudah penuh", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    olseattersedia.ForeColor = Color.Red;
                }
            }
        }

        private void odseatno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && odseatno.Columns[e.ColumnIndex].HeaderText == "Action") 
            {
                if (odseatno.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Red)
                {
                    MessageBox.Show("Seat telah di Booking oleh pelanggan lain", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vseatno = odseatno.Rows[e.RowIndex].Cells["cdseatno"].Value.ToString();
                    this.Close();

                }
            }
        }
    }
}
