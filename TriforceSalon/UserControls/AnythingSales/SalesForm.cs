using salesreport.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon;
using TriforceSalon.UserControls;

namespace salesreport
{

    public partial class SalesForm : UserControl
    {
        readonly GeneralReport report = new GeneralReport();
        readonly EmployeePerformance employeePerformance = new EmployeePerformance();
        readonly ProductsSales productsSales = new ProductsSales();
        readonly ShipmentReports shipmentReports = new ShipmentReports();
        readonly ServiceRetention serviceRetention = new ServiceRetention();

        public SalesForm()
        {
            InitializeComponent();
        }

        private void ShowDefault()
        {
            foreach (Control control in this.Controls)
            {
                if(control is EmployeePerformance || control is ProductsSales || control is ShipmentReports || control is ServiceRetention || control is GeneralReport)
                {
                    this.Controls.Remove(employeePerformance);
                    this.Controls.Remove(productsSales);
                    this.Controls.Remove(shipmentReports);
                    this.Controls.Remove(serviceRetention);
                    this.Controls.Remove(report);
                }
            }
        }

        private async void EmployeeFilter_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(employeePerformance))
                {
                    ShowDefault();
                    this.Controls.Add(employeePerformance);
                    employeePerformance.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        private async void ProductFilter_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(productsSales))
                {
                    ShowDefault();
                    this.Controls.Add(productsSales);
                    productsSales.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        private async void ShipmentFilter_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(shipmentReports))
                {
                    ShowDefault();
                    this.Controls.Add(shipmentReports);
                    shipmentReports.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        private async void ServiceFilter_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(serviceRetention))
                {
                    ShowDefault();
                    this.Controls.Add(serviceRetention);
                    serviceRetention.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Parent.Controls.Remove(this);

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    ManagerPage managerPage = new ManagerPage();
                    UserControlNavigator.ShowControl(managerPage, MainForm.mainFormInstance.MainFormContent);
                    break;
                }
            }
        }

        private async void GenBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(report))
                {
                    ShowDefault();
                    this.Controls.Add(report);
                    report.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        private async void SalesForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(500);
            GenBtn_Click(null, null);
        }
    }
}
