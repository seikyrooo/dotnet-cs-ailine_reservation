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
using static airline1.GLobalClass;

namespace airline1
{
    public partial class FormKirimPesan : Form
    {
        db_airlineEntities db;
        public FormKirimPesan()
        {
            InitializeComponent();
        }
        void AutoNumber()
        {
            db = new db_airlineEntities();
            var message = (from msg in db.tbl_message select msg.message_id).Max();
            string urutan;
            long hitung;
            if (message == null)
            {
                urutan = "MSG001";
            }
            else
            {
                hitung = Convert.ToInt32(message.Substring(message.Length -3 , 3)) + 1;
                string urutankode = "000" + hitung;
                urutan = "MSG" + urutankode.Substring(urutankode.Length -3 , 3);
            }
            tmessageid.Text = urutan;
        }
        void LoadPenerima()
        {
            cpenerima.DataSource = db.tbl_user.ToList();
            cpenerima.DisplayMember = "user_id";
            cpenerima.SelectedIndex = -1;
        }
        private void FormKirimPesan_Load(object sender, EventArgs e)
        {
            AutoNumber();
            tpengirim.Text = vuserid;
            LoadPenerima();
        }

        private void bconfirm_Click(object sender, EventArgs e)
        {
            if (tsubject.Text == string.Empty || tmessage.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi semua kolom diatas");
            }
            else
            {
                if (cpenerima.Text == tpengirim.Text)
                {
                    MessageBox.Show("Tidak bisa mengirim pesan ke penerima");
                }
                else
                {
                    var message = new tbl_message();
                    message.message_id = tmessageid.Text;
                    message.pengirim = tpengirim.Text;
                    message.penerima = cpenerima.Text;
                    message.subject = tsubject.Text;
                    message.message = tmessage.Text;
                    db.tbl_message.Add(message);
                    db.SaveChanges();
                    MessageBox.Show("Pesan Telah Terkirim");
                    this.Close();
                }
            }
        }
    }
}
