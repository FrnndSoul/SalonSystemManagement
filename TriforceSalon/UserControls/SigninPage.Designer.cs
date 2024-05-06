namespace TriforceSalon
{
    partial class SigninPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SigninBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TogglePassword
            // 
            this.TogglePassword.AutoSize = true;
            this.TogglePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(110)))));
            this.TogglePassword.Font = new System.Drawing.Font("Chinacat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TogglePassword.ForeColor = System.Drawing.Color.White;
            this.TogglePassword.Location = new System.Drawing.Point(109, 538);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(180, 27);
            this.TogglePassword.TabIndex = 2;
            this.TogglePassword.Text = "Show Password\r\n";
            this.TogglePassword.UseVisualStyleBackColor = false;
            this.TogglePassword.CheckedChanged += new System.EventHandler(this.TogglePassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.SigninBtn);
            this.panel1.Controls.Add(this.PasswordTxtbox);
            this.panel1.Controls.Add(this.UsernameTxtbox);
            this.panel1.Controls.Add(this.TogglePassword);
            this.panel1.Controls.Add(this.guna2Shapes1);
            this.panel1.Controls.Add(this.guna2PictureBox4);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 1080);
            this.panel1.TabIndex = 5;
            // 
            // SigninBtn
            // 
            this.SigninBtn.Animated = true;
            this.SigninBtn.BackColor = System.Drawing.Color.Transparent;
            this.SigninBtn.BorderRadius = 20;
            this.SigninBtn.BorderThickness = 1;
            this.SigninBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SigninBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SigninBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.SigninBtn.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninBtn.ForeColor = System.Drawing.Color.White;
            this.SigninBtn.Location = new System.Drawing.Point(109, 631);
            this.SigninBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(350, 50);
            this.SigninBtn.TabIndex = 3;
            this.SigninBtn.Text = "Log In";
            this.SigninBtn.UseTransparentBackground = true;
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click_1);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Animated = true;
            this.PasswordTxtbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.PasswordTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(110)))));
            this.PasswordTxtbox.BorderColor = System.Drawing.Color.Black;
            this.PasswordTxtbox.BorderRadius = 20;
            this.PasswordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtbox.DefaultText = "";
            this.PasswordTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtbox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.PasswordTxtbox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtbox.Location = new System.Drawing.Point(109, 482);
            this.PasswordTxtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '\0';
            this.PasswordTxtbox.PlaceholderText = "Password";
            this.PasswordTxtbox.SelectedText = "";
            this.PasswordTxtbox.Size = new System.Drawing.Size(350, 50);
            this.PasswordTxtbox.TabIndex = 1;
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Animated = true;
            this.UsernameTxtbox.AutoRoundedCorners = true;
            this.UsernameTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(110)))));
            this.UsernameTxtbox.BorderColor = System.Drawing.Color.Black;
            this.UsernameTxtbox.BorderRadius = 24;
            this.UsernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxtbox.DefaultText = "";
            this.UsernameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxtbox.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.UsernameTxtbox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxtbox.Location = new System.Drawing.Point(109, 411);
            this.UsernameTxtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.PasswordChar = '\0';
            this.UsernameTxtbox.PlaceholderText = "User ID";
            this.UsernameTxtbox.SelectedText = "";
            this.UsernameTxtbox.Size = new System.Drawing.Size(350, 50);
            this.UsernameTxtbox.TabIndex = 0;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Black;
            this.guna2Shapes1.BorderThickness = 1;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(110)))));
            this.guna2Shapes1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Shapes1.Location = new System.Drawing.Point(30, 344);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(510, 390);
            this.guna2Shapes1.TabIndex = 9;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 80;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::TriforceSalon.Properties.Resources.SignInDesignLogo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(560, 300);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::TriforceSalon.Properties.Resources.SignInDesign;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(1920, 1080);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 7;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::TriforceSalon.Properties.Resources.SignInDesignGradient;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(199, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(891, 1060);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = global::TriforceSalon.Properties.Resources.shadow_shit;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(72, 376);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(432, 331);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 10;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // SigninPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Name = "SigninPage";
            this.Size = new System.Drawing.Size(1900, 1060);
            this.Load += new System.EventHandler(this.SigninPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox TogglePassword;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtbox;
        private Guna.UI2.WinForms.Guna2Button SigninBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
    }
}
