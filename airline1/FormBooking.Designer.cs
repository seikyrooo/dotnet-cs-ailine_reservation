namespace airline1
{
    partial class FormBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.occustomerid = new System.Windows.Forms.ComboBox();
            this.obconfirmbooking = new System.Windows.Forms.Button();
            this.obselectseat = new System.Windows.Forms.Button();
            this.oddateofjourney = new System.Windows.Forms.DateTimePicker();
            this.odbirthdate = new System.Windows.Forms.DateTimePicker();
            this.otaddress = new System.Windows.Forms.TextBox();
            this.otseatno = new System.Windows.Forms.TextBox();
            this.otflightid = new System.Windows.Forms.TextBox();
            this.otphone = new System.Windows.Forms.TextBox();
            this.otemail = new System.Windows.Forms.TextBox();
            this.otfathername = new System.Windows.Forms.TextBox();
            this.otname = new System.Windows.Forms.TextBox();
            this.otticketid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.obshowflight = new System.Windows.Forms.Button();
            this.ocdestination = new System.Windows.Forms.ComboBox();
            this.ocsource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odflight = new System.Windows.Forms.DataGridView();
            this.cdflightid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdflightname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdsource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cddestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdarrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cddeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdflightclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdflightcharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdseats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdselect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PD = new System.Drawing.Printing.PrintDocument();
            this.PPD = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odflight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 78);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(572, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Form Booking";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.occustomerid);
            this.panel2.Controls.Add(this.obconfirmbooking);
            this.panel2.Controls.Add(this.obselectseat);
            this.panel2.Controls.Add(this.oddateofjourney);
            this.panel2.Controls.Add(this.odbirthdate);
            this.panel2.Controls.Add(this.otaddress);
            this.panel2.Controls.Add(this.otseatno);
            this.panel2.Controls.Add(this.otflightid);
            this.panel2.Controls.Add(this.otphone);
            this.panel2.Controls.Add(this.otemail);
            this.panel2.Controls.Add(this.otfathername);
            this.panel2.Controls.Add(this.otname);
            this.panel2.Controls.Add(this.otticketid);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 837);
            this.panel2.TabIndex = 12;
            // 
            // occustomerid
            // 
            this.occustomerid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occustomerid.FormattingEnabled = true;
            this.occustomerid.Location = new System.Drawing.Point(208, 281);
            this.occustomerid.Name = "occustomerid";
            this.occustomerid.Size = new System.Drawing.Size(266, 28);
            this.occustomerid.TabIndex = 15;
            this.occustomerid.SelectedIndexChanged += new System.EventHandler(this.occustomerid_SelectedIndexChanged);
            // 
            // obconfirmbooking
            // 
            this.obconfirmbooking.Location = new System.Drawing.Point(208, 759);
            this.obconfirmbooking.Name = "obconfirmbooking";
            this.obconfirmbooking.Size = new System.Drawing.Size(266, 50);
            this.obconfirmbooking.TabIndex = 11;
            this.obconfirmbooking.Text = "Confirm Booking";
            this.obconfirmbooking.UseVisualStyleBackColor = true;
            this.obconfirmbooking.Click += new System.EventHandler(this.obconfirmbooking_Click);
            // 
            // obselectseat
            // 
            this.obselectseat.Location = new System.Drawing.Point(337, 712);
            this.obselectseat.Name = "obselectseat";
            this.obselectseat.Size = new System.Drawing.Size(137, 41);
            this.obselectseat.TabIndex = 10;
            this.obselectseat.Text = "Select Seat";
            this.obselectseat.UseVisualStyleBackColor = true;
            this.obselectseat.Click += new System.EventHandler(this.obselectseat_Click);
            // 
            // oddateofjourney
            // 
            this.oddateofjourney.Location = new System.Drawing.Point(208, 622);
            this.oddateofjourney.Name = "oddateofjourney";
            this.oddateofjourney.Size = new System.Drawing.Size(266, 26);
            this.oddateofjourney.TabIndex = 8;
            this.oddateofjourney.ValueChanged += new System.EventHandler(this.oddateofjourney_ValueChanged);
            // 
            // odbirthdate
            // 
            this.odbirthdate.Enabled = false;
            this.odbirthdate.Location = new System.Drawing.Point(208, 415);
            this.odbirthdate.Name = "odbirthdate";
            this.odbirthdate.Size = new System.Drawing.Size(266, 26);
            this.odbirthdate.TabIndex = 4;
            // 
            // otaddress
            // 
            this.otaddress.Enabled = false;
            this.otaddress.Location = new System.Drawing.Point(208, 547);
            this.otaddress.Multiline = true;
            this.otaddress.Name = "otaddress";
            this.otaddress.Size = new System.Drawing.Size(266, 52);
            this.otaddress.TabIndex = 7;
            // 
            // otseatno
            // 
            this.otseatno.Enabled = false;
            this.otseatno.Location = new System.Drawing.Point(208, 712);
            this.otseatno.Name = "otseatno";
            this.otseatno.Size = new System.Drawing.Size(109, 26);
            this.otseatno.TabIndex = 14;
            // 
            // otflightid
            // 
            this.otflightid.Enabled = false;
            this.otflightid.Location = new System.Drawing.Point(208, 667);
            this.otflightid.Name = "otflightid";
            this.otflightid.Size = new System.Drawing.Size(266, 26);
            this.otflightid.TabIndex = 9;
            // 
            // otphone
            // 
            this.otphone.Enabled = false;
            this.otphone.Location = new System.Drawing.Point(208, 503);
            this.otphone.Name = "otphone";
            this.otphone.Size = new System.Drawing.Size(266, 26);
            this.otphone.TabIndex = 6;
            // 
            // otemail
            // 
            this.otemail.Enabled = false;
            this.otemail.Location = new System.Drawing.Point(208, 459);
            this.otemail.Name = "otemail";
            this.otemail.Size = new System.Drawing.Size(266, 26);
            this.otemail.TabIndex = 5;
            // 
            // otfathername
            // 
            this.otfathername.Enabled = false;
            this.otfathername.Location = new System.Drawing.Point(208, 371);
            this.otfathername.Name = "otfathername";
            this.otfathername.Size = new System.Drawing.Size(266, 26);
            this.otfathername.TabIndex = 3;
            // 
            // otname
            // 
            this.otname.Enabled = false;
            this.otname.Location = new System.Drawing.Point(208, 327);
            this.otname.Name = "otname";
            this.otname.Size = new System.Drawing.Size(266, 26);
            this.otname.TabIndex = 2;
            // 
            // otticketid
            // 
            this.otticketid.Enabled = false;
            this.otticketid.Location = new System.Drawing.Point(208, 239);
            this.otticketid.Name = "otticketid";
            this.otticketid.Size = new System.Drawing.Size(266, 26);
            this.otticketid.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(32, 713);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Seat No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(32, 668);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Flight ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(32, 623);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Date Of Journey";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(32, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(32, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(32, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(32, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(32, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Father Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(32, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(32, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ticket ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.obshowflight);
            this.panel3.Controls.Add(this.ocdestination);
            this.panel3.Controls.Add(this.ocsource);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 198);
            this.panel3.TabIndex = 0;
            // 
            // obshowflight
            // 
            this.obshowflight.ForeColor = System.Drawing.Color.Black;
            this.obshowflight.Location = new System.Drawing.Point(301, 141);
            this.obshowflight.Name = "obshowflight";
            this.obshowflight.Size = new System.Drawing.Size(173, 44);
            this.obshowflight.TabIndex = 2;
            this.obshowflight.Text = "Show";
            this.obshowflight.UseVisualStyleBackColor = true;
            this.obshowflight.Click += new System.EventHandler(this.obshowflight_Click);
            // 
            // ocdestination
            // 
            this.ocdestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ocdestination.FormattingEnabled = true;
            this.ocdestination.Location = new System.Drawing.Point(37, 104);
            this.ocdestination.Name = "ocdestination";
            this.ocdestination.Size = new System.Drawing.Size(437, 28);
            this.ocdestination.TabIndex = 1;
            // 
            // ocsource
            // 
            this.ocsource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ocsource.FormattingEnabled = true;
            this.ocsource.Location = new System.Drawing.Point(37, 45);
            this.ocsource.Name = "ocsource";
            this.ocsource.Size = new System.Drawing.Size(437, 28);
            this.ocsource.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Source";
            // 
            // odflight
            // 
            this.odflight.AllowUserToAddRows = false;
            this.odflight.AllowUserToDeleteRows = false;
            this.odflight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odflight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odflight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdflightid,
            this.cdflightname,
            this.cdsource,
            this.cddestination,
            this.cdarrivaltime,
            this.cddeparture,
            this.cdflightclass,
            this.cdflightcharges,
            this.cdseats,
            this.cdselect});
            this.odflight.Location = new System.Drawing.Point(543, 113);
            this.odflight.Name = "odflight";
            this.odflight.ReadOnly = true;
            this.odflight.RowHeadersVisible = false;
            this.odflight.RowHeadersWidth = 62;
            this.odflight.RowTemplate.Height = 28;
            this.odflight.Size = new System.Drawing.Size(853, 774);
            this.odflight.TabIndex = 0;
            this.odflight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odflight_CellClick);
            // 
            // cdflightid
            // 
            this.cdflightid.DataPropertyName = "flight_id";
            this.cdflightid.HeaderText = "Flight ID";
            this.cdflightid.MinimumWidth = 8;
            this.cdflightid.Name = "cdflightid";
            this.cdflightid.ReadOnly = true;
            // 
            // cdflightname
            // 
            this.cdflightname.DataPropertyName = "flight_name";
            this.cdflightname.HeaderText = "Flight Name";
            this.cdflightname.MinimumWidth = 8;
            this.cdflightname.Name = "cdflightname";
            this.cdflightname.ReadOnly = true;
            // 
            // cdsource
            // 
            this.cdsource.DataPropertyName = "source";
            this.cdsource.HeaderText = "Source";
            this.cdsource.MinimumWidth = 8;
            this.cdsource.Name = "cdsource";
            this.cdsource.ReadOnly = true;
            // 
            // cddestination
            // 
            this.cddestination.DataPropertyName = "destination";
            this.cddestination.HeaderText = "Destination";
            this.cddestination.MinimumWidth = 8;
            this.cddestination.Name = "cddestination";
            this.cddestination.ReadOnly = true;
            // 
            // cdarrivaltime
            // 
            this.cdarrivaltime.DataPropertyName = "arrival_time";
            this.cdarrivaltime.HeaderText = "Arrival Time";
            this.cdarrivaltime.MinimumWidth = 8;
            this.cdarrivaltime.Name = "cdarrivaltime";
            this.cdarrivaltime.ReadOnly = true;
            // 
            // cddeparture
            // 
            this.cddeparture.DataPropertyName = "departure";
            this.cddeparture.HeaderText = "Departure";
            this.cddeparture.MinimumWidth = 8;
            this.cddeparture.Name = "cddeparture";
            this.cddeparture.ReadOnly = true;
            // 
            // cdflightclass
            // 
            this.cdflightclass.DataPropertyName = "flight_class";
            this.cdflightclass.HeaderText = "Flight Class";
            this.cdflightclass.MinimumWidth = 8;
            this.cdflightclass.Name = "cdflightclass";
            this.cdflightclass.ReadOnly = true;
            // 
            // cdflightcharges
            // 
            this.cdflightcharges.DataPropertyName = "flight_charges";
            this.cdflightcharges.HeaderText = "Flight Charges";
            this.cdflightcharges.MinimumWidth = 8;
            this.cdflightcharges.Name = "cdflightcharges";
            this.cdflightcharges.ReadOnly = true;
            // 
            // cdseats
            // 
            this.cdseats.DataPropertyName = "seats";
            this.cdseats.HeaderText = "Seats";
            this.cdseats.MinimumWidth = 8;
            this.cdseats.Name = "cdseats";
            this.cdseats.ReadOnly = true;
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
            // PD
            // 
            this.PD.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PD_BeginPrint);
            this.PD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD_PrintPage);
            // 
            // PPD
            // 
            this.PPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD.Enabled = true;
            this.PPD.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD.Icon")));
            this.PPD.Name = "PPD";
            this.PPD.Visible = false;
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 915);
            this.Controls.Add(this.odflight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBooking";
            this.Activated += new System.EventHandler(this.FormBooking_Activated);
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odflight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ocsource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button obshowflight;
        private System.Windows.Forms.ComboBox ocdestination;
        private System.Windows.Forms.Button obconfirmbooking;
        private System.Windows.Forms.Button obselectseat;
        private System.Windows.Forms.DateTimePicker oddateofjourney;
        private System.Windows.Forms.DateTimePicker odbirthdate;
        private System.Windows.Forms.TextBox otaddress;
        private System.Windows.Forms.TextBox otseatno;
        private System.Windows.Forms.TextBox otflightid;
        private System.Windows.Forms.TextBox otphone;
        private System.Windows.Forms.TextBox otemail;
        private System.Windows.Forms.TextBox otfathername;
        private System.Windows.Forms.TextBox otname;
        private System.Windows.Forms.TextBox otticketid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView odflight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdsource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cddestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdarrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cddeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightcharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdseats;
        private System.Windows.Forms.DataGridViewButtonColumn cdselect;
        private System.Windows.Forms.ComboBox occustomerid;
        private System.Drawing.Printing.PrintDocument PD;
        private System.Windows.Forms.PrintPreviewDialog PPD;
    }
}