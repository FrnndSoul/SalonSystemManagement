using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class ServicesUserControl : UserControl
    {
        public static ServicesUserControl servicesUserControlInstance;
        private readonly GetServiceType_ServiceData serviceTypeService = new GetServiceType_ServiceData();
        public readonly string mysqlcon;
        private PictureBox pic;
        private Label serviceTypeLbl;
        TransactionMethods transactionMethods = new TransactionMethods();
        public KeypressLettersRestrictions keypressLettersRestrictions = new KeypressLettersRestrictions();
        public KeypressNumbersRestrictions keypressNumbersRestrictions = new KeypressNumbersRestrictions();

        public ServicesUserControl()
        {
            InitializeComponent();
            servicesUserControlInstance = this;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

            //serviceTypeService = new GetServiceType_ServiceData();
            CustomerNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            CustomerAgeTxtB.KeyPress += keypressLettersRestrictions.KeyPress;
            CustomerPhoneNTxtB.KeyPress += keypressLettersRestrictions.KeyPress;

           /* GetServiceTypeData();
            GetServiceData();*/
        }

        private async void ServicesUserControl_Load(object sender, System.EventArgs e)
        {
            //await serviceTypeService.GetServiceTypeData(ServiceTypeFL, mysqlcon, UpdateServiceFL);
            //await serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);

            await serviceTypeService.GetServiceTypeAsync(mysqlcon);
            ServiceFilterComB.SelectedIndex = 0;
            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, "All", ServiceFL, ServiceTxtB, ServiceAmountTxtB);

            await serviceTypeService.GetAllEmployee(mysqlcon);
            transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());

        }

        /*public void GetServiceTypeData()
        {
            serviceTypeService.GetServiceTypeData(ServiceTypeFL, mysqlcon, UpdateServiceFL);
        }

        public void GetServiceData()
        {
            serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
        }*/

        private async void UpdateServiceFL(string serviceTypeID)
        {
            await serviceTypeService.UpdateServiceFL(ServiceFL, serviceTypeID, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
        }

        private void ProcessCustomerBtn_Click(object sender, System.EventArgs e)
        {
            if(CustomerNameTxtB.Text is null || CustomerAgeTxtB.Text is null || CustomerPhoneNTxtB is null
                || ServiceAmountTxtB.Text is null || ServiceTxtB.Text is null)
            {
                MessageBox.Show("Please fill all the customer information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceName = ServiceTxtB.Text;
                transactionMethods.GetServiceTypeID(serviceName);
                transactionMethods.ProcessCustomer(serviceName, transactionMethods.GetServiceTypeID(serviceName));
            }
        }

        private async void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            string search = SearchServiceTxtB.Text;

            try {
                await serviceTypeService.GetServiceDataForSearch(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB, search);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private async void GetAllServiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceFL.Controls.Clear();
                await serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
                await serviceTypeService.GetAllEmployee(mysqlcon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
                
        private void CustomerAgeTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string currentText = CustomerAgeTxtB.Text;

            int totalLength = currentText.Length + 1;
            if (totalLength >= 2)
            {
                e.Handled = true;
                return;
            }*/

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Get the current text in the TextBox
            string currentText = CustomerAgeTxtB.Text;

            // Check if the input length will exceed 3 characters after adding the new input
            if (currentText.Length >= 3 && e.KeyChar != '\b') // '\b' represents the Backspace key
            {
                e.Handled = true; // Ignore the input
                return;
            }
        }

        private void CustomerPhoneNTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string currentText = CustomerAgeTxtB.Text;

            int totalLength = currentText.Length + 1;
            if (totalLength >= 11)
            {
                e.Handled = true;
                return;
            }*/

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Get the current text in the TextBox
            string currentText = CustomerPhoneNTxtB.Text;

            // Check if the input length will exceed 11 characters after adding the new input
            if (currentText.Length >= 11 && e.KeyChar != '\b') // '\b' represents the Backspace key
            {
                e.Handled = true; // Ignore the input
                return;
            }
        }

        private async void ServiceFilterComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = ServiceFilterComB.SelectedItem.ToString();
            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, selectedType, ServiceFL, ServiceTxtB, ServiceAmountTxtB);
        }

        public decimal ExtractAmount(string input)
        {
            string pattern = @"Amount:\s*₱\s*(\d+)";

            // Match the pattern in the input string
            Match match = Regex.Match(input, pattern);

            // Check if a match is found
            if (match.Success)
            {
                // Extract the amount from the match
                string amountString = match.Groups[1].Value;

                // Convert the amount to a decimal
                if (decimal.TryParse(amountString, out decimal extractedAmount))
                {
                    return extractedAmount;
                }
                else
                {
                    throw new ArgumentException("Failed to parse amount.");
                }
            }
            else
            {
                throw new ArgumentException("Pattern not found in input string.");
            }
        }

        private async void AddLServiceListBtn_Click(object sender, EventArgs e)
        {
            string dateNow = Convert.ToString(DateTime.Now);
            string serviceName = ServiceTxtB.Text;
            string prefEmp = PEmployeeComB.SelectedItem.ToString();
            decimal amountService = Convert.ToDecimal(ServiceAmountTxtB.Text);
            int queueNumber = await serviceTypeService.GetLargestQueue(dateNow, serviceName, mysqlcon);

            ServicesGDGVVControl.Rows.Add(serviceName, prefEmp, amountService, queueNumber);
            /* DataTable dt = new DataTable();
             ServicesGDGVVControl.DataSource = dt;
             dt.Rows.Add(serviceName, prefEmp, amountService, queueNumber);*/
        }
    }
}