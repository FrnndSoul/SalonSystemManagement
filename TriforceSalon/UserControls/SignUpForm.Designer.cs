using System.Windows.Forms;

namespace TriforceSalon
{
    partial class SignUpForm
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
            this.TogglePassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UploadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.BirthdayPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RoleBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Photo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // TogglePassword
            // 
            this.TogglePassword.AutoSize = true;
            this.TogglePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.TogglePassword.Font = new System.Drawing.Font("Chinacat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TogglePassword.ForeColor = System.Drawing.Color.White;
            this.TogglePassword.Location = new System.Drawing.Point(1274, 626);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(180, 27);
            this.TogglePassword.TabIndex = 13;
            this.TogglePassword.Text = "Show Password";
            this.TogglePassword.UseVisualStyleBackColor = false;
            this.TogglePassword.CheckedChanged += new System.EventHandler(this.TogglePassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(721, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label2.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(721, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label3.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(721, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label4.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(989, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label5.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1267, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label6.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1267, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label7.Font = new System.Drawing.Font("Stanberry", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1267, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 37);
            this.label7.TabIndex = 24;
            this.label7.Text = "Role";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Animated = true;
            this.CreateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.CreateBtn.BorderRadius = 20;
            this.CreateBtn.BorderThickness = 1;
            this.CreateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.CreateBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(302, 874);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(600, 70);
            this.CreateBtn.TabIndex = 28;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click_1);
            // 
            // BackBtn
            // 
            this.BackBtn.Animated = true;
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.BackBtn.BorderRadius = 20;
            this.BackBtn.BorderThickness = 1;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.BackBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(1013, 874);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(600, 70);
            this.BackBtn.TabIndex = 29;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Animated = true;
            this.UploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.UploadBtn.BorderRadius = 15;
            this.UploadBtn.BorderThickness = 1;
            this.UploadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.UploadBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.UploadBtn.ForeColor = System.Drawing.Color.White;
            this.UploadBtn.Location = new System.Drawing.Point(171, 658);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(300, 35);
            this.UploadBtn.TabIndex = 30;
            this.UploadBtn.Text = "Upload Photo";
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Animated = true;
            this.NameBox.AutoRoundedCorners = true;
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
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
            this.NameBox.Location = new System.Drawing.Point(728, 357);
            this.NameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(450, 50);
            this.NameBox.TabIndex = 31;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Animated = true;
            this.UsernameBox.AutoRoundedCorners = true;
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
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
            this.UsernameBox.Location = new System.Drawing.Point(728, 463);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PlaceholderText = "";
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.Size = new System.Drawing.Size(450, 50);
            this.UsernameBox.TabIndex = 32;
            // 
            // EmailBox
            // 
            this.EmailBox.Animated = true;
            this.EmailBox.AutoRoundedCorners = true;
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
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
            this.EmailBox.Location = new System.Drawing.Point(728, 566);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PasswordChar = '\0';
            this.EmailBox.PlaceholderText = "";
            this.EmailBox.SelectedText = "";
            this.EmailBox.Size = new System.Drawing.Size(450, 50);
            this.EmailBox.TabIndex = 33;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Animated = true;
            this.PasswordBox.AutoRoundedCorners = true;
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.PasswordBox.BorderColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderRadius = 24;
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.DefaultText = "";
            this.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.Location = new System.Drawing.Point(1274, 465);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '\0';
            this.PasswordBox.PlaceholderText = "";
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.Size = new System.Drawing.Size(450, 50);
            this.PasswordBox.TabIndex = 34;
            // 
            // PasswordBox1
            // 
            this.PasswordBox1.Animated = true;
            this.PasswordBox1.AutoRoundedCorners = true;
            this.PasswordBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.PasswordBox1.BorderColor = System.Drawing.Color.Black;
            this.PasswordBox1.BorderRadius = 24;
            this.PasswordBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox1.DefaultText = "";
            this.PasswordBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox1.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.PasswordBox1.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox1.Location = new System.Drawing.Point(1274, 568);
            this.PasswordBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.PasswordChar = '\0';
            this.PasswordBox1.PlaceholderText = "";
            this.PasswordBox1.SelectedText = "";
            this.PasswordBox1.Size = new System.Drawing.Size(450, 50);
            this.PasswordBox1.TabIndex = 35;
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
            this.BirthdayPicker.Location = new System.Drawing.Point(995, 713);
            this.BirthdayPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(450, 50);
            this.BirthdayPicker.TabIndex = 36;
            this.BirthdayPicker.UseTransparentBackground = true;
            this.BirthdayPicker.Value = new System.DateTime(2024, 2, 18, 11, 15, 15, 115);
            // 
            // RoleBox
            // 
            this.RoleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RoleBox.AutoRoundedCorners = true;
            this.RoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.RoleBox.BorderColor = System.Drawing.Color.Black;
            this.RoleBox.BorderRadius = 17;
            this.RoleBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(75)))), ((int)(((byte)(164)))));
            this.RoleBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleBox.Font = new System.Drawing.Font("Stanberry", 21.75F);
            this.RoleBox.ForeColor = System.Drawing.Color.White;
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.ItemHeight = 30;
            this.RoleBox.ItemsAppearance.Font = new System.Drawing.Font("Stanberry", 21.75F);
            this.RoleBox.Location = new System.Drawing.Point(1274, 357);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(450, 36);
            this.RoleBox.TabIndex = 23;
            this.RoleBox.SelectedIndexChanged += new System.EventHandler(this.RoleBox_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::TriforceSalon.Properties.Resources.SignUpDesignBackGround;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1900, 1060);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 37;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.Guna2PictureBox1_Click);
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.Transparent;
            this.Photo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Photo.ImageRotate = 0F;
            this.Photo.Location = new System.Drawing.Point(122, 231);
            this.Photo.Name = "Photo";
            this.Photo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Photo.Size = new System.Drawing.Size(400, 400);
            this.Photo.TabIndex = 26;
            this.Photo.TabStop = false;
            this.Photo.UseTransparentBackground = true;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Black;
            this.guna2Shapes1.BorderThickness = 1;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(450, 95);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(1000, 140);
            this.guna2Shapes1.TabIndex = 38;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label8.Font = new System.Drawing.Font("Chinacat", 59.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(596, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(709, 96);
            this.label8.TabIndex = 39;
            this.label8.Text = "Account Creation";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.TogglePassword);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "SignUpForm";
            this.Size = new System.Drawing.Size(1900, 1060);
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox TogglePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Photo;
        private Guna.UI2.WinForms.Guna2Button CreateBtn;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button UploadBtn;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthdayPicker;
        private Guna.UI2.WinForms.Guna2ComboBox RoleBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Label label8;
    }
}
