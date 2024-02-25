namespace TriforceSalon.UserControls
{
    partial class WalkInTransactionForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ProcessBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServicesComBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeListDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.RefreshBtn);
            this.guna2ShadowPanel1.Controls.Add(this.ProcessBtn);
            this.guna2ShadowPanel1.Controls.Add(this.CustomerNameTxtB);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.ServicesComBox);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.EmployeeListDGV);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(34, 35);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 100;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1774, 1004);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.AutoRoundedCorners = true;
            this.ProcessBtn.BorderRadius = 30;
            this.ProcessBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProcessBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProcessBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProcessBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProcessBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ProcessBtn.Font = new System.Drawing.Font("Stanberry", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessBtn.ForeColor = System.Drawing.Color.White;
            this.ProcessBtn.Location = new System.Drawing.Point(1139, 852);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(411, 63);
            this.ProcessBtn.TabIndex = 6;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseTransparentBackground = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // CustomerNameTxtB
            // 
            this.CustomerNameTxtB.AutoRoundedCorners = true;
            this.CustomerNameTxtB.BorderRadius = 23;
            this.CustomerNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTxtB.DefaultText = "";
            this.CustomerNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Location = new System.Drawing.Point(1139, 292);
            this.CustomerNameTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerNameTxtB.Name = "CustomerNameTxtB";
            this.CustomerNameTxtB.PasswordChar = '\0';
            this.CustomerNameTxtB.PlaceholderText = "";
            this.CustomerNameTxtB.SelectedText = "";
            this.CustomerNameTxtB.Size = new System.Drawing.Size(411, 48);
            this.CustomerNameTxtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chinacat", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1131, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Chinacat", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1131, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Services";
            // 
            // ServicesComBox
            // 
            this.ServicesComBox.AutoRoundedCorners = true;
            this.ServicesComBox.BackColor = System.Drawing.Color.Transparent;
            this.ServicesComBox.BorderRadius = 17;
            this.ServicesComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServicesComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServicesComBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServicesComBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServicesComBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServicesComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServicesComBox.ItemHeight = 30;
            this.ServicesComBox.Location = new System.Drawing.Point(1139, 443);
            this.ServicesComBox.Name = "ServicesComBox";
            this.ServicesComBox.Size = new System.Drawing.Size(411, 36);
            this.ServicesComBox.TabIndex = 2;
            this.ServicesComBox.SelectedIndexChanged += new System.EventHandler(this.ServicesComBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chinacat", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1185, 144);
            this.label1.TabIndex = 1;
            this.label1.Text = "Walk-In Transaction";
            // 
            // EmployeeListDGV
            // 
            this.EmployeeListDGV.AllowUserToAddRows = false;
            this.EmployeeListDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeListDGV.ColumnHeadersHeight = 4;
            this.EmployeeListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeListDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeListDGV.Location = new System.Drawing.Point(106, 244);
            this.EmployeeListDGV.Name = "EmployeeListDGV";
            this.EmployeeListDGV.ReadOnly = true;
            this.EmployeeListDGV.RowHeadersVisible = false;
            this.EmployeeListDGV.RowHeadersWidth = 51;
            this.EmployeeListDGV.RowTemplate.Height = 24;
            this.EmployeeListDGV.Size = new System.Drawing.Size(846, 671);
            this.EmployeeListDGV.TabIndex = 0;
            this.EmployeeListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeListDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeListDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeListDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeListDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeListDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.EmployeeListDGV.ThemeStyle.ReadOnly = true;
            this.EmployeeListDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeListDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeListDGV.ThemeStyle.RowsStyle.Height = 24;
            this.EmployeeListDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeListDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(1652, 159);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RefreshBtn.Size = new System.Drawing.Size(63, 63);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "R";
            this.RefreshBtn.UseTransparentBackground = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // WalkInTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "WalkInTransactionForm";
            this.Size = new System.Drawing.Size(1859, 1081);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox ServicesComBox;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2DataGridView EmployeeListDGV;
        private Guna.UI2.WinForms.Guna2Button ProcessBtn;
        public Guna.UI2.WinForms.Guna2TextBox CustomerNameTxtB;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton RefreshBtn;
    }
}
