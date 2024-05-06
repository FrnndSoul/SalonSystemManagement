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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ServiceFL = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ServicePromoTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ActivateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AppointmentDateTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicesGDGVVControl = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefEmpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveServiceCol = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label2 = new System.Windows.Forms.Label();
            this.PEmployeeComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CustomerPhoneNTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerNameTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProcessCustomerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServicePromoComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceTypeComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryFL = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGDGVVControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceFL
            // 
            this.ServiceFL.AutoScroll = true;
            this.ServiceFL.BackColor = System.Drawing.Color.White;
            this.ServiceFL.Location = new System.Drawing.Point(14, 201);
            this.ServiceFL.Name = "ServiceFL";
            this.ServiceFL.Size = new System.Drawing.Size(1266, 629);
            this.ServiceFL.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.ServicePromoComB);
            this.guna2Panel1.Controls.Add(this.ServicePromoTxtB);
            this.guna2Panel1.Controls.Add(this.ActivateBtn);
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
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.PEmployeeComB);
            this.guna2Panel1.Controls.Add(this.CustomerPhoneNTxtB);
            this.guna2Panel1.Controls.Add(this.CustomerNameTxtB);
            this.guna2Panel1.Controls.Add(this.ProcessCustomerBtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1298, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(606, 820);
            this.guna2Panel1.TabIndex = 12;
            // 
            // ServicePromoTxtB
            // 
            this.ServicePromoTxtB.AutoRoundedCorners = true;
            this.ServicePromoTxtB.BackColor = System.Drawing.Color.Transparent;
            this.ServicePromoTxtB.BorderRadius = 13;
            this.ServicePromoTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServicePromoTxtB.DefaultText = "";
            this.ServicePromoTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServicePromoTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServicePromoTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServicePromoTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServicePromoTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServicePromoTxtB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePromoTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServicePromoTxtB.Location = new System.Drawing.Point(540, 552);
            this.ServicePromoTxtB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ServicePromoTxtB.Name = "ServicePromoTxtB";
            this.ServicePromoTxtB.PasswordChar = '\0';
            this.ServicePromoTxtB.PlaceholderText = "Enter Promo Code Here";
            this.ServicePromoTxtB.SelectedText = "";
            this.ServicePromoTxtB.Size = new System.Drawing.Size(29, 36);
            this.ServicePromoTxtB.TabIndex = 49;
            // 
            // ActivateBtn
            // 
            this.ActivateBtn.AutoRoundedCorners = true;
            this.ActivateBtn.BackColor = System.Drawing.Color.Transparent;
            this.ActivateBtn.BorderRadius = 17;
            this.ActivateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ActivateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ActivateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ActivateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ActivateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ActivateBtn.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.ActivateBtn.ForeColor = System.Drawing.Color.White;
            this.ActivateBtn.Location = new System.Drawing.Point(36, 502);
            this.ActivateBtn.Name = "ActivateBtn";
            this.ActivateBtn.Size = new System.Drawing.Size(180, 36);
            this.ActivateBtn.TabIndex = 48;
            this.ActivateBtn.Text = "Avail Promo";
            this.ActivateBtn.Click += new System.EventHandler(this.ActivateBtn_Click);
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
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.ServicesGDGVVControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesGDGVVControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.ServicesGDGVVControl.ColumnHeadersHeight = 28;
            this.ServicesGDGVVControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServicesGDGVVControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTypeCol,
            this.SNameCol,
            this.PrefEmpCol,
            this.AmountCol,
            this.DiscountCol,
            this.RemoveServiceCol,
            this.QueNumCol});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesGDGVVControl.DefaultCellStyle = dataGridViewCellStyle18;
            this.ServicesGDGVVControl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServicesGDGVVControl.Location = new System.Drawing.Point(34, 229);
            this.ServicesGDGVVControl.Name = "ServicesGDGVVControl";
            this.ServicesGDGVVControl.ReadOnly = true;
            this.ServicesGDGVVControl.RowHeadersVisible = false;
            this.ServicesGDGVVControl.Size = new System.Drawing.Size(535, 243);
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
            this.ServicesGDGVVControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServicesGDGVVControl_CellContentClick);
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
            // DiscountCol
            // 
            this.DiscountCol.HeaderText = "Discount";
            this.DiscountCol.Name = "DiscountCol";
            this.DiscountCol.ReadOnly = true;
            // 
            // RemoveServiceCol
            // 
            this.RemoveServiceCol.HeaderText = "X";
            this.RemoveServiceCol.Name = "RemoveServiceCol";
            this.RemoveServiceCol.ReadOnly = true;
            // 
            // QueNumCol
            // 
            this.QueNumCol.HeaderText = "Queue Number";
            this.QueNumCol.Name = "QueNumCol";
            this.QueNumCol.ReadOnly = true;
            this.QueNumCol.Visible = false;
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
            this.label4.Location = new System.Drawing.Point(343, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.CustomerPhoneNTxtB.Location = new System.Drawing.Point(343, 92);
            this.CustomerPhoneNTxtB.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerPhoneNTxtB.Name = "CustomerPhoneNTxtB";
            this.CustomerPhoneNTxtB.PasswordChar = '\0';
            this.CustomerPhoneNTxtB.PlaceholderText = "";
            this.CustomerPhoneNTxtB.ReadOnly = true;
            this.CustomerPhoneNTxtB.SelectedText = "";
            this.CustomerPhoneNTxtB.Size = new System.Drawing.Size(181, 36);
            this.CustomerPhoneNTxtB.TabIndex = 3;
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
            this.CustomerNameTxtB.ReadOnly = true;
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
            // ServicePromoComB
            // 
            this.ServicePromoComB.AutoRoundedCorners = true;
            this.ServicePromoComB.BackColor = System.Drawing.Color.Transparent;
            this.ServicePromoComB.BorderRadius = 17;
            this.ServicePromoComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServicePromoComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServicePromoComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServicePromoComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServicePromoComB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServicePromoComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServicePromoComB.ItemHeight = 30;
            this.ServicePromoComB.Location = new System.Drawing.Point(222, 502);
            this.ServicePromoComB.Name = "ServicePromoComB";
            this.ServicePromoComB.Size = new System.Drawing.Size(347, 36);
            this.ServicePromoComB.TabIndex = 50;
            this.ServicePromoComB.SelectedIndexChanged += new System.EventHandler(this.ServicePromoComB_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AutoRoundedCorners = true;
            this.RefreshBtn.BorderRadius = 21;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Stanberry", 15.75F);
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(14, 131);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(217, 45);
            this.RefreshBtn.TabIndex = 54;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ServiceTypeComB
            // 
            this.ServiceTypeComB.AutoRoundedCorners = true;
            this.ServiceTypeComB.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeComB.BorderRadius = 17;
            this.ServiceTypeComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceTypeComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeComB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServiceTypeComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceTypeComB.ItemHeight = 30;
            this.ServiceTypeComB.Location = new System.Drawing.Point(14, 64);
            this.ServiceTypeComB.Name = "ServiceTypeComB";
            this.ServiceTypeComB.Size = new System.Drawing.Size(217, 36);
            this.ServiceTypeComB.TabIndex = 53;
            this.ServiceTypeComB.SelectedIndexChanged += new System.EventHandler(this.ServiceTypeComB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 37);
            this.label3.TabIndex = 52;
            this.label3.Text = "Filter Category:";
            // 
            // CategoryFL
            // 
            this.CategoryFL.AutoScroll = true;
            this.CategoryFL.BackColor = System.Drawing.Color.White;
            this.CategoryFL.Location = new System.Drawing.Point(247, 15);
            this.CategoryFL.Name = "CategoryFL";
            this.CategoryFL.Size = new System.Drawing.Size(1033, 161);
            this.CategoryFL.TabIndex = 51;
            // 
            // EditAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ServiceTypeComB);
            this.Controls.Add(this.ServiceFL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryFL);
            this.Name = "EditAppointmentUserControl";
            this.Size = new System.Drawing.Size(1920, 843);
            this.Load += new System.EventHandler(this.EditAppointmentUserControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGDGVVControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ServiceFL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ServicesGDGVVControl;
        private Guna.UI2.WinForms.Guna2Button AddLServiceListBtn;
        public Guna.UI2.WinForms.Guna2TextBox transactionIDTxtB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox ServiceAmountTxtB;
        private System.Windows.Forms.Label CServiceTxtB;
        public Guna.UI2.WinForms.Guna2TextBox ServiceTxtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox PEmployeeComB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerPhoneNTxtB;
        public Guna.UI2.WinForms.Guna2TextBox CustomerNameTxtB;
        private Guna.UI2.WinForms.Guna2Button ProcessCustomerBtn;
        public Guna.UI2.WinForms.Guna2TextBox AppointmentDateTxtB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2TextBox ServicePromoTxtB;
        private Guna.UI2.WinForms.Guna2Button ActivateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrefEmpCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCol;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveServiceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueNumCol;
        private Guna.UI2.WinForms.Guna2ComboBox ServicePromoComB;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2ComboBox ServiceTypeComB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel CategoryFL;
    }
}
