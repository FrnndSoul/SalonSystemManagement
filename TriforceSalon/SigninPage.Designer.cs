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
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.TogglePassword = new System.Windows.Forms.CheckBox();
            this.SigninBtn = new System.Windows.Forms.Button();
            this.CreateAccountLnk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Location = new System.Drawing.Point(79, 209);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(228, 20);
            this.UsernameTxtbox.TabIndex = 0;
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Location = new System.Drawing.Point(79, 248);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(228, 20);
            this.PasswordTxtbox.TabIndex = 1;
            // 
            // TogglePassword
            // 
            this.TogglePassword.AutoSize = true;
            this.TogglePassword.Location = new System.Drawing.Point(79, 283);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(80, 17);
            this.TogglePassword.TabIndex = 2;
            this.TogglePassword.Text = "checkBox1";
            this.TogglePassword.UseVisualStyleBackColor = true;
            // 
            // SigninBtn
            // 
            this.SigninBtn.Location = new System.Drawing.Point(79, 322);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(75, 23);
            this.SigninBtn.TabIndex = 3;
            this.SigninBtn.Text = "button1";
            this.SigninBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountLnk
            // 
            this.CreateAccountLnk.AutoSize = true;
            this.CreateAccountLnk.Location = new System.Drawing.Point(187, 381);
            this.CreateAccountLnk.Name = "CreateAccountLnk";
            this.CreateAccountLnk.Size = new System.Drawing.Size(55, 13);
            this.CreateAccountLnk.TabIndex = 4;
            this.CreateAccountLnk.TabStop = true;
            this.CreateAccountLnk.Text = "linkLabel1";
            // 
            // SigninPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateAccountLnk);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.TogglePassword);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.UsernameTxtbox);
            this.Name = "SigninPage";
            this.Size = new System.Drawing.Size(392, 473);
            this.Load += new System.EventHandler(this.SigninPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.CheckBox TogglePassword;
        private System.Windows.Forms.Button SigninBtn;
        private System.Windows.Forms.LinkLabel CreateAccountLnk;
    }
}
