namespace TriforceSalon.UserControls.Promo_Controls
{
    partial class PServicesUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddPromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditPromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductsFL = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PromoNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PEndDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PStartDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PromoCodeTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.PercentageTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecrementCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncrementCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ServiceFilterComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FilterServiceComboBox = new System.Windows.Forms.Label();
            this.SearchServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchServiceTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPromoBtn
            // 
            this.AddPromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPromoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddPromoBtn.ForeColor = System.Drawing.Color.White;
            this.AddPromoBtn.Location = new System.Drawing.Point(1164, 735);
            this.AddPromoBtn.Name = "AddPromoBtn";
            this.AddPromoBtn.Size = new System.Drawing.Size(218, 45);
            this.AddPromoBtn.TabIndex = 45;
            this.AddPromoBtn.Text = "Add Promo";
            // 
            // EditPromoBtn
            // 
            this.EditPromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditPromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditPromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditPromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditPromoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditPromoBtn.ForeColor = System.Drawing.Color.White;
            this.EditPromoBtn.Location = new System.Drawing.Point(19, 735);
            this.EditPromoBtn.Name = "EditPromoBtn";
            this.EditPromoBtn.Size = new System.Drawing.Size(218, 45);
            this.EditPromoBtn.TabIndex = 44;
            this.EditPromoBtn.Text = "Edit Promo";
            // 
            // ProductsFL
            // 
            this.ProductsFL.AutoScroll = true;
            this.ProductsFL.BackColor = System.Drawing.Color.White;
            this.ProductsFL.Location = new System.Drawing.Point(19, 78);
            this.ProductsFL.Name = "ProductsFL";
            this.ProductsFL.Size = new System.Drawing.Size(878, 634);
            this.ProductsFL.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1209, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1170, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 30);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(922, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(958, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Promo Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(960, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Promo Name";
            // 
            // PromoNameTxtB
            // 
            this.PromoNameTxtB.AutoRoundedCorners = true;
            this.PromoNameTxtB.BorderRadius = 17;
            this.PromoNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PromoNameTxtB.DefaultText = "";
            this.PromoNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PromoNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PromoNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromoNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromoNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromoNameTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PromoNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromoNameTxtB.Location = new System.Drawing.Point(965, 242);
            this.PromoNameTxtB.Name = "PromoNameTxtB";
            this.PromoNameTxtB.PasswordChar = '\0';
            this.PromoNameTxtB.PlaceholderText = "";
            this.PromoNameTxtB.SelectedText = "";
            this.PromoNameTxtB.Size = new System.Drawing.Size(349, 36);
            this.PromoNameTxtB.TabIndex = 37;
            // 
            // PEndDTP
            // 
            this.PEndDTP.AutoRoundedCorners = true;
            this.PEndDTP.BorderRadius = 17;
            this.PEndDTP.Checked = true;
            this.PEndDTP.FillColor = System.Drawing.Color.White;
            this.PEndDTP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PEndDTP.Location = new System.Drawing.Point(1175, 420);
            this.PEndDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PEndDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PEndDTP.Name = "PEndDTP";
            this.PEndDTP.Size = new System.Drawing.Size(207, 36);
            this.PEndDTP.TabIndex = 36;
            this.PEndDTP.Value = new System.DateTime(2024, 4, 19, 17, 4, 37, 762);
            // 
            // PStartDTP
            // 
            this.PStartDTP.AutoRoundedCorners = true;
            this.PStartDTP.BorderRadius = 17;
            this.PStartDTP.Checked = true;
            this.PStartDTP.FillColor = System.Drawing.Color.White;
            this.PStartDTP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PStartDTP.Location = new System.Drawing.Point(927, 420);
            this.PStartDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PStartDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PStartDTP.Name = "PStartDTP";
            this.PStartDTP.Size = new System.Drawing.Size(207, 36);
            this.PStartDTP.TabIndex = 35;
            this.PStartDTP.Value = new System.DateTime(2024, 4, 19, 17, 4, 36, 655);
            // 
            // PromoCodeTxtB
            // 
            this.PromoCodeTxtB.AutoRoundedCorners = true;
            this.PromoCodeTxtB.BorderRadius = 17;
            this.PromoCodeTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PromoCodeTxtB.DefaultText = "";
            this.PromoCodeTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PromoCodeTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PromoCodeTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromoCodeTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromoCodeTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromoCodeTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PromoCodeTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromoCodeTxtB.Location = new System.Drawing.Point(965, 337);
            this.PromoCodeTxtB.Name = "PromoCodeTxtB";
            this.PromoCodeTxtB.PasswordChar = '\0';
            this.PromoCodeTxtB.PlaceholderText = "";
            this.PromoCodeTxtB.ReadOnly = true;
            this.PromoCodeTxtB.SelectedText = "";
            this.PromoCodeTxtB.Size = new System.Drawing.Size(218, 36);
            this.PromoCodeTxtB.TabIndex = 34;
            // 
            // PercentageTxtB
            // 
            this.PercentageTxtB.AutoRoundedCorners = true;
            this.PercentageTxtB.BorderRadius = 17;
            this.PercentageTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PercentageTxtB.DefaultText = "";
            this.PercentageTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PercentageTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PercentageTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PercentageTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PercentageTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PercentageTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PercentageTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PercentageTxtB.Location = new System.Drawing.Point(1214, 337);
            this.PercentageTxtB.Name = "PercentageTxtB";
            this.PercentageTxtB.PasswordChar = '\0';
            this.PercentageTxtB.PlaceholderText = "";
            this.PercentageTxtB.SelectedText = "";
            this.PercentageTxtB.Size = new System.Drawing.Size(87, 36);
            this.PercentageTxtB.TabIndex = 33;
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToAddRows = false;
            this.ProductsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ProductsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ProductsDGV.ColumnHeadersHeight = 15;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameCol,
            this.ItemIDCol,
            this.DecrementCol,
            this.QuantityCol,
            this.IncrementCol,
            this.RemoveCol});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.ProductsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsDGV.Location = new System.Drawing.Point(927, 485);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.RowHeadersVisible = false;
            this.ProductsDGV.Size = new System.Drawing.Size(455, 227);
            this.ProductsDGV.TabIndex = 32;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Height = 15;
            this.ProductsDGV.ThemeStyle.ReadOnly = false;
            this.ProductsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.HeaderText = "ItemName";
            this.ItemNameCol.Name = "ItemNameCol";
            this.ItemNameCol.ReadOnly = true;
            // 
            // ItemIDCol
            // 
            this.ItemIDCol.HeaderText = "Item ID";
            this.ItemIDCol.Name = "ItemIDCol";
            this.ItemIDCol.ReadOnly = true;
            this.ItemIDCol.Visible = false;
            // 
            // DecrementCol
            // 
            this.DecrementCol.HeaderText = "-";
            this.DecrementCol.Name = "DecrementCol";
            this.DecrementCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DecrementCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            // 
            // IncrementCol
            // 
            this.IncrementCol.HeaderText = "+";
            this.IncrementCol.Name = "IncrementCol";
            this.IncrementCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IncrementCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RemoveCol
            // 
            this.RemoveCol.HeaderText = "Remove";
            this.RemoveCol.Name = "RemoveCol";
            this.RemoveCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ServiceFilterComB
            // 
            this.ServiceFilterComB.AutoRoundedCorners = true;
            this.ServiceFilterComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceFilterComB.BorderRadius = 17;
            this.ServiceFilterComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceFilterComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceFilterComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceFilterComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceFilterComB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ServiceFilterComB.ForeColor = System.Drawing.Color.Black;
            this.ServiceFilterComB.ItemHeight = 30;
            this.ServiceFilterComB.Location = new System.Drawing.Point(184, 22);
            this.ServiceFilterComB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceFilterComB.Name = "ServiceFilterComB";
            this.ServiceFilterComB.Size = new System.Drawing.Size(198, 36);
            this.ServiceFilterComB.TabIndex = 72;
            // 
            // FilterServiceComboBox
            // 
            this.FilterServiceComboBox.Font = new System.Drawing.Font("Stanberry", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterServiceComboBox.ForeColor = System.Drawing.Color.White;
            this.FilterServiceComboBox.Location = new System.Drawing.Point(21, 22);
            this.FilterServiceComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilterServiceComboBox.Name = "FilterServiceComboBox";
            this.FilterServiceComboBox.Size = new System.Drawing.Size(180, 29);
            this.FilterServiceComboBox.TabIndex = 71;
            this.FilterServiceComboBox.Text = "Filter Services: ";
            // 
            // SearchServiceBtn
            // 
            this.SearchServiceBtn.AutoRoundedCorners = true;
            this.SearchServiceBtn.BorderRadius = 17;
            this.SearchServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchServiceBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SearchServiceBtn.Font = new System.Drawing.Font("Stanberry", 17.25F);
            this.SearchServiceBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchServiceBtn.Location = new System.Drawing.Point(521, 22);
            this.SearchServiceBtn.Name = "SearchServiceBtn";
            this.SearchServiceBtn.Size = new System.Drawing.Size(137, 36);
            this.SearchServiceBtn.TabIndex = 70;
            this.SearchServiceBtn.Text = "Search";
            this.SearchServiceBtn.Click += new System.EventHandler(this.SearchServiceBtn_Click);
            // 
            // SearchServiceTxtB
            // 
            this.SearchServiceTxtB.Animated = true;
            this.SearchServiceTxtB.AutoRoundedCorners = true;
            this.SearchServiceTxtB.BorderRadius = 17;
            this.SearchServiceTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchServiceTxtB.DefaultText = "";
            this.SearchServiceTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchServiceTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchServiceTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchServiceTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchServiceTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchServiceTxtB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SearchServiceTxtB.ForeColor = System.Drawing.Color.Black;
            this.SearchServiceTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchServiceTxtB.Location = new System.Drawing.Point(664, 22);
            this.SearchServiceTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchServiceTxtB.Name = "SearchServiceTxtB";
            this.SearchServiceTxtB.PasswordChar = '\0';
            this.SearchServiceTxtB.PlaceholderText = "";
            this.SearchServiceTxtB.SelectedText = "";
            this.SearchServiceTxtB.Size = new System.Drawing.Size(233, 36);
            this.SearchServiceTxtB.TabIndex = 69;
            // 
            // PServicesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.ServiceFilterComB);
            this.Controls.Add(this.FilterServiceComboBox);
            this.Controls.Add(this.SearchServiceBtn);
            this.Controls.Add(this.SearchServiceTxtB);
            this.Controls.Add(this.AddPromoBtn);
            this.Controls.Add(this.EditPromoBtn);
            this.Controls.Add(this.ProductsFL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PromoNameTxtB);
            this.Controls.Add(this.PEndDTP);
            this.Controls.Add(this.PStartDTP);
            this.Controls.Add(this.PromoCodeTxtB);
            this.Controls.Add(this.PercentageTxtB);
            this.Controls.Add(this.ProductsDGV);
            this.Name = "PServicesUserControl";
            this.Size = new System.Drawing.Size(1400, 800);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddPromoBtn;
        private Guna.UI2.WinForms.Guna2Button EditPromoBtn;
        private System.Windows.Forms.FlowLayoutPanel ProductsFL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox PromoNameTxtB;
        private Guna.UI2.WinForms.Guna2DateTimePicker PEndDTP;
        private Guna.UI2.WinForms.Guna2DateTimePicker PStartDTP;
        private Guna.UI2.WinForms.Guna2TextBox PromoCodeTxtB;
        private Guna.UI2.WinForms.Guna2TextBox PercentageTxtB;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDCol;
        private System.Windows.Forms.DataGridViewButtonColumn DecrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewButtonColumn IncrementCol;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveCol;
        public Guna.UI2.WinForms.Guna2ComboBox ServiceFilterComB;
        private System.Windows.Forms.Label FilterServiceComboBox;
        private Guna.UI2.WinForms.Guna2Button SearchServiceBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchServiceTxtB;
    }
}
