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
            this.CreateAccountLnk = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SigninBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TogglePassword
            // 
            this.TogglePassword.AutoSize = true;
            this.TogglePassword.ForeColor = System.Drawing.Color.White;
            this.TogglePassword.Location = new System.Drawing.Point(134, 758);
            this.TogglePassword.Margin = new System.Windows.Forms.Padding(4);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(125, 20);
            this.TogglePassword.TabIndex = 2;
            this.TogglePassword.Text = "Show Password";
            this.TogglePassword.UseVisualStyleBackColor = true;
            this.TogglePassword.CheckedChanged += new System.EventHandler(this.TogglePassword_CheckedChanged);
            // 
            // CreateAccountLnk
            // 
            this.CreateAccountLnk.AutoSize = true;
            this.CreateAccountLnk.LinkColor = System.Drawing.Color.White;
            this.CreateAccountLnk.Location = new System.Drawing.Point(354, 1002);
            this.CreateAccountLnk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateAccountLnk.Name = "CreateAccountLnk";
            this.CreateAccountLnk.Size = new System.Drawing.Size(88, 16);
            this.CreateAccountLnk.TabIndex = 4;
            this.CreateAccountLnk.TabStop = true;
            this.CreateAccountLnk.Text = "Sign Up Here";
            this.CreateAccountLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLnk_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CreateAccountLnk);
            this.panel1.Controls.Add(this.SigninBtn);
            this.panel1.Controls.Add(this.PasswordTxtbox);
            this.panel1.Controls.Add(this.UsernameTxtbox);
            this.panel1.Controls.Add(this.TogglePassword);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 1305);
            this.panel1.TabIndex = 5;
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.BorderRadius = 20;
            this.UsernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxtbox.DefaultText = "";
            this.UsernameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxtbox.Location = new System.Drawing.Point(134, 582);
            this.UsernameTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.PasswordChar = '\0';
            this.UsernameTxtbox.PlaceholderText = "";
            this.UsernameTxtbox.SelectedText = "";
            this.UsernameTxtbox.Size = new System.Drawing.Size(421, 50);
            this.UsernameTxtbox.TabIndex = 0;
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.BorderRadius = 20;
            this.PasswordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtbox.DefaultText = "";
            this.PasswordTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtbox.Location = new System.Drawing.Point(134, 687);
            this.PasswordTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '\0';
            this.PasswordTxtbox.PlaceholderText = "";
            this.PasswordTxtbox.SelectedText = "";
            this.PasswordTxtbox.Size = new System.Drawing.Size(421, 63);
            this.PasswordTxtbox.TabIndex = 1;
            // 
            // SigninBtn
            // 
            this.SigninBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.SigninBtn.BorderRadius = 20;
            this.SigninBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SigninBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SigninBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.SigninBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SigninBtn.ForeColor = System.Drawing.Color.White;
            this.SigninBtn.Location = new System.Drawing.Point(134, 913);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(421, 63);
            this.SigninBtn.TabIndex = 3;
            this.SigninBtn.Text = "Login";
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 1002);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Account?";
            // 
            // SigninPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SigninPage";
            this.Size = new System.Drawing.Size(2533, 1305);
            this.Load += new System.EventHandler(this.SigninPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox TogglePassword;
        private System.Windows.Forms.LinkLabel CreateAccountLnk;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtbox;
        private Guna.UI2.WinForms.Guna2Button SigninBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
