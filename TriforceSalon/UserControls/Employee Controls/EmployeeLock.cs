using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Employee_Controls
{
    public partial class EmployeeLock : UserControl
    {
        public static EmployeeLock employeeLockInstance;
        public EmployeeTicketTransaction transaction = new EmployeeTicketTransaction();
        public TransactionMethods transactionMethods = new TransactionMethods();
        private RealTimeClock userClock;

        public EmployeeLock()
        {
            InitializeComponent();
            employeeLockInstance = this;
        }
        private async void EmployeeLock_Load(object sender, EventArgs e)
        {
            await transaction.GetServicesAsync(EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text);
        }
        private async void EmployeeDoneBtn_Click(object sender, EventArgs e)
        {
            int CustID = Convert.ToInt32(CustomerIDTxtB.Text);
            transaction.ShowCustomerList();

            EmployeeDoneBtn.Enabled = false;
            await transaction.EmployeeProcessCompleteAsync(CustID);

            try
            {
                //test
                await EmployeeUserConrols.employeeUserConrolsInstance.LoadSpecialCustomersAsync(EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EmployeeDoneBtn.Enabled = true;
            }
        }

        private void AddServiceChckB_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkbox = sender as Guna2CheckBox;

            if (checkbox.Checked)
            {
                AddServicePanel.Enabled = false;
            }
            else
            {
                AddServicePanel.Enabled = true;
            }
        }

        private async void ServiceListComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serviceName = Convert.ToString(ServiceListComB.SelectedItem);
            await transaction.GetServiceAmountAsync(serviceName);
        }
    }
}
