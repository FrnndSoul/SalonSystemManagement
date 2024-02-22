namespace TriforceSalon
{
    partial class InventoryPage
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
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ReqShipBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ShipmentDGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.StatusBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ReqShipPanel = new System.Windows.Forms.Panel();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RequestBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Less = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Add = new Guna.UI2.WinForms.Guna2CircleButton();
            this.StockBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CodeBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CostBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AggregateBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShipmentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDGV)).BeginInit();
            this.ReqShipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.AllowUserToAddRows = false;
            this.InventoryDGV.AllowUserToDeleteRows = false;
            this.InventoryDGV.AllowUserToResizeColumns = false;
            this.InventoryDGV.AllowUserToResizeRows = false;
            this.InventoryDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Location = new System.Drawing.Point(6, 6);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.ReadOnly = true;
            this.InventoryDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryDGV.Size = new System.Drawing.Size(584, 574);
            this.InventoryDGV.TabIndex = 0;
            this.InventoryDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDGV_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1894, 1025);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReqShipPanel);
            this.tabPage1.Controls.Add(this.ReqShipBtn);
            this.tabPage1.Controls.Add(this.InventoryDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1886, 999);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReqShipBtn
            // 
            this.ReqShipBtn.Location = new System.Drawing.Point(6, 586);
            this.ReqShipBtn.Name = "ReqShipBtn";
            this.ReqShipBtn.Size = new System.Drawing.Size(167, 23);
            this.ReqShipBtn.TabIndex = 1;
            this.ReqShipBtn.Text = " Request Shipment";
            this.ReqShipBtn.UseVisualStyleBackColor = true;
            this.ReqShipBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ShipmentDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1886, 999);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shipment History";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ShipmentDGV
            // 
            this.ShipmentDGV.AllowUserToAddRows = false;
            this.ShipmentDGV.AllowUserToDeleteRows = false;
            this.ShipmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDGV.Location = new System.Drawing.Point(45, 37);
            this.ShipmentDGV.Name = "ShipmentDGV";
            this.ShipmentDGV.ReadOnly = true;
            this.ShipmentDGV.Size = new System.Drawing.Size(722, 412);
            this.ShipmentDGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1886, 999);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transaction History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1822, 1034);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.AutoRoundedCorners = true;
            this.StatusBox.BorderRadius = 17;
            this.StatusBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StatusBox.DefaultText = "";
            this.StatusBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StatusBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StatusBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusBox.Location = new System.Drawing.Point(86, 377);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.PasswordChar = '\0';
            this.StatusBox.PlaceholderText = "";
            this.StatusBox.SelectedText = "";
            this.StatusBox.Size = new System.Drawing.Size(175, 36);
            this.StatusBox.TabIndex = 2;
            // 
            // ReqShipPanel
            // 
            this.ReqShipPanel.Controls.Add(this.guna2HtmlLabel1);
            this.ReqShipPanel.Controls.Add(this.ShipmentBtn);
            this.ReqShipPanel.Controls.Add(this.AggregateBox);
            this.ReqShipPanel.Controls.Add(this.CostBox);
            this.ReqShipPanel.Controls.Add(this.CodeBox);
            this.ReqShipPanel.Controls.Add(this.StockBox);
            this.ReqShipPanel.Controls.Add(this.Add);
            this.ReqShipPanel.Controls.Add(this.Less);
            this.ReqShipPanel.Controls.Add(this.RequestBox);
            this.ReqShipPanel.Controls.Add(this.NameBox);
            this.ReqShipPanel.Controls.Add(this.StatusBox);
            this.ReqShipPanel.Location = new System.Drawing.Point(596, 6);
            this.ReqShipPanel.Name = "ReqShipPanel";
            this.ReqShipPanel.Size = new System.Drawing.Size(729, 707);
            this.ReqShipPanel.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.AutoRoundedCorners = true;
            this.NameBox.BorderRadius = 17;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultText = "";
            this.NameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Location = new System.Drawing.Point(267, 209);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(356, 36);
            this.NameBox.TabIndex = 4;
            // 
            // RequestBox
            // 
            this.RequestBox.AutoRoundedCorners = true;
            this.RequestBox.BorderRadius = 17;
            this.RequestBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RequestBox.DefaultText = "0";
            this.RequestBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RequestBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RequestBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RequestBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RequestBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RequestBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RequestBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RequestBox.Location = new System.Drawing.Point(490, 377);
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.PasswordChar = '\0';
            this.RequestBox.PlaceholderText = "";
            this.RequestBox.SelectedText = "";
            this.RequestBox.Size = new System.Drawing.Size(91, 36);
            this.RequestBox.TabIndex = 11;
            // 
            // Less
            // 
            this.Less.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Less.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Less.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Less.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Less.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Less.ForeColor = System.Drawing.Color.White;
            this.Less.Location = new System.Drawing.Point(448, 377);
            this.Less.Name = "Less";
            this.Less.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Less.Size = new System.Drawing.Size(36, 36);
            this.Less.TabIndex = 15;
            this.Less.Text = "-";
            this.Less.Click += new System.EventHandler(this.Less_Click);
            // 
            // Add
            // 
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(587, 377);
            this.Add.Name = "Add";
            this.Add.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Add.Size = new System.Drawing.Size(36, 36);
            this.Add.TabIndex = 16;
            this.Add.Text = "+";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // StockBox
            // 
            this.StockBox.AutoRoundedCorners = true;
            this.StockBox.BorderRadius = 17;
            this.StockBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StockBox.DefaultText = "";
            this.StockBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StockBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StockBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StockBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StockBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StockBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StockBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StockBox.Location = new System.Drawing.Point(86, 293);
            this.StockBox.Name = "StockBox";
            this.StockBox.PasswordChar = '\0';
            this.StockBox.PlaceholderText = "";
            this.StockBox.SelectedText = "";
            this.StockBox.Size = new System.Drawing.Size(175, 36);
            this.StockBox.TabIndex = 17;
            // 
            // CodeBox
            // 
            this.CodeBox.AutoRoundedCorners = true;
            this.CodeBox.BorderRadius = 17;
            this.CodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeBox.DefaultText = "";
            this.CodeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CodeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CodeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CodeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CodeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CodeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeBox.Location = new System.Drawing.Point(86, 209);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.PasswordChar = '\0';
            this.CodeBox.PlaceholderText = "";
            this.CodeBox.SelectedText = "";
            this.CodeBox.Size = new System.Drawing.Size(175, 36);
            this.CodeBox.TabIndex = 20;
            // 
            // CostBox
            // 
            this.CostBox.AutoRoundedCorners = true;
            this.CostBox.BorderRadius = 17;
            this.CostBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CostBox.DefaultText = "";
            this.CostBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CostBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CostBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CostBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CostBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CostBox.Location = new System.Drawing.Point(267, 293);
            this.CostBox.Name = "CostBox";
            this.CostBox.PasswordChar = '\0';
            this.CostBox.PlaceholderText = "";
            this.CostBox.SelectedText = "";
            this.CostBox.Size = new System.Drawing.Size(175, 36);
            this.CostBox.TabIndex = 21;
            // 
            // AggregateBox
            // 
            this.AggregateBox.AutoRoundedCorners = true;
            this.AggregateBox.BorderRadius = 17;
            this.AggregateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AggregateBox.DefaultText = "";
            this.AggregateBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AggregateBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AggregateBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AggregateBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AggregateBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AggregateBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AggregateBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AggregateBox.Location = new System.Drawing.Point(448, 293);
            this.AggregateBox.Name = "AggregateBox";
            this.AggregateBox.PasswordChar = '\0';
            this.AggregateBox.PlaceholderText = "";
            this.AggregateBox.SelectedText = "";
            this.AggregateBox.Size = new System.Drawing.Size(175, 36);
            this.AggregateBox.TabIndex = 22;
            // 
            // ShipmentBtn
            // 
            this.ShipmentBtn.AutoRoundedCorners = true;
            this.ShipmentBtn.BorderRadius = 21;
            this.ShipmentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShipmentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShipmentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShipmentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShipmentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShipmentBtn.ForeColor = System.Drawing.Color.White;
            this.ShipmentBtn.Location = new System.Drawing.Point(448, 461);
            this.ShipmentBtn.Name = "ShipmentBtn";
            this.ShipmentBtn.Size = new System.Drawing.Size(180, 45);
            this.ShipmentBtn.TabIndex = 23;
            this.ShipmentBtn.Text = "Request Shipment";
            this.ShipmentBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(86, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Product Details";
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "InventoryPage";
            this.Size = new System.Drawing.Size(1900, 1060);
            this.Load += new System.EventHandler(this.InventoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDGV)).EndInit();
            this.ReqShipPanel.ResumeLayout(false);
            this.ReqShipPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryDGV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ReqShipBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ShipmentDGV;
        private System.Windows.Forms.Panel ReqShipPanel;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2TextBox StatusBox;
        private Guna.UI2.WinForms.Guna2CircleButton Add;
        private Guna.UI2.WinForms.Guna2CircleButton Less;
        private Guna.UI2.WinForms.Guna2TextBox RequestBox;
        private Guna.UI2.WinForms.Guna2TextBox StockBox;
        private Guna.UI2.WinForms.Guna2TextBox CodeBox;
        private Guna.UI2.WinForms.Guna2TextBox AggregateBox;
        private Guna.UI2.WinForms.Guna2TextBox CostBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ShipmentBtn;
    }
}
