﻿namespace TriforceSalon
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.adminForm1 = new TriforceSalon.AdminForm();
            this.signinPage1 = new TriforceSalon.SigninPage();
            this.signUpForm1 = new TriforceSalon.SignUpForm();
            this.SuspendLayout();
            // 
            // adminForm1
            // 
            this.adminForm1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this.adminForm1, "adminForm1");
            this.adminForm1.Name = "adminForm1";
            // 
            // signinPage1
            // 
            resources.ApplyResources(this.signinPage1, "signinPage1");
            this.signinPage1.Name = "signinPage1";
            this.signinPage1.Load += new System.EventHandler(this.SigninPage1_Load);
            // 
            // signUpForm1
            // 
            resources.ApplyResources(this.signUpForm1, "signUpForm1");
            this.signUpForm1.Name = "signUpForm1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signinPage1);
            this.Controls.Add(this.signUpForm1);
            this.Controls.Add(this.adminForm1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SigninPage signinPage1;
        private AdminForm adminForm1;
        private SignUpForm signUpForm1;
    }
}

