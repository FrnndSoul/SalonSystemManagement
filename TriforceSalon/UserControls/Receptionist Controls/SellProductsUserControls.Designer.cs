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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cLbl = new System.Windows.Forms.Label();
            this.cashLbl = new System.Windows.Forms.Label();
            this.ttlLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.dscLbl = new System.Windows.Forms.Label();
            this.discLbl = new System.Windows.Forms.Label();
            this.sbLbl = new System.Windows.Forms.Label();
            this.subLbl = new System.Windows.Forms.Label();
            this.VoidBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PaymentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductsControlDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecrementCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncrementCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisposeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsControlDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsFL
            // 
            this.ProductsFL.BackColor = System.Drawing.Color.White;
            this.ProductsFL.Location = new System.Drawing.Point(24, 88);
            this.ProductsFL.Name = "ProductsFL";
            this.ProductsFL.Size = new System.Drawing.Size(1329, 737);
            this.ProductsFL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(624, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Services:";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(879, 24);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(474, 38);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // cLbl
            // 
            this.cLbl.BackColor = System.Drawing.Color.Transparent;
            this.cLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLbl.ForeColor = System.Drawing.Color.White;
            this.cLbl.Location = new System.Drawing.Point(1696, 592);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(154, 56);
            this.cLbl.TabIndex = 19;
            this.cLbl.Text = "Php.";
            // 
            // cashLbl
            // 
            this.cashLbl.BackColor = System.Drawing.Color.Transparent;
            this.cashLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLbl.ForeColor = System.Drawing.Color.White;
            this.cashLbl.Location = new System.Drawing.Point(1390, 592);
            this.cashLbl.Name = "cashLbl";
            this.cashLbl.Size = new System.Drawing.Size(154, 56);
            this.cashLbl.TabIndex = 18;
            this.cashLbl.Text = "Cash";
            // 
            // ttlLbl
            // 
            this.ttlLbl.BackColor = System.Drawing.Color.Transparent;
            this.ttlLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLbl.ForeColor = System.Drawing.Color.White;
            this.ttlLbl.Location = new System.Drawing.Point(1696, 536);
            this.ttlLbl.Name = "ttlLbl";
            this.ttlLbl.Size = new System.Drawing.Size(154, 56);
            this.ttlLbl.TabIndex = 17;
            this.ttlLbl.Text = "Php. 0.00";
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(1390, 536);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(153, 56);
            this.totalLbl.TabIndex = 16;
            this.totalLbl.Text = "Total";
            // 
            // dscLbl
            // 
            this.dscLbl.BackColor = System.Drawing.Color.Transparent;
            this.dscLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dscLbl.ForeColor = System.Drawing.Color.White;
            this.dscLbl.Location = new System.Drawing.Point(1696, 480);
            this.dscLbl.Name = "dscLbl";
            this.dscLbl.Size = new System.Drawing.Size(154, 56);
            this.dscLbl.TabIndex = 15;
            this.dscLbl.Text = "Php. 0.00";
            // 
            // discLbl
            // 
            this.discLbl.BackColor = System.Drawing.Color.Transparent;
            this.discLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discLbl.ForeColor = System.Drawing.Color.White;
            this.discLbl.Location = new System.Drawing.Point(1390, 480);
            this.discLbl.Name = "discLbl";
            this.discLbl.Size = new System.Drawing.Size(184, 56);
            this.discLbl.TabIndex = 14;
            this.discLbl.Text = "Discount";
            // 
            // sbLbl
            // 
            this.sbLbl.BackColor = System.Drawing.Color.Transparent;
            this.sbLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLbl.ForeColor = System.Drawing.Color.White;
            this.sbLbl.Location = new System.Drawing.Point(1696, 424);
            this.sbLbl.Name = "sbLbl";
            this.sbLbl.Size = new System.Drawing.Size(154, 56);
            this.sbLbl.TabIndex = 13;
            this.sbLbl.Text = "Php. 0.00";
            // 
            // subLbl
            // 
            this.subLbl.BackColor = System.Drawing.Color.Transparent;
            this.subLbl.Font = new System.Drawing.Font("Handmade", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.ForeColor = System.Drawing.Color.White;
            this.subLbl.Location = new System.Drawing.Point(1390, 424);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(179, 56);
            this.subLbl.TabIndex = 12;
            this.subLbl.Text = "Subtotal";
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
            this.VoidBtn.Location = new System.Drawing.Point(1388, 762);
            this.VoidBtn.Name = "VoidBtn";
            this.VoidBtn.Size = new System.Drawing.Size(227, 63);
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
            this.PaymentBtn.Location = new System.Drawing.Point(1665, 762);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(227, 63);
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
            this.ProductsControlDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.ProductsControlDGV.Location = new System.Drawing.Point(1388, 24);
            this.ProductsControlDGV.Name = "ProductsControlDGV";
            this.ProductsControlDGV.ReadOnly = true;
            this.ProductsControlDGV.RowHeadersVisible = false;
            this.ProductsControlDGV.Size = new System.Drawing.Size(504, 329);
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
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsControlDGV.ThemeStyle.HeaderStyle.Height = 15;
            this.ProductsControlDGV.ThemeStyle.ReadOnly = true;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsControlDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsControlDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProductsControlDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsControlDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // SellProductsUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.ProductsControlDGV);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.VoidBtn);
            this.Controls.Add(this.cLbl);
            this.Controls.Add(this.cashLbl);
            this.Controls.Add(this.ttlLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.dscLbl);
            this.Controls.Add(this.discLbl);
            this.Controls.Add(this.sbLbl);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.ProductsFL);
            this.Name = "SellProductsUserControls";
            this.Size = new System.Drawing.Size(1920, 843);
            this.Load += new System.EventHandler(this.SellProductsUserControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsControlDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsFL;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.Label cashLbl;
        private System.Windows.Forms.Label ttlLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label dscLbl;
        private System.Windows.Forms.Label discLbl;
        private System.Windows.Forms.Label sbLbl;
        private System.Windows.Forms.Label subLbl;
        private Guna.UI2.WinForms.Guna2Button VoidBtn;
        private Guna.UI2.WinForms.Guna2Button PaymentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCol;
        private System.Windows.Forms.DataGridViewButtonColumn DecrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewButtonColumn IncrementCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostCol;
        private System.Windows.Forms.DataGridViewButtonColumn DisposeCol;
        public Guna.UI2.WinForms.Guna2DataGridView ProductsControlDGV;
    }
}
