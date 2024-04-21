namespace TriforceSalon.UserControls.Promo_Controls.PromoRecords
{
    partial class ServiceRecords
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
            this.EditPromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PromoProductsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PromoNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromoCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStartStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEndCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindedItemsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PromoProductsDGV)).BeginInit();
            this.SuspendLayout();
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
            this.EditPromoBtn.Location = new System.Drawing.Point(23, 742);
            this.EditPromoBtn.Name = "EditPromoBtn";
            this.EditPromoBtn.Size = new System.Drawing.Size(861, 45);
            this.EditPromoBtn.TabIndex = 5;
            this.EditPromoBtn.Text = "Edit Promo";
            this.EditPromoBtn.Click += new System.EventHandler(this.EditPromoBtn_Click);
            // 
            // PromoProductsDGV
            // 
            this.PromoProductsDGV.AllowUserToAddRows = false;
            this.PromoProductsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PromoProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PromoProductsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PromoProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PromoProductsDGV.ColumnHeadersHeight = 44;
            this.PromoProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PromoProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PromoNameCol,
            this.PromoCodeCol,
            this.DateStartStart,
            this.DateEndCol,
            this.DiscountCol,
            this.BindedItemsCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PromoProductsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PromoProductsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PromoProductsDGV.Location = new System.Drawing.Point(23, 93);
            this.PromoProductsDGV.Name = "PromoProductsDGV";
            this.PromoProductsDGV.ReadOnly = true;
            this.PromoProductsDGV.RowHeadersVisible = false;
            this.PromoProductsDGV.Size = new System.Drawing.Size(861, 629);
            this.PromoProductsDGV.TabIndex = 4;
            this.PromoProductsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PromoProductsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PromoProductsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PromoProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PromoProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PromoProductsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PromoProductsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PromoProductsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PromoProductsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PromoProductsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoProductsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PromoProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PromoProductsDGV.ThemeStyle.HeaderStyle.Height = 44;
            this.PromoProductsDGV.ThemeStyle.ReadOnly = true;
            this.PromoProductsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PromoProductsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PromoProductsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoProductsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PromoProductsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.PromoProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PromoProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.BindedItemsCol.HeaderText = "Products";
            this.BindedItemsCol.Name = "BindedItemsCol";
            this.BindedItemsCol.ReadOnly = true;
            // 
            // ServiceRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.EditPromoBtn);
            this.Controls.Add(this.PromoProductsDGV);
            this.Name = "ServiceRecords";
            this.Size = new System.Drawing.Size(907, 800);
            this.Load += new System.EventHandler(this.ServiceRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PromoProductsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button EditPromoBtn;
        private Guna.UI2.WinForms.Guna2DataGridView PromoProductsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromoNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromoCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStartStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEndCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BindedItemsCol;
    }
}
