namespace airline1
{
    partial class FormMenuUtama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.opphoto = new System.Windows.Forms.PictureBox();
            this.ogprofil = new System.Windows.Forms.GroupBox();
            this.obprofil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oblogout = new System.Windows.Forms.Button();
            this.obbooking = new System.Windows.Forms.Button();
            this.obcustomers = new System.Windows.Forms.Button();
            this.obflights = new System.Windows.Forms.Button();
            this.ogadminnavigation = new System.Windows.Forms.GroupBox();
            this.obusers = new System.Windows.Forms.Button();
            this.iinbox = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opphoto)).BeginInit();
            this.ogprofil.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ogadminnavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iinbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 78);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(350, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Airline Reservation";
            // 
            // opphoto
            // 
            this.opphoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.opphoto.Location = new System.Drawing.Point(17, 25);
            this.opphoto.Name = "opphoto";
            this.opphoto.Size = new System.Drawing.Size(165, 182);
            this.opphoto.TabIndex = 5;
            this.opphoto.TabStop = false;
            // 
            // ogprofil
            // 
            this.ogprofil.Controls.Add(this.obprofil);
            this.ogprofil.Controls.Add(this.opphoto);
            this.ogprofil.Location = new System.Drawing.Point(48, 114);
            this.ogprofil.Name = "ogprofil";
            this.ogprofil.Size = new System.Drawing.Size(198, 273);
            this.ogprofil.TabIndex = 6;
            this.ogprofil.TabStop = false;
            this.ogprofil.Text = "Username";
            // 
            // obprofil
            // 
            this.obprofil.Location = new System.Drawing.Point(17, 213);
            this.obprofil.Name = "obprofil";
            this.obprofil.Size = new System.Drawing.Size(165, 54);
            this.obprofil.TabIndex = 0;
            this.obprofil.Text = "Profil";
            this.obprofil.UseVisualStyleBackColor = true;
            this.obprofil.Click += new System.EventHandler(this.obprofil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oblogout);
            this.groupBox1.Controls.Add(this.obbooking);
            this.groupBox1.Controls.Add(this.obcustomers);
            this.groupBox1.Controls.Add(this.obflights);
            this.groupBox1.Controls.Add(this.ogadminnavigation);
            this.groupBox1.Location = new System.Drawing.Point(316, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 273);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // oblogout
            // 
            this.oblogout.BackColor = System.Drawing.Color.Red;
            this.oblogout.ForeColor = System.Drawing.Color.White;
            this.oblogout.Location = new System.Drawing.Point(56, 213);
            this.oblogout.Name = "oblogout";
            this.oblogout.Size = new System.Drawing.Size(206, 40);
            this.oblogout.TabIndex = 2;
            this.oblogout.Text = "Logout";
            this.oblogout.UseVisualStyleBackColor = false;
            this.oblogout.Click += new System.EventHandler(this.oblogout_Click);
            // 
            // obbooking
            // 
            this.obbooking.Location = new System.Drawing.Point(56, 140);
            this.obbooking.Name = "obbooking";
            this.obbooking.Size = new System.Drawing.Size(206, 40);
            this.obbooking.TabIndex = 2;
            this.obbooking.Text = "Booking";
            this.obbooking.UseVisualStyleBackColor = true;
            this.obbooking.Click += new System.EventHandler(this.obbooking_Click);
            // 
            // obcustomers
            // 
            this.obcustomers.Location = new System.Drawing.Point(56, 94);
            this.obcustomers.Name = "obcustomers";
            this.obcustomers.Size = new System.Drawing.Size(206, 40);
            this.obcustomers.TabIndex = 1;
            this.obcustomers.Text = "Customers";
            this.obcustomers.UseVisualStyleBackColor = true;
            this.obcustomers.Click += new System.EventHandler(this.obcustomers_Click);
            // 
            // obflights
            // 
            this.obflights.Location = new System.Drawing.Point(56, 48);
            this.obflights.Name = "obflights";
            this.obflights.Size = new System.Drawing.Size(206, 40);
            this.obflights.TabIndex = 0;
            this.obflights.Text = "Flights";
            this.obflights.UseVisualStyleBackColor = true;
            this.obflights.Click += new System.EventHandler(this.obflights_Click);
            // 
            // ogadminnavigation
            // 
            this.ogadminnavigation.Controls.Add(this.obusers);
            this.ogadminnavigation.Location = new System.Drawing.Point(313, 36);
            this.ogadminnavigation.Name = "ogadminnavigation";
            this.ogadminnavigation.Size = new System.Drawing.Size(239, 217);
            this.ogadminnavigation.TabIndex = 0;
            this.ogadminnavigation.TabStop = false;
            this.ogadminnavigation.Text = "Admin";
            // 
            // obusers
            // 
            this.obusers.Location = new System.Drawing.Point(16, 36);
            this.obusers.Name = "obusers";
            this.obusers.Size = new System.Drawing.Size(206, 40);
            this.obusers.TabIndex = 0;
            this.obusers.Text = "Users";
            this.obusers.UseVisualStyleBackColor = true;
            this.obusers.Click += new System.EventHandler(this.obusers_Click);
            // 
            // iinbox
            // 
            this.iinbox.BackColor = System.Drawing.SystemColors.Control;
            this.iinbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iinbox.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.iinbox.IconColor = System.Drawing.SystemColors.ControlText;
            this.iinbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iinbox.IconSize = 36;
            this.iinbox.Location = new System.Drawing.Point(910, 84);
            this.iinbox.Name = "iinbox";
            this.iinbox.Size = new System.Drawing.Size(32, 32);
            this.iinbox.TabIndex = 8;
            this.iinbox.TabStop = false;
            this.iinbox.Click += new System.EventHandler(this.iinbox_Click);
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.iinbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ogprofil);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUtama";
            this.Activated += new System.EventHandler(this.FormMenuUtama_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuUtama_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opphoto)).EndInit();
            this.ogprofil.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ogadminnavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iinbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox opphoto;
        private System.Windows.Forms.GroupBox ogprofil;
        private System.Windows.Forms.Button obprofil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obbooking;
        private System.Windows.Forms.Button obcustomers;
        private System.Windows.Forms.Button obflights;
        private System.Windows.Forms.GroupBox ogadminnavigation;
        private System.Windows.Forms.Button obusers;
        private System.Windows.Forms.Button oblogout;
        private FontAwesome.Sharp.IconPictureBox iinbox;
    }
}