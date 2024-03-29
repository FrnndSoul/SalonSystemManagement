namespace TriforceSalon.UserControls.Receptionist_Controls
{
    partial class EditAppointmentUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ServiceFilterComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FilterServiceComboBox = new System.Windows.Forms.Label();
            this.SearchServiceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchServiceTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServiceFL = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AppointmentDateTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicesGDGVVControl = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefEmpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddLServiceListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.transactionIDTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceAmountTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CServiceTxtB = new System.Windows.Forms.Label();
            this.ServiceTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PEmployeeComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CustomerPhoneNTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerAgeTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProcessCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGDGVVControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceFilterComB
            // 
            this.ServiceFilterComB.AutoRoundedCorners = true;
            this.ServiceFilterComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceFilterComB.BorderRadius = 17;
            this.ServiceFilterComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceFilterComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceFilterComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceFilterComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceFilterComB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceFilterComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceFilterComB.ItemHeight = 30;
            this.ServiceFilterComB.Location = new System.Drawing.Point(172, 19);
            this.ServiceFilterComB.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceFilterComB.Name = "ServiceFilterComB";
            this.ServiceFilterComB.Size = new System.Drawing.Size(347, 36);
            this.ServiceFilterComB.TabIndex = 11;
            this.ServiceFilterComB.SelectedIndexChanged += new System.EventHandler(this.ServiceFilterComB_SelectedIndexChanged);
            // 
            // FilterServiceComboBox
            // 
            this.FilterServiceComboBox.Font = new System.Drawing.Font("Stanberry", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterServiceComboBox.ForeColor = System.Drawing.Color.White;
            this.FilterServiceComboBox.Location = new System.Drawing.Point(10, 23);
            this.FilterServiceComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilterServiceComboBox.Name = "FilterServiceComboBox";
            this.FilterServiceComboBox.Size = new System.Drawing.Size(180, 29);
            this.FilterServiceComboBox.TabIndex = 10;
            this.FilterServiceComboBox.Text = "Filter Services: ";
            // 
            // SearchServiceBtn
            // 
            this.SearchServiceBtn.AutoRoundedCorners = true;
            this.SearchServiceBtn.BorderRadius = 17;
            this.SearchServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchServiceBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SearchServiceBtn.Font = new System.Drawing.Font("Stanberry", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchServiceBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchServiceBtn.Location = new System.Drawing.Point(620, 19);
            this.SearchServiceBtn.Name = "SearchServiceBtn";
            this.SearchServiceBtn.Size = new System.Drawing.Size(180, 36);
            this.SearchServiceBtn.TabIndex = 9;
            this.SearchServiceBtn.Text = "Search";
            this.SearchServiceBtn.Click += new System.EventHandler(this.SearchServiceBtn_Click);
            // 
            // SearchServiceTxtB
            // 
            this.SearchServiceTxtB.Animated = true;
            this.SearchServiceTxtB.AutoRoundedCorners = true;
            this.SearchServiceTxtB.BorderRadius = 17;
            this.SearchServiceTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchServiceTxtB.DefaultText = "";
            this.SearchServiceTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchServiceTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchServiceTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchServiceTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchServiceTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchServiceTxtB.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.SearchServiceTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchServiceTxtB.Location = new System.Drawing.Point(806, 19);
            this.SearchServiceTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchServiceTxtB.Name = "SearchServiceTxtB";
            this.SearchServiceTxtB.PasswordChar = '\0';
            this.SearchServiceTxtB.PlaceholderText = "";
            this.SearchServiceTxtB.SelectedText = "";
            this.SearchServiceTxtB.Size = new System.Drawing.Size(474, 36);
            this.SearchServiceTxtB.TabIndex = 8;
            // 
            // ServiceFL
            // 
            this.ServiceFL.BackColor = System.Drawing.Color.White;
            this.ServiceFL.Location = new System.Drawing.Point(14, 80);
            this.ServiceFL.Name = "ServiceFL";
            this.ServiceFL.Size = new System.Drawing.Size(1266, 750);
            this.ServiceFL.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.CancelBtn);
            this.guna2Panel1.Controls.Add(this.AppointmentDateTxtB);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.ServicesGDGVVControl);
            this.guna2Panel1.Controls.Add(this.AddLServiceListBtn);
            this.guna2Panel1.Controls.Add(this.transactionIDTxtB);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.ServiceAmountTxtB);
            this.guna2Panel1.Controls.Add(this.CServiceTxtB);
            this.guna2Panel1.Controls.Add(this.ServiceTxtB);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.PEmployeeComB);
            this.guna2Panel1.Controls.Add(this.CustomerPhoneNTxtB);
            this.guna2Panel1.Controls.Add(this.CustomerAgeTxtB);
            this.guna2Panel1.Controls.Add(this.CustomerNameTxtB);
            this.guna2Panel1.Controls.Add(this.ProcessCustomerBtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1298, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(606, 820);
            this.guna2Panel1.TabIndex = 12;
            // 
            // AppointmentDateTxtB
            // 
            this.AppointmentDateTxtB.AutoRoundedCorners = true;
            this.AppointmentDateTxtB.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentDateTxtB.BorderRadius = 17;
            this.AppointmentDateTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppointmentDateTxtB.DefaultText = "";
            this.AppointmentDateTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AppointmentDateTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AppointmentDateTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppointmentDateTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppointmentDateTxtB.Enabled = false;
            this.AppointmentDateTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppointmentDateTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDateTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppointmentDateTxtB.Location = new System.Drawing.Point(265, 171);
            this.AppointmentDateTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.AppointmentDateTxtB.Name = "AppointmentDateTxtB";
            this.AppointmentDateTxtB.PasswordChar = '\0';
            this.AppointmentDateTxtB.PlaceholderText = "";
            this.AppointmentDateTxtB.ReadOnly = true;
            this.AppointmentDateTxtB.SelectedText = "";
            this.AppointmentDateTxtB.Size = new System.Drawing.Size(259, 36);
            this.AppointmentDateTxtB.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Appointment Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServicesGDGVVControl
            // 
            this.ServicesGDGVVControl.AllowUserToAddRows = false;
            this.ServicesGDGVVControl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ServicesGDGVVControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesGDGVVControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ServicesGDGVVControl.ColumnHeadersHeight = 28;
            this.ServicesGDGVVControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServicesGDGVVControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTypeCol,
            this.SNameCol,
            this.PrefEmpCol,
            this.AmountCol,
            this.QueNumCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesGDGVVControl.DefaultCellStyle = dataGridViewCellStyle3;
            this.ServicesGDGVVControl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGDGVVControl.Location = new System.Drawing.Point(34, 229);
            this.ServicesGDGVVControl.Name = "ServicesGDGVVControl";
            this.ServicesGDGVVControl.ReadOnly = true;
            this.ServicesGDGVVControl.RowHeadersVisible = false;
            this.ServicesGDGVVControl.Size = new System.Drawing.Size(535, 311);
            this.ServicesGDGVVControl.TabIndex = 24;
            this.ServicesGDGVVControl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServicesGDGVVControl.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServicesGDGVVControl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServicesGDGVVControl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServicesGDGVVControl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServicesGDGVVControl.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ServicesGDGVVControl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGDGVVControl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServicesGDGVVControl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServicesGDGVVControl.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesGDGVVControl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServicesGDGVVControl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServicesGDGVVControl.ThemeStyle.HeaderStyle.Height = 28;
            this.ServicesGDGVVControl.ThemeStyle.ReadOnly = true;
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.Height = 22;
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGDGVVControl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ServiceTypeCol
            // 
            this.ServiceTypeCol.HeaderText = "ServiceType";
            this.ServiceTypeCol.Name = "ServiceTypeCol";
            this.ServiceTypeCol.ReadOnly = true;
            // 
            // SNameCol
            // 
            this.SNameCol.HeaderText = "Service Name";
            this.SNameCol.Name = "SNameCol";
            this.SNameCol.ReadOnly = true;
            // 
            // PrefEmpCol
            // 
            this.PrefEmpCol.HeaderText = "Preferred Employee";
            this.PrefEmpCol.Name = "PrefEmpCol";
            this.PrefEmpCol.ReadOnly = true;
            // 
            // AmountCol
            // 
            this.AmountCol.HeaderText = "Amount";
            this.AmountCol.Name = "AmountCol";
            this.AmountCol.ReadOnly = true;
            // 
            // QueNumCol
            // 
            this.QueNumCol.HeaderText = "Queue Number";
            this.QueNumCol.Name = "QueNumCol";
            this.QueNumCol.ReadOnly = true;
            // 
            // AddLServiceListBtn
            // 
            this.AddLServiceListBtn.Animated = true;
            this.AddLServiceListBtn.AutoRoundedCorners = true;
            this.AddLServiceListBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddLServiceListBtn.BorderRadius = 30;
            this.AddLServiceListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddLServiceListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddLServiceListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddLServiceListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddLServiceListBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.AddLServiceListBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLServiceListBtn.ForeColor = System.Drawing.Color.White;
            this.AddLServiceListBtn.Location = new System.Drawing.Point(13, 745);
            this.AddLServiceListBtn.Name = "AddLServiceListBtn";
            this.AddLServiceListBtn.Size = new System.Drawing.Size(190, 62);
            this.AddLServiceListBtn.TabIndex = 23;
            this.AddLServiceListBtn.Text = "Add To List";
            this.AddLServiceListBtn.UseTransparentBackground = true;
            this.AddLServiceListBtn.Click += new System.EventHandler(this.AddLServiceListBtn_Click);
            // 
            // transactionIDTxtB
            // 
            this.transactionIDTxtB.AutoRoundedCorners = true;
            this.transactionIDTxtB.BackColor = System.Drawing.Color.Transparent;
            this.transactionIDTxtB.BorderRadius = 17;
            this.transactionIDTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transactionIDTxtB.DefaultText = "";
            this.transactionIDTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transactionIDTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transactionIDTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transactionIDTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transactionIDTxtB.Enabled = false;
            this.transactionIDTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transactionIDTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIDTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transactionIDTxtB.Location = new System.Drawing.Point(19, 171);
            this.transactionIDTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.transactionIDTxtB.Name = "transactionIDTxtB";
            this.transactionIDTxtB.PasswordChar = '\0';
            this.transactionIDTxtB.PlaceholderText = "";
            this.transactionIDTxtB.ReadOnly = true;
            this.transactionIDTxtB.SelectedText = "";
            this.transactionIDTxtB.Size = new System.Drawing.Size(215, 36);
            this.transactionIDTxtB.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "Transaction ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "Amount (₱)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceAmountTxtB
            // 
            this.ServiceAmountTxtB.AutoRoundedCorners = true;
            this.ServiceAmountTxtB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceAmountTxtB.BorderRadius = 17;
            this.ServiceAmountTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceAmountTxtB.DefaultText = "";
            this.ServiceAmountTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceAmountTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceAmountTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceAmountTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceAmountTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceAmountTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceAmountTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceAmountTxtB.Location = new System.Drawing.Point(419, 598);
            this.ServiceAmountTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.ServiceAmountTxtB.Name = "ServiceAmountTxtB";
            this.ServiceAmountTxtB.PasswordChar = '\0';
            this.ServiceAmountTxtB.PlaceholderText = "";
            this.ServiceAmountTxtB.ReadOnly = true;
            this.ServiceAmountTxtB.SelectedText = "";
            this.ServiceAmountTxtB.Size = new System.Drawing.Size(150, 36);
            this.ServiceAmountTxtB.TabIndex = 19;
            // 
            // CServiceTxtB
            // 
            this.CServiceTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CServiceTxtB.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CServiceTxtB.Location = new System.Drawing.Point(29, 555);
            this.CServiceTxtB.Name = "CServiceTxtB";
            this.CServiceTxtB.Size = new System.Drawing.Size(104, 38);
            this.CServiceTxtB.TabIndex = 18;
            this.CServiceTxtB.Text = "Service";
            this.CServiceTxtB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceTxtB
            // 
            this.ServiceTxtB.AutoRoundedCorners = true;
            this.ServiceTxtB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTxtB.BorderRadius = 17;
            this.ServiceTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceTxtB.DefaultText = "";
            this.ServiceTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTxtB.Location = new System.Drawing.Point(34, 598);
            this.ServiceTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.ServiceTxtB.Name = "ServiceTxtB";
            this.ServiceTxtB.PasswordChar = '\0';
            this.ServiceTxtB.PlaceholderText = "";
            this.ServiceTxtB.ReadOnly = true;
            this.ServiceTxtB.SelectedText = "";
            this.ServiceTxtB.Size = new System.Drawing.Size(331, 36);
            this.ServiceTxtB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preferred Employee";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PEmployeeComB
            // 
            this.PEmployeeComB.AutoRoundedCorners = true;
            this.PEmployeeComB.BackColor = System.Drawing.Color.Transparent;
            this.PEmployeeComB.BorderRadius = 17;
            this.PEmployeeComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PEmployeeComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PEmployeeComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PEmployeeComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PEmployeeComB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEmployeeComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PEmployeeComB.ItemHeight = 30;
            this.PEmployeeComB.Location = new System.Drawing.Point(34, 685);
            this.PEmployeeComB.Name = "PEmployeeComB";
            this.PEmployeeComB.Size = new System.Drawing.Size(328, 36);
            this.PEmployeeComB.TabIndex = 9;
            this.PEmployeeComB.SelectedIndexChanged += new System.EventHandler(this.PEmployeeComB_SelectedIndexChanged);
            // 
            // CustomerPhoneNTxtB
            // 
            this.CustomerPhoneNTxtB.AutoRoundedCorners = true;
            this.CustomerPhoneNTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPhoneNTxtB.BorderRadius = 17;
            this.CustomerPhoneNTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhoneNTxtB.DefaultText = "";
            this.CustomerPhoneNTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerPhoneNTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerPhoneNTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhoneNTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhoneNTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhoneNTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhoneNTxtB.Location = new System.Drawing.Point(405, 92);
            this.CustomerPhoneNTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerPhoneNTxtB.Name = "CustomerPhoneNTxtB";
            this.CustomerPhoneNTxtB.PasswordChar = '\0';
            this.CustomerPhoneNTxtB.PlaceholderText = "";
            this.CustomerPhoneNTxtB.SelectedText = "";
            this.CustomerPhoneNTxtB.Size = new System.Drawing.Size(181, 36);
            this.CustomerPhoneNTxtB.TabIndex = 3;
            // 
            // CustomerAgeTxtB
            // 
            this.CustomerAgeTxtB.AutoRoundedCorners = true;
            this.CustomerAgeTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerAgeTxtB.BorderRadius = 17;
            this.CustomerAgeTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerAgeTxtB.DefaultText = "";
            this.CustomerAgeTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerAgeTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerAgeTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerAgeTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerAgeTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAgeTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAgeTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAgeTxtB.Location = new System.Drawing.Point(305, 92);
            this.CustomerAgeTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerAgeTxtB.Name = "CustomerAgeTxtB";
            this.CustomerAgeTxtB.PasswordChar = '\0';
            this.CustomerAgeTxtB.PlaceholderText = "";
            this.CustomerAgeTxtB.SelectedText = "";
            this.CustomerAgeTxtB.Size = new System.Drawing.Size(83, 36);
            this.CustomerAgeTxtB.TabIndex = 2;
            // 
            // CustomerNameTxtB
            // 
            this.CustomerNameTxtB.AutoRoundedCorners = true;
            this.CustomerNameTxtB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameTxtB.BorderRadius = 17;
            this.CustomerNameTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTxtB.DefaultText = "";
            this.CustomerNameTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxtB.Location = new System.Drawing.Point(19, 92);
            this.CustomerNameTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerNameTxtB.Name = "CustomerNameTxtB";
            this.CustomerNameTxtB.PasswordChar = '\0';
            this.CustomerNameTxtB.PlaceholderText = "";
            this.CustomerNameTxtB.SelectedText = "";
            this.CustomerNameTxtB.Size = new System.Drawing.Size(272, 36);
            this.CustomerNameTxtB.TabIndex = 1;
            // 
            // ProcessCustomerBtn
            // 
            this.ProcessCustomerBtn.Animated = true;
            this.ProcessCustomerBtn.AutoRoundedCorners = true;
            this.ProcessCustomerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProcessCustomerBtn.BorderRadius = 30;
            this.ProcessCustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProcessCustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProcessCustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProcessCustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProcessCustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ProcessCustomerBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.ProcessCustomerBtn.Location = new System.Drawing.Point(207, 745);
            this.ProcessCustomerBtn.Name = "ProcessCustomerBtn";
            this.ProcessCustomerBtn.Size = new System.Drawing.Size(190, 62);
            this.ProcessCustomerBtn.TabIndex = 0;
            this.ProcessCustomerBtn.Text = "Activate Appointment";
            this.ProcessCustomerBtn.UseTransparentBackground = true;
            this.ProcessCustomerBtn.Click += new System.EventHandler(this.ProcessCustomerBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Animated = true;
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderRadius = 30;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.Red;
            this.CancelBtn.Font = new System.Drawing.Font("Stanberry", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(400, 745);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(190, 62);
            this.CancelBtn.TabIndex = 27;
            this.CancelBtn.Text = "Cancel Edit";
            this.CancelBtn.UseTransparentBackground = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ServiceFilterComB);
            this.Controls.Add(this.FilterServiceComboBox);
            this.Controls.Add(this.SearchServiceBtn);
            this.Controls.Add(this.SearchServiceTxtB);
            this.Controls.Add(this.ServiceFL);
            this.Name = "EditAppointmentUserControl";
            this.Size = new System.Drawing.Size(1920, 843);
            this.Load += new System.EventHandler(this.EditAppointmentUserControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGDGVVControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox ServiceFilterComB;
        private System.Windows.Forms.Label FilterServiceComboBox;
        private Guna.UI2.WinForms.Guna2Button SearchServiceBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchServiceTxtB;
        private System.Windows.Forms.FlowLayoutPanel ServiceFL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ServicesGDGVVControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrefEmpCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueNumCol;
        private Guna.UI2.WinForms.Guna2Button AddLServiceListBtn;
        public Guna.UI2.WinForms.Guna2TextBox transactionIDTxtB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox ServiceAmountTxtB;
        private System.Windows.Forms.Label CServiceTxtB;
        public Guna.UI2.WinForms.Guna2TextBox ServiceTxtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox PEmployeeComB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerPhoneNTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerAgeTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerNameTxtB;
        private Guna.UI2.WinForms.Guna2Button ProcessCustomerBtn;
        public Guna.UI2.WinForms.Guna2TextBox AppointmentDateTxtB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
    }
}
