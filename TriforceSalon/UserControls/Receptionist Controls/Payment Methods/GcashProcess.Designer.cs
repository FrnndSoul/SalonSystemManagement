namespace TriforceSalon.UserControls.Receptionist_Controls.Payment_Methods
{
    partial class GcashProcess
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PaymentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ReferenceBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::TriforceSalon.Properties.Resources.photo_2024_03_04_03_03_56;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(58, 24);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 530);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Animated = true;
            this.PaymentBtn.AutoRoundedCorners = true;
            this.PaymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.PaymentBtn.BorderRadius = 21;
            this.PaymentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PaymentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PaymentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PaymentBtn.Enabled = false;
            this.PaymentBtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.PaymentBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.PaymentBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentBtn.IndicateFocus = true;
            this.PaymentBtn.Location = new System.Drawing.Point(72, 686);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(273, 44);
            this.PaymentBtn.TabIndex = 32;
            this.PaymentBtn.Text = "Proceed";
            this.PaymentBtn.UseTransparentBackground = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // ReferenceBox
            // 
            this.ReferenceBox.Animated = true;
            this.ReferenceBox.AutoRoundedCorners = true;
            this.ReferenceBox.BackColor = System.Drawing.Color.Transparent;
            this.ReferenceBox.BorderColor = System.Drawing.Color.Black;
            this.ReferenceBox.BorderRadius = 21;
            this.ReferenceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReferenceBox.DefaultText = "";
            this.ReferenceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReferenceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReferenceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReferenceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReferenceBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ReferenceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReferenceBox.Font = new System.Drawing.Font("Chinacat", 18F);
            this.ReferenceBox.ForeColor = System.Drawing.Color.White;
            this.ReferenceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReferenceBox.Location = new System.Drawing.Point(23, 609);
            this.ReferenceBox.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.ReferenceBox.Name = "ReferenceBox";
            this.ReferenceBox.PasswordChar = '\0';
            this.ReferenceBox.PlaceholderText = "Enter Reference Num. Here";
            this.ReferenceBox.SelectedText = "";
            this.ReferenceBox.Size = new System.Drawing.Size(371, 44);
            this.ReferenceBox.TabIndex = 30;
            this.ReferenceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReferenceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReferenceBox_KeyPress);
            // 
            // GcashProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.ReferenceBox);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "GcashProcess";
            this.Size = new System.Drawing.Size(417, 767);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button PaymentBtn;
        private Guna.UI2.WinForms.Guna2TextBox ReferenceBox;
    }
}
