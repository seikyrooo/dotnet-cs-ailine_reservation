namespace airline1
{
    partial class FormKirimPesan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmessage = new System.Windows.Forms.TextBox();
            this.tsubject = new System.Windows.Forms.TextBox();
            this.tmessageid = new System.Windows.Forms.TextBox();
            this.cpenerima = new System.Windows.Forms.ComboBox();
            this.tpengirim = new System.Windows.Forms.TextBox();
            this.bconfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pengirim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Penerima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message ( Maks 1000 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subject";
            // 
            // tmessage
            // 
            this.tmessage.Location = new System.Drawing.Point(30, 234);
            this.tmessage.Multiline = true;
            this.tmessage.Name = "tmessage";
            this.tmessage.Size = new System.Drawing.Size(870, 295);
            this.tmessage.TabIndex = 1;
            // 
            // tsubject
            // 
            this.tsubject.Location = new System.Drawing.Point(174, 165);
            this.tsubject.Name = "tsubject";
            this.tsubject.Size = new System.Drawing.Size(263, 26);
            this.tsubject.TabIndex = 2;
            // 
            // tmessageid
            // 
            this.tmessageid.Enabled = false;
            this.tmessageid.Location = new System.Drawing.Point(174, 45);
            this.tmessageid.Name = "tmessageid";
            this.tmessageid.Size = new System.Drawing.Size(263, 26);
            this.tmessageid.TabIndex = 2;
            // 
            // cpenerima
            // 
            this.cpenerima.FormattingEnabled = true;
            this.cpenerima.Location = new System.Drawing.Point(174, 123);
            this.cpenerima.Name = "cpenerima";
            this.cpenerima.Size = new System.Drawing.Size(263, 28);
            this.cpenerima.TabIndex = 3;
            // 
            // tpengirim
            // 
            this.tpengirim.Enabled = false;
            this.tpengirim.Location = new System.Drawing.Point(174, 85);
            this.tpengirim.Name = "tpengirim";
            this.tpengirim.Size = new System.Drawing.Size(263, 26);
            this.tpengirim.TabIndex = 2;
            // 
            // bconfirm
            // 
            this.bconfirm.Location = new System.Drawing.Point(816, 535);
            this.bconfirm.Name = "bconfirm";
            this.bconfirm.Size = new System.Drawing.Size(84, 37);
            this.bconfirm.TabIndex = 4;
            this.bconfirm.Text = "Confirm";
            this.bconfirm.UseVisualStyleBackColor = true;
            this.bconfirm.Click += new System.EventHandler(this.bconfirm_Click);
            // 
            // FormKirimPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 599);
            this.Controls.Add(this.bconfirm);
            this.Controls.Add(this.cpenerima);
            this.Controls.Add(this.tpengirim);
            this.Controls.Add(this.tmessageid);
            this.Controls.Add(this.tsubject);
            this.Controls.Add(this.tmessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKirimPesan";
            this.Text = "FormKirimPesan";
            this.Load += new System.EventHandler(this.FormKirimPesan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tmessage;
        private System.Windows.Forms.TextBox tsubject;
        private System.Windows.Forms.TextBox tmessageid;
        private System.Windows.Forms.ComboBox cpenerima;
        private System.Windows.Forms.TextBox tpengirim;
        private System.Windows.Forms.Button bconfirm;
    }
}