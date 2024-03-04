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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.servicesUserControl1 = new TriforceSalon.UserControls.Receptionist_Controls.ServicesUserControl();
            this.NServicesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NSellProdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NAppointmentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NPaymentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RecepLogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.paymentsUserControls1 = new TriforceSalon.UserControls.Receptionist_Controls.PaymentsUserControls();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2Panel2.Controls.Add(this.servicesUserControl1);
            this.guna2Panel2.Controls.Add(this.paymentsUserControls1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 229);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1920, 843);
            this.guna2Panel2.TabIndex = 10;
            // 
            // servicesUserControl1
            // 
            this.servicesUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.servicesUserControl1.Location = new System.Drawing.Point(4, 4);
            this.servicesUserControl1.Name = "servicesUserControl1";
            this.servicesUserControl1.Size = new System.Drawing.Size(1920, 843);
            this.servicesUserControl1.TabIndex = 0;
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
            this.NServicesBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NServicesBtn.ForeColor = System.Drawing.Color.White;
            this.NServicesBtn.Location = new System.Drawing.Point(12, 138);
            this.NServicesBtn.Name = "NServicesBtn";
            this.NServicesBtn.Size = new System.Drawing.Size(321, 76);
            this.NServicesBtn.TabIndex = 11;
            this.NServicesBtn.Text = "Services";
            this.NServicesBtn.UseTransparentBackground = true;
            this.NServicesBtn.Click += new System.EventHandler(this.NServicesBtn_Click);
            // 
            // NSellProdBtn
            // 
            this.NSellProdBtn.Animated = true;
            this.NSellProdBtn.AutoRoundedCorners = true;
            this.NSellProdBtn.BackColor = System.Drawing.Color.Transparent;
            this.NSellProdBtn.BorderRadius = 37;
            this.NSellProdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NSellProdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NSellProdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NSellProdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NSellProdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NSellProdBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSellProdBtn.ForeColor = System.Drawing.Color.White;
            this.NSellProdBtn.Location = new System.Drawing.Point(350, 138);
            this.NSellProdBtn.Name = "NSellProdBtn";
            this.NSellProdBtn.Size = new System.Drawing.Size(321, 76);
            this.NSellProdBtn.TabIndex = 12;
            this.NSellProdBtn.Text = "Sell Products";
            this.NSellProdBtn.UseTransparentBackground = true;
            // 
            // NAppointmentsBtn
            // 
            this.NAppointmentsBtn.Animated = true;
            this.NAppointmentsBtn.AutoRoundedCorners = true;
            this.NAppointmentsBtn.BackColor = System.Drawing.Color.Transparent;
            this.NAppointmentsBtn.BorderRadius = 37;
            this.NAppointmentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NAppointmentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NAppointmentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NAppointmentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NAppointmentsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NAppointmentsBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAppointmentsBtn.ForeColor = System.Drawing.Color.White;
            this.NAppointmentsBtn.Location = new System.Drawing.Point(697, 138);
            this.NAppointmentsBtn.Name = "NAppointmentsBtn";
            this.NAppointmentsBtn.Size = new System.Drawing.Size(321, 76);
            this.NAppointmentsBtn.TabIndex = 13;
            this.NAppointmentsBtn.Text = "Appointments";
            this.NAppointmentsBtn.UseTransparentBackground = true;
            // 
            // NPaymentBtn
            // 
            this.NPaymentBtn.Animated = true;
            this.NPaymentBtn.AutoRoundedCorners = true;
            this.NPaymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.NPaymentBtn.BorderRadius = 37;
            this.NPaymentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NPaymentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NPaymentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NPaymentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NPaymentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NPaymentBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPaymentBtn.ForeColor = System.Drawing.Color.White;
            this.NPaymentBtn.Location = new System.Drawing.Point(1037, 138);
            this.NPaymentBtn.Name = "NPaymentBtn";
            this.NPaymentBtn.Size = new System.Drawing.Size(321, 76);
            this.NPaymentBtn.TabIndex = 14;
            this.NPaymentBtn.Text = "Payment";
            this.NPaymentBtn.UseTransparentBackground = true;
            this.NPaymentBtn.Click += new System.EventHandler(this.NPaymentBtn_Click);
            // 
            // RecepLogOutBtn
            // 
            this.RecepLogOutBtn.Animated = true;
            this.RecepLogOutBtn.AutoRoundedCorners = true;
            this.RecepLogOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.RecepLogOutBtn.BorderRadius = 37;
            this.RecepLogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RecepLogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RecepLogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RecepLogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RecepLogOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.RecepLogOutBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecepLogOutBtn.ForeColor = System.Drawing.Color.White;
            this.RecepLogOutBtn.Location = new System.Drawing.Point(1586, 138);
            this.RecepLogOutBtn.Name = "RecepLogOutBtn";
            this.RecepLogOutBtn.Size = new System.Drawing.Size(321, 76);
            this.RecepLogOutBtn.TabIndex = 15;
            this.RecepLogOutBtn.Text = "Log-Out";
            this.RecepLogOutBtn.UseTransparentBackground = true;
            this.RecepLogOutBtn.Click += new System.EventHandler(this.RecepLogOutBtn_Click);
            // 
            // paymentsUserControls1
            // 
            this.paymentsUserControls1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.paymentsUserControls1.Location = new System.Drawing.Point(4, 4);
            this.paymentsUserControls1.Name = "paymentsUserControls1";
            this.paymentsUserControls1.Size = new System.Drawing.Size(1920, 843);
            this.paymentsUserControls1.TabIndex = 1;
            // 
            // WalkInTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.RecepLogOutBtn);
            this.Controls.Add(this.NPaymentBtn);
            this.Controls.Add(this.NAppointmentsBtn);
            this.Controls.Add(this.NSellProdBtn);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button NServicesBtn;
        private Guna.UI2.WinForms.Guna2Button NSellProdBtn;
        private Guna.UI2.WinForms.Guna2Button NAppointmentsBtn;
        private Guna.UI2.WinForms.Guna2Button NPaymentBtn;
        private Guna.UI2.WinForms.Guna2Button RecepLogOutBtn;
        private Receptionist_Controls.ServicesUserControl servicesUserControl1;
        private Receptionist_Controls.PaymentsUserControls paymentsUserControls1;
    }
}