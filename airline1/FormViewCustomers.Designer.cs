namespace airline1
{
    partial class FormViewCustomers
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
            this.odcustomers = new System.Windows.Forms.DataGridView();
            this.cdcostumerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdfathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdbirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cddelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.obinput = new System.Windows.Forms.Button();
            this.otsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.odcustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odcustomers
            // 
            this.odcustomers.AllowUserToAddRows = false;
            this.odcustomers.AllowUserToDeleteRows = false;
            this.odcustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odcustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdcostumerid,
            this.cdname,
            this.cdfathername,
            this.cdbirthdate,
            this.cdemail,
            this.cdphone,
            this.cdaddress,
            this.cdupdate,
            this.cddelete});
            this.odcustomers.Location = new System.Drawing.Point(41, 182);
            this.odcustomers.Name = "odcustomers";
            this.odcustomers.ReadOnly = true;
            this.odcustomers.RowHeadersVisible = false;
            this.odcustomers.RowHeadersWidth = 62;
            this.odcustomers.RowTemplate.Height = 28;
            this.odcustomers.Size = new System.Drawing.Size(855, 492);
            this.odcustomers.TabIndex = 14;
            this.odcustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odcustomers_CellClick);
            // 
            // cdcostumerid
            // 
            this.cdcostumerid.DataPropertyName = "costumer_id";
            this.cdcostumerid.HeaderText = "Customer ID";
            this.cdcostumerid.MinimumWidth = 8;
            this.cdcostumerid.Name = "cdcostumerid";
            this.cdcostumerid.ReadOnly = true;
            // 
            // cdname
            // 
            this.cdname.DataPropertyName = "name";
            this.cdname.HeaderText = "Name";
            this.cdname.MinimumWidth = 8;
            this.cdname.Name = "cdname";
            this.cdname.ReadOnly = true;
            // 
            // cdfathername
            // 
            this.cdfathername.DataPropertyName = "father_name";
            this.cdfathername.HeaderText = "Father\'s Name";
            this.cdfathername.MinimumWidth = 8;
            this.cdfathername.Name = "cdfathername";
            this.cdfathername.ReadOnly = true;
            // 
            // cdbirthdate
            // 
            this.cdbirthdate.DataPropertyName = "birth_date";
            this.cdbirthdate.HeaderText = "Birth Date";
            this.cdbirthdate.MinimumWidth = 8;
            this.cdbirthdate.Name = "cdbirthdate";
            this.cdbirthdate.ReadOnly = true;
            // 
            // cdemail
            // 
            this.cdemail.DataPropertyName = "email";
            this.cdemail.HeaderText = "Email";
            this.cdemail.MinimumWidth = 8;
            this.cdemail.Name = "cdemail";
            this.cdemail.ReadOnly = true;
            // 
            // cdphone
            // 
            this.cdphone.DataPropertyName = "phone";
            this.cdphone.HeaderText = "Phone";
            this.cdphone.MinimumWidth = 8;
            this.cdphone.Name = "cdphone";
            this.cdphone.ReadOnly = true;
            // 
            // cdaddress
            // 
            this.cdaddress.DataPropertyName = "address";
            this.cdaddress.HeaderText = "Address";
            this.cdaddress.MinimumWidth = 8;
            this.cdaddress.Name = "cdaddress";
            this.cdaddress.ReadOnly = true;
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
            // obinput
            // 
            this.obinput.Location = new System.Drawing.Point(758, 116);
            this.obinput.Name = "obinput";
            this.obinput.Size = new System.Drawing.Size(138, 43);
            this.obinput.TabIndex = 13;
            this.obinput.Text = "Input";
            this.obinput.UseVisualStyleBackColor = true;
            this.obinput.Click += new System.EventHandler(this.obinput_Click);
            // 
            // otsearch
            // 
            this.otsearch.Location = new System.Drawing.Point(129, 124);
            this.otsearch.Name = "otsearch";
            this.otsearch.Size = new System.Drawing.Size(383, 26);
            this.otsearch.TabIndex = 12;
            this.otsearch.TextChanged += new System.EventHandler(this.otsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(36, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(371, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "View Customers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 78);
            this.panel1.TabIndex = 10;
            // 
            // FormViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 691);
            this.Controls.Add(this.odcustomers);
            this.Controls.Add(this.obinput);
            this.Controls.Add(this.otsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewCustomers";
            this.Activated += new System.EventHandler(this.FormViewCustomers_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.odcustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView odcustomers;
        private System.Windows.Forms.Button obinput;
        private System.Windows.Forms.TextBox otsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcostumerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdfathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdbirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdaddress;
        private System.Windows.Forms.DataGridViewButtonColumn cdupdate;
        private System.Windows.Forms.DataGridViewButtonColumn cddelete;
    }
}