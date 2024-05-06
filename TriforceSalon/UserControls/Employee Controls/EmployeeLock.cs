using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Employee_Controls
{
    public partial class EmployeeLock : UserControl
    {
        public static EmployeeLock employeeLockInstance;
        public EmployeeTicketTransaction transaction = new EmployeeTicketTransaction();
        public TransactionMethods transactionMethods = new TransactionMethods();
        RatingsUserControl ratings = new RatingsUserControl();  
        SalonServices salonServices = new SalonServices();
        private RealTimeClock userClock;
        public static int serviceID;
        public static long customerID;

        public EmployeeLock()
        {
            InitializeComponent();
            employeeLockInstance = this;

        }
       
        //Need ayusin ang tamang refresh hindi narereset ang list
        private async void EmployeeDoneBtn_Click(object sender, EventArgs e)
        {
            long CustID = Convert.ToInt64(CustomerIDTxtB.Text);
            string serviceVariation = CustomerServiceTxtB.Text;
            serviceID = await salonServices.GetServiceVariationID(serviceVariation);
            customerID = CustID;
            EmployeeDoneBtn.Enabled = false;
            await transaction.EmployeeProcessCompleteAsync(CustID, serviceVariation);

            //ratings.GetCustomerService(CustID, serviceID);
            try
            {
                //test
                await EmployeeUserConrols.employeeUserConrolsInstance.LoadSpecialCustomersAsync(EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));
                await EmployeeUserConrols.employeeUserConrolsInstance.LoadGeneralCustomersAsync(EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));

                //transaction.ShowCustomerList();
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
            //AddServicePanel.Enabled = checkbox?.Checked ?? false;

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
