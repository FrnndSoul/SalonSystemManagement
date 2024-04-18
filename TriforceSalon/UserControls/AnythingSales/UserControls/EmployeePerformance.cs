using MySql.Data.MySqlClient;
using Mysqlx.Expect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace salesreport.UserControls
{
    public partial class EmployeePerformance : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        DataTable currentTable = SalesClass.LoadEmployeeDGV(filter);
        public static string filter;
        public int pageSize = 15;
        public int currentPage = 1;
        public int totalPages;

        public EmployeePerformance()
        {
            InitializeComponent();
            GetServiceTypeData(TypeFLP);
            EmployeeDGV.DataSource = currentTable;
            LoadCharts();
            RecountPages();
            RangeFilter.MaxDate = DateTime.Now.AddDays(1);
            RangeFilter.MinDate = DateTime.Now.AddYears(-2);
            RangeFilter.Value = DateTime.Now;
            RangeFilter.Format = DateTimePickerFormat.Custom;
            RangeFilter.CustomFormat = "dd/MM/yyyy";
        }

        public void RecountPages()
        {
            currentPage = 1;
            DataTable dataTable = (DataTable)EmployeeDGV.DataSource;
            int totalData = dataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalData / pageSize);
            PageBox.Text = currentPage.ToString() + "/" + totalPages.ToString();
            LoadPage();
        }

        public void LoadCharts()
        {
            // Sales Chart
            Dictionary<string, decimal> salesByEmployee = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in EmployeeDGV.Rows)
            {
                string employeeName = row.Cells["Name"].Value?.ToString();
                string[] nameParts = employeeName.Split(' ');
                string firstName = nameParts[0]; 
                string salesValue = row.Cells["Sales"].Value?.ToString();

                if (decimal.TryParse(salesValue, out decimal sales))
                {
                    if (salesByEmployee.ContainsKey(firstName))
                    {
                        salesByEmployee[firstName] += sales;
                    }
                    else
                    {
                        salesByEmployee.Add(firstName, sales);
                    }
                }
            }

            SalesChart.Series.Clear();

            Series salesSeries = new Series("Sales by Employee");

            foreach (var item in salesByEmployee)
            {
                salesSeries.Points.AddXY(item.Key, item.Value);
            }

            SalesChart.Series.Add(salesSeries);

            if (SalesChart.ChartAreas.Count == 0)
            {
                SalesChart.ChartAreas.Add(new ChartArea());
            }

            SalesChart.ChartAreas[0].AxisX.Title = "Employee Names";
            SalesChart.ChartAreas[0].AxisY.Title = "Total Sales";

            // Ratings Chart
            Dictionary<string, decimal> ratesByEmployee = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in EmployeeDGV.Rows)
            {
                string employeeName = row.Cells["Name"].Value?.ToString();
                string[] nameParts = employeeName.Split(' '); 
                string firstName = nameParts[0]; 
                string ratingsValue = row.Cells["Rating"].Value?.ToString();

                if (decimal.TryParse(ratingsValue, out decimal ratings))
                {
                    if (ratesByEmployee.ContainsKey(firstName))
                    {
                        ratesByEmployee[firstName] += ratings;
                    }
                    else
                    {
                        ratesByEmployee.Add(firstName, ratings);
                    }
                }
            }

            RatingsChart.Series.Clear();

            Series ratingsSeries = new Series("Ratings by Employee");

            foreach (var item in ratesByEmployee)
            {
                ratingsSeries.Points.AddXY(item.Key, item.Value);
            }

            RatingsChart.Series.Add(ratingsSeries);

            if (RatingsChart.ChartAreas.Count == 0)
            {
                RatingsChart.ChartAreas.Add(new ChartArea());
            }

            RatingsChart.ChartAreas[0].AxisX.Title = "Employee Names";
            RatingsChart.ChartAreas[0].AxisY.Title = "Average Rating";

            ChartFontRefresh();
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
                                    Text = reader["ServiceTypeName"].ToString() + "\nStylists",
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
                                    currentTable = SalesClass.LoadEmployeeDGV(filter);
                                    EmployeeDGV.DataSource = currentTable;
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

        private void LabelTitle_Click(object sender, EventArgs e)
        {
            filter = null;
            currentTable = SalesClass.LoadEmployeeDGV(filter);
            EmployeeDGV.DataSource = currentTable;
            LoadCharts();
            RecountPages();
        }

        public void ChartFontRefresh()
        {
            //Sales Chart
            if (SalesChart.Titles.Count > 0)
            {
                SalesChart.Titles[0].Font = new Font("Stanberry", 18, FontStyle.Bold);
            }

            if (SalesChart.ChartAreas.Count > 0)
            {
                SalesChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);
                SalesChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);

                SalesChart.ChartAreas[0].AxisX.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
                SalesChart.ChartAreas[0].AxisY.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
            }

            foreach (var series in RatingsChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }

            //Ratings Chart
            if (RatingsChart.Titles.Count > 0)
            {
                RatingsChart.Titles[0].Font = new Font("Stanberry", 18, FontStyle.Bold);
            }

            if (RatingsChart.ChartAreas.Count > 0)
            {
                RatingsChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);
                RatingsChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);

                RatingsChart.ChartAreas[0].AxisX.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
                RatingsChart.ChartAreas[0].AxisY.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
            }

            foreach (var series in RatingsChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }
        }

        //<date filter>
        private void DayFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)EmployeeDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime timeTaken) && timeTaken.Date == selectedDate)
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                EmployeeDGV.DataSource = filteredTable;
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
            EmployeeDGV.DataSource = SalesClass.LoadEmployeeDGV(filter);
            RecountPages();
            LoadCharts();
            currentPage = 1;
            LoadPage();

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
                if (EmployeeDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)EmployeeDGV.DataSource;

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


                EmployeeDGV.DataSource = filteredTable;
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
                if (EmployeeDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)EmployeeDGV.DataSource;

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

                EmployeeDGV.DataSource = filteredTable;
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
        //</date filter>
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            DataTable originalDataTable = SalesClass.LoadEmployeeDGV(filter); // Load the original data
            DataView dataView = originalDataTable.DefaultView;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string filterExpression = $"Convert(RefID, 'System.String') LIKE '%{searchText}%' OR " +
                                          $"Convert([Date], 'System.String') LIKE '%{searchText}%' OR " +
                                          $"Convert(EmployeeID, 'System.String') LIKE '%{searchText}%' OR " +
                                          $"ServiceType LIKE '%{searchText}%' OR " +
                                          $"Name LIKE '%{searchText}%' OR " +
                                          $"Convert(Sales, 'System.String') LIKE '%{searchText}%' OR " +
                                          $"Convert(Rating, 'System.String') LIKE '%{searchText}%'";
                dataView.RowFilter = filterExpression;
            }
            else
            {
                currentTable = SalesClass.LoadEmployeeDGV(filter);
                EmployeeDGV.DataSource = currentTable;
                LoadCharts();
                RecountPages();
                return;
            }

            currentTable = dataView.ToTable(); // Update the DataGridView with the filtered data
            RecountPages(); // Recount pages after filtering
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

            EmployeeDGV.DataSource = filteredTable;
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)EmployeeDGV.DataSource;
            int totalData = dataTable.Rows.Count;

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
