namespace airline1
{
    partial class FormMessage
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
            this.dmessage = new System.Windows.Forms.DataGridView();
            this.bkirimpesan = new System.Windows.Forms.Button();
            this.tmessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dmessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dmessage
            // 
            this.dmessage.AllowUserToAddRows = false;
            this.dmessage.AllowUserToDeleteRows = false;
            this.dmessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dmessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dmessage.Location = new System.Drawing.Point(34, 177);
            this.dmessage.Name = "dmessage";
            this.dmessage.ReadOnly = true;
            this.dmessage.RowHeadersVisible = false;
            this.dmessage.RowHeadersWidth = 62;
            this.dmessage.RowTemplate.Height = 28;
            this.dmessage.Size = new System.Drawing.Size(810, 366);
            this.dmessage.TabIndex = 0;
            this.dmessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dmessage_CellClick);
            // 
            // bkirimpesan
            // 
            this.bkirimpesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bkirimpesan.Location = new System.Drawing.Point(790, 114);
            this.bkirimpesan.Name = "bkirimpesan";
            this.bkirimpesan.Size = new System.Drawing.Size(54, 47);
            this.bkirimpesan.TabIndex = 1;
            this.bkirimpesan.Text = "+";
            this.bkirimpesan.UseVisualStyleBackColor = true;
            this.bkirimpesan.Click += new System.EventHandler(this.bkirimpesan_Click);
            // 
            // tmessage
            // 
            this.tmessage.Enabled = false;
            this.tmessage.Location = new System.Drawing.Point(34, 38);
            this.tmessage.Multiline = true;
            this.tmessage.Name = "tmessage";
            this.tmessage.Size = new System.Drawing.Size(738, 123);
            this.tmessage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message";
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmessage);
            this.Controls.Add(this.bkirimpesan);
            this.Controls.Add(this.dmessage);
            this.Name = "FormMessage";
            this.Text = "FormMessage";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dmessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dmessage;
        private System.Windows.Forms.Button bkirimpesan;
        private System.Windows.Forms.TextBox tmessage;
        private System.Windows.Forms.Label label1;
    }
}