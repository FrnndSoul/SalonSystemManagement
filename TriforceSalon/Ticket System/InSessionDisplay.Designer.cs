namespace TriforceSalon.Ticket_System
{
    partial class InSessionDisplay
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
            this.EmpIDLbl = new System.Windows.Forms.Label();
            this.ServiceDoneBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceVarLbl = new System.Windows.Forms.Label();
            this.RefLbl = new System.Windows.Forms.Label();
            this.TransactionIDLbl = new System.Windows.Forms.Label();
            this.QueueNumLbl = new System.Windows.Forms.Label();
            this.QueueTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueueTicket
            // 
            this.QueueTicket.BackColor = System.Drawing.Color.Transparent;
            this.QueueTicket.BorderColor = System.Drawing.Color.Black;
            this.QueueTicket.BorderRadius = 30;
            this.QueueTicket.BorderThickness = 2;
            this.QueueTicket.Controls.Add(this.EmpIDLbl);
            this.QueueTicket.Controls.Add(this.ServiceDoneBtn);
            this.QueueTicket.Controls.Add(this.ServiceVarLbl);
            this.QueueTicket.Controls.Add(this.RefLbl);
            this.QueueTicket.Controls.Add(this.TransactionIDLbl);
            this.QueueTicket.Controls.Add(this.QueueNumLbl);
            this.QueueTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueueTicket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.QueueTicket.Location = new System.Drawing.Point(0, 0);
            this.QueueTicket.Name = "QueueTicket";
            this.QueueTicket.Size = new System.Drawing.Size(209, 140);
            this.QueueTicket.TabIndex = 1;
            // 
            // EmpIDLbl
            // 
            this.EmpIDLbl.Location = new System.Drawing.Point(137, 30);
            this.EmpIDLbl.Name = "EmpIDLbl";
            this.EmpIDLbl.Size = new System.Drawing.Size(59, 18);
            this.EmpIDLbl.TabIndex = 5;
            this.EmpIDLbl.Text = "label1";
            this.EmpIDLbl.Visible = false;
            // 
            // ServiceDoneBtn
            // 
            this.ServiceDoneBtn.AutoRoundedCorners = true;
            this.ServiceDoneBtn.BorderRadius = 13;
            this.ServiceDoneBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServiceDoneBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServiceDoneBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServiceDoneBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServiceDoneBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ServiceDoneBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDoneBtn.ForeColor = System.Drawing.Color.Black;
            this.ServiceDoneBtn.Location = new System.Drawing.Point(44, 99);
            this.ServiceDoneBtn.Name = "ServiceDoneBtn";
            this.ServiceDoneBtn.Size = new System.Drawing.Size(123, 28);
            this.ServiceDoneBtn.TabIndex = 4;
            this.ServiceDoneBtn.Text = "Done";
            this.ServiceDoneBtn.Click += new System.EventHandler(this.ServiceDoneBtn_Click);
            // 
            // ServiceVarLbl
            // 
            this.ServiceVarLbl.Location = new System.Drawing.Point(140, 12);
            this.ServiceVarLbl.Name = "ServiceVarLbl";
            this.ServiceVarLbl.Size = new System.Drawing.Size(56, 18);
            this.ServiceVarLbl.TabIndex = 3;
            this.ServiceVarLbl.Text = "label1";
            this.ServiceVarLbl.Visible = false;
            // 
            // RefLbl
            // 
            this.RefLbl.AutoSize = true;
            this.RefLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefLbl.ForeColor = System.Drawing.Color.White;
            this.RefLbl.Location = new System.Drawing.Point(15, 72);
            this.RefLbl.Name = "RefLbl";
            this.RefLbl.Size = new System.Drawing.Size(103, 20);
            this.RefLbl.TabIndex = 2;
            this.RefLbl.Text = "Reference ID:";
            // 
            // TransactionIDLbl
            // 
            this.TransactionIDLbl.AutoSize = true;
            this.TransactionIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDLbl.ForeColor = System.Drawing.Color.White;
            this.TransactionIDLbl.Location = new System.Drawing.Point(114, 71);
            this.TransactionIDLbl.Name = "TransactionIDLbl";
            this.TransactionIDLbl.Size = new System.Drawing.Size(82, 21);
            this.TransactionIDLbl.TabIndex = 1;
            this.TransactionIDLbl.Text = "00000000";
            // 
            // QueueNumLbl
            // 
            this.QueueNumLbl.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueNumLbl.ForeColor = System.Drawing.Color.White;
            this.QueueNumLbl.Location = new System.Drawing.Point(70, 12);
            this.QueueNumLbl.Name = "QueueNumLbl";
            this.QueueNumLbl.Size = new System.Drawing.Size(79, 57);
            this.QueueNumLbl.TabIndex = 0;
            this.QueueNumLbl.Text = "10";
            this.QueueNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InSessionDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.QueueTicket);
            this.Name = "InSessionDisplay";
            this.Size = new System.Drawing.Size(209, 140);
            this.QueueTicket.ResumeLayout(false);
            this.QueueTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel QueueTicket;
        private System.Windows.Forms.Label ServiceVarLbl;
        private System.Windows.Forms.Label RefLbl;
        private System.Windows.Forms.Label TransactionIDLbl;
        private System.Windows.Forms.Label QueueNumLbl;
        private Guna.UI2.WinForms.Guna2Button ServiceDoneBtn;
        private System.Windows.Forms.Label EmpIDLbl;
    }
}
