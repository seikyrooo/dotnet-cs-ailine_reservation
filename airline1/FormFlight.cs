using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline1
{
    public partial class FormFlight : Form
    {
        string updateid;
        db_airlineEntities db;
        public FormFlight(string id)
        {
            InitializeComponent();
            updateid= id;
        }
        void AutoNumber()
        {
            db = new db_airlineEntities();
            string urutan;
            long hitung;
            var max = (from flg in db.tbl_flight select flg.flight_id).Max();
            if (max != null)
            {
                hitung = Convert.ToInt32(max.Substring(max.Length - 5, 5)) + 1;
                string kodeurutan = "00000" + hitung;
                urutan = "FLG" + kodeurutan.Substring(kodeurutan.Length -5, 5);
            }
            else
            {
                urutan = "FLG00001";
            }
            otflightid.Text = urutan;
        }
        private void FormFlight_Load(object sender, EventArgs e)
        {
            LoadDestnSource();
            if (updateid != null)
            {
                db = new db_airlineEntities();
                var flight = db.tbl_flight.Where(a=>a.flight_id == updateid).FirstOrDefault();
                otflightid.Text = flight.flight_id;
                otflightname.Text = flight.flight_name;
                ocsource.Text = flight.source;
                ocdestination.Text = flight.destination;
                otarrivaltime.Text = flight.arrival_time;
                otdeparture.Text = flight.departure;
                otflightclass.Text = flight.flight_class;
                otflightcharges.Text = flight.flight_charges.ToString();
                otseats.Text = flight.seats.ToString();
                obconfirm.Text = "Update";
            }
            else
            {
                AutoNumber();
                obconfirm.Text = "Input";
            }
            
        }
        void LoadDestnSource()
        {
            db = new db_airlineEntities();
            ocdestination.DataSource = (from fl in db.tbl_flight select fl.destination).Distinct().ToList();
            ocdestination.DisplayMember= "destination";
            ocsource.DataSource = (from fl in db.tbl_flight select fl.source).Distinct().ToList();
            ocsource.DisplayMember = "source";
            ocdestination.SelectedIndex = -1;
            ocsource.SelectedIndex = -1;
        }
        private void obconfirm_Click(object sender, EventArgs e)
        {
            if ( otflightname.Text == string.Empty || ocsource.Text == string.Empty ||ocdestination.Text == string.Empty || otarrivaltime.Text == string.Empty || otdeparture.Text == string.Empty || otflightcharges.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi semua kolom diatas");
            }
            else
            {
                if (obconfirm.Text == "Input")
                {   
                    var flight = new tbl_flight();
                    flight.flight_id = otflightid.Text;
                    flight.flight_name =otflightname.Text;
                    flight.source = ocsource.Text;
                    flight.destination =ocdestination.Text;
                    flight.arrival_time =otarrivaltime.Text;
                    flight.departure =otdeparture.Text;
                    flight.flight_class = otflightclass.Text;
                    flight.flight_charges = Convert.ToDecimal(otflightcharges.Text);
                    flight.seats = Convert.ToInt32(otseats.Text);
                    db.tbl_flight.Add(flight);
                    db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Data berhasil di input");
                }
                if (obconfirm.Text == "Update")
                {
                    var flight = db.tbl_flight.Where(a=>a.flight_id == otflightid.Text).FirstOrDefault();
                    flight.flight_name = otflightname.Text;
                    flight.source = ocsource.Text;
                    flight.destination = ocdestination.Text;
                    flight.arrival_time = otarrivaltime.Text;
                    flight.departure = otdeparture.Text;
                    flight.flight_class = otflightclass.Text;
                    flight.flight_charges = Convert.ToDecimal(otflightcharges.Text);
                    flight.seats = Convert.ToInt32(otseats.Text);
                    db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Data berhasil di Update");
                }
            }
        }
    }
}
