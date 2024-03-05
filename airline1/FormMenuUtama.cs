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
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void FormMenuUtama_Activated(object sender, EventArgs e)
        {
            ogprofil.Text = vusername;
            opphoto.ImageLocation = vurlphoto;
            opphoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormMenuUtama_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin Logout ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                GlobalLogin.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void oblogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void obprofil_Click(object sender, EventArgs e)
        {
            FormProfil fp = new FormProfil();
            fp.ShowDialog();
        }

        private void obflights_Click(object sender, EventArgs e)
        {
            FormViewFlights fvf = new FormViewFlights();
            fvf.ShowDialog();
        }

        private void obcustomers_Click(object sender, EventArgs e)
        {
            FormViewCustomers fvc = new FormViewCustomers();
            fvc.ShowDialog();
        }

        private void obbooking_Click(object sender, EventArgs e)
        {
            FormBooking fb = new FormBooking();
            fb.ShowDialog();
        }

        private void iinbox_Click(object sender, EventArgs e)
        {
            FormMessage fm = new FormMessage();
            fm.ShowDialog();
        }

        private void obusers_Click(object sender, EventArgs e)
        {
            FormViewUsers fmu = new FormViewUsers();
            fmu.ShowDialog();
        }
    }
}
