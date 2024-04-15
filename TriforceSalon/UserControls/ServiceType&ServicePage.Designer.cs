namespace TriforceSalon.UserControls
{
    partial class ServiceType_ServicePage
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
            this.backgroundShape = new Guna.UI2.WinForms.Guna2Shapes();
            this.ServiceTypeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceManagementContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backgroundShape
            // 
            this.backgroundShape.BackColor = System.Drawing.Color.Transparent;
            this.backgroundShape.BorderColor = System.Drawing.Color.Black;
            this.backgroundShape.BorderThickness = 0;
            this.backgroundShape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.backgroundShape.Location = new System.Drawing.Point(50, 82);
            this.backgroundShape.Name = "backgroundShape";
            this.backgroundShape.PolygonSkip = 1;
            this.backgroundShape.Rotate = 0F;
            this.backgroundShape.RoundedRadius = 30;
            this.backgroundShape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.backgroundShape.Size = new System.Drawing.Size(1400, 843);
            this.backgroundShape.TabIndex = 42;
            this.backgroundShape.Text = "guna2Shapes1";
            this.backgroundShape.UseTransparentBackground = true;
            this.backgroundShape.Zoom = 100;
            // 
            // ServiceTypeBtn
            // 
            this.ServiceTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeBtn.BorderRadius = 40;
            this.ServiceTypeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServiceTypeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServiceTypeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServiceTypeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServiceTypeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ServiceTypeBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.ServiceTypeBtn.ForeColor = System.Drawing.Color.White;
            this.ServiceTypeBtn.Image = global::TriforceSalon.Properties.Resources.service_type_icon__2_;
            this.ServiceTypeBtn.ImageOffset = new System.Drawing.Point(0, -15);
            this.ServiceTypeBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.ServiceTypeBtn.Location = new System.Drawing.Point(50, 13);
            this.ServiceTypeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceTypeBtn.Name = "ServiceTypeBtn";
            this.ServiceTypeBtn.Size = new System.Drawing.Size(705, 108);
            this.ServiceTypeBtn.TabIndex = 90;
            this.ServiceTypeBtn.Text = " Service Type";
            this.ServiceTypeBtn.TextOffset = new System.Drawing.Point(0, -15);
            this.ServiceTypeBtn.UseTransparentBackground = true;
            this.ServiceTypeBtn.Click += new System.EventHandler(this.ServiceTypeBtn_Click);
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.BackColor = System.Drawing.Color.Transparent;
            this.ServiceBtn.BorderRadius = 40;
            this.ServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServiceBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ServiceBtn.Font = new System.Drawing.Font("Chinacat", 21.75F);
            this.ServiceBtn.ForeColor = System.Drawing.Color.Black;
            this.ServiceBtn.Image = global::TriforceSalon.Properties.Resources.service_black_icon;
            this.ServiceBtn.ImageOffset = new System.Drawing.Point(0, -15);
            this.ServiceBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ServiceBtn.Location = new System.Drawing.Point(750, 13);
            this.ServiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(700, 108);
            this.ServiceBtn.TabIndex = 91;
            this.ServiceBtn.Text = " Service Variation";
            this.ServiceBtn.TextOffset = new System.Drawing.Point(0, -15);
            this.ServiceBtn.UseTransparentBackground = true;
            this.ServiceBtn.Click += new System.EventHandler(this.ServiceBtn_Click);
            // 
            // ServiceManagementContainer
            // 
            this.ServiceManagementContainer.BackColor = System.Drawing.Color.White;
            this.ServiceManagementContainer.Location = new System.Drawing.Point(50, 106);
            this.ServiceManagementContainer.Name = "ServiceManagementContainer";
            this.ServiceManagementContainer.Size = new System.Drawing.Size(1400, 800);
            this.ServiceManagementContainer.TabIndex = 92;
            // 
            // ServiceType_ServicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ServiceManagementContainer);
            this.Controls.Add(this.backgroundShape);
            this.Controls.Add(this.ServiceBtn);
            this.Controls.Add(this.ServiceTypeBtn);
            this.Name = "ServiceType_ServicePage";
            this.Size = new System.Drawing.Size(1500, 950);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Shapes backgroundShape;
        private Guna.UI2.WinForms.Guna2Button ServiceTypeBtn;
        private Guna.UI2.WinForms.Guna2Button ServiceBtn;
        private System.Windows.Forms.Panel ServiceManagementContainer;
    }
}
