namespace airline1
{
    partial class FormUsers
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
            this.ishowpassword = new System.Windows.Forms.CheckBox();
            this.pphoto = new System.Windows.Forms.PictureBox();
            this.bconfirm = new System.Windows.Forms.Button();
            this.tuserlevel = new System.Windows.Forms.ComboBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.tuserid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ishowpassword
            // 
            this.ishowpassword.AutoSize = true;
            this.ishowpassword.Location = new System.Drawing.Point(409, 261);
            this.ishowpassword.Name = "ishowpassword";
            this.ishowpassword.Size = new System.Drawing.Size(148, 24);
            this.ishowpassword.TabIndex = 56;
            this.ishowpassword.Text = "Show Password";
            this.ishowpassword.UseVisualStyleBackColor = true;
            this.ishowpassword.CheckedChanged += new System.EventHandler(this.ishowpassword_CheckedChanged);
            // 
            // pphoto
            // 
            this.pphoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pphoto.Location = new System.Drawing.Point(65, 133);
            this.pphoto.Name = "pphoto";
            this.pphoto.Size = new System.Drawing.Size(139, 158);
            this.pphoto.TabIndex = 55;
            this.pphoto.TabStop = false;
            this.pphoto.Click += new System.EventHandler(this.pphoto_Click);
            // 
            // bconfirm
            // 
            this.bconfirm.Location = new System.Drawing.Point(729, 338);
            this.bconfirm.Name = "bconfirm";
            this.bconfirm.Size = new System.Drawing.Size(115, 45);
            this.bconfirm.TabIndex = 54;
            this.bconfirm.Text = "Confirm";
            this.bconfirm.UseVisualStyleBackColor = true;
            this.bconfirm.Click += new System.EventHandler(this.bconfirm_Click);
            // 
            // tuserlevel
            // 
            this.tuserlevel.FormattingEnabled = true;
            this.tuserlevel.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.tuserlevel.Location = new System.Drawing.Point(409, 301);
            this.tuserlevel.Name = "tuserlevel";
            this.tuserlevel.Size = new System.Drawing.Size(205, 28);
            this.tuserlevel.TabIndex = 53;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(409, 180);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(435, 26);
            this.tname.TabIndex = 52;
            // 
            // tpassword
            // 
            this.tpassword.Location = new System.Drawing.Point(409, 228);
            this.tpassword.Name = "tpassword";
            this.tpassword.Size = new System.Drawing.Size(272, 26);
            this.tpassword.TabIndex = 50;
            // 
            // tuserid
            // 
            this.tuserid.Enabled = false;
            this.tuserid.Location = new System.Drawing.Point(409, 132);
            this.tuserid.Name = "tuserid";
            this.tuserid.Size = new System.Drawing.Size(205, 26);
            this.tuserid.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(235, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(235, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(235, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(235, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "User Detail";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 462);
            this.Controls.Add(this.ishowpassword);
            this.Controls.Add(this.pphoto);
            this.Controls.Add(this.bconfirm);
            this.Controls.Add(this.tuserlevel);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.tuserid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ishowpassword;
        private System.Windows.Forms.PictureBox pphoto;
        private System.Windows.Forms.Button bconfirm;
        private System.Windows.Forms.ComboBox tuserlevel;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.TextBox tuserid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}