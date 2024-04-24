using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace salesreport.UserControls
{
    public partial class ProductsSales : UserControl
    {
        DataTable currentTable = SalesClass.LoadProductSales();
        public int pageSize = 15;
        public int currentPage = 1;
        public int totalPages;

        public ProductsSales()
        {
            InitializeComponent();
            ProductSalesDGV.DataSource = currentTable;
            LoadCharts();
            RangeFilter.MaxDate = DateTime.Now.AddDays(1);
            RangeFilter.MinDate = DateTime.Now.AddYears(-2);
            RangeFilter.Value = DateTime.Now;
            RangeFilter.Format = DateTimePickerFormat.Custom;
            RangeFilter.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadCharts()
        {
            Dictionary<string, decimal> salesByProduct = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in ProductSalesDGV.Rows)
            {
                string productName = row.Cells["Product Name"].Value?.ToString();
                string salesValue = row.Cells["Sales"].Value?.ToString();

                if (decimal.TryParse(salesValue, out decimal sales))
                {
                    if (salesByProduct.ContainsKey(productName))
                    {
                        salesByProduct[productName] += sales;
                    }
                    else
                    {
                        salesByProduct.Add(productName, sales);
                    }
                }
            }

            SalesChart.Series.Clear();

            Series salesSeries = new Series("Sales by Product");

            foreach (var item in salesByProduct)
            {
                salesSeries.Points.AddXY(item.Key, item.Value);
            }

            SalesChart.Series.Add(salesSeries);

            if (SalesChart.ChartAreas.Count == 0)
            {
                SalesChart.ChartAreas.Add(new ChartArea());
            }

            SalesChart.ChartAreas[0].AxisX.Title = "Product Names";
            SalesChart.ChartAreas[0].AxisY.Title = "Total Sales";
            ChartFontRefresh();
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

            foreach (var series in SalesChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }

            /*if (VoidChart.Titles.Count > 0)
            {
                VoidChart.Titles[0].Font = new Font("Stanberry", 18, FontStyle.Bold);
            }

            if (VoidChart.ChartAreas.Count > 0)
            {
                VoidChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);
                VoidChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);

                VoidChart.ChartAreas[0].AxisX.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
                VoidChart.ChartAreas[0].AxisY.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
            }

            foreach (var series in VoidChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }*/
        }

        private void DayFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductSalesDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)ProductSalesDGV.DataSource;

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
                ProductSalesDGV.DataSource = currentTable;
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
            currentTable = SalesClass.LoadProductSales();
            ProductSalesDGV.DataSource = currentTable;
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
                if (ProductSalesDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)ProductSalesDGV.DataSource;

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
                ProductSalesDGV.DataSource = currentTable;
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
                if (ProductSalesDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)ProductSalesDGV.DataSource;

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
                ProductSalesDGV.DataSource = currentTable;
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            DataTable originalDataTable = SalesClass.LoadProductSales(); // Load the original data
            DataView dataView = originalDataTable.DefaultView;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string filterExpression = $"Convert([Reference Number], 'System.String') LIKE '%{searchText}%' OR " +
                           $"Convert([Date], 'System.String') LIKE '%{searchText}%' OR " +
                           $"Convert([Product ID], 'System.String') LIKE '%{searchText}%' OR " +
                           $"[Product Name] LIKE '%{searchText}%' OR " +
                           $"Convert(Quantity, 'System.String') LIKE '%{searchText}%' OR " +
                           $"Convert(Sales, 'System.String') LIKE '%{searchText}%'";
                dataView.RowFilter = filterExpression;
            }
            else
            {
                currentTable = SalesClass.LoadProductSales();
                ProductSalesDGV.DataSource = currentTable;
                LoadCharts();
                RecountPages();
                return;
            }

            currentTable = dataView.ToTable(); // Update the DataGridView with the filtered data
            RecountPages(); // Recount pages after filtering
        }

        public void RecountPages()
        {
            currentPage = 1;
            DataTable dataTable = (DataTable)ProductSalesDGV.DataSource;
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
            ProductSalesDGV.DataSource = filteredTable;
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

