namespace salesreport.UserControls
{
    partial class ServiceRetention
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TypeFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadAllPanel = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ServiceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ServiceDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MonthlyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.WeeklyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.DayFilter = new Guna.UI2.WinForms.Guna2Button();
            this.NoFilter = new Guna.UI2.WinForms.Guna2Button();
            this.RangeFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowVoided = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TypeFLP.SuspendLayout();
            this.LoadAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeFLP
            // 
            this.TypeFLP.AutoScroll = true;
            this.TypeFLP.BackColor = System.Drawing.Color.White;
            this.TypeFLP.Controls.Add(this.LoadAllPanel);
            this.TypeFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TypeFLP.Location = new System.Drawing.Point(4, 86);
            this.TypeFLP.Name = "TypeFLP";
            this.TypeFLP.Size = new System.Drawing.Size(256, 779);
            this.TypeFLP.TabIndex = 14;
            // 
            // LoadAllPanel
            // 
            this.LoadAllPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoadAllPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadAllPanel.Controls.Add(this.LabelTitle);
            this.LoadAllPanel.Location = new System.Drawing.Point(3, 3);
            this.LoadAllPanel.Name = "LoadAllPanel";
            this.LoadAllPanel.Size = new System.Drawing.Size(250, 94);
            this.LoadAllPanel.TabIndex = 5;
            this.LoadAllPanel.Click += new System.EventHandler(this.LoadAllPanel_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Stanberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(35, 11);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(187, 68);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Load All\r\nService Types";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
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
            this.searchBox.Location = new System.Drawing.Point(934, 6);
            this.searchBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(504, 42);
            this.searchBox.TabIndex = 13;
            // 
            // ServiceChart
            // 
            this.ServiceChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ServiceChart.BorderlineColor = System.Drawing.Color.Black;
            this.ServiceChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ServiceChart.Location = new System.Drawing.Point(265, 447);
            this.ServiceChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServiceChart.Name = "ServiceChart";
            this.ServiceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ServiceChart.Size = new System.Drawing.Size(1173, 418);
            this.ServiceChart.TabIndex = 12;
            this.ServiceChart.Text = "chart1";
            // 
            // ServiceDGV
            // 
            this.ServiceDGV.AllowUserToAddRows = false;
            this.ServiceDGV.AllowUserToDeleteRows = false;
            this.ServiceDGV.AllowUserToResizeColumns = false;
            this.ServiceDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.ServiceDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.ServiceDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.ServiceDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceDGV.DefaultCellStyle = dataGridViewCellStyle21;
            this.ServiceDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceDGV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ServiceDGV.Location = new System.Drawing.Point(265, 56);
            this.ServiceDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServiceDGV.MultiSelect = false;
            this.ServiceDGV.Name = "ServiceDGV";
            this.ServiceDGV.ReadOnly = true;
            this.ServiceDGV.RowHeadersVisible = false;
            this.ServiceDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ServiceDGV.Size = new System.Drawing.Size(1175, 381);
            this.ServiceDGV.TabIndex = 11;
            this.ServiceDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServiceDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServiceDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServiceDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServiceDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ServiceDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServiceDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServiceDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServiceDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ServiceDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ServiceDGV.ThemeStyle.ReadOnly = true;
            this.ServiceDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ServiceDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.MonthlyFilter.Location = new System.Drawing.Point(765, 8);
            this.MonthlyFilter.Name = "MonthlyFilter";
            this.MonthlyFilter.Size = new System.Drawing.Size(163, 42);
            this.MonthlyFilter.TabIndex = 20;
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
            this.WeeklyFilter.Location = new System.Drawing.Point(626, 8);
            this.WeeklyFilter.Name = "WeeklyFilter";
            this.WeeklyFilter.Size = new System.Drawing.Size(133, 42);
            this.WeeklyFilter.TabIndex = 19;
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
            this.DayFilter.Location = new System.Drawing.Point(503, 8);
            this.DayFilter.Name = "DayFilter";
            this.DayFilter.Size = new System.Drawing.Size(117, 42);
            this.DayFilter.TabIndex = 18;
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
            this.NoFilter.Location = new System.Drawing.Point(265, 8);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(232, 42);
            this.NoFilter.TabIndex = 17;
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
            this.RangeFilter.Location = new System.Drawing.Point(4, 8);
            this.RangeFilter.MaxDate = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            this.RangeFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RangeFilter.Name = "RangeFilter";
            this.RangeFilter.Size = new System.Drawing.Size(257, 42);
            this.RangeFilter.TabIndex = 16;
            this.RangeFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RangeFilter.Value = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stanberry", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Toggle Voided Orders:";
            // 
            // ShowVoided
            // 
            this.ShowVoided.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowVoided.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowVoided.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowVoided.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowVoided.Location = new System.Drawing.Point(211, 56);
            this.ShowVoided.Name = "ShowVoided";
            this.ShowVoided.Size = new System.Drawing.Size(47, 24);
            this.ShowVoided.TabIndex = 21;
            this.ShowVoided.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowVoided.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowVoided.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowVoided.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowVoided.CheckedChanged += new System.EventHandler(this.ShowVoided_CheckedChanged);
            // 
            // ServiceRetention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowVoided);
            this.Controls.Add(this.TypeFLP);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ServiceChart);
            this.Controls.Add(this.ServiceDGV);
            this.Controls.Add(this.MonthlyFilter);
            this.Controls.Add(this.WeeklyFilter);
            this.Controls.Add(this.DayFilter);
            this.Controls.Add(this.NoFilter);
            this.Controls.Add(this.RangeFilter);
            this.Name = "ServiceRetention";
            this.Size = new System.Drawing.Size(1445, 870);
            this.TypeFLP.ResumeLayout(false);
            this.LoadAllPanel.ResumeLayout(false);
            this.LoadAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TypeFLP;
        private System.Windows.Forms.Panel LoadAllPanel;
        private System.Windows.Forms.Label LabelTitle;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ServiceChart;
        public Guna.UI2.WinForms.Guna2DataGridView ServiceDGV;
        private Guna.UI2.WinForms.Guna2Button MonthlyFilter;
        private Guna.UI2.WinForms.Guna2Button WeeklyFilter;
        private Guna.UI2.WinForms.Guna2Button DayFilter;
        private Guna.UI2.WinForms.Guna2Button NoFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker RangeFilter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ShowVoided;
    }
}
