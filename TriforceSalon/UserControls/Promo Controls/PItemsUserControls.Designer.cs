namespace TriforceSalon.UserControls.Promo_Controls
{
    partial class PItemsUserControls
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
            this.AddPromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchProductsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductSearchTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductContainer = new System.Windows.Forms.Panel();
            this.RecordsContainer = new System.Windows.Forms.Panel();
            this.EditAPromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdatePromoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DiscardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.ProductContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsFL
            // 
            this.ProductsFL.AutoScroll = true;
            this.ProductsFL.BackColor = System.Drawing.Color.White;
            this.ProductsFL.Location = new System.Drawing.Point(16, 76);
            this.ProductsFL.Name = "ProductsFL";
            this.ProductsFL.Size = new System.Drawing.Size(878, 699);
            this.ProductsFL.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1270, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1158, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Date End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(924, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(924, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "Promo Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(924, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 24;
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
            this.PromoNameTxtB.Location = new System.Drawing.Point(929, 132);
            this.PromoNameTxtB.Name = "PromoNameTxtB";
            this.PromoNameTxtB.PasswordChar = '\0';
            this.PromoNameTxtB.PlaceholderText = "";
            this.PromoNameTxtB.SelectedText = "";
            this.PromoNameTxtB.Size = new System.Drawing.Size(442, 36);
            this.PromoNameTxtB.TabIndex = 23;
            // 
            // PEndDTP
            // 
            this.PEndDTP.AutoRoundedCorners = true;
            this.PEndDTP.BorderRadius = 17;
            this.PEndDTP.Checked = true;
            this.PEndDTP.FillColor = System.Drawing.Color.White;
            this.PEndDTP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PEndDTP.Location = new System.Drawing.Point(1163, 310);
            this.PEndDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PEndDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PEndDTP.Name = "PEndDTP";
            this.PEndDTP.Size = new System.Drawing.Size(221, 36);
            this.PEndDTP.TabIndex = 22;
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
            this.PStartDTP.Location = new System.Drawing.Point(929, 310);
            this.PStartDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PStartDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PStartDTP.Name = "PStartDTP";
            this.PStartDTP.Size = new System.Drawing.Size(221, 36);
            this.PStartDTP.TabIndex = 21;
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
            this.PromoCodeTxtB.Location = new System.Drawing.Point(929, 227);
            this.PromoCodeTxtB.Name = "PromoCodeTxtB";
            this.PromoCodeTxtB.PasswordChar = '\0';
            this.PromoCodeTxtB.PlaceholderText = "";
            this.PromoCodeTxtB.ReadOnly = true;
            this.PromoCodeTxtB.SelectedText = "";
            this.PromoCodeTxtB.Size = new System.Drawing.Size(318, 36);
            this.PromoCodeTxtB.TabIndex = 20;
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
            this.PercentageTxtB.Location = new System.Drawing.Point(1275, 227);
            this.PercentageTxtB.Name = "PercentageTxtB";
            this.PercentageTxtB.PasswordChar = '\0';
            this.PercentageTxtB.PlaceholderText = "";
            this.PercentageTxtB.SelectedText = "";
            this.PercentageTxtB.Size = new System.Drawing.Size(96, 36);
            this.PercentageTxtB.TabIndex = 19;
            this.PercentageTxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentageTxtB_KeyPress);
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToAddRows = false;
            this.ProductsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDGV.ColumnHeadersHeight = 15;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameCol,
            this.ItemIDCol,
            this.DecrementCol,
            this.QuantityCol,
            this.IncrementCol,
            this.RemoveCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsDGV.Location = new System.Drawing.Point(932, 399);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.RowHeadersVisible = false;
            this.ProductsDGV.Size = new System.Drawing.Size(455, 227);
            this.ProductsDGV.TabIndex = 18;
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
            this.ProductsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDGV_CellClick);
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
            // AddPromoBtn
            // 
            this.AddPromoBtn.AutoRoundedCorners = true;
            this.AddPromoBtn.BorderRadius = 21;
            this.AddPromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPromoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AddPromoBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPromoBtn.ForeColor = System.Drawing.Color.Black;
            this.AddPromoBtn.Location = new System.Drawing.Point(1163, 743);
            this.AddPromoBtn.Name = "AddPromoBtn";
            this.AddPromoBtn.Size = new System.Drawing.Size(221, 45);
            this.AddPromoBtn.TabIndex = 31;
            this.AddPromoBtn.Text = "Add Promo";
            this.AddPromoBtn.Click += new System.EventHandler(this.AddPromoBtn_Click);
            // 
            // SearchProductsBtn
            // 
            this.SearchProductsBtn.AutoRoundedCorners = true;
            this.SearchProductsBtn.BorderRadius = 18;
            this.SearchProductsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchProductsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchProductsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchProductsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchProductsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SearchProductsBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductsBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchProductsBtn.Location = new System.Drawing.Point(540, 16);
            this.SearchProductsBtn.Name = "SearchProductsBtn";
            this.SearchProductsBtn.Size = new System.Drawing.Size(122, 38);
            this.SearchProductsBtn.TabIndex = 33;
            this.SearchProductsBtn.Text = "Search";
            this.SearchProductsBtn.Click += new System.EventHandler(this.SearchProductsBtn_Click);
            // 
            // ProductSearchTxtB
            // 
            this.ProductSearchTxtB.Animated = true;
            this.ProductSearchTxtB.AutoRoundedCorners = true;
            this.ProductSearchTxtB.BorderRadius = 18;
            this.ProductSearchTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductSearchTxtB.DefaultText = "";
            this.ProductSearchTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductSearchTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductSearchTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductSearchTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductSearchTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductSearchTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ProductSearchTxtB.ForeColor = System.Drawing.Color.Black;
            this.ProductSearchTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductSearchTxtB.Location = new System.Drawing.Point(668, 16);
            this.ProductSearchTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductSearchTxtB.Name = "ProductSearchTxtB";
            this.ProductSearchTxtB.PasswordChar = '\0';
            this.ProductSearchTxtB.PlaceholderText = "";
            this.ProductSearchTxtB.SelectedText = "";
            this.ProductSearchTxtB.Size = new System.Drawing.Size(226, 38);
            this.ProductSearchTxtB.TabIndex = 32;
            // 
            // ProductContainer
            // 
            this.ProductContainer.Controls.Add(this.SearchProductsBtn);
            this.ProductContainer.Controls.Add(this.ProductsFL);
            this.ProductContainer.Controls.Add(this.ProductSearchTxtB);
            this.ProductContainer.Location = new System.Drawing.Point(0, 0);
            this.ProductContainer.Name = "ProductContainer";
            this.ProductContainer.Size = new System.Drawing.Size(907, 800);
            this.ProductContainer.TabIndex = 34;
            // 
            // RecordsContainer
            // 
            this.RecordsContainer.Location = new System.Drawing.Point(0, 0);
            this.RecordsContainer.Name = "RecordsContainer";
            this.RecordsContainer.Size = new System.Drawing.Size(907, 800);
            this.RecordsContainer.TabIndex = 35;
            this.RecordsContainer.Visible = false;
            // 
            // EditAPromoBtn
            // 
            this.EditAPromoBtn.AutoRoundedCorners = true;
            this.EditAPromoBtn.BorderRadius = 21;
            this.EditAPromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditAPromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditAPromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditAPromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditAPromoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.EditAPromoBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAPromoBtn.ForeColor = System.Drawing.Color.Black;
            this.EditAPromoBtn.Location = new System.Drawing.Point(929, 743);
            this.EditAPromoBtn.Name = "EditAPromoBtn";
            this.EditAPromoBtn.Size = new System.Drawing.Size(221, 45);
            this.EditAPromoBtn.TabIndex = 35;
            this.EditAPromoBtn.Text = "Edit A Promo";
            this.EditAPromoBtn.Click += new System.EventHandler(this.EditAPromoBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BorderRadius = 21;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.CancelBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(929, 743);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(221, 45);
            this.CancelBtn.TabIndex = 36;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(921, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 72);
            this.label3.TabIndex = 37;
            this.label3.Text = "Promo Information";
            // 
            // UpdatePromoBtn
            // 
            this.UpdatePromoBtn.AutoRoundedCorners = true;
            this.UpdatePromoBtn.BorderRadius = 21;
            this.UpdatePromoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdatePromoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdatePromoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdatePromoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdatePromoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.UpdatePromoBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePromoBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdatePromoBtn.Location = new System.Drawing.Point(929, 677);
            this.UpdatePromoBtn.Name = "UpdatePromoBtn";
            this.UpdatePromoBtn.Size = new System.Drawing.Size(221, 45);
            this.UpdatePromoBtn.TabIndex = 39;
            this.UpdatePromoBtn.Text = "Update Promo";
            this.UpdatePromoBtn.Click += new System.EventHandler(this.UpdatePromoBtn_Click);
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.AutoRoundedCorners = true;
            this.DiscardBtn.BorderRadius = 21;
            this.DiscardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.DiscardBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscardBtn.ForeColor = System.Drawing.Color.Black;
            this.DiscardBtn.Location = new System.Drawing.Point(1163, 677);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(221, 45);
            this.DiscardBtn.TabIndex = 38;
            this.DiscardBtn.Text = "Discard Edit";
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(927, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "Promo Items";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(929, 638);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(35, 13);
            this.IDLbl.TabIndex = 41;
            this.IDLbl.Text = "label8";
            // 
            // PItemsUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdatePromoBtn);
            this.Controls.Add(this.DiscardBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditAPromoBtn);
            this.Controls.Add(this.AddPromoBtn);
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
            this.Controls.Add(this.ProductContainer);
            this.Controls.Add(this.RecordsContainer);
            this.Controls.Add(this.CancelBtn);
            this.Name = "PItemsUserControls";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.PItemsUserControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ProductContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsFL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDCol;
        private System.Windows.Forms.DataGridViewButtonColumn DecrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewButtonColumn IncrementCol;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveCol;
        private Guna.UI2.WinForms.Guna2Button SearchProductsBtn;
        private Guna.UI2.WinForms.Guna2TextBox ProductSearchTxtB;
        private System.Windows.Forms.Panel ProductContainer;
        private System.Windows.Forms.Panel RecordsContainer;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        public Guna.UI2.WinForms.Guna2TextBox PromoNameTxtB;
        public Guna.UI2.WinForms.Guna2DateTimePicker PEndDTP;
        public Guna.UI2.WinForms.Guna2DateTimePicker PStartDTP;
        public Guna.UI2.WinForms.Guna2TextBox PromoCodeTxtB;
        public Guna.UI2.WinForms.Guna2TextBox PercentageTxtB;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2DataGridView ProductsDGV;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2Button UpdatePromoBtn;
        public Guna.UI2.WinForms.Guna2Button DiscardBtn;
        public Guna.UI2.WinForms.Guna2Button AddPromoBtn;
        public Guna.UI2.WinForms.Guna2Button EditAPromoBtn;
        public System.Windows.Forms.Label IDLbl;
    }
}
