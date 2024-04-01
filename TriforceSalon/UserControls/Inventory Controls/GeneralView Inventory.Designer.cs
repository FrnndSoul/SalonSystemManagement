namespace TriforceSalon.UserControls
{
    partial class GeneralView_Inventory
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
            this.InventoryDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RequestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.editProduct_Inventory1 = new TriforceSalon.UserControls.EditProduct_Inventory();
            this.addProduct_Inventory1 = new TriforceSalon.UserControls.AddProduct_Inventory();
            this.requestShipment_Inventory1 = new TriforceSalon.UserControls.RequestShipment_Inventory();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.AllowUserToAddRows = false;
            this.InventoryDGV.AllowUserToDeleteRows = false;
            this.InventoryDGV.AllowUserToResizeColumns = false;
            this.InventoryDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.InventoryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InventoryDGV.ColumnHeadersHeight = 80;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.InventoryDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InventoryDGV.Location = new System.Drawing.Point(25, 33);
            this.InventoryDGV.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.ReadOnly = true;
            this.InventoryDGV.RowHeadersVisible = false;
            this.InventoryDGV.RowHeadersWidth = 51;
            this.InventoryDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InventoryDGV.RowTemplate.Height = 40;
            this.InventoryDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDGV.Size = new System.Drawing.Size(1450, 800);
            this.InventoryDGV.TabIndex = 0;
            this.InventoryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.InventoryDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.InventoryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.InventoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.InventoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.InventoryDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.InventoryDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InventoryDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.InventoryDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.InventoryDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.InventoryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InventoryDGV.ThemeStyle.HeaderStyle.Height = 80;
            this.InventoryDGV.ThemeStyle.ReadOnly = true;
            this.InventoryDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.InventoryDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InventoryDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.InventoryDGV.ThemeStyle.RowsStyle.Height = 40;
            this.InventoryDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InventoryDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // EditBtn
            // 
            this.EditBtn.Animated = true;
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BorderRadius = 20;
            this.EditBtn.BorderThickness = 1;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.EditBtn.Font = new System.Drawing.Font("Chinacat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Image = global::TriforceSalon.Properties.Resources.edit_icon;
            this.EditBtn.Location = new System.Drawing.Point(578, 863);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(300, 70);
            this.EditBtn.TabIndex = 53;
            this.EditBtn.Text = " Edit";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RequestBtn
            // 
            this.RequestBtn.Animated = true;
            this.RequestBtn.BackColor = System.Drawing.Color.Transparent;
            this.RequestBtn.BorderRadius = 20;
            this.RequestBtn.BorderThickness = 1;
            this.RequestBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RequestBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RequestBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RequestBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RequestBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.RequestBtn.Font = new System.Drawing.Font("Chinacat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.ForeColor = System.Drawing.Color.White;
            this.RequestBtn.Image = global::TriforceSalon.Properties.Resources.request1_icon;
            this.RequestBtn.Location = new System.Drawing.Point(125, 863);
            this.RequestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(300, 70);
            this.RequestBtn.TabIndex = 52;
            this.RequestBtn.Text = " Request";
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderRadius = 20;
            this.AddBtn.BorderThickness = 1;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.AddBtn.Font = new System.Drawing.Font("Chinacat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::TriforceSalon.Properties.Resources.access_icon;
            this.AddBtn.Location = new System.Drawing.Point(1021, 863);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(300, 70);
            this.AddBtn.TabIndex = 55;
            this.AddBtn.Text = " Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // editProduct_Inventory1
            // 
            this.editProduct_Inventory1.BackColor = System.Drawing.Color.Transparent;
            this.editProduct_Inventory1.Location = new System.Drawing.Point(0, 0);
            this.editProduct_Inventory1.Name = "editProduct_Inventory1";
            this.editProduct_Inventory1.Size = new System.Drawing.Size(1500, 950);
            this.editProduct_Inventory1.TabIndex = 58;
            this.editProduct_Inventory1.Visible = false;
            this.editProduct_Inventory1.VisibleChanged += new System.EventHandler(this.editProduct_Inventory1_VisibleChanged);
            // 
            // addProduct_Inventory1
            // 
            this.addProduct_Inventory1.BackColor = System.Drawing.Color.Transparent;
            this.addProduct_Inventory1.Location = new System.Drawing.Point(8, 8);
            this.addProduct_Inventory1.Name = "addProduct_Inventory1";
            this.addProduct_Inventory1.Size = new System.Drawing.Size(1500, 950);
            this.addProduct_Inventory1.TabIndex = 57;
            this.addProduct_Inventory1.Visible = false;
            this.addProduct_Inventory1.VisibleChanged += new System.EventHandler(this.addProduct_Inventory1_VisibleChanged);
            // 
            // requestShipment_Inventory1
            // 
            this.requestShipment_Inventory1.BackColor = System.Drawing.Color.Transparent;
            this.requestShipment_Inventory1.Location = new System.Drawing.Point(0, 0);
            this.requestShipment_Inventory1.Name = "requestShipment_Inventory1";
            this.requestShipment_Inventory1.Size = new System.Drawing.Size(1500, 950);
            this.requestShipment_Inventory1.TabIndex = 59;
            this.requestShipment_Inventory1.Visible = false;
            this.requestShipment_Inventory1.VisibleChanged += new System.EventHandler(this.requestShipment_Inventory1_VisibleChanged);
            // 
            // GeneralView_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.InventoryDGV);
            this.Controls.Add(this.editProduct_Inventory1);
            this.Controls.Add(this.addProduct_Inventory1);
            this.Controls.Add(this.requestShipment_Inventory1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeneralView_Inventory";
            this.Size = new System.Drawing.Size(1500, 950);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView InventoryDGV;
        private Guna.UI2.WinForms.Guna2Button RequestBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private AddProduct_Inventory addProduct_Inventory1;
        private EditProduct_Inventory editProduct_Inventory1;
        private RequestShipment_Inventory requestShipment_Inventory1;
    }
}
