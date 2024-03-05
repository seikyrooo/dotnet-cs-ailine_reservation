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
    public partial class FormCustomer : Form
    {
        db_airlineEntities db;
        string updateid;
        public FormCustomer(string id)
        {
            InitializeComponent();
            updateid= id;
        }
        void AutoNumber()
        {
            long hitung;
            string urutan;
            db = new db_airlineEntities();
            var max = (from customer in db.tbl_costumerdetails select customer.costumer_id).Max();
            if (max == null)
            {
                urutan = "CSR001";
            }
            else
            {
                hitung = Convert.ToInt32(max.Substring(max.Length - 3,3))+1;
                string kodeurutan = "000" + hitung;
                urutan = "CSR" + kodeurutan.Substring(kodeurutan.Length - 3,3);
            }
            otcustomerid.Text = urutan;
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            if (updateid !=null)
            {
                db = new db_airlineEntities();
                var customer = db.tbl_costumerdetails.Where(a=>a.costumer_id==updateid).FirstOrDefault();
                otcustomerid.Text = customer.costumer_id;
                otname.Text = customer.name;
                otfathername.Text = customer.father_name;
                odbirthdate.Value = customer.birth_date.Value;
                otemail.Text = customer.email;
                otphone.Text = customer.phone;
                otaddress.Text = customer.address;
                obconfirm.Text = "Update";
            }
            else
            {
                obconfirm.Text = "Input";
                AutoNumber();
            }
        }

        private void obconfirm_Click(object sender, EventArgs e)
        {
            if (otcustomerid.Text == string.Empty || otname.Text == string.Empty || otfathername.Text == string.Empty || otemail.Text == string.Empty || otphone.Text == string.Empty || otaddress.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi Kolom diatas !");
            }
            else
            {
                if (obconfirm.Text == "Input")
                {
                    db = new db_airlineEntities();
                    tbl_costumerdetails customer = new tbl_costumerdetails();
                    customer.costumer_id = otcustomerid.Text;
                    customer.name = otname.Text;
                    customer.father_name = otfathername.Text;
                    customer.birth_date = odbirthdate.Value;
                    customer.email = otemail.Text;
                    customer.phone = otphone.Text;
                    customer.address= otaddress.Text;
                    db.tbl_costumerdetails.Add(customer);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil diInput");
                    this.Close();
                }
                if(obconfirm.Text == "Update")
                {
                    db = new db_airlineEntities();
                    var customer = db.tbl_costumerdetails.Where(a=>a.costumer_id == updateid).FirstOrDefault();
                    customer.costumer_id = otcustomerid.Text;
                    customer.name = otname.Text;
                    customer.father_name = otfathername.Text;
                    customer.birth_date = odbirthdate.Value;
                    customer.email = otemail.Text;
                    customer.phone = otphone.Text;
                    customer.address = otaddress.Text;
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Update");
                    this.Close();
                }
            }
        }
    }
}
