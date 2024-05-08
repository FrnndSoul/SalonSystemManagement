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
            this.QueueTicket.Controls.Add(this.ServiceVarLbl);
            this.QueueTicket.Controls.Add(this.RefLbl);
            this.QueueTicket.Controls.Add(this.TransactionIDLbl);
            this.QueueTicket.Controls.Add(this.QueueNumLbl);
            this.QueueTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueueTicket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(209)))));
            this.QueueTicket.Location = new System.Drawing.Point(0, 0);
            this.QueueTicket.Name = "QueueTicket";
            this.QueueTicket.Size = new System.Drawing.Size(209, 135);
            this.QueueTicket.TabIndex = 0;
            this.QueueTicket.Click += new System.EventHandler(this.QueueTicket_Click);
            this.QueueTicket.Paint += new System.Windows.Forms.PaintEventHandler(this.QueueTicket_Paint);
            // 
            // ServiceVarLbl
            // 
            this.ServiceVarLbl.AutoSize = true;
            this.ServiceVarLbl.Location = new System.Drawing.Point(171, 113);
            this.ServiceVarLbl.Name = "ServiceVarLbl";
            this.ServiceVarLbl.Size = new System.Drawing.Size(35, 13);
            this.ServiceVarLbl.TabIndex = 3;
            this.ServiceVarLbl.Text = "label1";
            this.ServiceVarLbl.Visible = false;
            // 
            // RefLbl
            // 
            this.RefLbl.AutoSize = true;
            this.RefLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefLbl.ForeColor = System.Drawing.Color.White;
            this.RefLbl.Location = new System.Drawing.Point(13, 93);
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
            this.TransactionIDLbl.Location = new System.Drawing.Point(112, 92);
            this.TransactionIDLbl.Name = "TransactionIDLbl";
            this.TransactionIDLbl.Size = new System.Drawing.Size(82, 21);
            this.TransactionIDLbl.TabIndex = 1;
            this.TransactionIDLbl.Text = "00000000";
            // 
            // QueueNumLbl
            // 
            this.QueueNumLbl.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueNumLbl.ForeColor = System.Drawing.Color.White;
            this.QueueNumLbl.Location = new System.Drawing.Point(57, 16);
            this.QueueNumLbl.Name = "QueueNumLbl";
            this.QueueNumLbl.Size = new System.Drawing.Size(92, 65);
            this.QueueNumLbl.TabIndex = 0;
            this.QueueNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.QueueTicket);
            this.Name = "QueueDisplay";
            this.Size = new System.Drawing.Size(209, 135);
            this.QueueTicket.ResumeLayout(false);
            this.QueueTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel QueueTicket;
        private System.Windows.Forms.Label RefLbl;
        private System.Windows.Forms.Label TransactionIDLbl;
        private System.Windows.Forms.Label QueueNumLbl;
        private System.Windows.Forms.Label ServiceVarLbl;
    }
}
