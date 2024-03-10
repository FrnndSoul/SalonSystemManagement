namespace TriforceSalon.Test
{
    partial class CustomerTicket
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.TicketLbl = new System.Windows.Forms.Label();
            this.ServiceVarLbl = new System.Windows.Forms.Label();
            this.ProcessCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PrioStatusLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.NameLbl.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(36, 34);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(248, 35);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicketLbl
            // 
            this.TicketLbl.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketLbl.ForeColor = System.Drawing.Color.White;
            this.TicketLbl.Location = new System.Drawing.Point(970, 28);
            this.TicketLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TicketLbl.Name = "TicketLbl";
            this.TicketLbl.Size = new System.Drawing.Size(173, 35);
            this.TicketLbl.TabIndex = 1;
            this.TicketLbl.Text = "TicketID";
            this.TicketLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceVarLbl
            // 
            this.ServiceVarLbl.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceVarLbl.ForeColor = System.Drawing.Color.White;
            this.ServiceVarLbl.Location = new System.Drawing.Point(663, 30);
            this.ServiceVarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceVarLbl.Name = "ServiceVarLbl";
            this.ServiceVarLbl.Size = new System.Drawing.Size(119, 35);
            this.ServiceVarLbl.TabIndex = 3;
            this.ServiceVarLbl.Text = "Service";
            this.ServiceVarLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessCustomerBtn
            // 
            this.ProcessCustomerBtn.Animated = true;
            this.ProcessCustomerBtn.AutoRoundedCorners = true;
            this.ProcessCustomerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProcessCustomerBtn.BorderRadius = 17;
            this.ProcessCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProcessCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProcessCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProcessCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProcessCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ProcessCustomerBtn.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.ProcessCustomerBtn.Location = new System.Drawing.Point(1161, 27);
            this.ProcessCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProcessCustomerBtn.Name = "ProcessCustomerBtn";
            this.ProcessCustomerBtn.Size = new System.Drawing.Size(135, 37);
            this.ProcessCustomerBtn.TabIndex = 5;
            this.ProcessCustomerBtn.Text = "Serve";
            this.ProcessCustomerBtn.UseTransparentBackground = true;
            this.ProcessCustomerBtn.Click += new System.EventHandler(this.ProcessCustomerBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.ProcessCustomerBtn);
            this.guna2Panel1.Controls.Add(this.PrioStatusLbl);
            this.guna2Panel1.Controls.Add(this.PhoneNumberLbl);
            this.guna2Panel1.Controls.Add(this.AgeLbl);
            this.guna2Panel1.Controls.Add(this.ServiceVarLbl);
            this.guna2Panel1.Controls.Add(this.TicketLbl);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.guna2Panel1.Location = new System.Drawing.Point(8, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1319, 94);
            this.guna2Panel1.TabIndex = 6;
            // 
            // PrioStatusLbl
            // 
            this.PrioStatusLbl.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioStatusLbl.ForeColor = System.Drawing.Color.White;
            this.PrioStatusLbl.Location = new System.Drawing.Point(828, 22);
            this.PrioStatusLbl.Name = "PrioStatusLbl";
            this.PrioStatusLbl.Size = new System.Drawing.Size(110, 50);
            this.PrioStatusLbl.TabIndex = 5;
            this.PrioStatusLbl.Text = "Priority Status";
            this.PrioStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLbl.ForeColor = System.Drawing.Color.White;
            this.PhoneNumberLbl.Location = new System.Drawing.Point(403, 30);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(217, 37);
            this.PhoneNumberLbl.TabIndex = 3;
            this.PhoneNumberLbl.Text = "Phone Number";
            this.PhoneNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgeLbl
            // 
            this.AgeLbl.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.ForeColor = System.Drawing.Color.White;
            this.AgeLbl.Location = new System.Drawing.Point(298, 28);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(64, 35);
            this.AgeLbl.TabIndex = 0;
            this.AgeLbl.Text = "Age";
            this.AgeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerTicket";
            this.Size = new System.Drawing.Size(1337, 101);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ProcessCustomerBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label NameLbl;
        public System.Windows.Forms.Label TicketLbl;
        public System.Windows.Forms.Label ServiceVarLbl;
        public System.Windows.Forms.Label PhoneNumberLbl;
        public System.Windows.Forms.Label AgeLbl;
        public System.Windows.Forms.Label PrioStatusLbl;
    }
}