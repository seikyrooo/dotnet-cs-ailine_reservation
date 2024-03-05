namespace airline1
{
    partial class FormViewUsers
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
            this.odusers = new System.Windows.Forms.DataGridView();
            this.obinput = new System.Windows.Forms.Button();
            this.otsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cuserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuserlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cddelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.odusers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odusers
            // 
            this.odusers.AllowUserToAddRows = false;
            this.odusers.AllowUserToDeleteRows = false;
            this.odusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.odusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuserid,
            this.cusername,
            this.cpassword,
            this.cuserlevel,
            this.cphoto,
            this.cdupdate,
            this.cddelete});
            this.odusers.Location = new System.Drawing.Point(41, 190);
            this.odusers.Name = "odusers";
            this.odusers.ReadOnly = true;
            this.odusers.RowHeadersVisible = false;
            this.odusers.RowHeadersWidth = 62;
            this.odusers.RowTemplate.Height = 28;
            this.odusers.Size = new System.Drawing.Size(855, 492);
            this.odusers.TabIndex = 19;
            this.odusers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odusers_CellClick);
            // 
            // obinput
            // 
            this.obinput.Location = new System.Drawing.Point(758, 124);
            this.obinput.Name = "obinput";
            this.obinput.Size = new System.Drawing.Size(138, 43);
            this.obinput.TabIndex = 18;
            this.obinput.Text = "Input";
            this.obinput.UseVisualStyleBackColor = true;
            this.obinput.Click += new System.EventHandler(this.obinput_Click);
            // 
            // otsearch
            // 
            this.otsearch.Location = new System.Drawing.Point(129, 132);
            this.otsearch.Name = "otsearch";
            this.otsearch.Size = new System.Drawing.Size(383, 26);
            this.otsearch.TabIndex = 17;
            this.otsearch.TextChanged += new System.EventHandler(this.otsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(36, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(411, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "View User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 78);
            this.panel1.TabIndex = 15;
            // 
            // cuserid
            // 
            this.cuserid.DataPropertyName = "user_id";
            this.cuserid.HeaderText = "User ID";
            this.cuserid.MinimumWidth = 8;
            this.cuserid.Name = "cuserid";
            this.cuserid.ReadOnly = true;
            // 
            // cusername
            // 
            this.cusername.DataPropertyName = "user_name";
            this.cusername.HeaderText = "Username";
            this.cusername.MinimumWidth = 8;
            this.cusername.Name = "cusername";
            this.cusername.ReadOnly = true;
            // 
            // cpassword
            // 
            this.cpassword.DataPropertyName = "password";
            this.cpassword.HeaderText = "Password";
            this.cpassword.MinimumWidth = 8;
            this.cpassword.Name = "cpassword";
            this.cpassword.ReadOnly = true;
            this.cpassword.Visible = false;
            // 
            // cuserlevel
            // 
            this.cuserlevel.DataPropertyName = "user_level";
            this.cuserlevel.HeaderText = "Level";
            this.cuserlevel.MinimumWidth = 8;
            this.cuserlevel.Name = "cuserlevel";
            this.cuserlevel.ReadOnly = true;
            // 
            // cphoto
            // 
            this.cphoto.DataPropertyName = "photo";
            this.cphoto.HeaderText = "Photo";
            this.cphoto.MinimumWidth = 8;
            this.cphoto.Name = "cphoto";
            this.cphoto.ReadOnly = true;
            this.cphoto.Visible = false;
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
            // FormViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 695);
            this.Controls.Add(this.odusers);
            this.Controls.Add(this.obinput);
            this.Controls.Add(this.otsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewUsers";
            this.Text = "FormViewUsers";
            this.Activated += new System.EventHandler(this.FormViewUsers_Activated);
            this.Load += new System.EventHandler(this.FormViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odusers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView odusers;
        private System.Windows.Forms.Button obinput;
        private System.Windows.Forms.TextBox otsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuserlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphoto;
        private System.Windows.Forms.DataGridViewButtonColumn cdupdate;
        private System.Windows.Forms.DataGridViewButtonColumn cddelete;
    }
}