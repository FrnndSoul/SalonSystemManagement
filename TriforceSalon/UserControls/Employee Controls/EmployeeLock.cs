using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Employee_Controls
{
    public partial class EmployeeLock : UserControl
    {
        public static EmployeeLock employeeLockInstance;
        public EmployeeTicketTransaction transaction = new EmployeeTicketTransaction();
        public TransactionMethods transactionMethods = new TransactionMethods();
        SalonServices salonServices = new SalonServices();
        private RealTimeClock userClock;

        public EmployeeLock()
        {
            InitializeComponent();
            employeeLockInstance = this;

        }
        private async void EmployeeLock_Load(object sender, EventArgs e)
        {
            await transaction.GetServicesAsync(salonServices.GetServiceTypeID(EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text));
        }

        //Need ayusin ang tamang refresh hindi narereset ang list
        private async void EmployeeDoneBtn_Click(object sender, EventArgs e)
        {
            long CustID = Convert.ToInt64(CustomerIDTxtB.Text);

            EmployeeDoneBtn.Enabled = false;
            await transaction.EmployeeProcessCompleteAsync(CustID);
            try
            {
                //test
                await EmployeeUserConrols.employeeUserConrolsInstance.LoadSpecialCustomersAsync(EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));
                transaction.ShowCustomerList();
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
            Guna2CustomCheckBox checkbox = sender as Guna2CustomCheckBox;
            AddServicePanel.Enabled = checkbox?.Checked ?? false;

            /* Guna2CheckBox checkbox = sender as Guna2CheckBox;

             if (checkbox != null)
             {
                 if (checkbox.Checked)
                 {
                     AddServicePanel.Enabled = true;
                 }
                 else
                 {
                     AddServicePanel.Enabled = false; 
                 }
             }*/
        }

        private async void ServiceListComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serviceName = Convert.ToString(ServiceListComB.SelectedItem);
            await transaction.GetServiceAmountAsync(serviceName);
        }

        private void AddServiceChckB_Click(object sender, EventArgs e)
        {
            /*Guna2CheckBox checkbox = sender as Guna2CheckBox;

            if (checkbox != null)
            {
                if (checkbox.Checked)
                {
                    AddServicePanel.Enabled = true;
                }
                else
                {
                    AddServicePanel.Enabled = false;
                }
            }*/
        }
    }
}
