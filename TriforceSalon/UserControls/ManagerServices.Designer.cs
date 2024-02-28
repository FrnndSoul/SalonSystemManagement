namespace TriforceSalon.UserControls
{
    partial class ManagerServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ServiceTypeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SalonServicesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceTypeTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddServiceTypeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceTypePicB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AddImageServiceTypeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceImagePicB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ServiceNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServiceAmountTxtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServiceTypesComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddServiceImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditServiceTBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateServiceTBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelEditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelEditServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateServBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditServBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalonServicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypePicB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceImagePicB)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTypeDGV
            // 
            this.ServiceTypeDGV.AllowUserToAddRows = false;
            this.ServiceTypeDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ServiceTypeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ServiceTypeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceTypeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ServiceTypeDGV.ColumnHeadersHeight = 4;
            this.ServiceTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceTypeDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.ServiceTypeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceTypeDGV.Location = new System.Drawing.Point(59, 55);
            this.ServiceTypeDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceTypeDGV.Name = "ServiceTypeDGV";
            this.ServiceTypeDGV.ReadOnly = true;
            this.ServiceTypeDGV.RowHeadersVisible = false;
            this.ServiceTypeDGV.RowHeadersWidth = 51;
            this.ServiceTypeDGV.RowTemplate.Height = 24;
            this.ServiceTypeDGV.Size = new System.Drawing.Size(434, 255);
            this.ServiceTypeDGV.TabIndex = 0;
            this.ServiceTypeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceTypeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServiceTypeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServiceTypeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServiceTypeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServiceTypeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ServiceTypeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceTypeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServiceTypeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServiceTypeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTypeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServiceTypeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServiceTypeDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ServiceTypeDGV.ThemeStyle.ReadOnly = true;
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceTypeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SalonServicesDGV
            // 
            this.SalonServicesDGV.AllowUserToAddRows = false;
            this.SalonServicesDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.SalonServicesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.SalonServicesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalonServicesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.SalonServicesDGV.ColumnHeadersHeight = 4;
            this.SalonServicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalonServicesDGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.SalonServicesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalonServicesDGV.Location = new System.Drawing.Point(59, 433);
            this.SalonServicesDGV.Margin = new System.Windows.Forms.Padding(2);
            this.SalonServicesDGV.Name = "SalonServicesDGV";
            this.SalonServicesDGV.ReadOnly = true;
            this.SalonServicesDGV.RowHeadersVisible = false;
            this.SalonServicesDGV.RowHeadersWidth = 51;
            this.SalonServicesDGV.RowTemplate.Height = 24;
            this.SalonServicesDGV.Size = new System.Drawing.Size(434, 255);
            this.SalonServicesDGV.TabIndex = 1;
            this.SalonServicesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SalonServicesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalonServicesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalonServicesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalonServicesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalonServicesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SalonServicesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalonServicesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SalonServicesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SalonServicesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonServicesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SalonServicesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalonServicesDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.SalonServicesDGV.ThemeStyle.ReadOnly = true;
            this.SalonServicesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SalonServicesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SalonServicesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonServicesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SalonServicesDGV.ThemeStyle.RowsStyle.Height = 24;
            this.SalonServicesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalonServicesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ServiceTypeTxtB
            // 
            this.ServiceTypeTxtB.AutoRoundedCorners = true;
            this.ServiceTypeTxtB.BorderRadius = 18;
            this.ServiceTypeTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceTypeTxtB.DefaultText = "";
            this.ServiceTypeTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceTypeTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceTypeTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceTypeTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceTypeTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServiceTypeTxtB.ForeColor = System.Drawing.Color.Black;
            this.ServiceTypeTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeTxtB.Location = new System.Drawing.Point(585, 230);
            this.ServiceTypeTxtB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ServiceTypeTxtB.Name = "ServiceTypeTxtB";
            this.ServiceTypeTxtB.PasswordChar = '\0';
            this.ServiceTypeTxtB.PlaceholderText = "Service Type Name";
            this.ServiceTypeTxtB.SelectedText = "";
            this.ServiceTypeTxtB.Size = new System.Drawing.Size(172, 39);
            this.ServiceTypeTxtB.TabIndex = 2;
            // 
            // AddServiceTypeBtn
            // 
            this.AddServiceTypeBtn.AutoRoundedCorners = true;
            this.AddServiceTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddServiceTypeBtn.BorderRadius = 17;
            this.AddServiceTypeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceTypeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceTypeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddServiceTypeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddServiceTypeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddServiceTypeBtn.ForeColor = System.Drawing.Color.White;
            this.AddServiceTypeBtn.Location = new System.Drawing.Point(666, 274);
            this.AddServiceTypeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddServiceTypeBtn.Name = "AddServiceTypeBtn";
            this.AddServiceTypeBtn.Size = new System.Drawing.Size(135, 37);
            this.AddServiceTypeBtn.TabIndex = 3;
            this.AddServiceTypeBtn.Text = "Add Service Type";
            this.AddServiceTypeBtn.UseTransparentBackground = true;
            this.AddServiceTypeBtn.Click += new System.EventHandler(this.AddServiceTypeBtn_Click);
            // 
            // ServiceTypePicB
            // 
            this.ServiceTypePicB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypePicB.ImageRotate = 0F;
            this.ServiceTypePicB.Location = new System.Drawing.Point(585, 79);
            this.ServiceTypePicB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceTypePicB.Name = "ServiceTypePicB";
            this.ServiceTypePicB.Size = new System.Drawing.Size(172, 125);
            this.ServiceTypePicB.TabIndex = 4;
            this.ServiceTypePicB.TabStop = false;
            // 
            // AddImageServiceTypeBtn
            // 
            this.AddImageServiceTypeBtn.AutoRoundedCorners = true;
            this.AddImageServiceTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddImageServiceTypeBtn.BorderRadius = 17;
            this.AddImageServiceTypeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddImageServiceTypeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddImageServiceTypeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddImageServiceTypeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddImageServiceTypeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddImageServiceTypeBtn.ForeColor = System.Drawing.Color.White;
            this.AddImageServiceTypeBtn.Location = new System.Drawing.Point(527, 274);
            this.AddImageServiceTypeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddImageServiceTypeBtn.Name = "AddImageServiceTypeBtn";
            this.AddImageServiceTypeBtn.Size = new System.Drawing.Size(135, 37);
            this.AddImageServiceTypeBtn.TabIndex = 5;
            this.AddImageServiceTypeBtn.Text = "Add Image";
            this.AddImageServiceTypeBtn.UseTransparentBackground = true;
            this.AddImageServiceTypeBtn.Click += new System.EventHandler(this.AddImageServiceTypeBtn_Click);
            // 
            // ServiceImagePicB
            // 
            this.ServiceImagePicB.ImageRotate = 0F;
            this.ServiceImagePicB.Location = new System.Drawing.Point(606, 450);
            this.ServiceImagePicB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceImagePicB.Name = "ServiceImagePicB";
            this.ServiceImagePicB.Size = new System.Drawing.Size(172, 125);
            this.ServiceImagePicB.TabIndex = 6;
            this.ServiceImagePicB.TabStop = false;
            // 
            // ServiceNameTxtB
            // 
            this.ServiceNameTxtB.AutoRoundedCorners = true;
            this.ServiceNameTxtB.BorderRadius = 18;
            this.ServiceNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceNameTxtB.DefaultText = "";
            this.ServiceNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceNameTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServiceNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceNameTxtB.Location = new System.Drawing.Point(606, 580);
            this.ServiceNameTxtB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ServiceNameTxtB.Name = "ServiceNameTxtB";
            this.ServiceNameTxtB.PasswordChar = '\0';
            this.ServiceNameTxtB.PlaceholderText = "Service Name";
            this.ServiceNameTxtB.SelectedText = "";
            this.ServiceNameTxtB.Size = new System.Drawing.Size(172, 39);
            this.ServiceNameTxtB.TabIndex = 7;
            // 
            // ServiceAmountTxtb
            // 
            this.ServiceAmountTxtb.AutoRoundedCorners = true;
            this.ServiceAmountTxtb.BorderRadius = 18;
            this.ServiceAmountTxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceAmountTxtb.DefaultText = "";
            this.ServiceAmountTxtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceAmountTxtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceAmountTxtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceAmountTxtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceAmountTxtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceAmountTxtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServiceAmountTxtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceAmountTxtb.Location = new System.Drawing.Point(525, 624);
            this.ServiceAmountTxtb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ServiceAmountTxtb.Name = "ServiceAmountTxtb";
            this.ServiceAmountTxtb.PasswordChar = '\0';
            this.ServiceAmountTxtb.PlaceholderText = "Amount";
            this.ServiceAmountTxtb.SelectedText = "";
            this.ServiceAmountTxtb.Size = new System.Drawing.Size(172, 39);
            this.ServiceAmountTxtb.TabIndex = 9;
            // 
            // ServiceTypesComB
            // 
            this.ServiceTypesComB.AutoRoundedCorners = true;
            this.ServiceTypesComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypesComB.BorderRadius = 17;
            this.ServiceTypesComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceTypesComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypesComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypesComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypesComB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServiceTypesComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceTypesComB.ItemHeight = 30;
            this.ServiceTypesComB.Location = new System.Drawing.Point(714, 624);
            this.ServiceTypesComB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceTypesComB.Name = "ServiceTypesComB";
            this.ServiceTypesComB.Size = new System.Drawing.Size(173, 36);
            this.ServiceTypesComB.TabIndex = 10;
            // 
            // AddServiceImageBtn
            // 
            this.AddServiceImageBtn.AutoRoundedCorners = true;
            this.AddServiceImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddServiceImageBtn.BorderRadius = 17;
            this.AddServiceImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddServiceImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddServiceImageBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddServiceImageBtn.ForeColor = System.Drawing.Color.White;
            this.AddServiceImageBtn.Location = new System.Drawing.Point(544, 679);
            this.AddServiceImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddServiceImageBtn.Name = "AddServiceImageBtn";
            this.AddServiceImageBtn.Size = new System.Drawing.Size(135, 37);
            this.AddServiceImageBtn.TabIndex = 11;
            this.AddServiceImageBtn.Text = "Add Image";
            this.AddServiceImageBtn.UseTransparentBackground = true;
            // 
            // AddServiceBtn
            // 
            this.AddServiceBtn.AutoRoundedCorners = true;
            this.AddServiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddServiceBtn.BorderRadius = 17;
            this.AddServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddServiceBtn.ForeColor = System.Drawing.Color.White;
            this.AddServiceBtn.Location = new System.Drawing.Point(737, 679);
            this.AddServiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddServiceBtn.Name = "AddServiceBtn";
            this.AddServiceBtn.Size = new System.Drawing.Size(135, 37);
            this.AddServiceBtn.TabIndex = 12;
            this.AddServiceBtn.Text = "Add Service ";
            this.AddServiceBtn.UseTransparentBackground = true;
            // 
            // EditServiceTBtn
            // 
            this.EditServiceTBtn.AutoRoundedCorners = true;
            this.EditServiceTBtn.BorderRadius = 17;
            this.EditServiceTBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditServiceTBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditServiceTBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditServiceTBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditServiceTBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditServiceTBtn.ForeColor = System.Drawing.Color.White;
            this.EditServiceTBtn.Location = new System.Drawing.Point(59, 315);
            this.EditServiceTBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditServiceTBtn.Name = "EditServiceTBtn";
            this.EditServiceTBtn.Size = new System.Drawing.Size(135, 37);
            this.EditServiceTBtn.TabIndex = 13;
            this.EditServiceTBtn.Text = "Edit Service Type";
            this.EditServiceTBtn.Click += new System.EventHandler(this.EditServiceTBtn_Click);
            // 
            // UpdateServiceTBtn
            // 
            this.UpdateServiceTBtn.AutoRoundedCorners = true;
            this.UpdateServiceTBtn.BorderRadius = 17;
            this.UpdateServiceTBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateServiceTBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateServiceTBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateServiceTBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateServiceTBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateServiceTBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateServiceTBtn.Location = new System.Drawing.Point(210, 315);
            this.UpdateServiceTBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateServiceTBtn.Name = "UpdateServiceTBtn";
            this.UpdateServiceTBtn.Size = new System.Drawing.Size(135, 37);
            this.UpdateServiceTBtn.TabIndex = 14;
            this.UpdateServiceTBtn.Text = "Update Service Type";
            this.UpdateServiceTBtn.Click += new System.EventHandler(this.UpdateServiceTBtn_Click);
            // 
            // CancelEditBtn
            // 
            this.CancelEditBtn.AutoRoundedCorners = true;
            this.CancelEditBtn.BorderRadius = 17;
            this.CancelEditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelEditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelEditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelEditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelEditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelEditBtn.ForeColor = System.Drawing.Color.White;
            this.CancelEditBtn.Location = new System.Drawing.Point(357, 315);
            this.CancelEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelEditBtn.Name = "CancelEditBtn";
            this.CancelEditBtn.Size = new System.Drawing.Size(135, 37);
            this.CancelEditBtn.TabIndex = 15;
            this.CancelEditBtn.Text = "Cancel Edit";
            this.CancelEditBtn.Click += new System.EventHandler(this.CancelEditBtn_Click);
            // 
            // CancelEditServiceBtn
            // 
            this.CancelEditServiceBtn.AutoRoundedCorners = true;
            this.CancelEditServiceBtn.BorderRadius = 17;
            this.CancelEditServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelEditServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelEditServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelEditServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelEditServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelEditServiceBtn.ForeColor = System.Drawing.Color.White;
            this.CancelEditServiceBtn.Location = new System.Drawing.Point(357, 693);
            this.CancelEditServiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelEditServiceBtn.Name = "CancelEditServiceBtn";
            this.CancelEditServiceBtn.Size = new System.Drawing.Size(135, 37);
            this.CancelEditServiceBtn.TabIndex = 18;
            this.CancelEditServiceBtn.Text = "Cancel Edit";
            this.CancelEditServiceBtn.Click += new System.EventHandler(this.CancelEditServiceBtn_Click);
            // 
            // UpdateServBtn
            // 
            this.UpdateServBtn.AutoRoundedCorners = true;
            this.UpdateServBtn.BorderRadius = 17;
            this.UpdateServBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateServBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateServBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateServBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateServBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateServBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateServBtn.Location = new System.Drawing.Point(210, 693);
            this.UpdateServBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateServBtn.Name = "UpdateServBtn";
            this.UpdateServBtn.Size = new System.Drawing.Size(135, 37);
            this.UpdateServBtn.TabIndex = 17;
            this.UpdateServBtn.Text = "Update Service";
            this.UpdateServBtn.Click += new System.EventHandler(this.UpdateServBtn_Click);
            // 
            // EditServBtn
            // 
            this.EditServBtn.AutoRoundedCorners = true;
            this.EditServBtn.BorderRadius = 17;
            this.EditServBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditServBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditServBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditServBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditServBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditServBtn.ForeColor = System.Drawing.Color.White;
            this.EditServBtn.Location = new System.Drawing.Point(59, 693);
            this.EditServBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditServBtn.Name = "EditServBtn";
            this.EditServBtn.Size = new System.Drawing.Size(135, 37);
            this.EditServBtn.TabIndex = 16;
            this.EditServBtn.Text = "Edit Service";
            this.EditServBtn.Click += new System.EventHandler(this.EditServBtn_Click);
            // 
            // ManagerServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.CancelEditServiceBtn);
            this.Controls.Add(this.UpdateServBtn);
            this.Controls.Add(this.EditServBtn);
            this.Controls.Add(this.CancelEditBtn);
            this.Controls.Add(this.UpdateServiceTBtn);
            this.Controls.Add(this.EditServiceTBtn);
            this.Controls.Add(this.AddServiceBtn);
            this.Controls.Add(this.AddServiceImageBtn);
            this.Controls.Add(this.ServiceTypesComB);
            this.Controls.Add(this.ServiceAmountTxtb);
            this.Controls.Add(this.ServiceNameTxtB);
            this.Controls.Add(this.ServiceImagePicB);
            this.Controls.Add(this.AddImageServiceTypeBtn);
            this.Controls.Add(this.ServiceTypePicB);
            this.Controls.Add(this.AddServiceTypeBtn);
            this.Controls.Add(this.ServiceTypeTxtB);
            this.Controls.Add(this.SalonServicesDGV);
            this.Controls.Add(this.ServiceTypeDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerServices";
            this.Size = new System.Drawing.Size(1886, 999);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalonServicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypePicB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceImagePicB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView ServiceTypeDGV;
        public Guna.UI2.WinForms.Guna2DataGridView SalonServicesDGV;
        public Guna.UI2.WinForms.Guna2TextBox ServiceTypeTxtB;
        public Guna.UI2.WinForms.Guna2Button AddServiceTypeBtn;
        public Guna.UI2.WinForms.Guna2PictureBox ServiceTypePicB;
        public Guna.UI2.WinForms.Guna2Button AddImageServiceTypeBtn;
        public Guna.UI2.WinForms.Guna2PictureBox ServiceImagePicB;
        public Guna.UI2.WinForms.Guna2TextBox ServiceNameTxtB;
        public Guna.UI2.WinForms.Guna2TextBox ServiceAmountTxtb;
        public Guna.UI2.WinForms.Guna2ComboBox ServiceTypesComB;
        public Guna.UI2.WinForms.Guna2Button AddServiceImageBtn;
        public Guna.UI2.WinForms.Guna2Button AddServiceBtn;
        public Guna.UI2.WinForms.Guna2Button EditServiceTBtn;
        public Guna.UI2.WinForms.Guna2Button UpdateServiceTBtn;
        public Guna.UI2.WinForms.Guna2Button CancelEditBtn;
        public Guna.UI2.WinForms.Guna2Button CancelEditServiceBtn;
        public Guna.UI2.WinForms.Guna2Button UpdateServBtn;
        public Guna.UI2.WinForms.Guna2Button EditServBtn;
    }
}
