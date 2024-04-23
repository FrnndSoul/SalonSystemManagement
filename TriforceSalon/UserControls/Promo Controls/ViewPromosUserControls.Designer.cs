namespace TriforceSalon.UserControls.Promo_Controls
{
    partial class ViewPromosUserControls
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
            this.AllPromoProductsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PromoNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStartStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEndCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindedItemsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeactivePromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WeekDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SearchVouchersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllPromoProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPromoProductsDGV
            // 
            this.AllPromoProductsDGV.AllowUserToAddRows = false;
            this.AllPromoProductsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AllPromoProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllPromoProductsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllPromoProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllPromoProductsDGV.ColumnHeadersHeight = 44;
            this.AllPromoProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllPromoProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PromoNameCol,
            this.PromoCodeCol,
            this.DateStartStart,
            this.DateEndCol,
            this.DiscountCol,
            this.BindedItemsCol,
            this.TypeCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllPromoProductsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllPromoProductsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllPromoProductsDGV.Location = new System.Drawing.Point(22, 140);
            this.AllPromoProductsDGV.Name = "AllPromoProductsDGV";
            this.AllPromoProductsDGV.ReadOnly = true;
            this.AllPromoProductsDGV.RowHeadersVisible = false;
            this.AllPromoProductsDGV.Size = new System.Drawing.Size(1353, 558);
            this.AllPromoProductsDGV.TabIndex = 1;
            this.AllPromoProductsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AllPromoProductsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AllPromoProductsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AllPromoProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AllPromoProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AllPromoProductsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AllPromoProductsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllPromoProductsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AllPromoProductsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllPromoProductsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPromoProductsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AllPromoProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllPromoProductsDGV.ThemeStyle.HeaderStyle.Height = 44;
            this.AllPromoProductsDGV.ThemeStyle.ReadOnly = true;
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllPromoProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllPromoProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPromoProductsDGV_CellContentClick);
            // 
            // PromoNameCol
            // 
            this.PromoNameCol.HeaderText = "Promo Name";
            this.PromoNameCol.Name = "PromoNameCol";
            this.PromoNameCol.ReadOnly = true;
            // 
            // PromoCodeCol
            // 
            this.PromoCodeCol.HeaderText = "Promo Code";
            this.PromoCodeCol.Name = "PromoCodeCol";
            this.PromoCodeCol.ReadOnly = true;
            // 
            // DateStartStart
            // 
            this.DateStartStart.HeaderText = "Promo Start";
            this.DateStartStart.Name = "DateStartStart";
            this.DateStartStart.ReadOnly = true;
            // 
            // DateEndCol
            // 
            this.DateEndCol.HeaderText = "Promo End";
            this.DateEndCol.Name = "DateEndCol";
            this.DateEndCol.ReadOnly = true;
            // 
            // DiscountCol
            // 
            this.DiscountCol.HeaderText = "Percentage Discount";
            this.DiscountCol.Name = "DiscountCol";
            this.DiscountCol.ReadOnly = true;
            // 
            // BindedItemsCol
            // 
            this.BindedItemsCol.HeaderText = "Bind ID";
            this.BindedItemsCol.Name = "BindedItemsCol";
            this.BindedItemsCol.ReadOnly = true;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Visible = false;
            // 
            // EditPromoBtn
            // 
            this.EditPromoBtn.AutoRoundedCorners = true;
            this.EditPromoBtn.BorderRadius = 21;
            this.EditPromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditPromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditPromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditPromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditPromoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.EditPromoBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPromoBtn.ForeColor = System.Drawing.Color.Black;
            this.EditPromoBtn.Location = new System.Drawing.Point(22, 722);
            this.EditPromoBtn.Name = "EditPromoBtn";
            this.EditPromoBtn.Size = new System.Drawing.Size(647, 45);
            this.EditPromoBtn.TabIndex = 4;
            this.EditPromoBtn.Text = "Edit Promo";
            this.EditPromoBtn.Click += new System.EventHandler(this.EditPromoBtn_Click);
            // 
            // DeactivePromoBtn
            // 
            this.DeactivePromoBtn.AutoRoundedCorners = true;
            this.DeactivePromoBtn.BorderRadius = 21;
            this.DeactivePromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeactivePromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeactivePromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeactivePromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeactivePromoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.DeactivePromoBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeactivePromoBtn.ForeColor = System.Drawing.Color.Black;
            this.DeactivePromoBtn.Location = new System.Drawing.Point(728, 722);
            this.DeactivePromoBtn.Name = "DeactivePromoBtn";
            this.DeactivePromoBtn.Size = new System.Drawing.Size(647, 45);
            this.DeactivePromoBtn.TabIndex = 5;
            this.DeactivePromoBtn.Text = "Deactivate Promo";
            this.DeactivePromoBtn.Click += new System.EventHandler(this.DeactivePromoBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find active vouchers within a week.";
            // 
            // WeekDTP
            // 
            this.WeekDTP.AutoRoundedCorners = true;
            this.WeekDTP.BorderRadius = 21;
            this.WeekDTP.Checked = true;
            this.WeekDTP.FillColor = System.Drawing.Color.White;
            this.WeekDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WeekDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.WeekDTP.Location = new System.Drawing.Point(494, 89);
            this.WeekDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.WeekDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.WeekDTP.Name = "WeekDTP";
            this.WeekDTP.Size = new System.Drawing.Size(301, 45);
            this.WeekDTP.TabIndex = 7;
            this.WeekDTP.Value = new System.DateTime(2024, 4, 23, 21, 26, 56, 475);
            // 
            // SearchVouchersBtn
            // 
            this.SearchVouchersBtn.AutoRoundedCorners = true;
            this.SearchVouchersBtn.BorderRadius = 21;
            this.SearchVouchersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchVouchersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchVouchersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchVouchersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchVouchersBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SearchVouchersBtn.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.SearchVouchersBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchVouchersBtn.Location = new System.Drawing.Point(260, 89);
            this.SearchVouchersBtn.Name = "SearchVouchersBtn";
            this.SearchVouchersBtn.Size = new System.Drawing.Size(228, 45);
            this.SearchVouchersBtn.TabIndex = 8;
            this.SearchVouchersBtn.Text = "Search";
            this.SearchVouchersBtn.Click += new System.EventHandler(this.SearchVouchersBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AutoRoundedCorners = true;
            this.RefreshBtn.BorderRadius = 21;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(22, 89);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(228, 45);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ViewPromosUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchVouchersBtn);
            this.Controls.Add(this.WeekDTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeactivePromoBtn);
            this.Controls.Add(this.EditPromoBtn);
            this.Controls.Add(this.AllPromoProductsDGV);
            this.Name = "ViewPromosUserControls";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.ViewPromosUserControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPromoProductsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView AllPromoProductsDGV;
        private Guna.UI2.WinForms.Guna2Button EditPromoBtn;
        private Guna.UI2.WinForms.Guna2Button DeactivePromoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromoNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromoCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStartStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEndCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BindedItemsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private Guna.UI2.WinForms.Guna2DateTimePicker WeekDTP;
        private Guna.UI2.WinForms.Guna2Button SearchVouchersBtn;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
    }
}
