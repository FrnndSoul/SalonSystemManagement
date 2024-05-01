namespace TriforceSalon.UserControls.Service_Controls
{
    partial class ServiceSubTypeControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CategoryDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceTypeIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoryNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchCategoryTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.EditCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelEditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddImageCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CategoryPicB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AddCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceCategoryTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceTypeComB = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicB)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryDGV
            // 
            this.CategoryDGV.AllowUserToAddRows = false;
            this.CategoryDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.CategoryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CategoryDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CategoryDGV.ColumnHeadersHeight = 30;
            this.CategoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTypeIDCol,
            this.ServiceTImageCol,
            this.CategoryNameCol,
            this.CategoryIDCol});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.CategoryDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryDGV.Location = new System.Drawing.Point(15, 75);
            this.CategoryDGV.Name = "CategoryDGV";
            this.CategoryDGV.ReadOnly = true;
            this.CategoryDGV.RowHeadersVisible = false;
            this.CategoryDGV.RowTemplate.Height = 30;
            this.CategoryDGV.Size = new System.Drawing.Size(900, 626);
            this.CategoryDGV.TabIndex = 81;
            this.CategoryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoryDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoryDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CategoryDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoryDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoryDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CategoryDGV.ThemeStyle.ReadOnly = true;
            this.CategoryDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoryDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoryDGV.ThemeStyle.RowsStyle.Height = 30;
            this.CategoryDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoryDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ServiceTypeIDCol
            // 
            this.ServiceTypeIDCol.HeaderText = "Service Type ID";
            this.ServiceTypeIDCol.Name = "ServiceTypeIDCol";
            this.ServiceTypeIDCol.ReadOnly = true;
            // 
            // ServiceTImageCol
            // 
            this.ServiceTImageCol.HeaderText = "Category Image";
            this.ServiceTImageCol.Name = "ServiceTImageCol";
            this.ServiceTImageCol.ReadOnly = true;
            this.ServiceTImageCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceTImageCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CategoryNameCol
            // 
            this.CategoryNameCol.HeaderText = "Category Name";
            this.CategoryNameCol.Name = "CategoryNameCol";
            this.CategoryNameCol.ReadOnly = true;
            // 
            // CategoryIDCol
            // 
            this.CategoryIDCol.HeaderText = "Category ID";
            this.CategoryIDCol.Name = "CategoryIDCol";
            this.CategoryIDCol.ReadOnly = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AutoRoundedCorners = true;
            this.RefreshBtn.BorderRadius = 17;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Stanberry", 17.25F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(15, 15);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(180, 36);
            this.RefreshBtn.TabIndex = 80;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SearchCategoryBtn
            // 
            this.SearchCategoryBtn.AutoRoundedCorners = true;
            this.SearchCategoryBtn.BorderRadius = 17;
            this.SearchCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SearchCategoryBtn.Font = new System.Drawing.Font("Stanberry", 17.25F);
            this.SearchCategoryBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchCategoryBtn.Location = new System.Drawing.Point(486, 15);
            this.SearchCategoryBtn.Name = "SearchCategoryBtn";
            this.SearchCategoryBtn.Size = new System.Drawing.Size(180, 36);
            this.SearchCategoryBtn.TabIndex = 79;
            this.SearchCategoryBtn.Text = "Search";
            this.SearchCategoryBtn.Click += new System.EventHandler(this.SearchCategoryBtn_Click);
            // 
            // SearchCategoryTxtB
            // 
            this.SearchCategoryTxtB.Animated = true;
            this.SearchCategoryTxtB.AutoRoundedCorners = true;
            this.SearchCategoryTxtB.BorderRadius = 17;
            this.SearchCategoryTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchCategoryTxtB.DefaultText = "";
            this.SearchCategoryTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchCategoryTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchCategoryTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchCategoryTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchCategoryTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchCategoryTxtB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SearchCategoryTxtB.ForeColor = System.Drawing.Color.Black;
            this.SearchCategoryTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchCategoryTxtB.Location = new System.Drawing.Point(682, 15);
            this.SearchCategoryTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchCategoryTxtB.Name = "SearchCategoryTxtB";
            this.SearchCategoryTxtB.PasswordChar = '\0';
            this.SearchCategoryTxtB.PlaceholderText = "";
            this.SearchCategoryTxtB.SelectedText = "";
            this.SearchCategoryTxtB.Size = new System.Drawing.Size(233, 36);
            this.SearchCategoryTxtB.TabIndex = 78;
            // 
            // EditCategoryBtn
            // 
            this.EditCategoryBtn.Animated = true;
            this.EditCategoryBtn.AutoRoundedCorners = true;
            this.EditCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditCategoryBtn.BorderRadius = 24;
            this.EditCategoryBtn.BorderThickness = 1;
            this.EditCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.EditCategoryBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.EditCategoryBtn.ForeColor = System.Drawing.Color.Black;
            this.EditCategoryBtn.Location = new System.Drawing.Point(15, 735);
            this.EditCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditCategoryBtn.Name = "EditCategoryBtn";
            this.EditCategoryBtn.Size = new System.Drawing.Size(900, 50);
            this.EditCategoryBtn.TabIndex = 75;
            this.EditCategoryBtn.Text = "Edit ";
            this.EditCategoryBtn.UseTransparentBackground = true;
            this.EditCategoryBtn.Click += new System.EventHandler(this.EditCategoryBtn_Click);
            // 
            // CancelEditBtn
            // 
            this.CancelEditBtn.Animated = true;
            this.CancelEditBtn.AutoRoundedCorners = true;
            this.CancelEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelEditBtn.BorderRadius = 24;
            this.CancelEditBtn.BorderThickness = 1;
            this.CancelEditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelEditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelEditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelEditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelEditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.CancelEditBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.CancelEditBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelEditBtn.Location = new System.Drawing.Point(475, 735);
            this.CancelEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelEditBtn.Name = "CancelEditBtn";
            this.CancelEditBtn.Size = new System.Drawing.Size(440, 50);
            this.CancelEditBtn.TabIndex = 77;
            this.CancelEditBtn.Text = "Cancel Edit";
            this.CancelEditBtn.UseTransparentBackground = true;
            this.CancelEditBtn.Click += new System.EventHandler(this.CancelEditBtn_Click);
            // 
            // UpdateCategoryBtn
            // 
            this.UpdateCategoryBtn.Animated = true;
            this.UpdateCategoryBtn.AutoRoundedCorners = true;
            this.UpdateCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateCategoryBtn.BorderRadius = 24;
            this.UpdateCategoryBtn.BorderThickness = 1;
            this.UpdateCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.UpdateCategoryBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.UpdateCategoryBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateCategoryBtn.Location = new System.Drawing.Point(16, 735);
            this.UpdateCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            this.UpdateCategoryBtn.Size = new System.Drawing.Size(440, 50);
            this.UpdateCategoryBtn.TabIndex = 76;
            this.UpdateCategoryBtn.Text = "Update";
            this.UpdateCategoryBtn.UseTransparentBackground = true;
            this.UpdateCategoryBtn.Click += new System.EventHandler(this.UpdateCategoryBtn_Click);
            // 
            // AddImageCategoryBtn
            // 
            this.AddImageCategoryBtn.Animated = true;
            this.AddImageCategoryBtn.AutoRoundedCorners = true;
            this.AddImageCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddImageCategoryBtn.BorderRadius = 24;
            this.AddImageCategoryBtn.BorderThickness = 1;
            this.AddImageCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddImageCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddImageCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddImageCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddImageCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AddImageCategoryBtn.Font = new System.Drawing.Font("Chinacat", 14.25F);
            this.AddImageCategoryBtn.ForeColor = System.Drawing.Color.Black;
            this.AddImageCategoryBtn.Location = new System.Drawing.Point(1060, 346);
            this.AddImageCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddImageCategoryBtn.Name = "AddImageCategoryBtn";
            this.AddImageCategoryBtn.Size = new System.Drawing.Size(210, 50);
            this.AddImageCategoryBtn.TabIndex = 74;
            this.AddImageCategoryBtn.Text = "Add Image";
            this.AddImageCategoryBtn.UseTransparentBackground = true;
            this.AddImageCategoryBtn.Click += new System.EventHandler(this.AddImageCategoryBtn_Click);
            // 
            // CategoryPicB
            // 
            this.CategoryPicB.BackColor = System.Drawing.Color.Transparent;
            this.CategoryPicB.ImageRotate = 0F;
            this.CategoryPicB.Location = new System.Drawing.Point(1060, 132);
            this.CategoryPicB.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryPicB.Name = "CategoryPicB";
            this.CategoryPicB.Size = new System.Drawing.Size(210, 210);
            this.CategoryPicB.TabIndex = 73;
            this.CategoryPicB.TabStop = false;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Animated = true;
            this.AddCategoryBtn.AutoRoundedCorners = true;
            this.AddCategoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddCategoryBtn.BorderRadius = 24;
            this.AddCategoryBtn.BorderThickness = 1;
            this.AddCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCategoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AddCategoryBtn.Font = new System.Drawing.Font("Chinacat", 14.25F);
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.Black;
            this.AddCategoryBtn.Location = new System.Drawing.Point(939, 735);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(447, 50);
            this.AddCategoryBtn.TabIndex = 72;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseTransparentBackground = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // ServiceCategoryTxtB
            // 
            this.ServiceCategoryTxtB.Animated = true;
            this.ServiceCategoryTxtB.AutoRoundedCorners = true;
            this.ServiceCategoryTxtB.BorderColor = System.Drawing.Color.Black;
            this.ServiceCategoryTxtB.BorderRadius = 24;
            this.ServiceCategoryTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceCategoryTxtB.DefaultText = "";
            this.ServiceCategoryTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceCategoryTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceCategoryTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceCategoryTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceCategoryTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceCategoryTxtB.Font = new System.Drawing.Font("Chinacat", 14.25F);
            this.ServiceCategoryTxtB.ForeColor = System.Drawing.Color.Black;
            this.ServiceCategoryTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceCategoryTxtB.Location = new System.Drawing.Point(1060, 434);
            this.ServiceCategoryTxtB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ServiceCategoryTxtB.Name = "ServiceCategoryTxtB";
            this.ServiceCategoryTxtB.PasswordChar = '\0';
            this.ServiceCategoryTxtB.PlaceholderText = "Category Name";
            this.ServiceCategoryTxtB.SelectedText = "";
            this.ServiceCategoryTxtB.Size = new System.Drawing.Size(210, 50);
            this.ServiceCategoryTxtB.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stanberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1054, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 43);
            this.label1.TabIndex = 83;
            this.label1.Text = "Service Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceTypeComB
            // 
            this.ServiceTypeComB.AutoRoundedCorners = true;
            this.ServiceTypeComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeComB.BorderColor = System.Drawing.Color.Black;
            this.ServiceTypeComB.BorderRadius = 17;
            this.ServiceTypeComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceTypeComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeComB.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ServiceTypeComB.ForeColor = System.Drawing.Color.Black;
            this.ServiceTypeComB.ItemHeight = 30;
            this.ServiceTypeComB.Location = new System.Drawing.Point(1060, 563);
            this.ServiceTypeComB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceTypeComB.Name = "ServiceTypeComB";
            this.ServiceTypeComB.Size = new System.Drawing.Size(210, 36);
            this.ServiceTypeComB.TabIndex = 82;
            // 
            // ServiceSubTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceTypeComB);
            this.Controls.Add(this.CategoryDGV);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchCategoryBtn);
            this.Controls.Add(this.SearchCategoryTxtB);
            this.Controls.Add(this.EditCategoryBtn);
            this.Controls.Add(this.CancelEditBtn);
            this.Controls.Add(this.UpdateCategoryBtn);
            this.Controls.Add(this.AddImageCategoryBtn);
            this.Controls.Add(this.CategoryPicB);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.ServiceCategoryTxtB);
            this.Name = "ServiceSubTypeControl";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.ServiceSubTypeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView CategoryDGV;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2Button SearchCategoryBtn;
        public Guna.UI2.WinForms.Guna2Button EditCategoryBtn;
        public Guna.UI2.WinForms.Guna2Button CancelEditBtn;
        public Guna.UI2.WinForms.Guna2Button UpdateCategoryBtn;
        public Guna.UI2.WinForms.Guna2Button AddImageCategoryBtn;
        public Guna.UI2.WinForms.Guna2PictureBox CategoryPicB;
        public Guna.UI2.WinForms.Guna2Button AddCategoryBtn;
        public Guna.UI2.WinForms.Guna2TextBox ServiceCategoryTxtB;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox ServiceTypeComB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTypeIDCol;
        private System.Windows.Forms.DataGridViewImageColumn ServiceTImageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDCol;
        public Guna.UI2.WinForms.Guna2TextBox SearchCategoryTxtB;
    }
}
