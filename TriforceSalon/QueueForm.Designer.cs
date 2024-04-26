namespace TriforceSalon
{
    partial class QueueForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InsessionFL = new System.Windows.Forms.FlowLayoutPanel();
            this.QueueFL = new System.Windows.Forms.FlowLayoutPanel();
            this.EmployeeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmpIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSpecialistCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsessionFL
            // 
            this.InsessionFL.AutoScroll = true;
            this.InsessionFL.BackColor = System.Drawing.Color.White;
            this.InsessionFL.Location = new System.Drawing.Point(515, 102);
            this.InsessionFL.Name = "InsessionFL";
            this.InsessionFL.Size = new System.Drawing.Size(670, 158);
            this.InsessionFL.TabIndex = 1;
            // 
            // QueueFL
            // 
            this.QueueFL.AutoScroll = true;
            this.QueueFL.BackColor = System.Drawing.Color.White;
            this.QueueFL.Location = new System.Drawing.Point(515, 348);
            this.QueueFL.Name = "QueueFL";
            this.QueueFL.Size = new System.Drawing.Size(670, 302);
            this.QueueFL.TabIndex = 3;
            // 
            // EmployeeDGV
            // 
            this.EmployeeDGV.AllowUserToAddRows = false;
            this.EmployeeDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDGV.ColumnHeadersHeight = 30;
            this.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpIDCol,
            this.EmpNameCol,
            this.EmpSpecialistCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.Location = new System.Drawing.Point(12, 102);
            this.EmployeeDGV.Name = "EmployeeDGV";
            this.EmployeeDGV.ReadOnly = true;
            this.EmployeeDGV.RowHeadersVisible = false;
            this.EmployeeDGV.Size = new System.Drawing.Size(467, 602);
            this.EmployeeDGV.TabIndex = 5;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.EmployeeDGV.ThemeStyle.ReadOnly = true;
            this.EmployeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDGV.ThemeStyle.RowsStyle.Height = 22;
            this.EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDGV_CellContentDoubleClick_1);
            // 
            // EmpIDCol
            // 
            this.EmpIDCol.HeaderText = "ID";
            this.EmpIDCol.Name = "EmpIDCol";
            this.EmpIDCol.ReadOnly = true;
            // 
            // EmpNameCol
            // 
            this.EmpNameCol.HeaderText = "Name";
            this.EmpNameCol.Name = "EmpNameCol";
            this.EmpNameCol.ReadOnly = true;
            // 
            // EmpSpecialistCol
            // 
            this.EmpSpecialistCol.HeaderText = "Specialist";
            this.EmpSpecialistCol.Name = "EmpSpecialistCol";
            this.EmpSpecialistCol.ReadOnly = true;
            // 
            // ServeBtn
            // 
            this.ServeBtn.AutoRoundedCorners = true;
            this.ServeBtn.BackColor = System.Drawing.Color.Transparent;
            this.ServeBtn.BorderRadius = 21;
            this.ServeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ServeBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServeBtn.ForeColor = System.Drawing.Color.White;
            this.ServeBtn.Location = new System.Drawing.Point(18, 660);
            this.ServeBtn.Name = "ServeBtn";
            this.ServeBtn.Size = new System.Drawing.Size(670, 45);
            this.ServeBtn.TabIndex = 6;
            this.ServeBtn.Text = "Serve";
            this.ServeBtn.Click += new System.EventHandler(this.ServeBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.ServeBtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2Panel1.Location = new System.Drawing.Point(497, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(727, 718);
            this.guna2Panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 64);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Queue";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 64);
            this.label2.TabIndex = 9;
            this.label2.Text = "In-Session ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 90);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee List";
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1197, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDGV);
            this.Controls.Add(this.QueueFL);
            this.Controls.Add(this.InsessionFL);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "QueueForm";
            this.Text = "Customer Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueueForm_FormClosing);
            this.Load += new System.EventHandler(this.QueueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel QueueFL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSpecialistCol;
        private Guna.UI2.WinForms.Guna2Button ServeBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel InsessionFL;
        public Guna.UI2.WinForms.Guna2DataGridView EmployeeDGV;
    }
}