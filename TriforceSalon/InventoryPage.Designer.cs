namespace TriforceSalon
{
    partial class InventoryPage
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
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.AllowUserToAddRows = false;
            this.InventoryDGV.AllowUserToDeleteRows = false;
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Location = new System.Drawing.Point(86, 66);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.ReadOnly = true;
            this.InventoryDGV.Size = new System.Drawing.Size(1099, 707);
            this.InventoryDGV.TabIndex = 0;
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventoryDGV);
            this.Name = "InventoryPage";
            this.Size = new System.Drawing.Size(1900, 1060);
            this.Load += new System.EventHandler(this.InventoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryDGV;
    }
}
