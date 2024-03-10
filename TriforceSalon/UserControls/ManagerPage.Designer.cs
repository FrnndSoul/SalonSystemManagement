namespace TriforceSalon.UserControls
{
    partial class ManagerPage
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LogoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ReportsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServicesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.InventoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ManagerContent = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 100;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.LogoutBtn);
            this.guna2Panel1.Controls.Add(this.ReportsBtn);
            this.guna2Panel1.Controls.Add(this.ServicesBtn);
            this.guna2Panel1.Controls.Add(this.InventoryBtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-86, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(331, 1090);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::TriforceSalon.Properties.Resources.SignInDesignLogo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(55, 38);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(281, 186);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Animated = true;
            this.LogoutBtn.AutoRoundedCorners = true;
            this.LogoutBtn.BorderRadius = 28;
            this.LogoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.LogoutBtn.Font = new System.Drawing.Font("Chinacat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = global::TriforceSalon.Properties.Resources.logout_icon;
            this.LogoutBtn.Location = new System.Drawing.Point(106, 813);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(197, 58);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = " Log-Out";
            this.LogoutBtn.UseTransparentBackground = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Animated = true;
            this.ReportsBtn.AutoRoundedCorners = true;
            this.ReportsBtn.BorderRadius = 48;
            this.ReportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ReportsBtn.Font = new System.Drawing.Font("Chinacat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.Location = new System.Drawing.Point(106, 527);
            this.ReportsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(197, 98);
            this.ReportsBtn.TabIndex = 2;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseTransparentBackground = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.Animated = true;
            this.ServicesBtn.AutoRoundedCorners = true;
            this.ServicesBtn.BorderRadius = 48;
            this.ServicesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServicesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServicesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServicesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServicesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ServicesBtn.Font = new System.Drawing.Font("Chinacat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesBtn.ForeColor = System.Drawing.Color.White;
            this.ServicesBtn.Location = new System.Drawing.Point(104, 386);
            this.ServicesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(200, 98);
            this.ServicesBtn.TabIndex = 1;
            this.ServicesBtn.Text = "Services";
            this.ServicesBtn.UseTransparentBackground = true;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.Animated = true;
            this.InventoryBtn.AutoRoundedCorners = true;
            this.InventoryBtn.BorderRadius = 48;
            this.InventoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InventoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InventoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InventoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InventoryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.InventoryBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.InventoryBtn.ForeColor = System.Drawing.Color.White;
            this.InventoryBtn.Location = new System.Drawing.Point(104, 242);
            this.InventoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Size = new System.Drawing.Size(200, 98);
            this.InventoryBtn.TabIndex = 0;
            this.InventoryBtn.Text = "Inventory";
            this.InventoryBtn.UseTransparentBackground = true;
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 100;
            this.guna2Panel2.Controls.Add(this.ManagerContent);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2Panel2.Location = new System.Drawing.Point(309, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1702, 1090);
            this.guna2Panel2.TabIndex = 1;
            // 
            // ManagerContent
            // 
            this.ManagerContent.BackColor = System.Drawing.Color.Transparent;
            this.ManagerContent.Location = new System.Drawing.Point(70, 74);
            this.ManagerContent.Name = "ManagerContent";
            this.ManagerContent.Size = new System.Drawing.Size(1500, 950);
            this.ManagerContent.TabIndex = 0;
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1090);
            this.MinimumSize = new System.Drawing.Size(1920, 1090);
            this.Name = "ManagerPage";
            this.Size = new System.Drawing.Size(1920, 1090);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button LogoutBtn;
        private Guna.UI2.WinForms.Guna2Button ReportsBtn;
        private Guna.UI2.WinForms.Guna2Button ServicesBtn;
        private Guna.UI2.WinForms.Guna2Button InventoryBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel ManagerContent;
    }
}
