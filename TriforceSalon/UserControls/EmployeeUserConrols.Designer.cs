namespace TriforceSalon.UserControls
{
    partial class EmployeeUserConrols
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerListFLowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1516, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(446, 1080);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(60, 964);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(320, 54);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Log-Out";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 50;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.CustomerListFLowLayout);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2Panel2.Location = new System.Drawing.Point(-41, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1462, 1080);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Queue";
            // 
            // CustomerListFLowLayout
            // 
            this.CustomerListFLowLayout.AutoScroll = true;
            this.CustomerListFLowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.CustomerListFLowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerListFLowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CustomerListFLowLayout.Location = new System.Drawing.Point(78, 228);
            this.CustomerListFLowLayout.Name = "CustomerListFLowLayout";
            this.CustomerListFLowLayout.Size = new System.Drawing.Size(1337, 790);
            this.CustomerListFLowLayout.TabIndex = 0;
            // 
            // EmployeeUserConrols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "EmployeeUserConrols";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel CustomerListFLowLayout;
    }
}
