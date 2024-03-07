namespace TriforceSalon.UserControls.Receptionist_Controls
{
    partial class CardProcess
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
            this.CardNumberBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CVCBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CardNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PaymentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExpirationDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::TriforceSalon.Properties.Resources.Card;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 39);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(411, 135);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.Animated = true;
            this.CardNumberBox.AutoRoundedCorners = true;
            this.CardNumberBox.BackColor = System.Drawing.Color.Transparent;
            this.CardNumberBox.BorderColor = System.Drawing.Color.Black;
            this.CardNumberBox.BorderRadius = 21;
            this.CardNumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNumberBox.DefaultText = "";
            this.CardNumberBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CardNumberBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CardNumberBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNumberBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNumberBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CardNumberBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNumberBox.Font = new System.Drawing.Font("Chinacat", 18F);
            this.CardNumberBox.ForeColor = System.Drawing.Color.White;
            this.CardNumberBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNumberBox.Location = new System.Drawing.Point(23, 260);
            this.CardNumberBox.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.PasswordChar = '\0';
            this.CardNumberBox.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            this.CardNumberBox.SelectedText = "";
            this.CardNumberBox.Size = new System.Drawing.Size(371, 44);
            this.CardNumberBox.TabIndex = 8;
            this.CardNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberBox_KeyPress);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(23, 211);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(159, 31);
            this.guna2HtmlLabel10.TabIndex = 17;
            this.guna2HtmlLabel10.Text = "Card Number";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 334);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(49, 31);
            this.guna2HtmlLabel1.TabIndex = 19;
            this.guna2HtmlLabel1.Text = "CVC";
            // 
            // CVCBox
            // 
            this.CVCBox.Animated = true;
            this.CVCBox.AutoRoundedCorners = true;
            this.CVCBox.BackColor = System.Drawing.Color.Transparent;
            this.CVCBox.BorderColor = System.Drawing.Color.Black;
            this.CVCBox.BorderRadius = 21;
            this.CVCBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CVCBox.DefaultText = "";
            this.CVCBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CVCBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CVCBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CVCBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CVCBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CVCBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CVCBox.Font = new System.Drawing.Font("Chinacat", 18F);
            this.CVCBox.ForeColor = System.Drawing.Color.White;
            this.CVCBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CVCBox.Location = new System.Drawing.Point(91, 334);
            this.CVCBox.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.CVCBox.Name = "CVCBox";
            this.CVCBox.PasswordChar = '\0';
            this.CVCBox.PlaceholderText = "XXX";
            this.CVCBox.SelectedText = "";
            this.CVCBox.Size = new System.Drawing.Size(303, 44);
            this.CVCBox.TabIndex = 18;
            this.CVCBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CVCBox_KeyPress);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 396);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(219, 31);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Card Holder Name";
            // 
            // CardNameBox
            // 
            this.CardNameBox.Animated = true;
            this.CardNameBox.AutoRoundedCorners = true;
            this.CardNameBox.BackColor = System.Drawing.Color.Transparent;
            this.CardNameBox.BorderColor = System.Drawing.Color.Black;
            this.CardNameBox.BorderRadius = 21;
            this.CardNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNameBox.DefaultText = "";
            this.CardNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CardNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CardNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNameBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CardNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNameBox.Font = new System.Drawing.Font("Chinacat", 18F);
            this.CardNameBox.ForeColor = System.Drawing.Color.White;
            this.CardNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNameBox.Location = new System.Drawing.Point(23, 445);
            this.CardNameBox.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.CardNameBox.Name = "CardNameBox";
            this.CardNameBox.PasswordChar = '\0';
            this.CardNameBox.PlaceholderText = "";
            this.CardNameBox.SelectedText = "";
            this.CardNameBox.Size = new System.Drawing.Size(371, 44);
            this.CardNameBox.TabIndex = 20;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(23, 507);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(126, 31);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Expiration";
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
            this.PaymentBtn.FillColor = System.Drawing.Color.DarkOrchid;
            this.PaymentBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.PaymentBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentBtn.IndicateFocus = true;
            this.PaymentBtn.Location = new System.Drawing.Point(72, 665);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(273, 44);
            this.PaymentBtn.TabIndex = 29;
            this.PaymentBtn.Text = "Proceed";
            this.PaymentBtn.UseTransparentBackground = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // ExpirationDatePicker
            // 
            this.ExpirationDatePicker.Animated = true;
            this.ExpirationDatePicker.AutoRoundedCorners = true;
            this.ExpirationDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.ExpirationDatePicker.BorderRadius = 17;
            this.ExpirationDatePicker.Checked = true;
            this.ExpirationDatePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ExpirationDatePicker.Font = new System.Drawing.Font("Chinacat", 18F);
            this.ExpirationDatePicker.ForeColor = System.Drawing.Color.White;
            this.ExpirationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ExpirationDatePicker.IndicateFocus = true;
            this.ExpirationDatePicker.Location = new System.Drawing.Point(23, 556);
            this.ExpirationDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpirationDatePicker.MinDate = new System.DateTime(2024, 3, 4, 0, 0, 0, 0);
            this.ExpirationDatePicker.MinimumSize = new System.Drawing.Size(371, 0);
            this.ExpirationDatePicker.Name = "ExpirationDatePicker";
            this.ExpirationDatePicker.Size = new System.Drawing.Size(371, 36);
            this.ExpirationDatePicker.TabIndex = 30;
            this.ExpirationDatePicker.UseTransparentBackground = true;
            this.ExpirationDatePicker.Value = new System.DateTime(2024, 3, 4, 1, 8, 48, 968);
            // 
            // CardProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.ExpirationDatePicker);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.CardNameBox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.CVCBox);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.CardNumberBox);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "CardProcess";
            this.Size = new System.Drawing.Size(417, 767);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox CardNumberBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox CVCBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox CardNameBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button PaymentBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpirationDatePicker;
    }
}
