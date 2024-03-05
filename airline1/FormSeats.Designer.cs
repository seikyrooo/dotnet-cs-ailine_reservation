namespace airline1
{
    partial class FormSeats
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
            this.odseatno = new System.Windows.Forms.DataGridView();
            this.oddateofjourney = new System.Windows.Forms.DateTimePicker();
            this.otflightid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.olseattersedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cdseatno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdselect = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.odseatno)).BeginInit();
            this.SuspendLayout();
            // 
            // odseatno
            // 
            this.odseatno.AllowUserToAddRows = false;
            this.odseatno.AllowUserToDeleteRows = false;
            this.odseatno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odseatno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odseatno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdseatno,
            this.cdselect});
            this.odseatno.Location = new System.Drawing.Point(44, 136);
            this.odseatno.Name = "odseatno";
            this.odseatno.ReadOnly = true;
            this.odseatno.RowHeadersVisible = false;
            this.odseatno.RowHeadersWidth = 62;
            this.odseatno.RowTemplate.Height = 28;
            this.odseatno.Size = new System.Drawing.Size(581, 551);
            this.odseatno.TabIndex = 0;
            this.odseatno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odseatno_CellClick);
            // 
            // oddateofjourney
            // 
            this.oddateofjourney.Enabled = false;
            this.oddateofjourney.Location = new System.Drawing.Point(215, 89);
            this.oddateofjourney.Name = "oddateofjourney";
            this.oddateofjourney.Size = new System.Drawing.Size(266, 26);
            this.oddateofjourney.TabIndex = 14;
            // 
            // otflightid
            // 
            this.otflightid.Enabled = false;
            this.otflightid.Location = new System.Drawing.Point(215, 39);
            this.otflightid.Name = "otflightid";
            this.otflightid.Size = new System.Drawing.Size(189, 26);
            this.otflightid.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(39, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Flight ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(39, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Date Of Journey";
            // 
            // olseattersedia
            // 
            this.olseattersedia.AutoSize = true;
            this.olseattersedia.ForeColor = System.Drawing.Color.Green;
            this.olseattersedia.Location = new System.Drawing.Point(436, 42);
            this.olseattersedia.Name = "olseattersedia";
            this.olseattersedia.Size = new System.Drawing.Size(51, 20);
            this.olseattersedia.TabIndex = 18;
            this.olseattersedia.Text = "Seats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tersedia";
            // 
            // cdseatno
            // 
            this.cdseatno.HeaderText = "Seat No";
            this.cdseatno.MinimumWidth = 8;
            this.cdseatno.Name = "cdseatno";
            this.cdseatno.ReadOnly = true;
            // 
            // cdselect
            // 
            this.cdselect.HeaderText = "Action";
            this.cdselect.MinimumWidth = 8;
            this.cdselect.Name = "cdselect";
            this.cdselect.ReadOnly = true;
            this.cdselect.Text = "Select";
            this.cdselect.UseColumnTextForButtonValue = true;
            // 
            // FormSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olseattersedia);
            this.Controls.Add(this.oddateofjourney);
            this.Controls.Add(this.otflightid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.odseatno);
            this.Name = "FormSeats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeats";
            this.Load += new System.EventHandler(this.FormSeats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odseatno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView odseatno;
        private System.Windows.Forms.DateTimePicker oddateofjourney;
        private System.Windows.Forms.TextBox otflightid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label olseattersedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdseatno;
        private System.Windows.Forms.DataGridViewButtonColumn cdselect;
    }
}