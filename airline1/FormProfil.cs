using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static airline1.GLobalClass;

namespace airline1
{
    public partial class FormProfil : Form
    {
        db_airlineEntities db;
        public FormProfil()
        {
            InitializeComponent();
            
        }
        private void FormProfil_Activated(object sender, EventArgs e)
        {
            otuserid.Text = vuserid;
            otusername.Text = vusername;
            otlevel.Text = vuserlevel;
            opphoto.ImageLocation = vurlphoto;
            opphoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void obchangephoto_Click(object sender, EventArgs e)
        {
            ombukafile.Filter = "*.jpg|";
            ombukafile.ShowDialog();
            if (ombukafile.FileName != string.Empty || ombukafile.FileName == vurlphoto)
            {
                vurlphoto = ombukafile.FileName;

                db = new db_airlineEntities();
                var user = db.tbl_user.Where(a => a.user_id == vuserid).FirstOrDefault();
                user.photo = vurlphoto;
                db.SaveChanges();
                MessageBox.Show("Photo berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                opphoto.ImageLocation = vurlphoto;
                opphoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Pengubahan Photo dibatalkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void obsavedata_Click(object sender, EventArgs e)
        {
            if (otusername.Text == string.Empty || otusername.Text == vusername)
            {
                MessageBox.Show("Kolom tidak boleh kosong atau sama seperti sebelumnya !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db = new db_airlineEntities();
                vusername = otusername.Text;
                var user = db.tbl_user.Where(a => a.user_id == otuserid.Text).FirstOrDefault();
                user.user_name= vusername;
                db.SaveChanges();
                MessageBox.Show("Username Berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void obchangepassword_Click(object sender, EventArgs e)
        {
            if (otoldpassword.Text == string.Empty || otnewpassword.Text == string.Empty || otnewpassword.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi semua kolom Password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db = new db_airlineEntities();
                var user = db.tbl_user.Where(a => a.user_id == otuserid.Text).FirstOrDefault();
                if (user.password == otoldpassword.Text)
                {
                    if (otnewpassword.Text == otconfirmpassword.Text)
                    {
                        DialogResult result = MessageBox.Show("Validasi berhasil, Yakin ingin mengubah Password ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            vpassword = otnewpassword.Text;
                            user.password = vpassword;
                            db.SaveChanges();
                            otoldpassword.Text = string.Empty;
                            otnewpassword.Text = string.Empty;
                            otconfirmpassword.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Pengubahan Password dibatalkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password baru dan Konfirmasi tidak boleh beda !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Password lama Salah !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
