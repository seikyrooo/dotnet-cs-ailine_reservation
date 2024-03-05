namespace airline1
{
    partial class FormProfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obchangephoto = new System.Windows.Forms.Button();
            this.opphoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.obsavedata = new System.Windows.Forms.Button();
            this.otlevel = new System.Windows.Forms.TextBox();
            this.otusername = new System.Windows.Forms.TextBox();
            this.otuserid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.obchangepassword = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.otconfirmpassword = new System.Windows.Forms.TextBox();
            this.otnewpassword = new System.Windows.Forms.TextBox();
            this.otoldpassword = new System.Windows.Forms.TextBox();
            this.ombukafile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opphoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obchangephoto);
            this.groupBox1.Controls.Add(this.opphoto);
            this.groupBox1.Location = new System.Drawing.Point(33, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // obchangephoto
            // 
            this.obchangephoto.Location = new System.Drawing.Point(17, 202);
            this.obchangephoto.Name = "obchangephoto";
            this.obchangephoto.Size = new System.Drawing.Size(148, 37);
            this.obchangephoto.TabIndex = 1;
            this.obchangephoto.Text = "Change";
            this.obchangephoto.UseVisualStyleBackColor = true;
            this.obchangephoto.Click += new System.EventHandler(this.obchangephoto_Click);
            // 
            // opphoto
            // 
            this.opphoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.opphoto.Location = new System.Drawing.Point(17, 25);
            this.opphoto.Name = "opphoto";
            this.opphoto.Size = new System.Drawing.Size(148, 171);
            this.opphoto.TabIndex = 0;
            this.opphoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.obsavedata);
            this.groupBox2.Controls.Add(this.otlevel);
            this.groupBox2.Controls.Add(this.otusername);
            this.groupBox2.Controls.Add(this.otuserid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(234, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // obsavedata
            // 
            this.obsavedata.Location = new System.Drawing.Point(90, 202);
            this.obsavedata.Name = "obsavedata";
            this.obsavedata.Size = new System.Drawing.Size(148, 37);
            this.obsavedata.TabIndex = 1;
            this.obsavedata.Text = "Save";
            this.obsavedata.UseVisualStyleBackColor = true;
            this.obsavedata.Click += new System.EventHandler(this.obsavedata_Click);
            // 
            // otlevel
            // 
            this.otlevel.Enabled = false;
            this.otlevel.Location = new System.Drawing.Point(24, 165);
            this.otlevel.Name = "otlevel";
            this.otlevel.Size = new System.Drawing.Size(214, 26);
            this.otlevel.TabIndex = 2;
            // 
            // otusername
            // 
            this.otusername.Location = new System.Drawing.Point(24, 113);
            this.otusername.Name = "otusername";
            this.otusername.Size = new System.Drawing.Size(214, 26);
            this.otusername.TabIndex = 2;
            // 
            // otuserid
            // 
            this.otuserid.Enabled = false;
            this.otuserid.Location = new System.Drawing.Point(24, 61);
            this.otuserid.Name = "otuserid";
            this.otuserid.Size = new System.Drawing.Size(214, 26);
            this.otuserid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 78);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(228, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Profil";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obchangepassword);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.otconfirmpassword);
            this.groupBox3.Controls.Add(this.otnewpassword);
            this.groupBox3.Controls.Add(this.otoldpassword);
            this.groupBox3.Location = new System.Drawing.Point(33, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 247);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Password";
            // 
            // obchangepassword
            // 
            this.obchangepassword.Location = new System.Drawing.Point(291, 189);
            this.obchangepassword.Name = "obchangepassword";
            this.obchangepassword.Size = new System.Drawing.Size(148, 37);
            this.obchangepassword.TabIndex = 1;
            this.obchangepassword.Text = "Change";
            this.obchangepassword.UseVisualStyleBackColor = true;
            this.obchangepassword.Click += new System.EventHandler(this.obchangepassword_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Old Password";
            // 
            // otconfirmpassword
            // 
            this.otconfirmpassword.Location = new System.Drawing.Point(182, 146);
            this.otconfirmpassword.Name = "otconfirmpassword";
            this.otconfirmpassword.Size = new System.Drawing.Size(257, 26);
            this.otconfirmpassword.TabIndex = 2;
            // 
            // otnewpassword
            // 
            this.otnewpassword.Location = new System.Drawing.Point(182, 101);
            this.otnewpassword.Name = "otnewpassword";
            this.otnewpassword.Size = new System.Drawing.Size(257, 26);
            this.otnewpassword.TabIndex = 2;
            // 
            // otoldpassword
            // 
            this.otoldpassword.Location = new System.Drawing.Point(182, 59);
            this.otoldpassword.Name = "otoldpassword";
            this.otoldpassword.Size = new System.Drawing.Size(257, 26);
            this.otoldpassword.TabIndex = 2;
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(541, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfil";
            this.Activated += new System.EventHandler(this.FormProfil_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opphoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obchangephoto;
        private System.Windows.Forms.PictureBox opphoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox otusername;
        private System.Windows.Forms.TextBox otuserid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button obsavedata;
        private System.Windows.Forms.TextBox otlevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button obchangepassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox otconfirmpassword;
        private System.Windows.Forms.TextBox otnewpassword;
        private System.Windows.Forms.TextBox otoldpassword;
        private System.Windows.Forms.OpenFileDialog ombukafile;
    }
}