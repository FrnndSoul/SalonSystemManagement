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
            await serviceTypeService.GetServiceTypeAsync(mysqlcon);
            await serviceTypeService.GetAllEmployee(mysqlcon);
            ServiceFilterComB.SelectedIndex = 0;
            PEmployeeComB.SelectedIndex = 0;
            transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());

            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, "All", ServiceFL, ServiceTxtB, ServiceAmountTxtB);
            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, "All", ServiceFL, ServiceTxtB, ServiceAmountTxtB);
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

        private async void ProcessCustomerBtn_Click(object sender, System.EventArgs e)
        {
            ProcessCustomerBtn.Enabled = false;

            string ID = transactionIDTxtB.Text;
            string name = CustomerNameTxtB.Text;
            string age = CustomerAgeTxtB.Text;
            if (CustomerNameTxtB.Text is null || CustomerAgeTxtB.Text is null || CustomerPhoneNTxtB is null
                || ServiceAmountTxtB.Text is null || ServiceTxtB.Text is null)
            {
                MessageBox.Show("Please fill all the customer information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(ServicesGDGVVControl.Rows.Count == 0)
            {
                MessageBox.Show("No service has been selected. Cannot process customer", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceName = ServiceTxtB.Text;
                transactionMethods.GetServiceTypeID(serviceName);
                //transactionMethods.ProcessCustomer(serviceName, transactionMethods.GetServiceTypeID(serviceName));
                await transactionMethods.TestProcessCustomer(ServicesGDGVVControl, "NORMAL");
                transactionMethods.GeneratePDFTicket(ID, name, age);
                ClearAll();

            }
            ProcessCustomerBtn.Enabled = true ;

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

        private void ClearAll()
        {
            ServicesGDGVVControl.Rows.Clear();
            CustomerNameTxtB.Clear();
            CustomerAgeTxtB.Clear();
            CustomerPhoneNTxtB.Clear();
            ServiceTxtB.Clear();
            ServiceAmountTxtB.Clear();
            PEmployeeComB.SelectedIndex = 0;
            transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());
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
            string dateNow = DateTime.Now.ToString("MM-dd-yyyy dddd");
            string serviceName = ServiceTxtB.Text;
            string prefEmp = PEmployeeComB.SelectedItem.ToString();
            decimal amountService = Convert.ToDecimal(ServiceAmountTxtB.Text);
            string serviceType = await transactionMethods.GetServiceType(ServiceTxtB.Text);
            int queueNumber = await serviceTypeService.GetLargestQueue(dateNow, serviceType, mysqlcon);

            ServicesGDGVVControl.Rows.Add(serviceType, serviceName, prefEmp, amountService, "X", queueNumber);
        }

        private void ServicesGDGVVControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ServicesGDGVVControl.Rows.Count)
            {
                DataGridViewCell clickedCell = ServicesGDGVVControl.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "RemoveServiceCol")
                {
                    ServicesGDGVVControl.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void PEmployeeComB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            // Check if the length exceeds the maximum allowed length (30 characters)
            if (CustomerNameTxtB.Text.Length >= 30 && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }
    }
}