﻿namespace salesreport.UserControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonthlyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.WeeklyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.DayFilter = new Guna.UI2.WinForms.Guna2Button();
            this.NoFilter = new Guna.UI2.WinForms.Guna2Button();
            this.RangeFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PageBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NextPage = new Guna.UI2.WinForms.Guna2Button();
            this.BackPage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).BeginInit();
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
            this.MonthlyFilter.Location = new System.Drawing.Point(913, 66);
            this.MonthlyFilter.Name = "MonthlyFilter";
            this.MonthlyFilter.Size = new System.Drawing.Size(163, 42);
            this.MonthlyFilter.TabIndex = 33;
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
            this.WeeklyFilter.Location = new System.Drawing.Point(774, 66);
            this.WeeklyFilter.Name = "WeeklyFilter";
            this.WeeklyFilter.Size = new System.Drawing.Size(133, 42);
            this.WeeklyFilter.TabIndex = 32;
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
            this.DayFilter.Location = new System.Drawing.Point(651, 66);
            this.DayFilter.Name = "DayFilter";
            this.DayFilter.Size = new System.Drawing.Size(117, 42);
            this.DayFilter.TabIndex = 31;
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
            this.NoFilter.Location = new System.Drawing.Point(413, 66);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(232, 42);
            this.NoFilter.TabIndex = 30;
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
            this.RangeFilter.Location = new System.Drawing.Point(139, 66);
            this.RangeFilter.MaxDate = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            this.RangeFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RangeFilter.Name = "RangeFilter";
            this.RangeFilter.Size = new System.Drawing.Size(257, 42);
            this.RangeFilter.TabIndex = 29;
            this.RangeFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RangeFilter.Value = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            // 
            // SalesChart
            // 
            this.SalesChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SalesChart.BorderlineColor = System.Drawing.Color.Black;
            this.SalesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.SalesChart.Location = new System.Drawing.Point(139, 441);
            this.SalesChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.SalesChart.Size = new System.Drawing.Size(1175, 371);
            this.SalesChart.TabIndex = 28;
            this.SalesChart.Text = "chart1";
            // 
            // SalesDGV
            // 
            this.SalesDGV.AllowUserToAddRows = false;
            this.SalesDGV.AllowUserToDeleteRows = false;
            this.SalesDGV.AllowUserToResizeColumns = false;
            this.SalesDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.SalesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SalesDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SalesDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.SalesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDGV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SalesDGV.Location = new System.Drawing.Point(139, 116);
            this.SalesDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesDGV.MultiSelect = false;
            this.SalesDGV.Name = "SalesDGV";
            this.SalesDGV.ReadOnly = true;
            this.SalesDGV.RowHeadersVisible = false;
            this.SalesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesDGV.Size = new System.Drawing.Size(1175, 315);
            this.SalesDGV.TabIndex = 27;
            this.SalesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SalesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SalesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SalesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SalesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SalesDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.SalesDGV.ThemeStyle.ReadOnly = true;
            this.SalesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SalesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SalesDGV.ThemeStyle.RowsStyle.Height = 22;
            this.SalesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.PageBox.Location = new System.Drawing.Point(1133, 66);
            this.PageBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PageBox.Name = "PageBox";
            this.PageBox.PasswordChar = '\0';
            this.PageBox.PlaceholderText = "#/#";
            this.PageBox.ReadOnly = true;
            this.PageBox.SelectedText = "";
            this.PageBox.Size = new System.Drawing.Size(130, 42);
            this.PageBox.TabIndex = 36;
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
            this.NextPage.Location = new System.Drawing.Point(1272, 66);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(42, 42);
            this.NextPage.TabIndex = 35;
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
            this.BackPage.Location = new System.Drawing.Point(1082, 66);
            this.BackPage.Name = "BackPage";
            this.BackPage.Size = new System.Drawing.Size(42, 42);
            this.BackPage.TabIndex = 34;
            this.BackPage.Text = "<";
            this.BackPage.Click += new System.EventHandler(this.BackPage_Click);
            // 
            // GeneralReport
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
            this.Controls.Add(this.SalesChart);
            this.Controls.Add(this.SalesDGV);
            this.Name = "GeneralReport";
            this.Size = new System.Drawing.Size(1452, 879);
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button MonthlyFilter;
        private Guna.UI2.WinForms.Guna2Button WeeklyFilter;
        private Guna.UI2.WinForms.Guna2Button DayFilter;
        private Guna.UI2.WinForms.Guna2Button NoFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker RangeFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        public Guna.UI2.WinForms.Guna2DataGridView SalesDGV;
        private Guna.UI2.WinForms.Guna2TextBox PageBox;
        private Guna.UI2.WinForms.Guna2Button NextPage;
        private Guna.UI2.WinForms.Guna2Button BackPage;
    }
}
