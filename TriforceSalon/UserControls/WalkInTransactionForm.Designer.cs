namespace TriforceSalon.UserControls
{
    partial class WalkInTransactionForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceListComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CustomerNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceTypeComBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.NServicesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stanberry", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Services";
            // 
            // ServiceListComB
            // 
            this.ServiceListComB.AutoRoundedCorners = true;
            this.ServiceListComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceListComB.BorderRadius = 17;
            this.ServiceListComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceListComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceListComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceListComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceListComB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServiceListComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceListComB.ItemHeight = 30;
            this.ServiceListComB.Location = new System.Drawing.Point(219, 263);
            this.ServiceListComB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceListComB.Name = "ServiceListComB";
            this.ServiceListComB.Size = new System.Drawing.Size(309, 36);
            this.ServiceListComB.TabIndex = 8;
            this.ServiceListComB.SelectedIndexChanged += new System.EventHandler(this.ServiceListComB_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(547, 53);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RefreshBtn.Size = new System.Drawing.Size(47, 51);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "R";
            this.RefreshBtn.UseTransparentBackground = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CustomerNameTxtB
            // 
            this.CustomerNameTxtB.AutoRoundedCorners = true;
            this.CustomerNameTxtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CustomerNameTxtB.BorderRadius = 18;
            this.CustomerNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTxtB.DefaultText = "";
            this.CustomerNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Location = new System.Drawing.Point(218, 95);
            this.CustomerNameTxtB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CustomerNameTxtB.Name = "CustomerNameTxtB";
            this.CustomerNameTxtB.PasswordChar = '\0';
            this.CustomerNameTxtB.PlaceholderText = "";
            this.CustomerNameTxtB.SelectedText = "";
            this.CustomerNameTxtB.Size = new System.Drawing.Size(308, 39);
            this.CustomerNameTxtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stanberry", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stanberry", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Types";
            // 
            // ServiceTypeComBox
            // 
            this.ServiceTypeComBox.AutoRoundedCorners = true;
            this.ServiceTypeComBox.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeComBox.BorderRadius = 17;
            this.ServiceTypeComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceTypeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeComBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeComBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeComBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServiceTypeComBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceTypeComBox.ItemHeight = 30;
            this.ServiceTypeComBox.Location = new System.Drawing.Point(218, 178);
            this.ServiceTypeComBox.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceTypeComBox.Name = "ServiceTypeComBox";
            this.ServiceTypeComBox.Size = new System.Drawing.Size(309, 36);
            this.ServiceTypeComBox.TabIndex = 2;
            this.ServiceTypeComBox.SelectedIndexChanged += new System.EventHandler(this.ServicesComBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chinacat", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Walk-In Transaction";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1914, 102);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.ServiceListComB);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.CustomerNameTxtB);
            this.guna2Panel2.Controls.Add(this.RefreshBtn);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.ServiceTypeComBox);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 229);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1920, 843);
            this.guna2Panel2.TabIndex = 10;
            // 
            // NServicesBtn
            // 
            this.NServicesBtn.Animated = true;
            this.NServicesBtn.AutoRoundedCorners = true;
            this.NServicesBtn.BackColor = System.Drawing.Color.Transparent;
            this.NServicesBtn.BorderRadius = 37;
            this.NServicesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NServicesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NServicesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NServicesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NServicesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NServicesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NServicesBtn.ForeColor = System.Drawing.Color.White;
            this.NServicesBtn.Location = new System.Drawing.Point(12, 138);
            this.NServicesBtn.Name = "NServicesBtn";
            this.NServicesBtn.Size = new System.Drawing.Size(321, 76);
            this.NServicesBtn.TabIndex = 11;
            this.NServicesBtn.Text = "Services";
            this.NServicesBtn.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 37;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(350, 138);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(321, 76);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Sell Products";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 37;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(697, 138);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(321, 76);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Appointments";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 37;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(1037, 138);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(321, 76);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.Text = "Payment";
            this.guna2Button3.UseTransparentBackground = true;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 37;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(1586, 138);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(321, 76);
            this.guna2Button4.TabIndex = 15;
            this.guna2Button4.Text = "Log-Out";
            this.guna2Button4.UseTransparentBackground = true;
            // 
            // WalkInTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.NServicesBtn);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WalkInTransactionForm";
            this.Size = new System.Drawing.Size(1920, 1072);
            this.Load += new System.EventHandler(this.WalkInTransactionForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox ServiceTypeComBox;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox CustomerNameTxtB;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton RefreshBtn;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2ComboBox ServiceListComB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button NServicesBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
