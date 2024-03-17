namespace TriforceSalon.UserControls.Employee_Controls
{
    partial class EmployeeLock
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
            this.EmployeeLockPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddServicePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ServiceListComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AServiceAmountTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddServiceChckB = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.CustomerServiceTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerPNumTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerAgeTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerIDTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeDoneBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeeLockPanel.SuspendLayout();
            this.AddServicePanel.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeLockPanel
            // 
            this.EmployeeLockPanel.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeLockPanel.BorderRadius = 50;
            this.EmployeeLockPanel.Controls.Add(this.label1);
            this.EmployeeLockPanel.Controls.Add(this.AddServicePanel);
            this.EmployeeLockPanel.Controls.Add(this.guna2Panel3);
            this.EmployeeLockPanel.Controls.Add(this.label10);
            this.EmployeeLockPanel.Controls.Add(this.EmployeeDoneBtn);
            this.EmployeeLockPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.EmployeeLockPanel.Location = new System.Drawing.Point(2, 0);
            this.EmployeeLockPanel.Name = "EmployeeLockPanel";
            this.EmployeeLockPanel.Size = new System.Drawing.Size(1337, 842);
            this.EmployeeLockPanel.TabIndex = 11;
            this.EmployeeLockPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(43, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 75);
            this.label1.TabIndex = 24;
            this.label1.Text = "Additional Service";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddServicePanel
            // 
            this.AddServicePanel.BackColor = System.Drawing.Color.Transparent;
            this.AddServicePanel.BorderRadius = 50;
            this.AddServicePanel.Controls.Add(this.ServiceListComB);
            this.AddServicePanel.Controls.Add(this.AServiceAmountTxtB);
            this.AddServicePanel.Controls.Add(this.label4);
            this.AddServicePanel.Controls.Add(this.label3);
            this.AddServicePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AddServicePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AddServicePanel.Location = new System.Drawing.Point(56, 483);
            this.AddServicePanel.Name = "AddServicePanel";
            this.AddServicePanel.Size = new System.Drawing.Size(637, 229);
            this.AddServicePanel.TabIndex = 23;
            // 
            // ServiceListComB
            // 
            this.ServiceListComB.AutoRoundedCorners = true;
            this.ServiceListComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceListComB.BorderRadius = 17;
            this.ServiceListComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceListComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceListComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceListComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceListComB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServiceListComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceListComB.ItemHeight = 30;
            this.ServiceListComB.Location = new System.Drawing.Point(239, 55);
            this.ServiceListComB.Name = "ServiceListComB";
            this.ServiceListComB.Size = new System.Drawing.Size(350, 36);
            this.ServiceListComB.TabIndex = 25;
            this.ServiceListComB.SelectedIndexChanged += new System.EventHandler(this.ServiceListComB_SelectedIndexChanged);
            // 
            // AServiceAmountTxtB
            // 
            this.AServiceAmountTxtB.AutoRoundedCorners = true;
            this.AServiceAmountTxtB.BackColor = System.Drawing.Color.Transparent;
            this.AServiceAmountTxtB.BorderRadius = 20;
            this.AServiceAmountTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AServiceAmountTxtB.DefaultText = "";
            this.AServiceAmountTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AServiceAmountTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AServiceAmountTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AServiceAmountTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AServiceAmountTxtB.Enabled = false;
            this.AServiceAmountTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AServiceAmountTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AServiceAmountTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AServiceAmountTxtB.Location = new System.Drawing.Point(239, 129);
            this.AServiceAmountTxtB.Name = "AServiceAmountTxtB";
            this.AServiceAmountTxtB.PasswordChar = '\0';
            this.AServiceAmountTxtB.PlaceholderText = "";
            this.AServiceAmountTxtB.SelectedText = "";
            this.AServiceAmountTxtB.Size = new System.Drawing.Size(350, 42);
            this.AServiceAmountTxtB.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 69);
            this.label4.TabIndex = 22;
            this.label4.Text = "Service Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 69);
            this.label3.TabIndex = 20;
            this.label3.Text = "Service Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 50;
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.AddServiceChckB);
            this.guna2Panel3.Controls.Add(this.CustomerServiceTxtB);
            this.guna2Panel3.Controls.Add(this.CustomerPNumTxtB);
            this.guna2Panel3.Controls.Add(this.CustomerAgeTxtB);
            this.guna2Panel3.Controls.Add(this.CustomerNameTxtB);
            this.guna2Panel3.Controls.Add(this.CustomerIDTxtB);
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Controls.Add(this.label16);
            this.guna2Panel3.Controls.Add(this.label15);
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.Controls.Add(this.label14);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2Panel3.Location = new System.Drawing.Point(56, 96);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1223, 282);
            this.guna2Panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(626, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 69);
            this.label2.TabIndex = 24;
            this.label2.Text = "Add Service?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddServiceChckB
            // 
            this.AddServiceChckB.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.AddServiceChckB.CheckedState.BorderRadius = 2;
            this.AddServiceChckB.CheckedState.BorderThickness = 0;
            this.AddServiceChckB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.AddServiceChckB.Location = new System.Drawing.Point(832, 197);
            this.AddServiceChckB.Name = "AddServiceChckB";
            this.AddServiceChckB.Size = new System.Drawing.Size(48, 45);
            this.AddServiceChckB.TabIndex = 23;
            this.AddServiceChckB.Text = "guna2CustomCheckBox1";
            this.AddServiceChckB.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.AddServiceChckB.UncheckedState.BorderRadius = 2;
            this.AddServiceChckB.UncheckedState.BorderThickness = 0;
            this.AddServiceChckB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.AddServiceChckB.CheckedChanged += new System.EventHandler(this.AddServiceChckB_CheckedChanged);
            // 
            // CustomerServiceTxtB
            // 
            this.CustomerServiceTxtB.AutoRoundedCorners = true;
            this.CustomerServiceTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerServiceTxtB.BorderRadius = 20;
            this.CustomerServiceTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerServiceTxtB.DefaultText = "";
            this.CustomerServiceTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerServiceTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerServiceTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerServiceTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerServiceTxtB.Enabled = false;
            this.CustomerServiceTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerServiceTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerServiceTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerServiceTxtB.Location = new System.Drawing.Point(831, 47);
            this.CustomerServiceTxtB.Name = "CustomerServiceTxtB";
            this.CustomerServiceTxtB.PasswordChar = '\0';
            this.CustomerServiceTxtB.PlaceholderText = "";
            this.CustomerServiceTxtB.SelectedText = "";
            this.CustomerServiceTxtB.Size = new System.Drawing.Size(350, 42);
            this.CustomerServiceTxtB.TabIndex = 22;
            // 
            // CustomerPNumTxtB
            // 
            this.CustomerPNumTxtB.AutoRoundedCorners = true;
            this.CustomerPNumTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPNumTxtB.BorderRadius = 20;
            this.CustomerPNumTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPNumTxtB.DefaultText = "";
            this.CustomerPNumTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerPNumTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerPNumTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPNumTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPNumTxtB.Enabled = false;
            this.CustomerPNumTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPNumTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerPNumTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPNumTxtB.Location = new System.Drawing.Point(831, 125);
            this.CustomerPNumTxtB.Name = "CustomerPNumTxtB";
            this.CustomerPNumTxtB.PasswordChar = '\0';
            this.CustomerPNumTxtB.PlaceholderText = "";
            this.CustomerPNumTxtB.SelectedText = "";
            this.CustomerPNumTxtB.Size = new System.Drawing.Size(350, 42);
            this.CustomerPNumTxtB.TabIndex = 21;
            // 
            // CustomerAgeTxtB
            // 
            this.CustomerAgeTxtB.AutoRoundedCorners = true;
            this.CustomerAgeTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerAgeTxtB.BorderRadius = 20;
            this.CustomerAgeTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerAgeTxtB.DefaultText = "";
            this.CustomerAgeTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerAgeTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerAgeTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerAgeTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerAgeTxtB.Enabled = false;
            this.CustomerAgeTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAgeTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerAgeTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAgeTxtB.Location = new System.Drawing.Point(260, 125);
            this.CustomerAgeTxtB.Name = "CustomerAgeTxtB";
            this.CustomerAgeTxtB.PasswordChar = '\0';
            this.CustomerAgeTxtB.PlaceholderText = "";
            this.CustomerAgeTxtB.SelectedText = "";
            this.CustomerAgeTxtB.Size = new System.Drawing.Size(350, 42);
            this.CustomerAgeTxtB.TabIndex = 20;
            // 
            // CustomerNameTxtB
            // 
            this.CustomerNameTxtB.AutoRoundedCorners = true;
            this.CustomerNameTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameTxtB.BorderRadius = 20;
            this.CustomerNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTxtB.DefaultText = "";
            this.CustomerNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.Enabled = false;
            this.CustomerNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Location = new System.Drawing.Point(260, 47);
            this.CustomerNameTxtB.Name = "CustomerNameTxtB";
            this.CustomerNameTxtB.PasswordChar = '\0';
            this.CustomerNameTxtB.PlaceholderText = "";
            this.CustomerNameTxtB.SelectedText = "";
            this.CustomerNameTxtB.Size = new System.Drawing.Size(350, 42);
            this.CustomerNameTxtB.TabIndex = 19;
            // 
            // CustomerIDTxtB
            // 
            this.CustomerIDTxtB.AutoRoundedCorners = true;
            this.CustomerIDTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerIDTxtB.BorderRadius = 20;
            this.CustomerIDTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIDTxtB.DefaultText = "";
            this.CustomerIDTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerIDTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerIDTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIDTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIDTxtB.Enabled = false;
            this.CustomerIDTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIDTxtB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerIDTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIDTxtB.Location = new System.Drawing.Point(260, 205);
            this.CustomerIDTxtB.Name = "CustomerIDTxtB";
            this.CustomerIDTxtB.PasswordChar = '\0';
            this.CustomerIDTxtB.PlaceholderText = "";
            this.CustomerIDTxtB.SelectedText = "";
            this.CustomerIDTxtB.Size = new System.Drawing.Size(350, 42);
            this.CustomerIDTxtB.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label11.Location = new System.Drawing.Point(54, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 50);
            this.label11.TabIndex = 16;
            this.label11.Text = "Transaction ID:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label16.Location = new System.Drawing.Point(49, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 69);
            this.label16.TabIndex = 11;
            this.label16.Text = "Customer Name:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label15.Location = new System.Drawing.Point(55, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 50);
            this.label15.TabIndex = 12;
            this.label15.Text = "Age:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label13.Location = new System.Drawing.Point(630, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 50);
            this.label13.TabIndex = 14;
            this.label13.Text = "Service:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(121)))));
            this.label14.Location = new System.Drawing.Point(626, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 69);
            this.label14.TabIndex = 13;
            this.label14.Text = "Phone Number:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(345, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(650, 75);
            this.label10.TabIndex = 1;
            this.label10.Text = "Customer Details";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeDoneBtn
            // 
            this.EmployeeDoneBtn.Animated = true;
            this.EmployeeDoneBtn.AutoRoundedCorners = true;
            this.EmployeeDoneBtn.BorderRadius = 34;
            this.EmployeeDoneBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeDoneBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeDoneBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeDoneBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeDoneBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.EmployeeDoneBtn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDoneBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeDoneBtn.Location = new System.Drawing.Point(316, 751);
            this.EmployeeDoneBtn.Name = "EmployeeDoneBtn";
            this.EmployeeDoneBtn.Size = new System.Drawing.Size(725, 71);
            this.EmployeeDoneBtn.TabIndex = 0;
            this.EmployeeDoneBtn.Text = "Customer Served";
            this.EmployeeDoneBtn.UseTransparentBackground = true;
            this.EmployeeDoneBtn.Click += new System.EventHandler(this.EmployeeDoneBtn_Click);
            // 
            // EmployeeLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.EmployeeLockPanel);
            this.Name = "EmployeeLock";
            this.Size = new System.Drawing.Size(1337, 861);
            this.Load += new System.EventHandler(this.EmployeeLock_Load);
            this.EmployeeLockPanel.ResumeLayout(false);
            this.AddServicePanel.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel EmployeeLockPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public Guna.UI2.WinForms.Guna2TextBox CustomerServiceTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerPNumTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerAgeTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerNameTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerIDTxtB;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button EmployeeDoneBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel AddServicePanel;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomCheckBox AddServiceChckB;
        public Guna.UI2.WinForms.Guna2TextBox AServiceAmountTxtB;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2ComboBox ServiceListComB;
    }
}
