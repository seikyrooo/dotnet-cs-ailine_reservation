using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static airline1.GLobalClass;

namespace airline1
{
    public partial class FormLogin : Form
    {
        db_airlineEntities db;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void oblogin_Click(object sender, EventArgs e)
        {
            db = new db_airlineEntities();
            var vuser = db.tbl_user.Where(a=>a.user_id== otuserid.Text && a.password == otpassword.Text).FirstOrDefault();
            if (otuserid.Text != string.Empty && otpassword.Text != string.Empty)
            {
                if (vuser != null)
                {
                    vuserid = vuser.user_id;
                    vusername = vuser.user_name;
                    vpassword = vuser.password;
                    vuserlevel = vuser.user_level;
                    vurlphoto = vuser.photo;

                    FormMenuUtama fmu = new FormMenuUtama();
                    GlobalLogin = this;
                    GlobalLogin.Hide();
                    MessageBox.Show("Login Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fmu.Show();
                }
                else
                {
                    MessageBox.Show("User ID atau Password yang anda Masukan salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Silahkan isi Kolom diatas !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin Keluar ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ocshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ocshowpassword.Checked)
            {
                otpassword.PasswordChar = '\0';
            }
            else
            {
                otpassword.PasswordChar = '*';
            }
        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            otpassword.Text = string.Empty;
            otpassword.PasswordChar = '*';
            ocshowpassword.Checked = false;
        }
    }
}
