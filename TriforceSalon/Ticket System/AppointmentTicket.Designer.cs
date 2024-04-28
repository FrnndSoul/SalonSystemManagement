namespace TriforceSalon.Ticket_System
{
    partial class AppointmentTicket
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
            this.EditInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ServiceChosen = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.Label();
            this.CustDate = new System.Windows.Forms.Label();
            this.CustID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelAppointBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ActivateCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CustNumber = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.CustNumber);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.EditInfoBtn);
            this.guna2Panel1.Controls.Add(this.SAmount);
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.Controls.Add(this.ServiceChosen);
            this.guna2Panel1.Controls.Add(this.CustName);
            this.guna2Panel1.Controls.Add(this.CustDate);
            this.guna2Panel1.Controls.Add(this.CustID);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.CancelAppointBtn);
            this.guna2Panel1.Controls.Add(this.ActivateCustomerBtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1717, 130);
            this.guna2Panel1.TabIndex = 0;
            // 
            // EditInfoBtn
            // 
            this.EditInfoBtn.AutoRoundedCorners = true;
            this.EditInfoBtn.BorderRadius = 17;
            this.EditInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditInfoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.EditInfoBtn.Font = new System.Drawing.Font("Stanberry", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInfoBtn.ForeColor = System.Drawing.Color.White;
            this.EditInfoBtn.Location = new System.Drawing.Point(1520, 49);
            this.EditInfoBtn.Name = "EditInfoBtn";
            this.EditInfoBtn.Size = new System.Drawing.Size(180, 37);
            this.EditInfoBtn.TabIndex = 18;
            this.EditInfoBtn.Text = "Edit Info";
            this.EditInfoBtn.Click += new System.EventHandler(this.EditInfoBtn_Click);
            // 
            // SAmount
            // 
            this.SAmount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAmount.Location = new System.Drawing.Point(1210, 26);
            this.SAmount.Name = "SAmount";
            this.SAmount.Size = new System.Drawing.Size(101, 26);
            this.SAmount.TabIndex = 17;
            this.SAmount.Text = "SAmount";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label14.Location = new System.Drawing.Point(1193, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 26);
            this.label14.TabIndex = 16;
            this.label14.Text = "₱";
            // 
            // ServiceChosen
            // 
            this.ServiceChosen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceChosen.Location = new System.Drawing.Point(655, 68);
            this.ServiceChosen.Name = "ServiceChosen";
            this.ServiceChosen.Size = new System.Drawing.Size(299, 29);
            this.ServiceChosen.TabIndex = 15;
            this.ServiceChosen.Text = "Thermal Reconditioning";
            this.ServiceChosen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustName
            // 
            this.CustName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(655, 26);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(231, 26);
            this.CustName.TabIndex = 12;
            this.CustName.Text = "Fernand Emil";
            // 
            // CustDate
            // 
            this.CustDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustDate.Location = new System.Drawing.Point(214, 75);
            this.CustDate.Name = "CustDate";
            this.CustDate.Size = new System.Drawing.Size(204, 26);
            this.CustDate.TabIndex = 11;
            this.CustDate.Text = "2024-05-01 19:00:00";
            // 
            // CustID
            // 
            this.CustID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustID.Location = new System.Drawing.Point(212, 30);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(204, 26);
            this.CustID.TabIndex = 10;
            this.CustID.Text = "72386971";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1027, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Service Amount:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Service:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appointment Date:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction ID:";
            // 
            // CancelAppointBtn
            // 
            this.CancelAppointBtn.AutoRoundedCorners = true;
            this.CancelAppointBtn.BorderRadius = 17;
            this.CancelAppointBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelAppointBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelAppointBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelAppointBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelAppointBtn.FillColor = System.Drawing.Color.Red;
            this.CancelAppointBtn.Font = new System.Drawing.Font("Stanberry", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAppointBtn.ForeColor = System.Drawing.Color.White;
            this.CancelAppointBtn.Location = new System.Drawing.Point(1520, 90);
            this.CancelAppointBtn.Name = "CancelAppointBtn";
            this.CancelAppointBtn.Size = new System.Drawing.Size(180, 37);
            this.CancelAppointBtn.TabIndex = 1;
            this.CancelAppointBtn.Text = "Cancel";
            this.CancelAppointBtn.Click += new System.EventHandler(this.CancelAppointBtn_Click);
            // 
            // ActivateCustomerBtn
            // 
            this.ActivateCustomerBtn.AutoRoundedCorners = true;
            this.ActivateCustomerBtn.BorderRadius = 17;
            this.ActivateCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ActivateCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ActivateCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ActivateCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ActivateCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ActivateCustomerBtn.Font = new System.Drawing.Font("Stanberry", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.ActivateCustomerBtn.Location = new System.Drawing.Point(1520, 8);
            this.ActivateCustomerBtn.Name = "ActivateCustomerBtn";
            this.ActivateCustomerBtn.Size = new System.Drawing.Size(180, 37);
            this.ActivateCustomerBtn.TabIndex = 0;
            this.ActivateCustomerBtn.Text = "Activate";
            this.ActivateCustomerBtn.Click += new System.EventHandler(this.ActivateCustomerBtn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1027, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CustNumber
            // 
            this.CustNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNumber.Location = new System.Drawing.Point(1193, 68);
            this.CustNumber.Name = "CustNumber";
            this.CustNumber.Size = new System.Drawing.Size(143, 26);
            this.CustNumber.TabIndex = 20;
            this.CustNumber.Text = "Phone Number";
            // 
            // AppointmentTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AppointmentTicket";
            this.Size = new System.Drawing.Size(1723, 136);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button CancelAppointBtn;
        private Guna.UI2.WinForms.Guna2Button ActivateCustomerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CustName;
        private System.Windows.Forms.Label CustDate;
        private System.Windows.Forms.Label CustID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ServiceChosen;
        private Guna.UI2.WinForms.Guna2Button EditInfoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CustNumber;
    }
}
