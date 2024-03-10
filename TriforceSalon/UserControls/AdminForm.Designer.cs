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
            this.SignoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AccessBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ServiceTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.CreateBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.Animated = true;
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
            // AccessBox
            // 
            this.AccessBox.AutoRoundedCorners = true;
            this.AccessBox.BackColor = System.Drawing.Color.Transparent;
            this.AccessBox.BorderColor = System.Drawing.Color.Black;
            this.AccessBox.BorderRadius = 17;
            this.AccessBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AccessBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessBox.Enabled = false;
            this.AccessBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AccessBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AccessBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.AccessBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AccessBox.ItemHeight = 30;
            this.AccessBox.Items.AddRange(new object[] {
            "Manager",
            "Receptionist",
            "Staff"});
            this.AccessBox.ItemsAppearance.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.AccessBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Stanberry", 15.75F);
            this.AccessBox.Location = new System.Drawing.Point(1422, 855);
            this.AccessBox.Name = "AccessBox";
            this.AccessBox.Size = new System.Drawing.Size(405, 36);
            this.AccessBox.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label8.Location = new System.Drawing.Point(1424, 826);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 26);
            this.label8.TabIndex = 91;
            this.label8.Text = "Account Access";
            // 
            // ServiceTypeBox
            // 
            this.ServiceTypeBox.AutoRoundedCorners = true;
            this.ServiceTypeBox.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeBox.BorderColor = System.Drawing.Color.Black;
            this.ServiceTypeBox.BorderRadius = 17;
            this.ServiceTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeBox.Enabled = false;
            this.ServiceTypeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ServiceTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceTypeBox.ItemHeight = 30;
            this.ServiceTypeBox.ItemsAppearance.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ServiceTypeBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Stanberry", 15.75F);
            this.ServiceTypeBox.Location = new System.Drawing.Point(1424, 771);
            this.ServiceTypeBox.Name = "ServiceTypeBox";
            this.ServiceTypeBox.Size = new System.Drawing.Size(405, 36);
            this.ServiceTypeBox.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label7.Location = new System.Drawing.Point(1016, 826);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 89;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label6.Location = new System.Drawing.Point(1423, 740);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 88;
            this.label6.Text = "Service Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label5.Location = new System.Drawing.Point(1423, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 87;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label4.Location = new System.Drawing.Point(1424, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 26);
            this.label4.TabIndex = 86;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label3.Location = new System.Drawing.Point(1014, 740);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 85;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label2.Location = new System.Drawing.Point(1014, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 84;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.label1.Location = new System.Drawing.Point(1014, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 83;
            this.label1.Text = "Name";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Animated = true;
            this.BirthdayPicker.AutoRoundedCorners = true;
            this.BirthdayPicker.BackColor = System.Drawing.Color.Transparent;
            this.BirthdayPicker.BorderRadius = 24;
            this.BirthdayPicker.BorderThickness = 1;
            this.BirthdayPicker.Checked = true;
            this.BirthdayPicker.Enabled = false;
            this.BirthdayPicker.FillColor = System.Drawing.Color.White;
            this.BirthdayPicker.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.BirthdayPicker.ForeColor = System.Drawing.Color.Black;
            this.BirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthdayPicker.IndicateFocus = true;
            this.BirthdayPicker.Location = new System.Drawing.Point(1021, 855);
            this.BirthdayPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1753, 12, 21, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(395, 50);
            this.BirthdayPicker.TabIndex = 82;
            this.BirthdayPicker.UseTransparentBackground = true;
            this.BirthdayPicker.Value = new System.DateTime(2024, 2, 25, 0, 0, 0, 0);
            // 
            // EmailBox
            // 
            this.EmailBox.Animated = true;
            this.EmailBox.AutoRoundedCorners = true;
            this.EmailBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailBox.BorderColor = System.Drawing.Color.Black;
            this.EmailBox.BorderRadius = 24;
            this.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.DefaultText = "";
            this.EmailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailBox.Enabled = false;
            this.EmailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.EmailBox.ForeColor = System.Drawing.Color.Black;
            this.EmailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailBox.Location = new System.Drawing.Point(1016, 771);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PasswordChar = '\0';
            this.EmailBox.PlaceholderText = "Email";
            this.EmailBox.SelectedText = "";
            this.EmailBox.Size = new System.Drawing.Size(400, 50);
            this.EmailBox.TabIndex = 81;
            // 
            // StatusBox
            // 
            this.StatusBox.Animated = true;
            this.StatusBox.AutoRoundedCorners = true;
            this.StatusBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusBox.BorderColor = System.Drawing.Color.Black;
            this.StatusBox.BorderRadius = 24;
            this.StatusBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StatusBox.DefaultText = "";
            this.StatusBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StatusBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StatusBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusBox.Enabled = false;
            this.StatusBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusBox.Location = new System.Drawing.Point(1429, 685);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.PasswordChar = '\0';
            this.StatusBox.PlaceholderText = "Status";
            this.StatusBox.SelectedText = "";
            this.StatusBox.Size = new System.Drawing.Size(400, 50);
            this.StatusBox.TabIndex = 80;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Animated = true;
            this.UsernameBox.AutoRoundedCorners = true;
            this.UsernameBox.BackColor = System.Drawing.Color.Transparent;
            this.UsernameBox.BorderColor = System.Drawing.Color.Black;
            this.UsernameBox.BorderRadius = 24;
            this.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameBox.DefaultText = "";
            this.UsernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.Enabled = false;
            this.UsernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.UsernameBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.Location = new System.Drawing.Point(1019, 685);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.Size = new System.Drawing.Size(400, 50);
            this.UsernameBox.TabIndex = 79;
            // 
            // IDBox
            // 
            this.IDBox.Animated = true;
            this.IDBox.AutoRoundedCorners = true;
            this.IDBox.BackColor = System.Drawing.Color.Transparent;
            this.IDBox.BorderColor = System.Drawing.Color.Black;
            this.IDBox.BorderRadius = 24;
            this.IDBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDBox.DefaultText = "";
            this.IDBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDBox.Enabled = false;
            this.IDBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.IDBox.ForeColor = System.Drawing.Color.Black;
            this.IDBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDBox.Location = new System.Drawing.Point(1429, 599);
            this.IDBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IDBox.Name = "IDBox";
            this.IDBox.PasswordChar = '\0';
            this.IDBox.PlaceholderText = "ID No.";
            this.IDBox.SelectedText = "";
            this.IDBox.Size = new System.Drawing.Size(400, 50);
            this.IDBox.TabIndex = 78;
            // 
            // NameBox
            // 
            this.NameBox.Animated = true;
            this.NameBox.AutoRoundedCorners = true;
            this.NameBox.BackColor = System.Drawing.Color.Transparent;
            this.NameBox.BorderColor = System.Drawing.Color.Black;
            this.NameBox.BorderRadius = 24;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultText = "";
            this.NameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.Enabled = false;
            this.NameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Location = new System.Drawing.Point(1019, 599);
            this.NameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(400, 50);
            this.NameBox.TabIndex = 77;
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
            this.EditBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(783, 938);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(225, 45);
            this.EditBtn.TabIndex = 76;
            this.EditBtn.Text = "Edit User";
            this.EditBtn.UseTransparentBackground = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
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
            this.UploadBtn.Enabled = false;
            this.UploadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.UploadBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.UploadBtn.ForeColor = System.Drawing.Color.White;
            this.UploadBtn.Location = new System.Drawing.Point(1277, 487);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(300, 35);
            this.UploadBtn.TabIndex = 75;
            this.UploadBtn.Text = "Upload Photo";
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click_1);
            // 
            // Photo
            // 
            this.Photo.ImageRotate = 0F;
            this.Photo.Location = new System.Drawing.Point(1219, 78);
            this.Photo.Name = "Photo";
            this.Photo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Photo.Size = new System.Drawing.Size(400, 400);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 74;
            this.Photo.TabStop = false;
            // 
            // DiscardBtn
            // 
            this.DiscardBtn.Animated = true;
            this.DiscardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DiscardBtn.BorderRadius = 20;
            this.DiscardBtn.BorderThickness = 1;
            this.DiscardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.DiscardBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.DiscardBtn.ForeColor = System.Drawing.Color.White;
            this.DiscardBtn.Location = new System.Drawing.Point(300, 938);
            this.DiscardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DiscardBtn.Name = "DiscardBtn";
            this.DiscardBtn.Size = new System.Drawing.Size(225, 45);
            this.DiscardBtn.TabIndex = 73;
            this.DiscardBtn.Text = "Discard";
            this.DiscardBtn.UseTransparentBackground = true;
            this.DiscardBtn.Visible = false;
            this.DiscardBtn.Click += new System.EventHandler(this.DiscardBtn_Click_1);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BorderRadius = 20;
            this.SaveBtn.BorderThickness = 1;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.SaveBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(71, 938);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(225, 45);
            this.SaveBtn.TabIndex = 72;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseTransparentBackground = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
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
            this.UserDGV.Location = new System.Drawing.Point(71, 82);
            this.UserDGV.MultiSelect = false;
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersWidth = 51;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(937, 823);
            this.UserDGV.TabIndex = 71;
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Animated = true;
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.BorderRadius = 20;
            this.CreateBtn.BorderThickness = 1;
            this.CreateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.CreateBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(554, 938);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(225, 45);
            this.CreateBtn.TabIndex = 93;
            this.CreateBtn.Text = "Create User";
            this.CreateBtn.UseTransparentBackground = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AdminForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.AccessBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ServiceTypeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.DiscardBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.SignoutBtn);
            this.Name = "AdminForm";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SignoutBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox AccessBox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox ServiceTypeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthdayPicker;
        private Guna.UI2.WinForms.Guna2TextBox EmailBox;
        private Guna.UI2.WinForms.Guna2TextBox StatusBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox IDBox;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button UploadBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Photo;
        private Guna.UI2.WinForms.Guna2Button DiscardBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private System.Windows.Forms.DataGridView UserDGV;
        private Guna.UI2.WinForms.Guna2Button CreateBtn;
    }
}