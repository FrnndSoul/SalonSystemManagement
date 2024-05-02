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
            this.DiscountComB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisposeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SearchProductsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AllProductsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CashTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerIDComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CalculateCostBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DatabaseTransactionRBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.DirectTransactionRBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OtherTransactionContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ActivateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PromoTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.GcashPayment = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ItemPromoComB = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsControlDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcashPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsFL
            // 
            this.ProductsFL.AutoScroll = true;
            this.ProductsFL.BackColor = System.Drawing.Color.White;
            this.ProductsFL.Location = new System.Drawing.Point(24, 88);
            this.ProductsFL.Name = "ProductsFL";
            this.ProductsFL.Size = new System.Drawing.Size(1252, 737);
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
            this.ProductSearchTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ProductSearchTxtB.ForeColor = System.Drawing.Color.Black;
            this.ProductSearchTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductSearchTxtB.Location = new System.Drawing.Point(802, 24);
            this.ProductSearchTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.cLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLbl.ForeColor = System.Drawing.Color.White;
            this.cLbl.Location = new System.Drawing.Point(1407, 705);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(76, 33);
            this.cLbl.TabIndex = 19;
            this.cLbl.Text = "₱";
            this.cLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cashLbl
            // 
            this.cashLbl.BackColor = System.Drawing.Color.Transparent;
            this.cashLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLbl.ForeColor = System.Drawing.Color.White;
            this.cashLbl.Location = new System.Drawing.Point(1284, 705);
            this.cashLbl.Name = "cashLbl";
            this.cashLbl.Size = new System.Drawing.Size(117, 33);
            this.cashLbl.TabIndex = 18;
            this.cashLbl.Text = "Cash";
            this.cashLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotLbl
            // 
            this.TotLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotLbl.ForeColor = System.Drawing.Color.White;
            this.TotLbl.Location = new System.Drawing.Point(1407, 654);
            this.TotLbl.Name = "TotLbl";
            this.TotLbl.Size = new System.Drawing.Size(168, 33);
            this.TotLbl.TabIndex = 17;
            this.TotLbl.Text = "₱ 0.00";
            this.TotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(1278, 654);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(123, 33);
            this.totalLbl.TabIndex = 16;
            this.totalLbl.Text = "Total";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscLbl
            // 
            this.DiscLbl.BackColor = System.Drawing.Color.Transparent;
            this.DiscLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscLbl.ForeColor = System.Drawing.Color.White;
            this.DiscLbl.Location = new System.Drawing.Point(1407, 604);
            this.DiscLbl.Name = "DiscLbl";
            this.DiscLbl.Size = new System.Drawing.Size(201, 33);
            this.DiscLbl.TabIndex = 15;
            this.DiscLbl.Text = "₱ 0.00";
            this.DiscLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discL
            // 
            this.discL.BackColor = System.Drawing.Color.Transparent;
            this.discL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discL.ForeColor = System.Drawing.Color.White;
            this.discL.Location = new System.Drawing.Point(1278, 604);
            this.discL.Name = "discL";
            this.discL.Size = new System.Drawing.Size(123, 33);
            this.discL.TabIndex = 14;
            this.discL.Text = "Discount";
            this.discL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubLbl
            // 
            this.SubLbl.BackColor = System.Drawing.Color.Transparent;
            this.SubLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubLbl.ForeColor = System.Drawing.Color.White;
            this.SubLbl.Location = new System.Drawing.Point(1407, 555);
            this.SubLbl.Name = "SubLbl";
            this.SubLbl.Size = new System.Drawing.Size(194, 33);
            this.SubLbl.TabIndex = 13;
            this.SubLbl.Text = "₱ 0.00";
            this.SubLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbLbl
            // 
            this.sbLbl.BackColor = System.Drawing.Color.Transparent;
            this.sbLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLbl.ForeColor = System.Drawing.Color.White;
            this.sbLbl.Location = new System.Drawing.Point(1278, 555);
            this.sbLbl.Name = "sbLbl";
            this.sbLbl.Size = new System.Drawing.Size(123, 33);
            this.sbLbl.TabIndex = 12;
            this.sbLbl.Text = "Subtotal";
            this.sbLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoidBtn
            // 
            this.VoidBtn.AutoRoundedCorners = true;
            this.VoidBtn.BorderRadius = 23;
            this.VoidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VoidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VoidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VoidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VoidBtn.FillColor = System.Drawing.Color.Red;
            this.VoidBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoidBtn.ForeColor = System.Drawing.Color.White;
            this.VoidBtn.Location = new System.Drawing.Point(1638, 689);
            this.VoidBtn.Name = "VoidBtn";
            this.VoidBtn.Size = new System.Drawing.Size(254, 49);
            this.VoidBtn.TabIndex = 20;
            this.VoidBtn.Text = "Void";
            this.VoidBtn.Click += new System.EventHandler(this.VoidBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.AutoRoundedCorners = true;
            this.PaymentBtn.BorderRadius = 23;
            this.PaymentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PaymentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PaymentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PaymentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.PaymentBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBtn.ForeColor = System.Drawing.Color.Black;
            this.PaymentBtn.Location = new System.Drawing.Point(1638, 623);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(190, 49);
            this.PaymentBtn.TabIndex = 21;
            this.PaymentBtn.Text = "Place";
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // ProductsControlDGV
            // 
            this.ProductsControlDGV.AllowUserToAddRows = false;
            this.ProductsControlDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsControlDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DiscountComB,
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
            this.ProductsControlDGV.Location = new System.Drawing.Point(1294, 24);
            this.ProductsControlDGV.Name = "ProductsControlDGV";
            this.ProductsControlDGV.RowHeadersVisible = false;
            this.ProductsControlDGV.RowHeadersWidth = 51;
            this.ProductsControlDGV.Size = new System.Drawing.Size(598, 291);
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
            this.ProductsControlDGV.ThemeStyle.ReadOnly = false;
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
            this.ProductCol.MinimumWidth = 6;
            this.ProductCol.Name = "ProductCol";
            // 
            // DecrementCol
            // 
            this.DecrementCol.HeaderText = "-";
            this.DecrementCol.MinimumWidth = 6;
            this.DecrementCol.Name = "DecrementCol";
            this.DecrementCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DecrementCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.MinimumWidth = 6;
            this.QuantityCol.Name = "QuantityCol";
            // 
            // IncrementCol
            // 
            this.IncrementCol.HeaderText = "+";
            this.IncrementCol.MinimumWidth = 6;
            this.IncrementCol.Name = "IncrementCol";
            this.IncrementCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IncrementCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CostCol
            // 
            this.CostCol.HeaderText = "Amount";
            this.CostCol.MinimumWidth = 6;
            this.CostCol.Name = "CostCol";
            this.CostCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DiscountComB
            // 
            this.DiscountComB.HeaderText = "Discount";
            this.DiscountComB.Name = "DiscountComB";
            this.DiscountComB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DisposeCol
            // 
            this.DisposeCol.HeaderText = "Bin";
            this.DisposeCol.MinimumWidth = 6;
            this.DisposeCol.Name = "DisposeCol";
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
            this.SearchProductsBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductsBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchProductsBtn.Location = new System.Drawing.Point(616, 24);
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
            this.AllProductsBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CashTxtBx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTxtBx.ForeColor = System.Drawing.Color.Black;
            this.CashTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CashTxtBx.Location = new System.Drawing.Point(1435, 705);
            this.CashTxtBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CashTxtBx.Name = "CashTxtBx";
            this.CashTxtBx.PasswordChar = '\0';
            this.CashTxtBx.PlaceholderText = "";
            this.CashTxtBx.SelectedText = "";
            this.CashTxtBx.Size = new System.Drawing.Size(173, 33);
            this.CashTxtBx.TabIndex = 25;
            this.CashTxtBx.TextChanged += new System.EventHandler(this.CashTxtBx_TextChanged);
            this.CashTxtBx.Enter += new System.EventHandler(this.CashTxtBx_Enter);
            this.CashTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTxtBx_KeyPress);
            this.CashTxtBx.Leave += new System.EventHandler(this.CashTxtBx_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1349, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerNameTxtB
            // 
            this.CustomerNameTxtB.AutoRoundedCorners = true;
            this.CustomerNameTxtB.BorderRadius = 18;
            this.CustomerNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTxtB.DefaultText = "";
            this.CustomerNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxtB.ForeColor = System.Drawing.Color.Black;
            this.CustomerNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Location = new System.Drawing.Point(1578, 344);
            this.CustomerNameTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerNameTxtB.Name = "CustomerNameTxtB";
            this.CustomerNameTxtB.PasswordChar = '\0';
            this.CustomerNameTxtB.PlaceholderText = "";
            this.CustomerNameTxtB.SelectedText = "";
            this.CustomerNameTxtB.Size = new System.Drawing.Size(314, 39);
            this.CustomerNameTxtB.TabIndex = 27;
            this.CustomerNameTxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameTxtB_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1353, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "Transaction ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerIDComB
            // 
            this.CustomerIDComB.AutoRoundedCorners = true;
            this.CustomerIDComB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerIDComB.BorderRadius = 17;
            this.CustomerIDComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustomerIDComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerIDComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIDComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIDComB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDComB.ForeColor = System.Drawing.Color.Black;
            this.CustomerIDComB.ItemHeight = 30;
            this.CustomerIDComB.Location = new System.Drawing.Point(1578, 404);
            this.CustomerIDComB.Name = "CustomerIDComB";
            this.CustomerIDComB.Size = new System.Drawing.Size(314, 36);
            this.CustomerIDComB.TabIndex = 31;
            // 
            // CalculateCostBtn
            // 
            this.CalculateCostBtn.AutoRoundedCorners = true;
            this.CalculateCostBtn.BorderRadius = 22;
            this.CalculateCostBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CalculateCostBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CalculateCostBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CalculateCostBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CalculateCostBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.CalculateCostBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateCostBtn.ForeColor = System.Drawing.Color.Black;
            this.CalculateCostBtn.Location = new System.Drawing.Point(1638, 555);
            this.CalculateCostBtn.Name = "CalculateCostBtn";
            this.CalculateCostBtn.Size = new System.Drawing.Size(254, 47);
            this.CalculateCostBtn.TabIndex = 32;
            this.CalculateCostBtn.Text = "Compute";
            this.CalculateCostBtn.Click += new System.EventHandler(this.CalculateCostBtn_Click);
            // 
            // DatabaseTransactionRBtn
            // 
            this.DatabaseTransactionRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DatabaseTransactionRBtn.CheckedState.BorderThickness = 0;
            this.DatabaseTransactionRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DatabaseTransactionRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DatabaseTransactionRBtn.Location = new System.Drawing.Point(1318, 413);
            this.DatabaseTransactionRBtn.Name = "DatabaseTransactionRBtn";
            this.DatabaseTransactionRBtn.Size = new System.Drawing.Size(23, 23);
            this.DatabaseTransactionRBtn.TabIndex = 34;
            this.DatabaseTransactionRBtn.Text = "guna2CustomRadioButton1";
            this.DatabaseTransactionRBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DatabaseTransactionRBtn.UncheckedState.BorderThickness = 2;
            this.DatabaseTransactionRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DatabaseTransactionRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.DatabaseTransactionRBtn.CheckedChanged += new System.EventHandler(this.DatabaseTransactionRBtn_CheckedChanged);
            // 
            // DirectTransactionRBtn
            // 
            this.DirectTransactionRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DirectTransactionRBtn.CheckedState.BorderThickness = 0;
            this.DirectTransactionRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DirectTransactionRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DirectTransactionRBtn.Location = new System.Drawing.Point(1318, 355);
            this.DirectTransactionRBtn.Name = "DirectTransactionRBtn";
            this.DirectTransactionRBtn.Size = new System.Drawing.Size(23, 23);
            this.DirectTransactionRBtn.TabIndex = 35;
            this.DirectTransactionRBtn.Text = "guna2CustomRadioButton2";
            this.DirectTransactionRBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DirectTransactionRBtn.UncheckedState.BorderThickness = 2;
            this.DirectTransactionRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DirectTransactionRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.DirectTransactionRBtn.CheckedChanged += new System.EventHandler(this.DirectTransactionRBtn_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 32;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Enabled = false;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2Button1.Font = new System.Drawing.Font("Chinacat", 18F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(1833, 613);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(66, 66);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.DarkOrchid;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Stanberry", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(896, 24);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(335, 82);
            this.guna2HtmlLabel12.TabIndex = 39;
            this.guna2HtmlLabel12.Text = "‎ ‎ ‎Payment ‎ ‎";
            this.guna2HtmlLabel12.Visible = false;
            // 
            // OtherTransactionContainer
            // 
            this.OtherTransactionContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.OtherTransactionContainer.Location = new System.Drawing.Point(860, 56);
            this.OtherTransactionContainer.Name = "OtherTransactionContainer";
            this.OtherTransactionContainer.Size = new System.Drawing.Size(417, 767);
            this.OtherTransactionContainer.TabIndex = 40;
            this.OtherTransactionContainer.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BorderRadius = 23;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.BackBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.Black;
            this.BackBtn.Location = new System.Drawing.Point(1303, 774);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(190, 49);
            this.BackBtn.TabIndex = 41;
            this.BackBtn.Text = "Back";
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ActivateBtn
            // 
            this.ActivateBtn.AutoRoundedCorners = true;
            this.ActivateBtn.BorderRadius = 17;
            this.ActivateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ActivateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ActivateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ActivateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ActivateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ActivateBtn.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ActivateBtn.ForeColor = System.Drawing.Color.Black;
            this.ActivateBtn.Location = new System.Drawing.Point(1382, 474);
            this.ActivateBtn.Name = "ActivateBtn";
            this.ActivateBtn.Size = new System.Drawing.Size(180, 36);
            this.ActivateBtn.TabIndex = 42;
            this.ActivateBtn.Text = "Avail Promo";
            this.ActivateBtn.Click += new System.EventHandler(this.ActivateBtn_Click);
            // 
            // PromoTxtB
            // 
            this.PromoTxtB.AutoRoundedCorners = true;
            this.PromoTxtB.BorderRadius = 16;
            this.PromoTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PromoTxtB.DefaultText = "";
            this.PromoTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PromoTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PromoTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromoTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromoTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromoTxtB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromoTxtB.Location = new System.Drawing.Point(1327, 474);
            this.PromoTxtB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PromoTxtB.Name = "PromoTxtB";
            this.PromoTxtB.PasswordChar = '\0';
            this.PromoTxtB.PlaceholderText = "Enter Promo Code Here";
            this.PromoTxtB.SelectedText = "";
            this.PromoTxtB.Size = new System.Drawing.Size(34, 36);
            this.PromoTxtB.TabIndex = 43;
            this.PromoTxtB.Visible = false;
            this.PromoTxtB.TextChanged += new System.EventHandler(this.PromoTxtB_TextChanged);
            // 
            // GcashPayment
            // 
            this.GcashPayment.BackColor = System.Drawing.Color.Transparent;
            this.GcashPayment.Image = global::TriforceSalon.Properties.Resources.Gcash;
            this.GcashPayment.ImageRotate = 0F;
            this.GcashPayment.Location = new System.Drawing.Point(1841, 621);
            this.GcashPayment.Name = "GcashPayment";
            this.GcashPayment.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GcashPayment.Size = new System.Drawing.Size(50, 50);
            this.GcashPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GcashPayment.TabIndex = 38;
            this.GcashPayment.TabStop = false;
            this.GcashPayment.UseTransparentBackground = true;
            this.GcashPayment.Click += new System.EventHandler(this.GcashPayment_Click);
            // 
            // ItemPromoComB
            // 
            this.ItemPromoComB.AutoRoundedCorners = true;
            this.ItemPromoComB.BackColor = System.Drawing.Color.Transparent;
            this.ItemPromoComB.BorderRadius = 17;
            this.ItemPromoComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ItemPromoComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemPromoComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemPromoComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemPromoComB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ItemPromoComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ItemPromoComB.ItemHeight = 30;
            this.ItemPromoComB.Location = new System.Drawing.Point(1578, 474);
            this.ItemPromoComB.Name = "ItemPromoComB";
            this.ItemPromoComB.Size = new System.Drawing.Size(313, 36);
            this.ItemPromoComB.TabIndex = 49;
            this.ItemPromoComB.SelectedIndexChanged += new System.EventHandler(this.ItemPromoComB_SelectedIndexChanged);
            // 
            // SellProductsUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.ItemPromoComB);
            this.Controls.Add(this.PromoTxtB);
            this.Controls.Add(this.ActivateBtn);
            this.Controls.Add(this.ProductsFL);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.GcashPayment);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DatabaseTransactionRBtn);
            this.Controls.Add(this.DirectTransactionRBtn);
            this.Controls.Add(this.CalculateCostBtn);
            this.Controls.Add(this.CustomerIDComB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNameTxtB);
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
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.OtherTransactionContainer);
            this.Name = "SellProductsUserControls";
            this.Size = new System.Drawing.Size(1920, 843);
            this.Load += new System.EventHandler(this.SellProductsUserControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsControlDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcashPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsFL;
        private Guna.UI2.WinForms.Guna2TextBox ProductSearchTxtB;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.Label cashLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label discL;
        private System.Windows.Forms.Label sbLbl;
        private Guna.UI2.WinForms.Guna2Button VoidBtn;
        private Guna.UI2.WinForms.Guna2Button PaymentBtn;
        public Guna.UI2.WinForms.Guna2DataGridView ProductsControlDGV;
        private Guna.UI2.WinForms.Guna2Button SearchProductsBtn;
        private Guna.UI2.WinForms.Guna2Button AllProductsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox CustomerIDComB;
        public Guna.UI2.WinForms.Guna2TextBox CashTxtBx;
        public Guna.UI2.WinForms.Guna2TextBox CustomerNameTxtB;
        public System.Windows.Forms.Label TotLbl;
        public System.Windows.Forms.Label DiscLbl;
        public System.Windows.Forms.Label SubLbl;
        private Guna.UI2.WinForms.Guna2Button CalculateCostBtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton DatabaseTransactionRBtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton DirectTransactionRBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox GcashPayment;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2Panel OtherTransactionContainer;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button ActivateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCol;
        private System.Windows.Forms.DataGridViewButtonColumn DecrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewButtonColumn IncrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountComB;
        private System.Windows.Forms.DataGridViewButtonColumn DisposeCol;
        public Guna.UI2.WinForms.Guna2TextBox PromoTxtB;
        public Guna.UI2.WinForms.Guna2ComboBox ItemPromoComB;
    }
}
