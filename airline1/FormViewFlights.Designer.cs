namespace airline1
{
    partial class FormViewFlights
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
            this.label1 = new System.Windows.Forms.Label();
            this.otsearch = new System.Windows.Forms.TextBox();
            this.obinput = new System.Windows.Forms.Button();
            this.odflights = new System.Windows.Forms.DataGridView();
            this.cdflightid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdflightname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdsource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cddestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdarrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cddeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdflightclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdflightcharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdseats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cddelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odflights)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 78);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(371, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "View Flights";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(36, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // otsearch
            // 
            this.otsearch.Location = new System.Drawing.Point(129, 108);
            this.otsearch.Name = "otsearch";
            this.otsearch.Size = new System.Drawing.Size(383, 26);
            this.otsearch.TabIndex = 7;
            this.otsearch.TextChanged += new System.EventHandler(this.otsearch_TextChanged);
            // 
            // obinput
            // 
            this.obinput.Location = new System.Drawing.Point(758, 100);
            this.obinput.Name = "obinput";
            this.obinput.Size = new System.Drawing.Size(138, 43);
            this.obinput.TabIndex = 8;
            this.obinput.Text = "Input";
            this.obinput.UseVisualStyleBackColor = true;
            this.obinput.Click += new System.EventHandler(this.obinput_Click);
            // 
            // odflights
            // 
            this.odflights.AllowUserToAddRows = false;
            this.odflights.AllowUserToDeleteRows = false;
            this.odflights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odflights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odflights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdflightid,
            this.cdflightname,
            this.cdsource,
            this.cddestination,
            this.cdarrivaltime,
            this.cddeparture,
            this.cdflightclass,
            this.cdflightcharges,
            this.cdseats,
            this.cdupdate,
            this.cddelete});
            this.odflights.Location = new System.Drawing.Point(41, 166);
            this.odflights.Name = "odflights";
            this.odflights.ReadOnly = true;
            this.odflights.RowHeadersVisible = false;
            this.odflights.RowHeadersWidth = 62;
            this.odflights.RowTemplate.Height = 28;
            this.odflights.Size = new System.Drawing.Size(855, 492);
            this.odflights.TabIndex = 9;
            this.odflights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odflights_CellClick);
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
            this.cdflightclass.HeaderText = "Flight  Class";
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
            // cdupdate
            // 
            this.cdupdate.HeaderText = "Action 1";
            this.cdupdate.MinimumWidth = 8;
            this.cdupdate.Name = "cdupdate";
            this.cdupdate.ReadOnly = true;
            this.cdupdate.Text = "Update";
            this.cdupdate.UseColumnTextForButtonValue = true;
            // 
            // cddelete
            // 
            this.cddelete.HeaderText = "Action 2";
            this.cddelete.MinimumWidth = 8;
            this.cddelete.Name = "cddelete";
            this.cddelete.ReadOnly = true;
            this.cddelete.Text = "Delete";
            this.cddelete.UseColumnTextForButtonValue = true;
            // 
            // FormViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 691);
            this.Controls.Add(this.odflights);
            this.Controls.Add(this.obinput);
            this.Controls.Add(this.otsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewFlights";
            this.Activated += new System.EventHandler(this.FormViewFlights_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odflights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox otsearch;
        private System.Windows.Forms.Button obinput;
        private System.Windows.Forms.DataGridView odflights;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdsource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cddestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdarrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cddeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdflightcharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdseats;
        private System.Windows.Forms.DataGridViewButtonColumn cdupdate;
        private System.Windows.Forms.DataGridViewButtonColumn cddelete;
    }
}