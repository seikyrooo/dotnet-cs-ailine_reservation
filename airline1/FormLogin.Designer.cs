namespace airline1
{
    partial class FormLogin
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
            this.oblogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.otuserid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.otpassword = new System.Windows.Forms.TextBox();
            this.ocshowpassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oblogin
            // 
            this.oblogin.Location = new System.Drawing.Point(379, 209);
            this.oblogin.Name = "oblogin";
            this.oblogin.Size = new System.Drawing.Size(119, 47);
            this.oblogin.TabIndex = 2;
            this.oblogin.Text = "Login";
            this.oblogin.UseVisualStyleBackColor = true;
            this.oblogin.Click += new System.EventHandler(this.oblogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            // 
            // otuserid
            // 
            this.otuserid.Location = new System.Drawing.Point(167, 117);
            this.otuserid.Name = "otuserid";
            this.otuserid.Size = new System.Drawing.Size(331, 26);
            this.otuserid.TabIndex = 0;
            this.otuserid.Text = "USR001";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 78);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(220, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Form Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // otpassword
            // 
            this.otpassword.Location = new System.Drawing.Point(167, 166);
            this.otpassword.Name = "otpassword";
            this.otpassword.PasswordChar = '*';
            this.otpassword.Size = new System.Drawing.Size(331, 26);
            this.otpassword.TabIndex = 1;
            this.otpassword.Text = "admin";
            // 
            // ocshowpassword
            // 
            this.ocshowpassword.AutoSize = true;
            this.ocshowpassword.Location = new System.Drawing.Point(504, 169);
            this.ocshowpassword.Name = "ocshowpassword";
            this.ocshowpassword.Size = new System.Drawing.Size(22, 21);
            this.ocshowpassword.TabIndex = 4;
            this.ocshowpassword.UseVisualStyleBackColor = true;
            this.ocshowpassword.CheckedChanged += new System.EventHandler(this.ocshowpassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 284);
            this.Controls.Add(this.ocshowpassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.otpassword);
            this.Controls.Add(this.otuserid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oblogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.FormLogin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oblogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox otuserid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox otpassword;
        private System.Windows.Forms.CheckBox ocshowpassword;
    }
}

