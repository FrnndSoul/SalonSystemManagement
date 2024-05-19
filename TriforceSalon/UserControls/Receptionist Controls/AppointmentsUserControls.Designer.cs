namespace TriforceSalon.UserControls.Receptionist_Controls
{
    partial class AppointmentsUserControls
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
            this.AppointmentLIstFL = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerIDTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchIDBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AppointmentDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SearchToggleBtn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.DateLbl = new System.Windows.Forms.Label();
            this.NameOrIDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppointmentLIstFL
            // 
            this.AppointmentLIstFL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.AppointmentLIstFL.Location = new System.Drawing.Point(88, 100);
            this.AppointmentLIstFL.Name = "AppointmentLIstFL";
            this.AppointmentLIstFL.Size = new System.Drawing.Size(1747, 682);
            this.AppointmentLIstFL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stanberry", 48F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Lists";
            // 
            // CustomerIDTxtB
            // 
            this.CustomerIDTxtB.AutoRoundedCorners = true;
            this.CustomerIDTxtB.BorderRadius = 17;
            this.CustomerIDTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIDTxtB.DefaultText = "";
            this.CustomerIDTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerIDTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerIDTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIDTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIDTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIDTxtB.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CustomerIDTxtB.ForeColor = System.Drawing.Color.Black;
            this.CustomerIDTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIDTxtB.Location = new System.Drawing.Point(901, 53);
            this.CustomerIDTxtB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CustomerIDTxtB.Name = "CustomerIDTxtB";
            this.CustomerIDTxtB.PasswordChar = '\0';
            this.CustomerIDTxtB.PlaceholderText = "Search ID or Name";
            this.CustomerIDTxtB.SelectedText = "";
            this.CustomerIDTxtB.Size = new System.Drawing.Size(383, 36);
            this.CustomerIDTxtB.TabIndex = 2;
            // 
            // SearchIDBtn
            // 
            this.SearchIDBtn.AutoRoundedCorners = true;
            this.SearchIDBtn.BorderRadius = 17;
            this.SearchIDBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchIDBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchIDBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchIDBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchIDBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.SearchIDBtn.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.SearchIDBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchIDBtn.Location = new System.Drawing.Point(1292, 53);
            this.SearchIDBtn.Name = "SearchIDBtn";
            this.SearchIDBtn.Size = new System.Drawing.Size(202, 36);
            this.SearchIDBtn.TabIndex = 3;
            this.SearchIDBtn.Text = "Search";
            this.SearchIDBtn.Click += new System.EventHandler(this.SearchIDBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AutoRoundedCorners = true;
            this.RefreshBtn.BorderRadius = 19;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Stanberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(1567, 788);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(314, 41);
            this.RefreshBtn.TabIndex = 6;
            this.RefreshBtn.Text = "Refresh List";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.AutoRoundedCorners = true;
            this.AppointmentDatePicker.BorderRadius = 17;
            this.AppointmentDatePicker.Checked = true;
            this.AppointmentDatePicker.FillColor = System.Drawing.Color.White;
            this.AppointmentDatePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.AppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.AppointmentDatePicker.Location = new System.Drawing.Point(1500, 53);
            this.AppointmentDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AppointmentDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(381, 36);
            this.AppointmentDatePicker.TabIndex = 7;
            this.AppointmentDatePicker.Value = new System.DateTime(2024, 4, 5, 8, 37, 47, 919);
            // 
            // SearchToggleBtn
            // 
            this.SearchToggleBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchToggleBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchToggleBtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SearchToggleBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SearchToggleBtn.Location = new System.Drawing.Point(1359, 12);
            this.SearchToggleBtn.Name = "SearchToggleBtn";
            this.SearchToggleBtn.Size = new System.Drawing.Size(68, 31);
            this.SearchToggleBtn.TabIndex = 8;
            this.SearchToggleBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SearchToggleBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SearchToggleBtn.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SearchToggleBtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SearchToggleBtn.CheckedChanged += new System.EventHandler(this.SearchToggleBtn_CheckedChanged);
            // 
            // DateLbl
            // 
            this.DateLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(1495, 12);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(140, 31);
            this.DateLbl.TabIndex = 9;
            this.DateLbl.Text = "Search by Date";
            this.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameOrIDLbl
            // 
            this.NameOrIDLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.NameOrIDLbl.ForeColor = System.Drawing.Color.White;
            this.NameOrIDLbl.Location = new System.Drawing.Point(1073, 12);
            this.NameOrIDLbl.Name = "NameOrIDLbl";
            this.NameOrIDLbl.Size = new System.Drawing.Size(211, 31);
            this.NameOrIDLbl.TabIndex = 10;
            this.NameOrIDLbl.Text = "Search by Name or iD";
            this.NameOrIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AppointmentsUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.AppointmentDatePicker);
            this.Controls.Add(this.NameOrIDLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.SearchToggleBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchIDBtn);
            this.Controls.Add(this.CustomerIDTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentLIstFL);
            this.Name = "AppointmentsUserControls";
            this.Size = new System.Drawing.Size(1920, 843);
            this.Load += new System.EventHandler(this.AppointmentsUserControls_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AppointmentLIstFL;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox CustomerIDTxtB;
        private Guna.UI2.WinForms.Guna2Button SearchIDBtn;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker AppointmentDatePicker;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SearchToggleBtn;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label NameOrIDLbl;
    }
}
