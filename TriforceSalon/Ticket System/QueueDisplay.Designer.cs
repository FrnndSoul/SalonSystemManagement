namespace TriforceSalon.Ticket_System
{
    partial class QueueDisplay
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
            this.QueueTicket = new Guna.UI2.WinForms.Guna2Panel();
            this.ServeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionIDLbl = new System.Windows.Forms.Label();
            this.QueueNumLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.QueueTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueueTicket
            // 
            this.QueueTicket.BackColor = System.Drawing.Color.Transparent;
            this.QueueTicket.BorderRadius = 30;
            this.QueueTicket.Controls.Add(this.ServeBtn);
            this.QueueTicket.Controls.Add(this.ServiceLbl);
            this.QueueTicket.Controls.Add(this.label1);
            this.QueueTicket.Controls.Add(this.NameLbl);
            this.QueueTicket.Controls.Add(this.label3);
            this.QueueTicket.Controls.Add(this.label2);
            this.QueueTicket.Controls.Add(this.TransactionIDLbl);
            this.QueueTicket.Controls.Add(this.QueueNumLbl);
            this.QueueTicket.Controls.Add(this.StatusLbl);
            this.QueueTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueueTicket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.QueueTicket.Location = new System.Drawing.Point(0, 0);
            this.QueueTicket.Name = "QueueTicket";
            this.QueueTicket.Size = new System.Drawing.Size(209, 194);
            this.QueueTicket.TabIndex = 0;
            // 
            // ServeBtn
            // 
            this.ServeBtn.AutoRoundedCorners = true;
            this.ServeBtn.BorderRadius = 13;
            this.ServeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.ServeBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ServeBtn.ForeColor = System.Drawing.Color.White;
            this.ServeBtn.Location = new System.Drawing.Point(29, 160);
            this.ServeBtn.Name = "ServeBtn";
            this.ServeBtn.Size = new System.Drawing.Size(154, 29);
            this.ServeBtn.TabIndex = 8;
            this.ServeBtn.Text = "Serve";
            this.ServeBtn.Click += new System.EventHandler(this.ServeBtn_Click);
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLbl.ForeColor = System.Drawing.Color.White;
            this.ServiceLbl.Location = new System.Drawing.Point(68, 105);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(56, 20);
            this.ServiceLbl.TabIndex = 6;
            this.ServiceLbl.Text = "Service";
            this.ServiceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(59, 81);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 20);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // TransactionIDLbl
            // 
            this.TransactionIDLbl.AutoSize = true;
            this.TransactionIDLbl.ForeColor = System.Drawing.Color.White;
            this.TransactionIDLbl.Location = new System.Drawing.Point(22, 0);
            this.TransactionIDLbl.Name = "TransactionIDLbl";
            this.TransactionIDLbl.Size = new System.Drawing.Size(18, 13);
            this.TransactionIDLbl.TabIndex = 1;
            this.TransactionIDLbl.Text = "ID";
            this.TransactionIDLbl.Visible = false;
            // 
            // QueueNumLbl
            // 
            this.QueueNumLbl.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueNumLbl.ForeColor = System.Drawing.Color.White;
            this.QueueNumLbl.Location = new System.Drawing.Point(14, 16);
            this.QueueNumLbl.Name = "QueueNumLbl";
            this.QueueNumLbl.Size = new System.Drawing.Size(180, 65);
            this.QueueNumLbl.TabIndex = 0;
            this.QueueNumLbl.Text = "1";
            this.QueueNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.Location = new System.Drawing.Point(63, 129);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(49, 20);
            this.StatusLbl.TabIndex = 7;
            this.StatusLbl.Text = "Status";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QueueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.QueueTicket);
            this.Name = "QueueDisplay";
            this.Size = new System.Drawing.Size(209, 194);
            this.QueueTicket.ResumeLayout(false);
            this.QueueTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel QueueTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TransactionIDLbl;
        private System.Windows.Forms.Label QueueNumLbl;
        private Guna.UI2.WinForms.Guna2Button ServeBtn;
        private System.Windows.Forms.Label ServiceLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label StatusLbl;
    }
}
