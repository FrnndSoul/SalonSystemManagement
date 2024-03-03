namespace TriforceSalon
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
            this.signinPage1 = new TriforceSalon.SigninPage();
            this.signUpForm1 = new TriforceSalon.SignUpForm();
            this.adminForm1 = new TriforceSalon.AdminForm();
            this.inventoryPage1 = new TriforceSalon.InventoryPage();
            this.walkInTransactionForm1 = new TriforceSalon.UserControls.WalkInTransactionForm();
            this.SuspendLayout();
            // 
            // signinPage1
            // 
            this.signinPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.signinPage1, "signinPage1");
            this.signinPage1.Name = "signinPage1";
            this.signinPage1.Load += new System.EventHandler(this.SigninPage1_Load);
            // 
            // signUpForm1
            // 
            this.signUpForm1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.signUpForm1, "signUpForm1");
            this.signUpForm1.Name = "signUpForm1";
            // 
            // adminForm1
            // 
            this.adminForm1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.adminForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            resources.ApplyResources(this.adminForm1, "adminForm1");
            this.adminForm1.Name = "adminForm1";
            // 
            // inventoryPage1
            // 
            resources.ApplyResources(this.inventoryPage1, "inventoryPage1");
            this.inventoryPage1.Name = "inventoryPage1";
            // 
            // walkInTransactionForm1
            // 
            this.walkInTransactionForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.walkInTransactionForm1, "walkInTransactionForm1");
            this.walkInTransactionForm1.Name = "walkInTransactionForm1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signinPage1);
            this.Controls.Add(this.signUpForm1);
            this.Controls.Add(this.adminForm1);
            this.Controls.Add(this.inventoryPage1);
            this.Controls.Add(this.walkInTransactionForm1);
            this.Controls.Add(this.managerPage1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SigninPage signinPage1;
        private AdminForm adminForm1;
        private SignUpForm signUpForm1;
        private InventoryPage inventoryPage1;
        private UserControls.WalkInTransactionForm walkInTransactionForm1;
    }
}

