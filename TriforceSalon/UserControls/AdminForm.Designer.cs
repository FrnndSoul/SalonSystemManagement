namespace TriforceSalon
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SignoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BirthdayPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EmailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StatusBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UploadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Photo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.DiscardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeRoleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.ServiceTypesTab = new System.Windows.Forms.TabPage();
            this.ServiceTypesGDV = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.UserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.ServiceTypesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypesGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserTab);
            this.tabControl1.Controls.Add(this.ServiceTypesTab);
            this.tabControl1.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(50, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1800, 1000);
            this.tabControl1.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.UserTab.Controls.Add(this.BirthdayPicker);
            this.UserTab.Controls.Add(this.EmailBox);
            this.UserTab.Controls.Add(this.StatusBox);
            this.UserTab.Controls.Add(this.UsernameBox);
            this.UserTab.Controls.Add(this.IDBox);
            this.UserTab.Controls.Add(this.NameBox);
            this.UserTab.Controls.Add(this.EditBtn);
            this.UserTab.Controls.Add(this.UploadBtn);
            this.UserTab.Controls.Add(this.Photo);
            this.UserTab.Controls.Add(this.DiscardBtn);
            this.UserTab.Controls.Add(this.ChangeRoleBtn);
            this.UserTab.Controls.Add(this.SaveBtn);
            this.UserTab.Controls.Add(this.UserDGV);
            this.UserTab.Location = new System.Drawing.Point(4, 35);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(1792, 961);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "List of Users";
            this.UserTab.Click += new System.EventHandler(this.UserTab_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::TriforceSalon.Properties.Resources.back_icon__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 1023);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(25, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 62;
            this.guna2PictureBox1.TabStop = false;
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignoutBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SignoutBtn.BorderRadius = 15;
            this.SignoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignoutBtn.FillColor = System.Drawing.Color.Transparent;
            this.SignoutBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.SignoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.SignoutBtn.Location = new System.Drawing.Point(-24, 1020);
            this.SignoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Size = new System.Drawing.Size(163, 35);
            this.SignoutBtn.TabIndex = 61;
            this.SignoutBtn.Text = "Log Out";
            this.SignoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SignoutBtn.UseTransparentBackground = true;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Animated = true;
            this.BirthdayPicker.AutoRoundedCorners = true;
            this.BirthdayPicker.BackColor = System.Drawing.Color.Transparent;
            this.BirthdayPicker.BorderRadius = 24;
            this.BirthdayPicker.BorderThickness = 1;
            this.BirthdayPicker.Checked = true;
            this.BirthdayPicker.FillColor = System.Drawing.Color.White;
            this.BirthdayPicker.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.BirthdayPicker.ForeColor = System.Drawing.Color.Black;
            this.BirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthdayPicker.IndicateFocus = true;
            this.BirthdayPicker.Location = new System.Drawing.Point(1384, 664);
            this.BirthdayPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1753, 12, 21, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(400, 50);
            this.BirthdayPicker.TabIndex = 60;
            this.BirthdayPicker.UseTransparentBackground = true;
            this.BirthdayPicker.Value = new System.DateTime(2024, 2, 25, 0, 0, 0, 0);
            // 
            // EmailBox
            // 
            this.EmailBox.Animated = true;
            this.EmailBox.AutoRoundedCorners = true;
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.EmailBox.BorderColor = System.Drawing.Color.Black;
            this.EmailBox.BorderRadius = 24;
            this.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.DefaultText = "";
            this.EmailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.EmailBox.ForeColor = System.Drawing.Color.Black;
            this.EmailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailBox.Location = new System.Drawing.Point(963, 664);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PasswordChar = '\0';
            this.EmailBox.PlaceholderText = "Email";
            this.EmailBox.SelectedText = "";
            this.EmailBox.Size = new System.Drawing.Size(400, 50);
            this.EmailBox.TabIndex = 59;
            // 
            // StatusBox
            // 
            this.StatusBox.Animated = true;
            this.StatusBox.AutoRoundedCorners = true;
            this.StatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.StatusBox.BorderColor = System.Drawing.Color.Black;
            this.StatusBox.BorderRadius = 24;
            this.StatusBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StatusBox.DefaultText = "";
            this.StatusBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StatusBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StatusBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusBox.Location = new System.Drawing.Point(1384, 580);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.PasswordChar = '\0';
            this.StatusBox.PlaceholderText = "Status";
            this.StatusBox.SelectedText = "";
            this.StatusBox.Size = new System.Drawing.Size(400, 50);
            this.StatusBox.TabIndex = 58;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Animated = true;
            this.UsernameBox.AutoRoundedCorners = true;
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.UsernameBox.BorderColor = System.Drawing.Color.Black;
            this.UsernameBox.BorderRadius = 24;
            this.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameBox.DefaultText = "";
            this.UsernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.UsernameBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.Location = new System.Drawing.Point(963, 580);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.Size = new System.Drawing.Size(400, 50);
            this.UsernameBox.TabIndex = 57;
            // 
            // IDBox
            // 
            this.IDBox.Animated = true;
            this.IDBox.AutoRoundedCorners = true;
            this.IDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.IDBox.BorderColor = System.Drawing.Color.Black;
            this.IDBox.BorderRadius = 24;
            this.IDBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDBox.DefaultText = "";
            this.IDBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.IDBox.ForeColor = System.Drawing.Color.Black;
            this.IDBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDBox.Location = new System.Drawing.Point(1384, 506);
            this.IDBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IDBox.Name = "IDBox";
            this.IDBox.PasswordChar = '\0';
            this.IDBox.PlaceholderText = "ID No.";
            this.IDBox.SelectedText = "";
            this.IDBox.Size = new System.Drawing.Size(400, 50);
            this.IDBox.TabIndex = 56;
            // 
            // NameBox
            // 
            this.NameBox.Animated = true;
            this.NameBox.AutoRoundedCorners = true;
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.NameBox.BorderColor = System.Drawing.Color.Black;
            this.NameBox.BorderRadius = 24;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultText = "";
            this.NameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Location = new System.Drawing.Point(963, 506);
            this.NameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(400, 50);
            this.NameBox.TabIndex = 55;
            // 
            // EditBtn
            // 
            this.EditBtn.Animated = true;
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.EditBtn.BorderRadius = 20;
            this.EditBtn.BorderThickness = 1;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.EditBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(730, 876);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(225, 45);
            this.EditBtn.TabIndex = 54;
            this.EditBtn.Text = "Edit User";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Animated = true;
            this.UploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.UploadBtn.BorderRadius = 15;
            this.UploadBtn.BorderThickness = 1;
            this.UploadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.UploadBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.UploadBtn.ForeColor = System.Drawing.Color.White;
            this.UploadBtn.Location = new System.Drawing.Point(1224, 425);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(300, 35);
            this.UploadBtn.TabIndex = 53;
            this.UploadBtn.Text = "Upload Photo";
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // Photo
            // 
            this.Photo.ImageRotate = 0F;
            this.Photo.Location = new System.Drawing.Point(1166, 16);
            this.Photo.Name = "Photo";
            this.Photo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Photo.Size = new System.Drawing.Size(400, 400);
            this.Photo.TabIndex = 52;
            this.Photo.TabStop = false;
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Animated = true;
            this.DiscardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.DiscardBtn.BorderRadius = 20;
            this.DiscardBtn.BorderThickness = 1;
            this.DiscardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.DiscardBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.DiscardBtn.ForeColor = System.Drawing.Color.White;
            this.DiscardBtn.Location = new System.Drawing.Point(494, 876);
            this.DiscardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(225, 45);
            this.DiscardBtn.TabIndex = 51;
            this.DiscardBtn.Text = "Discard";
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click);
            // 
            // ChangeRoleBtn
            // 
            this.ChangeRoleBtn.Animated = true;
            this.ChangeRoleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ChangeRoleBtn.BorderRadius = 20;
            this.ChangeRoleBtn.BorderThickness = 1;
            this.ChangeRoleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangeRoleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangeRoleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeRoleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangeRoleBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ChangeRoleBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.ChangeRoleBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeRoleBtn.Location = new System.Drawing.Point(258, 876);
            this.ChangeRoleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeRoleBtn.Name = "ChangeRoleBtn";
            this.ChangeRoleBtn.Size = new System.Drawing.Size(225, 45);
            this.ChangeRoleBtn.TabIndex = 50;
            this.ChangeRoleBtn.Text = "Promote/Demote";
            this.ChangeRoleBtn.Click += new System.EventHandler(this.ChangeRoleBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SaveBtn.BorderRadius = 20;
            this.SaveBtn.BorderThickness = 1;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.SaveBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(18, 876);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(225, 45);
            this.SaveBtn.TabIndex = 49;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.AllowUserToResizeColumns = false;
            this.UserDGV.AllowUserToResizeRows = false;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.BackgroundColor = System.Drawing.Color.White;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Location = new System.Drawing.Point(18, 20);
            this.UserDGV.MultiSelect = false;
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersWidth = 51;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(937, 819);
            this.UserDGV.TabIndex = 0;
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick_1);
            // 
            // ServiceTypesTab
            // 
            this.ServiceTypesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ServiceTypesTab.Controls.Add(this.ServiceTypesGDV);
            this.ServiceTypesTab.Location = new System.Drawing.Point(4, 35);
            this.ServiceTypesTab.Name = "ServiceTypesTab";
            this.ServiceTypesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTypesTab.Size = new System.Drawing.Size(1792, 961);
            this.ServiceTypesTab.TabIndex = 1;
            this.ServiceTypesTab.Text = "Service Types";
            // 
            // ServiceTypesGDV
            // 
            this.ServiceTypesGDV.AllowUserToAddRows = false;
            this.ServiceTypesGDV.AllowUserToDeleteRows = false;
            this.ServiceTypesGDV.AllowUserToResizeColumns = false;
            this.ServiceTypesGDV.AllowUserToResizeRows = false;
            this.ServiceTypesGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceTypesGDV.BackgroundColor = System.Drawing.Color.White;
            this.ServiceTypesGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceTypesGDV.Location = new System.Drawing.Point(3, 3);
            this.ServiceTypesGDV.MultiSelect = false;
            this.ServiceTypesGDV.Name = "ServiceTypesGDV";
            this.ServiceTypesGDV.ReadOnly = true;
            this.ServiceTypesGDV.RowHeadersWidth = 51;
            this.ServiceTypesGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceTypesGDV.Size = new System.Drawing.Size(952, 697);
            this.ServiceTypesGDV.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SignoutBtn);
            this.Name = "AdminForm";
            this.Size = new System.Drawing.Size(1900, 1060);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ServiceTypesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypesGDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage ServiceTypesTab;
        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.DataGridView ServiceTypesGDV;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2Button DiscardBtn;
        private Guna.UI2.WinForms.Guna2Button ChangeRoleBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Photo;
        private Guna.UI2.WinForms.Guna2Button UploadBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2TextBox EmailBox;
        private Guna.UI2.WinForms.Guna2TextBox StatusBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox IDBox;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthdayPicker;
        private Guna.UI2.WinForms.Guna2Button SignoutBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
