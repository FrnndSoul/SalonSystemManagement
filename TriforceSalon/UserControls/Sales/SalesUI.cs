using sales_roject.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_roject
{
    public partial class SalesUI : UserControl
    {
        public SalesUI()
        {
            InitializeComponent();
            DateStartPicker.MinDate = DateTime.Now.AddYears(-1);
            DateStartPicker.MaxDate = DateTime.Now.AddDays(-1);

            DataDGV.Font = new Font("Chinacat", 12f);
            LoadAllDGVAsync();
        }

        private async void LoadAllDGVAsync()
        {
            DataTable transactions = await SalesClass.GetTransactionsAsync();
            DataDGV.DataSource = transactions;
        }

        private async void LoadUserIntoDGV()
        {
            DataTable transactions = await SalesClass.GetPerUser();
            DataDGV.DataSource = transactions;
        }

        private async void LoadProductIntoDGV()
        {
            DataTable transactions = await SalesClass.GetPerProduct();
            DataDGV.DataSource = transactions;
        }

        private async void LoadServiceIntoDGV()
        {
            DataTable transactions = await SalesClass.GetPerServiceVariation();
            DataDGV.DataSource = transactions;
        }

        private void ResetRange()
        {
            DateStartPicker.Enabled = true;

            LoadAllBtn.Enabled = false;
            DayFilter.Enabled = true;
            WeeklyFilter.Enabled = true;
            MonthlyFilter.Enabled = true;
        }

        private void DailyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = (DataTable)DataDGV.DataSource;
                DateTime selectedDate = DateStartPicker.Value.Date;

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["TimeTaken"] is DateTime timeTaken && timeTaken.Date == selectedDate)
                    {
                        filteredTable.ImportRow(row);
                    }
                }
                DataDGV.DataSource = filteredTable;

                LoadAllBtn.Enabled = true;
                DayFilter.Enabled = false;
                WeeklyFilter.Enabled = true;
                MonthlyFilter.Enabled = true;
                DateStartPicker.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WeeklyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = DateStartPicker.Value.Date;
                DateTime sunday = selectedDate.AddDays(-(int)selectedDate.DayOfWeek);
                DateTime saturday = sunday.AddDays(6);

                foreach (DataGridViewRow row in DataDGV.Rows)
                {
                    if (DateTime.TryParse(row.Cells["TimeTaken"].Value.ToString(), out DateTime timeTaken))
                    {
                        if (timeTaken.Date >= sunday && timeTaken.Date <= saturday)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }

                LoadAllBtn.Enabled = true;
                DayFilter.Enabled = true;
                WeeklyFilter.Enabled = false;
                MonthlyFilter.Enabled = true;
                DateStartPicker.Enabled = false;
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
                int selectedYear = DateStartPicker.Value.Year;
                int selectedMonth = DateStartPicker.Value.Month;

                foreach (DataGridViewRow row in DataDGV.Rows)
                {
                    if (DateTime.TryParse(row.Cells["TimeTaken"].Value.ToString(), out DateTime timeTaken))
                    {
                        if (timeTaken.Year == selectedYear && timeTaken.Month == selectedMonth)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }

                LoadAllBtn.Enabled = true;
                DayFilter.Enabled = true;
                WeeklyFilter.Enabled = true;
                MonthlyFilter.Enabled = false;
                DateStartPicker.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllBtn_Click(object sender, EventArgs e)
        {
            LoadAllBtn.Enabled = false;
            DayFilter.Enabled = true;
            WeeklyFilter.Enabled = true;
            MonthlyFilter.Enabled = true;
            DateStartPicker.Enabled = true;
        }

        private void GeneralBtn_Click(object sender, EventArgs e)
        {
            LoadAllDGVAsync();
            ResetRange();

            GeneralBtn.Enabled = false;
            EmployeeFilter.Enabled = true;
            ShipmentFilter.Enabled = true;
            ServiceFilter.Enabled = true;
        }

        private void EmployeeFilter_Click(object sender, EventArgs e)
        {
            LoadUserIntoDGV();
            ResetRange();

            GeneralBtn.Enabled = true;
            EmployeeFilter.Enabled = false;
            ShipmentFilter.Enabled = true;
            ServiceFilter.Enabled = true;
        }

        private void ProductFilter_Click(object sender, EventArgs e)
        {
            LoadProductIntoDGV();
            ResetRange();

            GeneralBtn.Enabled = true;
            EmployeeFilter.Enabled = true;
            ShipmentFilter.Enabled = false;
            ServiceFilter.Enabled = true;
        }

        private void ServiceFilter_Click(object sender, EventArgs e)
        {
            LoadServiceIntoDGV();
            ResetRange();

            GeneralBtn.Enabled = true;
            EmployeeFilter.Enabled = true;
            ShipmentFilter.Enabled = true;
            ServiceFilter.Enabled = false;
        }
    }
}
