using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class ServicesUserControl : UserControl
    {
        public static ServicesUserControl servicesUserControlInstance;
        private readonly GetServiceType_ServiceData serviceTypeService = new GetServiceType_ServiceData();
        private readonly PromoMethods promoMethods = new PromoMethods();
        public readonly string mysqlcon;
        private PictureBox pic;
        private Label serviceTypeLbl;
        TransactionMethods transactionMethods = new TransactionMethods();
        SellProductsMethods sellMethods;
        public KeypressLettersRestrictions keypressLettersRestrictions = new KeypressLettersRestrictions();
        public KeypressNumbersRestrictions keypressNumbersRestrictions = new KeypressNumbersRestrictions();

        public ServicesUserControl()
        {
            InitializeComponent();
            servicesUserControlInstance = this;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

            CustomerNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            CustomerPhoneNTxtB.KeyPress += keypressLettersRestrictions.KeyPress;
        }

        private async void ServicesUserControl_Load(object sender, System.EventArgs e)
        {
            await serviceTypeService.GetAllEmployee(mysqlcon);
            PEmployeeComB.SelectedIndex = 0;
            transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());
            await serviceTypeService.GetAllType(ServiceTypeComB, mysqlcon);
            await promoMethods.GetActiveServicePromos(ServicePromoComB);
            DisplayServiceTypeFL();
        }
        public async void DisplayServiceTypeFL()
        {
            await serviceTypeService.DisplayServiceTypeFL(CategoryFL, ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB, PEmployeeComB);
        }
        private async void ServiceTypeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServiceType = ServiceTypeComB.SelectedItem.ToString();
            await serviceTypeService.UpdateServiceCategoryFL(selectedServiceType, CategoryFL, ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
            serviceTypeService.AddEmployeesComB(selectedServiceType, PEmployeeComB, mysqlcon);
        }
        private async void ProcessCustomerBtn_Click(object sender, System.EventArgs e)
        {
            ProcessCustomerBtn.Enabled = false;

            string ID = transactionIDTxtB.Text;
            string name = CustomerNameTxtB.Text;

            if (CustomerNameTxtB.Text is null || CustomerPhoneNTxtB is null
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

            if (!IsPhoneNumberValid())
            {
                MessageBox.Show("Phone number must be valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceName = ServiceTxtB.Text;
                await transactionMethods.GetServiceTypeID(serviceName);
                await transactionMethods.TestProcessCustomer(ServicesGDGVVControl, "NORMAL");
                transactionMethods.GeneratePDFTicket(ID, name);
                ClearAll();

            }
            ProcessCustomerBtn.Enabled = true ;

        }

        private void ClearAll()
        {
            ServicesGDGVVControl.Rows.Clear();
            CustomerNameTxtB.Clear();
            CustomerPhoneNTxtB.Clear();
            ServiceTxtB.Clear();
            ServiceAmountTxtB.Clear();
            PEmployeeComB.SelectedIndex = 0;
            ServicePromoComB.Text = null;
            PromoTxtB.Text = null;
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

        public bool IsPhoneNumberValid()
        {
            string number = CustomerPhoneNTxtB.Text;
            if (number[0] == '0' && number[1] == '9' && number.Length == 11)
            {
                return true;
            }
            return false;
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
            ServicesGDGVVControl.Rows.Add(serviceType, serviceName, prefEmp, amountService, "None", "X", queueNumber);

            ServiceTxtB.Clear();
            ServiceAmountTxtB.Clear();
            PEmployeeComB.SelectedIndex = 0;
        }

        private void ServicesGDGVVControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ServicesGDGVVControl.Rows.Count)
            {
                DataGridViewCell clickedCell = ServicesGDGVVControl.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (clickedCell.OwningColumn.Name == "RemoveServiceCol")
                {
                    string disountLabel = ServicesGDGVVControl.Rows[e.RowIndex].Cells["DiscountCol"].Value.ToString();
                    decimal removedServiceDiscount;

                    if (disountLabel == "None")
                    {
                        ServicesGDGVVControl.Rows.RemoveAt(e.RowIndex);
                    }
                    else if(decimal.TryParse(disountLabel, out removedServiceDiscount))
                    {
                        for (int i = 0; i < ServicesGDGVVControl.Rows.Count; i++)
                        {
                            decimal currentDiscount;
                            if (decimal.TryParse(ServicesGDGVVControl.Rows[i].Cells["DiscountCol"].Value.ToString(), out currentDiscount))
                            {
                                if (currentDiscount == removedServiceDiscount)
                                {
                                    ServicesGDGVVControl.Rows.RemoveAt(i);
                                    ServicePromoComB.Text = null;
                                    PromoTxtB.Text = null;
                                    ActivateBtn.Enabled = true;
                                    i--; 
                                }
                            }
                        }
                    }
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

        private async void ActivateBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn.Enabled = false;

            string promoName = ServicePromoComB.Text;
            await promoMethods.GetPromoCode(promoName, ServicePromoTxtB);

            string promoInput = ServicePromoTxtB.Text.Substring(0, 7);

            if (string.IsNullOrWhiteSpace(promoInput))
            {
                MessageBox.Show("No code has been entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(promoInput, out int promoCode))
            {
                var promoDetails = transactionMethods.GetPromoDetails(promoCode, mysqlcon);

                if (promoDetails.isValid == "YES")
                {
                    var serviceDetails = transactionMethods.GetServiceDetails(promoCode, mysqlcon);

                    // Check if any of the items from the promo are already present in the DataGridView
                    bool serviceAlreadyAdded = true; // Assume all services are already added
                    foreach (var service in serviceDetails)
                    {
                        bool found = false;
                        foreach (DataGridViewRow row in ServicesGDGVVControl.Rows)
                        {
                            if (row.Cells["SNameCol"].Value != null && row.Cells["SNameCol"].Value.ToString() == service.ServiceName)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            serviceAlreadyAdded = false;
                            break;
                        }
                    }

                    if (serviceAlreadyAdded)
                    {
                        foreach (var service in serviceDetails)
                        {
                            foreach (DataGridViewRow row in ServicesGDGVVControl.Rows)
                            {
                                if (row.Cells["SNameCol"].Value != null && row.Cells["SNameCol"].Value.ToString() == service.ServiceName)
                                {
                                    row.Cells["DiscountCol"].Value = service.ServiceDiscount;
                                }
                            }
                        }
                        MessageBox.Show("Discount applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select all the services from the promo before applying the discount.", "Service(s) not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    ServicePromoTxtB.Clear();
                }
                else if (promoDetails.isValid == "NO")
                {
                    MessageBox.Show($"Promo Code {promoDetails.promoCode} is not available right now.", "Invalid Promo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid promo code.", "Invalid Promo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ServicePromoTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else if (ServicePromoTxtB.Text.Length >= 7 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private async void ServicePromoComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string promoName = ServicePromoComB.Text;
            await promoMethods.GetPromoCode(promoName, ServicePromoTxtB);*/
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DisplayServiceTypeFL();
            ServiceFL.Controls.Clear();
            ServiceTypeComB.Text = null;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}