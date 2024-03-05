using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Forms;

namespace airline1
{
    public partial class FormUsers : Form
    {
        db_airlineEntities db;
        string updateid;
        public FormUsers(string id)
        {
            InitializeComponent();
            if (id != null)
            {
                updateid = id;
            }
        }
        void autonumber()
        {
            db = new db_airlineEntities();
            var max = (from user in db.tbl_user select user.user_id).Max();
            string urutan;
            long hitung;
            if (max!= null)
            {
                hitung = Convert.ToInt32(max.Substring(max.Length - 3, 3)) + 1;
                string urutankode = "000" + hitung;
                urutan = "USR" + urutankode.Substring(urutankode.Length - 3, 3);
            }
            else
            {
                urutan = "USR001";
            }
            tuserid.Text = urutan;
        }
        string labelpic;
        private void FormUsers_Load(object sender, EventArgs e)
        {

            if (updateid == null)
            {
                autonumber();
                bconfirm.Text = "Input";
            }
            else
            {
                db = new db_airlineEntities();
                var user = db.tbl_user.Where(a => a.user_id == updateid).FirstOrDefault();
                tuserid.Text = user.user_id;
                tname.Text = user.user_name;
                tpassword.Text = user.password;
                tuserlevel.Text = user.user_level;
                if (user.photo != null)
                {
                    labelpic = user.photo;
                    pphoto.ImageLocation = labelpic;
                    pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                
                bconfirm.Text = "Update";
            }
            tpassword.PasswordChar = '*';
        }

        private void pphoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "|*.jpg";
            openFileDialog1.ShowDialog();
            labelpic = openFileDialog1.FileName;
            pphoto.ImageLocation = labelpic;
            pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ishowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ishowpassword.Checked)
            {
                tpassword.PasswordChar = '\0';
            }
            else
            {
                tpassword.PasswordChar = '*';
            }
        }

        private void bconfirm_Click(object sender, EventArgs e)
        {
            if (updateid != null)
            {
                db = new db_airlineEntities();
                var user = db.tbl_user.Where(a=>a.user_id == updateid).FirstOrDefault();
                if (user != null)
                {
                    user.user_name = tname.Text;
                    user.password = tpassword.Text;
                    user.user_level = tuserlevel.Text;
                    if (labelpic != null)
                    {
                        user.photo = labelpic;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Berhasil Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                db = new db_airlineEntities();
                tbl_user user = new tbl_user();
                user.user_id = tuserid.Text;
                user.user_name = tname.Text;
                user.password = tpassword.Text;
                user.user_level= tuserlevel.Text;
                if (labelpic != null)
                {
                    user.photo = labelpic;
                }
                db.tbl_user.Add(user);
                db.SaveChanges();
                MessageBox.Show("Berhasil Input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
