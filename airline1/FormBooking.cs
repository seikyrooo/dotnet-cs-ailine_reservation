using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static airline1.GLobalClass;

namespace airline1
{
    public partial class FormBooking : Form
    {
        db_airlineEntities db;
        public FormBooking()
        {
            InitializeComponent();
        }
        void LoadDestnSource()
        {
            db = new db_airlineEntities();
            ocdestination.DataSource = (from fl in db.tbl_flight select fl.destination).Distinct().ToList();
            ocdestination.DisplayMember = "destination";
            ocsource.DataSource = (from fl in db.tbl_flight select fl.source).Distinct().ToList();
            ocsource.DisplayMember = "source";
            ocdestination.SelectedIndex = -1;
            ocsource.SelectedIndex = -1;
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            LoadDestnSource();
            AutoNumber();
            LoadCustomer();
            otname.Text = string.Empty;
            otfathername.Text = string.Empty;
            odbirthdate.Value = DateTime.Now;
            otemail.Text = string.Empty;
            otphone.Text = string.Empty;
            otaddress.Text = string.Empty;
        }
        void LoadCustomer()
        {
            db = new db_airlineEntities();
            occustomerid.DataSource = db.tbl_costumerdetails.ToList();
            occustomerid.DisplayMember= "costumer_id";
            occustomerid.SelectedIndex = -1;
        }
        void AutoNumber()
        {
            db = new db_airlineEntities();
            long hitung;
            string urutan;
            var max = (from book in db.tbl_booking select book.ticket_id).Max();
            if (max != null)
            {
                hitung = Convert.ToInt32(max.Substring(max.Length - 5, 5)) + 1;
                string kodeurutan = "00000" + hitung;
                urutan = "BOK" + kodeurutan.Substring(kodeurutan.Length -5 , 5);
            }
            else
            {
                urutan = "BOK00001";
            }
            otticketid.Text = urutan;
        }
        private void obshowflight_Click(object sender, EventArgs e)
        {
            db = new db_airlineEntities();
            odflight.DataSource = db.tbl_flight.Where(a=>a.destination == ocdestination.Text && a.source == ocsource.Text).ToList();

            cdselect.FlatStyle = FlatStyle.Popup;
            cdselect.DefaultCellStyle.BackColor= Color.Green;
            cdselect.DefaultCellStyle.ForeColor = Color.White;
        }

        private void occustomerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new db_airlineEntities();
            var cus = db.tbl_costumerdetails.Where(a=>a.costumer_id == occustomerid.Text).FirstOrDefault();
            if (cus != null)
            {
                otname.Text = cus.name;
                otfathername.Text = cus.father_name;
                odbirthdate.Value = cus.birth_date.Value;
                otemail.Text = cus.email;
                otphone.Text = cus.phone;
                otaddress.Text = cus.address;
            }
            
        }

        private void odflight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (odflight.Columns[e.ColumnIndex].HeaderText == "Action" && e.RowIndex >= 0)
            {
                otflightid.Text = odflight.Rows[e.RowIndex].Cells["cdflightid"].Value.ToString();
                otseatno.Text = string.Empty;
            }
        }
        string Time;
        private void obconfirmbooking_Click(object sender, EventArgs e)
        {
            if (occustomerid.Text != string.Empty ||otflightid.Text != string.Empty || otseatno.Text != string.Empty)
            {
                if (oddateofjourney.Value <= DateTime.Now)
                {
                    MessageBox.Show("Booking tidak bisa dilakukan pada tanggal tersebut");
                }
                else
                {
                    db = new db_airlineEntities();
                    tbl_booking book = new tbl_booking();
                    book.ticket_id = otticketid.Text;
                    book.costumer_id = occustomerid.Text;
                    book.dateofjourney = oddateofjourney.Value;
                    book.flight_id = otflightid.Text;
                    book.seat_no = Convert.ToInt32(otseatno.Text);
                    db.tbl_booking.Add(book);
                    db.SaveChanges();
                    DialogResult print = MessageBox.Show("Booking berhasil, ingin Print Struk ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    var flight = db.tbl_flight.Where(a => a.flight_id == otflightid.Text).FirstOrDefault();
                    Time = flight.departure;
                    if (print == DialogResult.Yes)
                    {
                        PPD.Document = PD;
                        PPD.ShowDialog();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Silahkan isi Data Penerbangan");
            }
        }
        private void oddateofjourney_ValueChanged(object sender, EventArgs e)
        {
            otseatno.Text = string.Empty;
        }

        private void obselectseat_Click(object sender, EventArgs e)
        {
            if (otflightid.Text == string.Empty || oddateofjourney.Value <= DateTime.Now)
            {
                MessageBox.Show("Silahkan isi terlebih dahulu Jadwal penerbangan");
            }
            else
            {
                FormSeats fs = new FormSeats(otflightid.Text, oddateofjourney.Value);
                fs.ShowDialog();
            }
            
        }
        private void FormBooking_Activated(object sender, EventArgs e)
        {
            if (vseatno != string.Empty)
            {
                otseatno.Text = vseatno;
            }
            vseatno = string.Empty;
        }

        private void PD_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            PageSettings ps = new PageSettings();
            ps.PaperSize = new PaperSize("Custom", 250, 500);
            PD.DefaultPageSettings = ps;
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f10 = new Font("Times New Roman", 10, FontStyle.Regular);
            Font f10b = new Font("Times New Roman", 10, FontStyle.Bold);
            Font f14 = new Font("Times New Roman", 14, FontStyle.Bold);

            int leftmargin = PD.DefaultPageSettings.Margins.Left;
            int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            int rightmargin = PD.DefaultPageSettings.PaperSize.Width;

            StringFormat kanan = new StringFormat();
            StringFormat tengah = new StringFormat();
            kanan.Alignment = StringAlignment.Far;
            tengah.Alignment = StringAlignment.Center;

            string garis = "-------------------------------------------------";

            e.Graphics.DrawString("Airline", f14, Brushes.Black, centermargin, 5, tengah);
            e.Graphics.DrawString("Jl Mauk No. 443", f10, Brushes.Black, centermargin, 25, tengah);
            e.Graphics.DrawString("Contact : 110-430", f10, Brushes.Black, centermargin, 40, tengah);

            e.Graphics.DrawString("User ID", f10, Brushes.Black, 0, 65);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 65);
            e.Graphics.DrawString(vuserid, f10, Brushes.Black, 100, 65);

            e.Graphics.DrawString("Name", f10, Brushes.Black, 0, 80);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 80);

            e.Graphics.DrawString(vusername, f10, Brushes.Black, 100, 80);

            e.Graphics.DrawString(DateTime.Now.ToString(), f10, Brushes.Black, 0, 100);

            e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 110);

            e.Graphics.DrawString("Customer ID", f10, Brushes.Black, 0, 125);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 125);

            e.Graphics.DrawString(occustomerid.Text, f10, Brushes.Black, 100, 125);

            e.Graphics.DrawString("Name", f10, Brushes.Black, 0, 140);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 140);

            e.Graphics.DrawString(otname.Text, f10, Brushes.Black, 100, 140);

            e.Graphics.DrawString("Flight ID", f10, Brushes.Black, 0, 155);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 155);

            e.Graphics.DrawString(otflightid.Text, f10, Brushes.Black, 100, 155);

            e.Graphics.DrawString("Source", f10, Brushes.Black, 0, 170);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 170);

            e.Graphics.DrawString(ocsource.Text, f10, Brushes.Black, 100, 170);

            e.Graphics.DrawString("Destination", f10, Brushes.Black, 0, 185);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 185);

            e.Graphics.DrawString(ocdestination.Text, f10, Brushes.Black, 100, 185);
            e.Graphics.DrawString("Journey", f10, Brushes.Black, 0, 200);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 200);

            e.Graphics.DrawString(oddateofjourney.Value.Date.ToString(), f10, Brushes.Black, 100, 200);

            e.Graphics.DrawString("Departure", f10, Brushes.Black, 0, 215);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 215);
            
            e.Graphics.DrawString(Time, f10, Brushes.Black, 100, 215);
            e.Graphics.DrawString("Seat No", f10, Brushes.Black, 0, 230);
            e.Graphics.DrawString(":", f10, Brushes.Black, 75, 230);

            e.Graphics.DrawString(otseatno.Text, f10, Brushes.Black, 100, 230);

            e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 245);
            e.Graphics.DrawString("Terima Kasih Telah", f10, Brushes.Black, centermargin, 270, tengah);
            e.Graphics.DrawString("Menggunakan Layanan Kami", f10, Brushes.Black, centermargin, 285, tengah);

        }
    }
}
