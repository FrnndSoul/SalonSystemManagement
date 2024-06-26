﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace salesreport.UserControls
{
    public partial class ServiceRetention : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        DataTable currentTable = SalesClass.LoadServiceRetention(filter);
        public static string filter;
        public int pageSize = 15;
        public int currentPage = 1;
        public int totalPages;

        public ServiceRetention()
        {
            InitializeComponent();
            ServiceDGV.DataSource = currentTable;
            LoadCharts();
            RecountPages();
            GetServiceTypeData(TypeFLP);
            RangeFilter.MaxDate = DateTime.Now.AddDays(1);
            RangeFilter.MinDate = DateTime.Now.AddYears(-2);
            RangeFilter.Value = DateTime.Now;
            RangeFilter.Format = DateTimePickerFormat.Custom;
            RangeFilter.CustomFormat = "dd/MM/yyyy";
        }

        public void GetServiceTypeData(FlowLayoutPanel serviceTypeFL)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT ServiceTypeName, ServiceTypeImage, ServiceID FROM service_type";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceTypeImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 250,
                                    Height = 94,
                                    Margin = new Padding(3),
                                    Tag = reader["ServiceID"].ToString(),
                                    BackColor = Color.FromArgb(255, 192, 255),
                                    BorderStyle = BorderStyle.FixedSingle,
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceTypeName"].ToString() + "\nServices",
                                    ForeColor = Color.Black,
                                    Size = new Size(250, 94),
                                    Location = new Point(0, 0),
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Font = new Font("Stanberry", 20, FontStyle.Regular),
                                    Tag = reader["ServiceID"].ToString()
                                };

                                void clickHandler(object sender, EventArgs e)
                                {
                                    string labelText = labelTitle.Text;
                                    string[] parts = labelText.Split('\n');
                                    filter = parts[0];

                                    currentTable = SalesClass.LoadServiceRetention(filter);
                                    ServiceDGV.DataSource = currentTable;
                                    LoadCharts();
                                    RecountPages();
                                }

                                panel.Click += clickHandler;
                                labelTitle.Click += clickHandler;
                                panel.Controls.Add(labelTitle);
                                serviceTypeFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }

        private void LoadAllPanel_Click(object sender, EventArgs e)
        {
            filter = null;
            DataTable currentTable = SalesClass.LoadServiceRetention(filter);
            ServiceDGV.DataSource = currentTable;
            LoadCharts();
            RecountPages();
        }

        public void LoadCharts()
        {
            Dictionary<string, decimal> salesByEmployee = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in ServiceDGV.Rows)
            {
                string serviceName = row.Cells["Service Name"].Value?.ToString();
                string salesValue = row.Cells["Sales"].Value?.ToString();

                if (decimal.TryParse(salesValue, out decimal sales))
                {
                    if (salesByEmployee.ContainsKey(serviceName))
                    {
                        salesByEmployee[serviceName] += sales;
                    }
                    else
                    {
                        salesByEmployee.Add(serviceName, sales);
                    }
                }
            }

            ServiceChart.Series.Clear();

            Series salesSeries = new Series("Sales by Service");

            foreach (var item in salesByEmployee)
            {
                salesSeries.Points.AddXY(item.Key, item.Value);
            }

            ServiceChart.Series.Add(salesSeries);

            if (ServiceChart.ChartAreas.Count == 0)
            {
                ServiceChart.ChartAreas.Add(new ChartArea());
            }

            ServiceChart.ChartAreas[0].AxisX.Title = "Service Names";
            ServiceChart.ChartAreas[0].AxisY.Title = "Total Sales";
            ChartFontRefresh();
        }

        public void ChartFontRefresh()
        {
            if (ServiceChart.Titles.Count > 0)
            {
                ServiceChart.Titles[0].Font = new Font("Stanberry", 18, FontStyle.Bold);
            }

            if (ServiceChart.ChartAreas.Count > 0)
            {
                ServiceChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);
                ServiceChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);

                ServiceChart.ChartAreas[0].AxisX.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
                ServiceChart.ChartAreas[0].AxisY.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
            }

            foreach (var series in ServiceChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {
            LoadAllPanel_Click(null, null);
        }

        private void DayFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)ServiceDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeTaken) && timeTaken.Date == selectedDate)
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                currentTable = filteredTable;
                ServiceDGV.DataSource = currentTable;
                LoadCharts();
                RecountPages();

                NoFilter.Enabled = true;
                DayFilter.Enabled = false;
                WeeklyFilter.Enabled = false;
                MonthlyFilter.Enabled = false;
                RangeFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void NoFilter_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            currentPage = 1;
            currentTable = SalesClass.LoadServiceRetention(filter);
            ServiceDGV.DataSource = currentTable;
            LoadCharts();
            RecountPages();

            NoFilter.Enabled = false;
            DayFilter.Enabled = true;
            WeeklyFilter.Enabled = true;
            MonthlyFilter.Enabled = true;
            RangeFilter.Enabled = true;
        }

        private void WeeklyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)ServiceDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeTaken))
                    {
                        // Extract the date part from timeTaken
                        DateTime datePart = timeTaken.Date;

                        // Check if the date falls within the start and end dates of the week
                        if (datePart >= startOfWeek && datePart <= endOfWeek)
                        {
                            filteredTable.ImportRow(row);
                        }
                    }
                }

                currentTable = filteredTable;
                ServiceDGV.DataSource = currentTable;
                LoadCharts();
                RecountPages();

                NoFilter.Enabled = true;
                DayFilter.Enabled = false;
                WeeklyFilter.Enabled = false;
                MonthlyFilter.Enabled = false;
                RangeFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonthlyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)ServiceDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeTaken))
                    {
                        if (timeTaken.Year == selectedDate.Year && timeTaken.Month == selectedDate.Month)
                        {
                            filteredTable.ImportRow(row);
                        }
                    }
                }

                currentTable = filteredTable;
                ServiceDGV.DataSource = currentTable;
                LoadCharts();
                RecountPages();

                NoFilter.Enabled = true;
                DayFilter.Enabled = false;
                WeeklyFilter.Enabled = false;
                MonthlyFilter.Enabled = false;
                RangeFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RecountPages()
        {
            currentPage = 1;
            DataTable dataTable = (DataTable)ServiceDGV.DataSource;
            int totalData = dataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalData / pageSize);
            PageBox.Text = currentPage.ToString() + "/" + totalPages.ToString();
            LoadPage();
        }

        public void LoadPage()
        {
            DataTable originalDataTable = currentTable; // Get the DataTable from the DataSource
            int totalData = originalDataTable.Rows.Count; // Get the total number of rows in the DataTable

            // Create a new DataTable to hold the filtered data for the current page
            DataTable filteredTable = originalDataTable.Clone(); // Create a clone of the original DataTable

            int startIndex = (currentPage - 1) * pageSize; // Corrected calculation of startIndex
            int endIndex = Math.Min(startIndex + pageSize - 1, totalData - 1);

            // Show rows for the current page and add them to the filteredTable
            for (int i = startIndex; i <= endIndex; i++)
            {
                filteredTable.ImportRow(originalDataTable.Rows[i]);
            }

            ServiceDGV.DataSource = filteredTable;
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage--;
                PageBox.Text = currentPage.ToString() + "/" + totalPages.ToString();
                LoadPage();
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                PageBox.Text = currentPage.ToString() + "/" + totalPages.ToString();
                LoadPage();
            }
        }
    }
}
