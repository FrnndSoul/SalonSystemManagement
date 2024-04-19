﻿namespace salesreport.UserControls
{
    partial class ShipmentReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonthlyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.WeeklyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.DayFilter = new Guna.UI2.WinForms.Guna2Button();
            this.NoFilter = new Guna.UI2.WinForms.Guna2Button();
            this.RangeFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShipmentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShipmentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PageBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NextPage = new Guna.UI2.WinForms.Guna2Button();
            this.BackPage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthlyFilter
            // 
            this.MonthlyFilter.Animated = true;
            this.MonthlyFilter.AutoRoundedCorners = true;
            this.MonthlyFilter.BorderRadius = 20;
            this.MonthlyFilter.BorderThickness = 1;
            this.MonthlyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MonthlyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MonthlyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MonthlyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MonthlyFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MonthlyFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.MonthlyFilter.ForeColor = System.Drawing.Color.Black;
            this.MonthlyFilter.Location = new System.Drawing.Point(909, 62);
            this.MonthlyFilter.Name = "MonthlyFilter";
            this.MonthlyFilter.Size = new System.Drawing.Size(163, 42);
            this.MonthlyFilter.TabIndex = 26;
            this.MonthlyFilter.Text = "Monthly";
            this.MonthlyFilter.Click += new System.EventHandler(this.MonthlyFilter_Click);
            // 
            // WeeklyFilter
            // 
            this.WeeklyFilter.Animated = true;
            this.WeeklyFilter.AutoRoundedCorners = true;
            this.WeeklyFilter.BorderRadius = 20;
            this.WeeklyFilter.BorderThickness = 1;
            this.WeeklyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WeeklyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WeeklyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WeeklyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WeeklyFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WeeklyFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.WeeklyFilter.ForeColor = System.Drawing.Color.Black;
            this.WeeklyFilter.Location = new System.Drawing.Point(770, 62);
            this.WeeklyFilter.Name = "WeeklyFilter";
            this.WeeklyFilter.Size = new System.Drawing.Size(133, 42);
            this.WeeklyFilter.TabIndex = 25;
            this.WeeklyFilter.Text = "Weekly";
            this.WeeklyFilter.Click += new System.EventHandler(this.WeeklyFilter_Click);
            // 
            // DayFilter
            // 
            this.DayFilter.Animated = true;
            this.DayFilter.AutoRoundedCorners = true;
            this.DayFilter.BorderRadius = 20;
            this.DayFilter.BorderThickness = 1;
            this.DayFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DayFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DayFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DayFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DayFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DayFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.DayFilter.ForeColor = System.Drawing.Color.Black;
            this.DayFilter.Location = new System.Drawing.Point(647, 62);
            this.DayFilter.Name = "DayFilter";
            this.DayFilter.Size = new System.Drawing.Size(117, 42);
            this.DayFilter.TabIndex = 24;
            this.DayFilter.Text = "Day";
            this.DayFilter.Click += new System.EventHandler(this.DayFilter_Click);
            // 
            // NoFilter
            // 
            this.NoFilter.Animated = true;
            this.NoFilter.AutoRoundedCorners = true;
            this.NoFilter.BorderRadius = 20;
            this.NoFilter.BorderThickness = 1;
            this.NoFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NoFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NoFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NoFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NoFilter.Enabled = false;
            this.NoFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NoFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.NoFilter.ForeColor = System.Drawing.Color.Black;
            this.NoFilter.Location = new System.Drawing.Point(409, 62);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(232, 42);
            this.NoFilter.TabIndex = 23;
            this.NoFilter.Text = "No Date Filter";
            this.NoFilter.Click += new System.EventHandler(this.NoFilter_Click);
            // 
            // RangeFilter
            // 
            this.RangeFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RangeFilter.BorderThickness = 1;
            this.RangeFilter.Checked = true;
            this.RangeFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RangeFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.RangeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RangeFilter.Location = new System.Drawing.Point(135, 62);
            this.RangeFilter.MaxDate = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            this.RangeFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RangeFilter.Name = "RangeFilter";
            this.RangeFilter.Size = new System.Drawing.Size(257, 42);
            this.RangeFilter.TabIndex = 22;
            this.RangeFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RangeFilter.Value = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            // 
            // searchBox
            // 
            this.searchBox.Animated = true;
            this.searchBox.AutoRoundedCorners = true;
            this.searchBox.BorderColor = System.Drawing.Color.Black;
            this.searchBox.BorderRadius = 20;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(135, 114);
            this.searchBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(937, 42);
            this.searchBox.TabIndex = 20;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ShipmentChart
            // 
            this.ShipmentChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShipmentChart.BorderlineColor = System.Drawing.Color.Black;
            this.ShipmentChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ShipmentChart.Location = new System.Drawing.Point(135, 493);
            this.ShipmentChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipmentChart.Name = "ShipmentChart";
            this.ShipmentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ShipmentChart.Size = new System.Drawing.Size(1175, 315);
            this.ShipmentChart.TabIndex = 18;
            this.ShipmentChart.Text = "chart1";
            // 
            // ShipmentDGV
            // 
            this.ShipmentDGV.AllowUserToAddRows = false;
            this.ShipmentDGV.AllowUserToDeleteRows = false;
            this.ShipmentDGV.AllowUserToResizeColumns = false;
            this.ShipmentDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ShipmentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ShipmentDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShipmentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ShipmentDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShipmentDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.ShipmentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShipmentDGV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ShipmentDGV.Location = new System.Drawing.Point(135, 168);
            this.ShipmentDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipmentDGV.MultiSelect = false;
            this.ShipmentDGV.Name = "ShipmentDGV";
            this.ShipmentDGV.ReadOnly = true;
            this.ShipmentDGV.RowHeadersVisible = false;
            this.ShipmentDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShipmentDGV.Size = new System.Drawing.Size(1175, 315);
            this.ShipmentDGV.TabIndex = 17;
            this.ShipmentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ShipmentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ShipmentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ShipmentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ShipmentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ShipmentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ShipmentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShipmentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShipmentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShipmentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ShipmentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShipmentDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ShipmentDGV.ThemeStyle.ReadOnly = true;
            this.ShipmentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ShipmentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShipmentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShipmentDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ShipmentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShipmentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PageBox
            // 
            this.PageBox.BorderColor = System.Drawing.Color.Black;
            this.PageBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PageBox.DefaultText = "";
            this.PageBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PageBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PageBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PageBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PageBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PageBox.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.PageBox.ForeColor = System.Drawing.Color.Black;
            this.PageBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PageBox.Location = new System.Drawing.Point(1132, 114);
            this.PageBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PageBox.Name = "PageBox";
            this.PageBox.PasswordChar = '\0';
            this.PageBox.PlaceholderText = "#/#";
            this.PageBox.ReadOnly = true;
            this.PageBox.SelectedText = "";
            this.PageBox.Size = new System.Drawing.Size(127, 42);
            this.PageBox.TabIndex = 29;
            this.PageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextPage
            // 
            this.NextPage.BorderThickness = 1;
            this.NextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NextPage.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.NextPage.ForeColor = System.Drawing.Color.Black;
            this.NextPage.Location = new System.Drawing.Point(1268, 114);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(42, 42);
            this.NextPage.TabIndex = 28;
            this.NextPage.Text = ">";
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // BackPage
            // 
            this.BackPage.BorderThickness = 1;
            this.BackPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackPage.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.BackPage.ForeColor = System.Drawing.Color.Black;
            this.BackPage.Location = new System.Drawing.Point(1081, 114);
            this.BackPage.Name = "BackPage";
            this.BackPage.Size = new System.Drawing.Size(42, 42);
            this.BackPage.TabIndex = 27;
            this.BackPage.Text = "<";
            this.BackPage.Click += new System.EventHandler(this.BackPage_Click);
            // 
            // ShipmentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PageBox);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.BackPage);
            this.Controls.Add(this.MonthlyFilter);
            this.Controls.Add(this.WeeklyFilter);
            this.Controls.Add(this.DayFilter);
            this.Controls.Add(this.NoFilter);
            this.Controls.Add(this.RangeFilter);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ShipmentChart);
            this.Controls.Add(this.ShipmentDGV);
            this.Name = "ShipmentReports";
            this.Size = new System.Drawing.Size(1445, 870);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button MonthlyFilter;
        private Guna.UI2.WinForms.Guna2Button WeeklyFilter;
        private Guna.UI2.WinForms.Guna2Button DayFilter;
        private Guna.UI2.WinForms.Guna2Button NoFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker RangeFilter;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ShipmentChart;
        public Guna.UI2.WinForms.Guna2DataGridView ShipmentDGV;
        private Guna.UI2.WinForms.Guna2TextBox PageBox;
        private Guna.UI2.WinForms.Guna2Button NextPage;
        private Guna.UI2.WinForms.Guna2Button BackPage;
    }
}
