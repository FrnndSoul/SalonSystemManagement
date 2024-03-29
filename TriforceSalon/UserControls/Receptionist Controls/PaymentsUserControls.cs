using Guna.UI2.WinForms;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Data.Common;
using System.IO;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.UserControls.Receptionist_Controls.Payment_Methods;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class PaymentsUserControls : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string CustomerName, ServiceType, ServiceVariation, PriorityStatus, EmployeeName, PaymentStatus, Phone;
        public static int TransactionID, Age, EmployeeID, VariationID, Amount;
        public TransactionMethods transaction = new TransactionMethods();
        CardProcess cardProcess = new CardProcess();

        public decimal totalPrice = 0;


        public PaymentsUserControls()
        {
            InitializeComponent();
            AdjustCheckBoxSize(PWDCheckbox);
        }

        private void PaymentsUserControls_Load(object sender, EventArgs e)
        {
            DefaultLoad();
        }

        private void GcashPayment_Click(object sender, EventArgs e)
        {
            //gcashProcess1.Visible = true;
            GcashProcess gcash = new GcashProcess();
            UserControlNavigator.ShowControl(gcash, OtherTransactionContainer);
        }

        private void gcashProcess1_VisibleChanged(object sender, EventArgs e)
        {
            if (cardProcess1.Visible == false)
            {
                cardProcess1.DefaultLoad();
            }
        }

        private void AdjustCheckBoxSize(CheckBox checkBox)
        {
            int largerCheckBoxSize = 20;
            checkBox.Width = largerCheckBoxSize;
            checkBox.Height = largerCheckBoxSize;
            checkBox.Invalidate();
        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PWDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            /*int amountValue = Convert.ToInt32(Amount);
            Amount = (int)(amountValue * 0.8);
            int discount = (int)(amountValue * 0.2);
            DiscountBox.Text = discount.ToString();*/

            /*
                        decimal totalAmount = Convert.ToDecimal(AmountBox.Text);
                        Amount = (decimal)(totalAmount * 0.8);
                        int discount = (decimal)(amountValue * 0.2);
                        DiscountBox.Text = discount.ToString();*/

            decimal totalAmount = Convert.ToDecimal(AmountBox.Text);
            decimal discountedAmount = totalAmount * 0.8m; // Apply 20% discount
            decimal discount = totalAmount - discountedAmount; // Calculate the discount
            AmountBox.Text = discountedAmount.ToString(); // Update the amount with the discounted value
            DiscountBox.Text = discount.ToString(); // Display the discount
        }

        private void CardPayment_Click(object sender, EventArgs e)
        {
            //cardProcess1.Visible = true;
            CardProcess cardProcess = new CardProcess();
            UserControlNavigator.ShowControl(cardProcess, OtherTransactionContainer);

            cardProcess.ThrowData(CustomerName, EmployeeName, ServiceVariation, PaymentStatus, Age, Phone, Amount, Convert.ToInt32(TransactionIDBox.Text));
        }
        private decimal DiscountFromProducts(decimal amount)
        {
            decimal VAT = amount * 0.12m;
            decimal PriceWithoutVAT = amount - VAT;
            decimal discountPrice = PriceWithoutVAT * 0.20m;
            return discountPrice + VAT;
        }
        private void OverallPrice()
        {
            totalPrice = 0.00m;
            decimal discountedTotal = 0.00m;
            decimal normalTotal = 0.00m;

            // Assuming ProductsControlDGV contains products data
            foreach (DataGridViewRow row in ProductsBoughtDGV.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    decimal rowTotal = decimal.Parse(row.Cells[2].Value.ToString());
                    string selectedValue = row.Cells["ProductsDiscountChckBoxCol"].Value.ToString();

                    if (selectedValue == "Discounted")
                    {
                        // Apply discount for discounted products
                        discountedTotal += rowTotal - DiscountFromProducts(rowTotal);
                    }
                    else
                    {
                        // Add original price for normal products
                        normalTotal += rowTotal;
                    }

                    totalPrice += rowTotal; // Add to total regardless
                }
            }

            // Assuming another DataGridView called SecondProductsControlDGV contains products data from another table
            foreach (DataGridViewRow row in ServiceAcquiredDGV.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    decimal rowTotal = decimal.Parse(row.Cells[1].Value.ToString());
                    string selectedValue = row.Cells["ServicesDiscountChckBoxCol"].Value.ToString();

                    if (selectedValue == "Discounted")
                    {
                        // Apply discount for discounted products
                        discountedTotal += rowTotal - DiscountFromProducts(rowTotal);
                    }
                    else
                    {
                        // Add original price for normal products
                        normalTotal += rowTotal;
                    }
                    totalPrice += rowTotal;
                }
            }

            // Update UI with totals
            AmountBox.Text = "Php. " + totalPrice.ToString("0.00");
            TotalAmountTxtB.Text = "Php. " + (discountedTotal + normalTotal).ToString("0.00");
            DiscountBox.Text = "Php. " + (totalPrice - (discountedTotal + normalTotal)).ToString("0.00");
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            long CustomerID = Convert.ToInt64(TransactionIDBox.Text);
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    /*string query = "select ci.CustomerName, ci.CustomerAge, ci.CustomerPhoneNumber, ci.PriorityStatus, ci.PaymentStatus, ci.TimeTaken, sg.EmployeeID, sg.ServiceType " +
                        "from customer_info ci" +
                        "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                        "where TransactionID = @transactionID";*/

                    string query = "SELECT ci.CustomerName, ci.CustomerAge, ci.CustomerPhoneNumber, ci.PriorityStatus, ci.PaymentStatus, ci.TimeTaken " +
                                   "FROM customer_info ci " +
                                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                                   "WHERE TransactionID = @transactionID";


                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@transactionID", CustomerID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                string paymentstatus = reader["PaymentStatus"].ToString();
                                if (string.Equals(paymentstatus, "PAID", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Transaction ID is already paid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                else if (string.Equals(paymentstatus, "VOIDED", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Transaction ID was voided", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                CustomerName = reader["CustomerName"].ToString();
                                //ServiceType = reader["ServiceType"].ToString();
                                Age = Convert.ToInt32(reader["CustomerAge"]);
                                Phone = Convert.ToString(reader["CustomerPhoneNumber"]);
                                //EmployeeID = Convert.ToInt32(reader["EmployeeID"]);

                                DisplayTransaction();
                                await FillProductsBoughtAsync(CustomerID, ProductsBoughtDGV);
                                await FillServiceAcquiredAsync(CustomerID, ServiceAcquiredDGV);
                                //CalculateTotalCombinedPrice(ProductsBoughtDGV, ServiceAcquiredDGV);
                            }
                            else
                            {
                                MessageBox.Show("Transaction ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nat TransactionIDBox Key Press", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            /*try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT * FROM `transaction` WHERE TransactionID = @transacID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@transacID", Convert.ToInt64(TransactionIDBox.Text));
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string paymentstatus = reader["PaymentStatus"].ToString();
                                if (string.Equals(paymentstatus, "PAID",StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Transaction ID is already paid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } 
                                
                                else if (string.Equals(paymentstatus, "VOIDED", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Transaction ID was voided", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                CustomerName = reader["CustomerName"].ToString();
                                ServiceType = reader["ServiceType"].ToString();
                                ServiceVariation = reader["ServiceVariation"].ToString();
                                PriorityStatus = reader["PriorityStatus"].ToString();
                                Age = Convert.ToInt32(reader["CustomerAge"]);
                                Phone = Convert.ToString(reader["CustomerPhoneNumber"]);
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                                VariationID = Convert.ToInt32(reader["ServiceVariationID"]);
                                Amount = Convert.ToInt32(reader["Amount"]);
                                DisplayTransaction();
                            } else
                            {
                                MessageBox.Show("Transaction ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nat TransactionIDBox Key Press", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
        }

        private void DisplayTransaction()
        {
            NameBox.Text = CustomerName;
            AgeBox.Text = Age.ToString();
            PhoneNumberBox.Text = Phone.ToString();
            //ServiceTypeBox.Text = ServiceType;
            //ServiceVariationBox.Text = ServiceVariation;
            //ServiceVariationIDBox.Text = VariationID.ToString();
            //EmployeeIDBox.Text = EmployeeID.ToString();
            //AmountBox.Text = Amount.ToString();


            //PaymentPanel.Enabled = true;
            TransactionIDBox.Enabled = false;
            LoadBtn.Enabled = false;
            CardPayment.Enabled = true;
            //CashPayment.Enabled = true;
            GcashPayment.Enabled = true;
            ClearFieldsBtn.Enabled = true;
            PaymentBtn.Enabled = true;
            VoidBtn.Enabled = true;
            CalculateTotalBtn.Enabled = true;

           /* if (Age >= 60)
            {
                PWDCheckbox.Checked = true;
                int amountValue = Convert.ToInt32(Amount);
                Amount = (int)(amountValue * 0.8);
                int discount = (int)(amountValue * 0.2);
                DiscountBox.Text = discount.ToString();
            }*/
        }



        private async void VoidBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to void the transaction?", "Void Items and Services", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string enteredPassword = Method.HashString(Microsoft.VisualBasic.Interaction.InputBox("Enter manager password:", "Password Required", ""));

                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT se.AccountAccess, a.Password FROM salon_employees se JOIN accounts a ON se.AccountID = a.AccountID WHERE a.Password = @enteredPassword;";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@enteredPassword", enteredPassword);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string position = reader["AccountAccess"].ToString();

                                if (position != "Manager")
                                {
                                    MessageBox.Show("Invalid password. You need manager permission to void items.", "Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                ChangePaymentStatus("VOIDED");
                                MessageBox.Show("Transaction has been voided", "Void Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DefaultLoad(); 
                            }
                            else
                            {
                                MessageBox.Show("Password not found. Please try again or contact your manager.", "Password Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }

            }
            /* DialogResult result = MessageBox.Show("Confirming before voiding this transaction.", "Confirm Void Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (result != DialogResult.Yes)
             {
                 return;
             }
             ChangePaymentStatus("VOIDED");
             DefaultLoad();*/
        }

        public void ChangePaymentStatus(string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE customer_info SET PaymentStatus = @NewStatus WHERE TransactionID = @TransactionID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", newStatus);
                        command.Parameters.AddWithValue("@TransactionID", TransactionIDBox.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error updating payment status: {e.Message}", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PaymentBtn_Click(object sender, EventArgs e)
        {
            long CustomerID = Convert.ToInt64(TransactionIDBox.Text);
            decimal cash = Convert.ToDecimal(CustomerMoneyInput.Text);

            if (cash < Convert.ToDecimal(TotalAmountTxtB.Text))
            {
                MessageBox.Show("Not enough cash entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cash > Convert.ToDecimal(TotalAmountTxtB.Text))
                {
                    //MessageBox.Show($"Customer's change: {Convert.ToInt32(AmountBox.Text) - cash}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"Customer's change: {cash - Convert.ToDecimal(AmountBox.Text)}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangePaymentStatus("PAID");
                    GeneratePDFBothReceipt();
                    await SendToSales(CustomerID, transaction.GenerateTransactionID());
                }
                else
                {
                    MessageBox.Show("No change needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangePaymentStatus("PAID");
                    GeneratePDFBothReceipt();
                    await SendToSales(CustomerID, transaction.GenerateTransactionID());
                }
                /* ChangePaymentStatus("PAID");
                 await SendToSales(CustomerID, transaction.GenerateTransactionID());*/
                DefaultLoad();

                OtherTransactionContainer.Controls.Clear();
            }

        }

        private void ClearFieldsBtn_Click(object sender, EventArgs e)
        {
            DefaultLoad();
            
        }

        public async Task FillProductsBoughtAsync(long transactionID, Guna2DataGridView productsBoughtDGV)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Select ProductName, Quantity, Amount from product_group where ProductGroupID = @transactionID AND IsVoided = 'NO'";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@transactionID", transactionID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string productName = reader["ProductName"].ToString();
                                int quantity = Convert.ToInt32(reader["Quantity"]);
                                decimal amount = Convert.ToDecimal(reader["Amount"]);

                                int rowIndex = productsBoughtDGV.Rows.Add();

                                productsBoughtDGV.Rows[rowIndex].Cells["ProdNameCol"].Value = productName;
                                productsBoughtDGV.Rows[rowIndex].Cells["QuantityCol"].Value = quantity;
                                productsBoughtDGV.Rows[rowIndex].Cells["TotAmountCol"].Value = amount;
                                productsBoughtDGV.Rows[rowIndex].Cells["ProductsDiscountChckBoxCol"].Value = "Normal";

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in FillProductsBoughtAsync");

            }
        }

        private void CustomerMoneyInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (CustomerMoneyInput.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void CalculateTotalBtn_Click(object sender, EventArgs e)
        {
            OverallPrice();
            PaymentBtn.Enabled = true;
        }

        public async Task FillServiceAcquiredAsync(long transactionID, Guna2DataGridView serviceAcquiredDGV)
        {

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Select ServiceVariation, Amount from service_group where ServiceGroupID = @transactionID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@transactionID", transactionID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string productName = reader["ServiceVariation"].ToString();
                                decimal amount = Convert.ToDecimal(reader["Amount"]);

                                int rowIndex = serviceAcquiredDGV.Rows.Add();

                                serviceAcquiredDGV.Rows[rowIndex].Cells["ServiceCol"].Value = productName;
                                serviceAcquiredDGV.Rows[rowIndex].Cells["ServiceAmountCol"].Value = amount;
                                serviceAcquiredDGV.Rows[rowIndex].Cells["ServicesDiscountChckBoxCol"].Value = "Normal";

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in FillServiceAcquiredAsync");

            }
        }

        public decimal CalculateTotalPriceOfProd(DataGridView dataGridView)
        {
            decimal totalPrice = 0;

            // Iterate over the rows of the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Assuming the price is in a column named "PriceCol"
                if (row.Cells["TotAmountCol"].Value != null && decimal.TryParse(row.Cells["TotAmountCol"].Value.ToString(), out decimal price))
                {
                    // Extract the price from the current row and add it to the total price
                    totalPrice += price;
                }
            }

            return totalPrice;
        }

        public decimal CalculateTotalPriceOfService(DataGridView dataGridView)
        {
            decimal totalPrice = 0;

            // Iterate over the rows of the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Assuming the price is in a column named "PriceCol"
                if (row.Cells["ServiceAmountCol"].Value != null && decimal.TryParse(row.Cells["ServiceAmountCol"].Value.ToString(), out decimal price))
                {
                    // Extract the price from the current row and add it to the total price
                    totalPrice += price;
                }
            }

            return totalPrice;
        }

        public void CalculateTotalCombinedPrice(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            // Calculate the total price for each DataGridView
            decimal totalPrice1 = CalculateTotalPriceOfProd(dataGridView1);
            decimal totalPrice2 = CalculateTotalPriceOfService(dataGridView2);

            // Compute the sum of the total prices
            decimal totalCombinedPrice = totalPrice1 + totalPrice2;

            AmountBox.Text = Convert.ToString(totalCombinedPrice);
        }

        public async Task SendToSales(long transactionID, int salesID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Insert into sales (SaleID, OrderID, SaleDate, Amount) values (@saleID, @orderID, @saleDate, @totAmount)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        /*string totalText = SellProductsUserControls.sellProductsUserControlsInstance.TotLbl.Text;
                        string numericValue = totalText.Replace("Php.", "").Trim();
                        decimal.TryParse(numericValue, out decimal totalAmount);*/

                        decimal totalAmount = Convert.ToDecimal(AmountBox.Text);

                        command.Parameters.AddWithValue("@saleID", salesID);
                        command.Parameters.AddWithValue("@orderID", transactionID);
                        command.Parameters.AddWithValue("@saleDate", DateTime.Now);
                        command.Parameters.AddWithValue("@totAmount", totalAmount);

                        await command.ExecuteNonQueryAsync();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SendToSales");
            }
        }



        public void DefaultLoad()
        {
            TransactionIDBox.Text = "";
            NameBox.Text = "";
            AgeBox.Text = "";
            PhoneNumberBox.Text = "";
            //ServiceTypeBox.Text = "";
            /*ServiceVariationBox.Text = "";
            ServiceVariationIDBox.Text = "";*/
            //EmployeeIDBox.Text = "";
            AmountBox.Text = "";
            DiscountBox.Text = "";

            ProductsBoughtDGV.Rows.Clear();
            ServiceAcquiredDGV.Rows.Clear();

            //PaymentPanel.Enabled = false;

            PWDCheckbox.Checked = false;

            TransactionIDBox.Enabled = true;
            LoadBtn.Enabled = true;
            CardPayment.Enabled = false;
            //CashPayment.Enabled = false;
            GcashPayment.Enabled = false;
            VoidBtn.Enabled = false;
            PaymentBtn.Enabled = false;
            ClearFieldsBtn.Enabled = false;
            CalculateTotalBtn.Enabled = false;


            /*cardProcess1.Visible = false;
            gcashProcess1.Visible = false;*/
        }

        private void cardProcess1_VisibleChanged(object sender, EventArgs e)
        {
            if (cardProcess1.Visible == false)
            {
                cardProcess1.DefaultLoad();
            }
        }

        private async void CashPayment_Click(object sender, EventArgs e)
        {
            long CustomerID = Convert.ToInt64(TransactionIDBox.Text);

            string userInput = ShowInputDialog("Enter the amount of customer's money:", "Cash Payment");

            if (!string.IsNullOrEmpty(userInput))
            {
                decimal cash = Convert.ToDecimal(userInput);
                if (cash < Convert.ToDecimal(AmountBox.Text))
                {
                    MessageBox.Show("Not enough cash entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cash > Convert.ToDecimal(AmountBox.Text))
                    {
                        //MessageBox.Show($"Customer's change: {Convert.ToInt32(AmountBox.Text) - cash}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"Customer's change: {cash - Convert.ToDecimal(AmountBox.Text)}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangePaymentStatus("PAID");
                        await SendToSales(CustomerID, transaction.GenerateTransactionID());
                    }
                    else
                    {
                        MessageBox.Show("No change needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangePaymentStatus("PAID");
                        await SendToSales(CustomerID, transaction.GenerateTransactionID());
                    }
                    /* ChangePaymentStatus("PAID");
                     await SendToSales(CustomerID, transaction.GenerateTransactionID());*/
                    DefaultLoad();
                }
            }
            else
            {
                MessageBox.Show("Transaction cancelled, please press the OKAY button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ShowInputDialog(string prompt, string title)
        {
            Form promptForm = new Form()
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = prompt };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 200 };
            inputBox.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            };
            Button confirmation = new Button() { Text = "OK", Left = 20, Width = 100, Top = 75, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { promptForm.Close(); };
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(inputBox);
            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? inputBox.Text : "0";
        }

        public void GeneratePDFBothReceipt()
        {
            decimal subtotalAmount = decimal.Parse(AmountBox.Text);
            decimal discount = decimal.Parse(DiscountBox.Text);
            decimal cashEntered = decimal.Parse(CustomerMoneyInput.Text);
            int totalProductQuantity = 0;
            int totalServiceQuantity = ServiceAcquiredDGV.Rows.Count;
            string nameText = NameBox.Text;

            if (!decimal.TryParse(CustomerMoneyInput.Text, out cashEntered))
            {
                MessageBox.Show("Please enter a valid amount for payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cashEntered < subtotalAmount)
            {
                MessageBox.Show("Please enter a valid amount for payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "PDF Files|*.pdf";
                saveFileDialog1.Title = "Save PDF File";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string pdfFilePath = saveFileDialog1.FileName;

                    using (PdfWriter writer = new PdfWriter(new FileStream(pdfFilePath, FileMode.Create)))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (iText.Layout.Document doc = new iText.Layout.Document(pdf))
                    {
                        doc.SetProperty(Property.TEXT_ALIGNMENT, TextAlignment.JUSTIFIED_ALL);
                        ImageData logoImageData = ImageDataFactory.Create(transaction.GetBytesFromImage(Properties.Resources.SalonLogo));
                        iText.Layout.Element.Image logo = new iText.Layout.Element.Image(logoImageData);
                        logo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        logo.SetWidth(200);
                        logo.SetHeight(200);

                        doc.Add(logo);
                        doc.Add(new Paragraph("BLOCK 5,  ORANGE STREET, LAKEVIEW, PINAGBUHATAN, PASIG CITY").SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph("Tel NO : (02) 4568-2996").SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph("Mobile NO : (0993) 369-4904").SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph($"Served by: " + Method.Name).SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph($"Served to: {nameText}").SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph($"Order #" + TransactionIDBox.Text).SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph("Date: " + DateTime.Now.ToString("MM/dd/yyyy   hh:mm:ss tt")).SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));

                        // Table for products bought
                        if (ProductsBoughtDGV.Rows.Count > 0)
                        {
                            Table productTable = new Table(4);
                            productTable.SetWidth(UnitValue.CreatePercentValue(100));
                            productTable.SetTextAlignment(TextAlignment.CENTER);
                            productTable.AddCell(new Cell().Add(new Paragraph("QUANTITY")).SetBorder(Border.NO_BORDER));
                            productTable.AddCell(new Cell().Add(new Paragraph("PRICE")).SetBorder(Border.NO_BORDER));
                            productTable.AddCell(new Cell().Add(new Paragraph("PRODUCT")).SetBorder(Border.NO_BORDER));
                            productTable.AddCell(new Cell().Add(new Paragraph("TOTAL")).SetBorder(Border.NO_BORDER));

                            foreach (DataGridViewRow row in ProductsBoughtDGV.Rows)
                            {
                                string product = row.Cells[0].Value.ToString();
                                string quantity = row.Cells[1].Value.ToString();
                                string totalprice = row.Cells[2].Value.ToString();
                                string variationCost = transaction.GetVariationCost(product);
                                if (int.TryParse(quantity, out int quantityValue))
                                {
                                    totalProductQuantity += quantityValue;
                                }

                                productTable.AddCell(new Cell().Add(new Paragraph(quantity)).SetBorder(Border.NO_BORDER));
                                productTable.AddCell(new Cell().Add(new Paragraph($"Php. {variationCost}")).SetBorder(Border.NO_BORDER));
                                productTable.AddCell(new Cell().Add(new Paragraph(product)).SetBorder(Border.NO_BORDER));
                                productTable.AddCell(new Cell().Add(new Paragraph($"Php. {totalprice}")).SetBorder(Border.NO_BORDER));
                            }
                            doc.Add(productTable);
                            doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));
                        }

                        // Table for services acquired
                        Table serviceTable = new Table(3);
                        serviceTable.SetWidth(UnitValue.CreatePercentValue(100));
                        serviceTable.SetTextAlignment(TextAlignment.CENTER);
                        serviceTable.AddCell(new Cell().Add(new Paragraph("SERVICE")).SetBorder(Border.NO_BORDER));
                        serviceTable.AddCell(new Cell().Add(new Paragraph("PRICE")).SetBorder(Border.NO_BORDER));
                        serviceTable.AddCell(new Cell().Add(new Paragraph("TOTAL")).SetBorder(Border.NO_BORDER));

                        foreach (DataGridViewRow row in ServiceAcquiredDGV.Rows)
                        {
                            string service = row.Cells["ServiceCol"].Value.ToString();
                            string serviceAmount = row.Cells["ServiceAmountCol"].Value.ToString();
                            serviceTable.AddCell(new Cell().Add(new Paragraph(service)).SetBorder(Border.NO_BORDER));
                            serviceTable.AddCell(new Cell().Add(new Paragraph($"Php. {serviceAmount}")).SetBorder(Border.NO_BORDER));
                            serviceTable.AddCell(new Cell().Add(new Paragraph($"Php. {serviceAmount}")).SetBorder(Border.NO_BORDER));
                        }

                        doc.Add(serviceTable);

                        Table summaryTable = new Table(2);
                        summaryTable.SetWidth(UnitValue.CreatePercentValue(100));
                        summaryTable.SetTextAlignment(TextAlignment.LEFT);
                        decimal totalAmount = subtotalAmount - discount;
                        decimal change = cashEntered - totalAmount;

                        transaction.AddReceiptDetailRow(summaryTable, "SUBTOTAL:", $"Php. {subtotalAmount.ToString("0.00")}");
                        transaction.AddReceiptDetailRow(summaryTable, "DISCOUNT:", $"Php. {discount.ToString("0.00")}");
                        transaction.AddReceiptDetailRow(summaryTable, "TOTAL:", $"Php. {totalAmount.ToString("0.00")}");
                        transaction.AddReceiptDetailRow(summaryTable, "CASH:", $"Php. {cashEntered.ToString("0.00")}");
                        transaction.AddReceiptDetailRow(summaryTable, "CHANGE:", $"Php. {change.ToString("0.00")}");

                        int totalQuantity = totalProductQuantity + totalServiceQuantity;
                        doc.Add(new Paragraph($"---------------------------------------{totalQuantity} Item(s)-----------------------------------------"));
                        doc.Add(summaryTable);
                        doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));
                        doc.Add(new Paragraph("THIS RECEIPT SERVES AS YOUR PROOF OF PURCHASE").SetTextAlignment(TextAlignment.CENTER));
                    }

                    MessageBox.Show("Receipt generated successfully and saved to:\n" + pdfFilePath, "🎉 Congrats on your purchase at TriCharm Salon! 🎉", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //guna2DataGridView1.Rows.Clear();
                    System.Diagnostics.Process.Start("cmd", $"/c start {pdfFilePath}");
                }
            }
        }
    }
}
