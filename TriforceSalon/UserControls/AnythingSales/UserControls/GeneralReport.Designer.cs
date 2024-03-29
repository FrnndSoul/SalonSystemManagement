namespace salesreport.UserControls
{
    partial class GeneralReport
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
            this.EmployeeFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.ServicesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chinacat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top 3 Employees";
            // 
            // EmployeeFLP
            // 
            this.EmployeeFLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EmployeeFLP.Location = new System.Drawing.Point(3, 72);
            this.EmployeeFLP.Name = "EmployeeFLP";
            this.EmployeeFLP.Size = new System.Drawing.Size(478, 804);
            this.EmployeeFLP.TabIndex = 5;
            // 
            // ServicesFLP
            // 
            this.ServicesFLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ServicesFLP.Location = new System.Drawing.Point(487, 72);
            this.ServicesFLP.Name = "ServicesFLP";
            this.ServicesFLP.Size = new System.Drawing.Size(478, 804);
            this.ServicesFLP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Chinacat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Top 3 Services";
            // 
            // ProductsFLP
            // 
            this.ProductsFLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductsFLP.Location = new System.Drawing.Point(971, 72);
            this.ProductsFLP.Name = "ProductsFLP";
            this.ProductsFLP.Size = new System.Drawing.Size(478, 804);
            this.ProductsFLP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chinacat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1070, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Top 3 Products";
            // 
            // GeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsFLP);
            this.Controls.Add(this.ServicesFLP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeFLP);
            this.Name = "GeneralReport";
            this.Size = new System.Drawing.Size(1452, 879);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel EmployeeFLP;
        private System.Windows.Forms.FlowLayoutPanel ServicesFLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ProductsFLP;
        private System.Windows.Forms.Label label3;
    }
}
