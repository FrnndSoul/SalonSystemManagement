namespace TriforceSalon.UserControls.Receptionist_Controls
{
    partial class SellProductsUserControls
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
            this.ProductSearchTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.cLbl = new System.Windows.Forms.Label();
            this.cashLbl = new System.Windows.Forms.Label();
            this.TotLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.DiscLbl = new System.Windows.Forms.Label();
            this.discL = new System.Windows.Forms.Label();
            this.SubLbl = new System.Windows.Forms.Label();
            this.sbLbl = new System.Windows.Forms.Label();
            this.VoidBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PaymentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductsControlDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecrementCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncrementCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisposeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SearchProductsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AllProductsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CashTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.discChckBx = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsControlDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsFL
            // 
            this.ProductsFL.BackColor = System.Drawing.Color.White;
            this.ProductsFL.Location = new System.Drawing.Point(24, 88);
            this.ProductsFL.Name = "ProductsFL";
            this.ProductsFL.Size = new System.Drawing.Size(1298, 737);
            this.ProductsFL.TabIndex = 1;
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
            this.ProductSearchTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductSearchTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductSearchTxtB.Location = new System.Drawing.Point(848, 24);
            this.ProductSearchTxtB.Name = "ProductSearchTxtB";
            this.ProductSearchTxtB.PasswordChar = '\0';
            this.ProductSearchTxtB.PlaceholderText = "";
            this.ProductSearchTxtB.SelectedText = "";
            this.ProductSearchTxtB.Size = new System.Drawing.Size(474, 38);
            this.ProductSearchTxtB.TabIndex = 5;
            // 
            // cLbl
            // 
            this.cLbl.BackColor = System.Drawing.Color.Transparent;
            this.cLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLbl.ForeColor = System.Drawing.Color.White;
            this.cLbl.Location = new System.Drawing.Point(1597, 649);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(87, 56);
            this.cLbl.TabIndex = 19;
            this.cLbl.Text = "Php.";
            this.cLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cashLbl
            // 
            this.cashLbl.BackColor = System.Drawing.Color.Transparent;
            this.cashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLbl.ForeColor = System.Drawing.Color.White;
            this.cashLbl.Location = new System.Drawing.Point(1388, 649);
            this.cashLbl.Name = "cashLbl";
            this.cashLbl.Size = new System.Drawing.Size(154, 56);
            this.cashLbl.TabIndex = 18;
            this.cashLbl.Text = "Cash";
            this.cashLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotLbl
            // 
            this.TotLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotLbl.ForeColor = System.Drawing.Color.White;
            this.TotLbl.Location = new System.Drawing.Point(1597, 585);
            this.TotLbl.Name = "TotLbl";
            this.TotLbl.Size = new System.Drawing.Size(268, 56);
            this.TotLbl.TabIndex = 17;
            this.TotLbl.Text = "Php. 0.00";
            this.TotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(1389, 585);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(153, 56);
            this.totalLbl.TabIndex = 16;
            this.totalLbl.Text = "Total";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscLbl
            // 
            this.DiscLbl.BackColor = System.Drawing.Color.Transparent;
            this.DiscLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscLbl.ForeColor = System.Drawing.Color.White;
            this.DiscLbl.Location = new System.Drawing.Point(1597, 529);
            this.DiscLbl.Name = "DiscLbl";
            this.DiscLbl.Size = new System.Drawing.Size(268, 56);
            this.DiscLbl.TabIndex = 15;
            this.DiscLbl.Text = "Php. 0.00";
            this.DiscLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discL
            // 
            this.discL.BackColor = System.Drawing.Color.Transparent;
            this.discL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discL.ForeColor = System.Drawing.Color.White;
            this.discL.Location = new System.Drawing.Point(1363, 529);
            this.discL.Name = "discL";
            this.discL.Size = new System.Drawing.Size(184, 56);
            this.discL.TabIndex = 14;
            this.discL.Text = "Discount";
            this.discL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubLbl
            // 
            this.SubLbl.BackColor = System.Drawing.Color.Transparent;
            this.SubLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubLbl.ForeColor = System.Drawing.Color.White;
            this.SubLbl.Location = new System.Drawing.Point(1597, 473);
            this.SubLbl.Name = "SubLbl";
            this.SubLbl.Size = new System.Drawing.Size(268, 56);
            this.SubLbl.TabIndex = 13;
            this.SubLbl.Text = "Php. 0.00";
            this.SubLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbLbl
            // 
            this.sbLbl.BackColor = System.Drawing.Color.Transparent;
            this.sbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLbl.ForeColor = System.Drawing.Color.White;
            this.sbLbl.Location = new System.Drawing.Point(1363, 473);
            this.sbLbl.Name = "sbLbl";
            this.sbLbl.Size = new System.Drawing.Size(179, 56);
            this.sbLbl.TabIndex = 12;
            this.sbLbl.Text = "Subtotal";
            this.sbLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoidBtn
            // 
            this.VoidBtn.AutoRoundedCorners = true;
            this.VoidBtn.BorderRadius = 30;
            this.VoidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VoidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VoidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VoidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VoidBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VoidBtn.ForeColor = System.Drawing.Color.White;
            this.VoidBtn.Location = new System.Drawing.Point(1357, 762);
            this.VoidBtn.Name = "VoidBtn";
            this.VoidBtn.Size = new System.Drawing.Size(254, 63);
            this.VoidBtn.TabIndex = 20;
            this.VoidBtn.Text = "Void";
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.AutoRoundedCorners = true;
            this.PaymentBtn.BorderRadius = 30;
            this.PaymentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PaymentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PaymentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PaymentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PaymentBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentBtn.Location = new System.Drawing.Point(1638, 762);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(254, 63);
            this.PaymentBtn.TabIndex = 21;
            this.PaymentBtn.Text = "Place";
            // 
            // ProductsControlDGV
            // 
            this.ProductsControlDGV.AllowUserToAddRows = false;
            this.ProductsControlDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsControlDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsControlDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsControlDGV.ColumnHeadersHeight = 15;
            this.ProductsControlDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsControlDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCol,
            this.DecrementCol,
            this.QuantityCol,
            this.IncrementCol,
            this.CostCol,
            this.DisposeCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsControlDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsControlDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsControlDGV.Location = new System.Drawing.Point(1357, 24);
            this.ProductsControlDGV.Name = "ProductsControlDGV";
            this.ProductsControlDGV.ReadOnly = true;
            this.ProductsControlDGV.RowHeadersVisible = false;
            this.ProductsControlDGV.Size = new System.Drawing.Size(535, 291);
            this.ProductsControlDGV.TabIndex = 22;
            this.ProductsControlDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsControlDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsControlDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsControlDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsControlDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsControlDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsControlDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.Height = 15;
            this.ProductsControlDGV.ThemeStyle.ReadOnly = true;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsControlDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsControlDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsControlDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsControlDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsControlDGV_CellClick);
            this.ProductsControlDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsControlDGV_CellValueChanged);
            this.ProductsControlDGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ProductsControlDGV_RowsAdded);
            this.ProductsControlDGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ProductsControlDGV_RowsRemoved);
            // 
            // ProductCol
            // 
            this.ProductCol.HeaderText = "Products";
            this.ProductCol.Name = "ProductCol";
            this.ProductCol.ReadOnly = true;
            // 
            // DecrementCol
            // 
            this.DecrementCol.HeaderText = "-";
            this.DecrementCol.Name = "DecrementCol";
            this.DecrementCol.ReadOnly = true;
            this.DecrementCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DecrementCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.ReadOnly = true;
            // 
            // IncrementCol
            // 
            this.IncrementCol.HeaderText = "+";
            this.IncrementCol.Name = "IncrementCol";
            this.IncrementCol.ReadOnly = true;
            this.IncrementCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IncrementCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CostCol
            // 
            this.CostCol.HeaderText = "Amount";
            this.CostCol.Name = "CostCol";
            this.CostCol.ReadOnly = true;
            // 
            // DisposeCol
            // 
            this.DisposeCol.HeaderText = "Bin";
            this.DisposeCol.Name = "DisposeCol";
            this.DisposeCol.ReadOnly = true;
            this.DisposeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DisposeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.SearchProductsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductsBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchProductsBtn.Location = new System.Drawing.Point(662, 24);
            this.SearchProductsBtn.Name = "SearchProductsBtn";
            this.SearchProductsBtn.Size = new System.Drawing.Size(180, 38);
            this.SearchProductsBtn.TabIndex = 23;
            this.SearchProductsBtn.Text = "Search";
            this.SearchProductsBtn.Click += new System.EventHandler(this.SearchProductsBtn_Click);
            // 
            // AllProductsBtn
            // 
            this.AllProductsBtn.AutoRoundedCorners = true;
            this.AllProductsBtn.BorderRadius = 18;
            this.AllProductsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllProductsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllProductsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllProductsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllProductsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AllProductsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProductsBtn.ForeColor = System.Drawing.Color.Black;
            this.AllProductsBtn.Location = new System.Drawing.Point(24, 24);
            this.AllProductsBtn.Name = "AllProductsBtn";
            this.AllProductsBtn.Size = new System.Drawing.Size(180, 38);
            this.AllProductsBtn.TabIndex = 24;
            this.AllProductsBtn.Text = "All Products";
            this.AllProductsBtn.Click += new System.EventHandler(this.AllProductsBtn_Click);
            // 
            // CashTxtBx
            // 
            this.CashTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CashTxtBx.DefaultText = "";
            this.CashTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CashTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CashTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CashTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CashTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CashTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CashTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CashTxtBx.Location = new System.Drawing.Point(1670, 649);
            this.CashTxtBx.Name = "CashTxtBx";
            this.CashTxtBx.PasswordChar = '\0';
            this.CashTxtBx.PlaceholderText = "";
            this.CashTxtBx.SelectedText = "";
            this.CashTxtBx.Size = new System.Drawing.Size(222, 56);
            this.CashTxtBx.TabIndex = 25;
            this.CashTxtBx.TextChanged += new System.EventHandler(this.CashTxtBx_TextChanged);
            this.CashTxtBx.Enter += new System.EventHandler(this.CashTxtBx_Enter);
            this.CashTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTxtBx_KeyPress);
            this.CashTxtBx.Leave += new System.EventHandler(this.CashTxtBx_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1358, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Name:";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.AutoRoundedCorners = true;
            this.guna2TextBox2.BorderRadius = 18;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(1587, 344);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(314, 39);
            this.guna2TextBox2.TabIndex = 27;
            // 
            // discChckBx
            // 
            this.discChckBx.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discChckBx.CheckedState.BorderRadius = 0;
            this.discChckBx.CheckedState.BorderThickness = 0;
            this.discChckBx.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discChckBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.discChckBx.ForeColor = System.Drawing.Color.White;
            this.discChckBx.Location = new System.Drawing.Point(1364, 402);
            this.discChckBx.Name = "discChckBx";
            this.discChckBx.Size = new System.Drawing.Size(315, 45);
            this.discChckBx.TabIndex = 28;
            this.discChckBx.Text = "PWD/Senior (20% off)";
            this.discChckBx.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.discChckBx.UncheckedState.BorderRadius = 0;
            this.discChckBx.UncheckedState.BorderThickness = 0;
            this.discChckBx.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.discChckBx.CheckedChanged += new System.EventHandler(this.discChckBx_CheckedChanged);
            // 
            // SellProductsUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.discChckBx);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashTxtBx);
            this.Controls.Add(this.AllProductsBtn);
            this.Controls.Add(this.SearchProductsBtn);
            this.Controls.Add(this.ProductsControlDGV);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.VoidBtn);
            this.Controls.Add(this.cLbl);
            this.Controls.Add(this.cashLbl);
            this.Controls.Add(this.TotLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.DiscLbl);
            this.Controls.Add(this.discL);
            this.Controls.Add(this.SubLbl);
            this.Controls.Add(this.sbLbl);
            this.Controls.Add(this.ProductSearchTxtB);
            this.Controls.Add(this.ProductsFL);
            this.Name = "SellProductsUserControls";
            this.Size = new System.Drawing.Size(1920, 843);
            this.Load += new System.EventHandler(this.SellProductsUserControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsControlDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsFL;
        private Guna.UI2.WinForms.Guna2TextBox ProductSearchTxtB;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.Label cashLbl;
        private System.Windows.Forms.Label TotLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label DiscLbl;
        private System.Windows.Forms.Label discL;
        private System.Windows.Forms.Label SubLbl;
        private System.Windows.Forms.Label sbLbl;
        private Guna.UI2.WinForms.Guna2Button VoidBtn;
        private Guna.UI2.WinForms.Guna2Button PaymentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCol;
        private System.Windows.Forms.DataGridViewButtonColumn DecrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewButtonColumn IncrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
        private System.Windows.Forms.DataGridViewButtonColumn DisposeCol;
        public Guna.UI2.WinForms.Guna2DataGridView ProductsControlDGV;
        private Guna.UI2.WinForms.Guna2Button SearchProductsBtn;
        private Guna.UI2.WinForms.Guna2Button AllProductsBtn;
        private Guna.UI2.WinForms.Guna2TextBox CashTxtBx;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2CheckBox discChckBx;
    }
}
