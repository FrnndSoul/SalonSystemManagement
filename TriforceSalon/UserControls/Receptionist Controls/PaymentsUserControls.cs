using Guna.UI2.WinForms;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
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
        public static PaymentsUserControls paymentInstance;
        Inventory inventory = new Inventory();
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string CustomerName, ServiceType, ServiceVariation, PriorityStatus, EmployeeName, PaymentStatus, Phone;
        public static int TransactionID, Age, EmployeeID, VariationID, Amount;
        public TransactionMethods transaction = new TransactionMethods();
        CardProcess cardProcess = new CardProcess();
        private int ratingsNumber = 0;

        public decimal totalPrice = 0;


        public PaymentsUserControls()
        {
            InitializeComponent();
            CustomerListDGV.CellContentDoubleClick += CustomerListDGV_CellDoubleClick;
            paymentInstance = this;

            RBtn1.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn2.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn3.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn4.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn5.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
        }

        private async void PaymentsUserControls_Load(object sender, EventArgs e)
        {
            DefaultLoad();
            await GetCustomers(CustomerListDGV);
        }

        private void GcashPayment_Click(object sender, EventArgs e)
        {
            //gcashProcess1.Visible = true;
            GcashProcessB gcash = new GcashProcessB();
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
        /*private void OverallPrice()
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
            AmountBox.Text = totalPrice.ToString("0.00");
            TotalAmountTxtB.Text = (discountedTotal + normalTotal).ToString("0.00");
            DiscountBox.Text = (totalPrice - (discountedTotal + normalTotal)).ToString("0.00");
        }*/

        private void OverallPrice(decimal downpayment)
        {
            totalPrice = 0.00m;
            decimal discountedTotal = 0.00m;
            decimal normalTotal = 0.00m;

            // Assuming ProductsControlDGV contains products data
            foreach (DataGridViewRow row in ProductsBoughtDGV.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells["ProductsDiscountCol"].Value.ToString() != "None")
                {
                    decimal rowTotal = decimal.Parse(row.Cells[2].Value.ToString());
                    string discountValue = row.Cells["ProductsDiscountCol"].Value.ToString();

                    if (decimal.TryParse(discountValue, out decimal discountAmount))
                    {
                        // Apply discount for items with a decimal discount
                        decimal discountedPrice = rowTotal * (1 - discountAmount);
                        discountedTotal += discountedPrice;
                    }
                    else
                    {
                        // Add original price for items with "Normal" discount
                        normalTotal += rowTotal;
                    }
                }
                else
                {
                    // Add original price for items with "None" discount
                    decimal rowTotal = decimal.Parse(row.Cells[2].Value.ToString());
                    normalTotal += rowTotal;
                }
                totalPrice += decimal.Parse(row.Cells[2].Value.ToString());
            }

            // Assuming another DataGridView called SecondProductsControlDGV contains products data from another table
            foreach (DataGridViewRow row in ServiceAcquiredDGV.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells["ServiceDiscountCol"].Value.ToString() != "None")
                {
                    decimal rowTotal = decimal.Parse(row.Cells[1].Value.ToString());
                    string discountValue = row.Cells["ServiceDiscountCol"].Value.ToString();

                    if (decimal.TryParse(discountValue, out decimal discountAmount))
                    {
                        // Apply discount for items with a decimal discount
                        decimal discountedPrice = rowTotal * (1 - discountAmount);
                        discountedTotal += discountedPrice;
                    }
                    else
                    {
                        // Add original price for items with "Normal" discount
                        normalTotal += rowTotal;
                    }
                }
                else
                {
                    // Add original price for items with "None" discount
                    decimal rowTotal = decimal.Parse(row.Cells[1].Value.ToString());
                    normalTotal += rowTotal;
                }
                totalPrice += decimal.Parse(row.Cells[1].Value.ToString());
            }

            // Update UI with totals
            /*AmountBox.Text = totalPrice.ToString("0.00");
            TotalAmountTxtB.Text = (discountedTotal + normalTotal).ToString("0.00");
            DiscountBox.Text = (totalPrice - (discountedTotal + normalTotal)).ToString("0.00");*/

            AmountBox.Text = totalPrice.ToString("0.00");
            TotalAmountTxtB.Text = (discountedTotal + normalTotal).ToString("0.00");
            DiscountBox.Text = (totalPrice - (discountedTotal + normalTotal)).ToString("0.00");
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            long CustomerID = Convert.ToInt64(TransactionIDBox.Text);
            if (TransactionIDBox.Text == null || TransactionIDBox.Text == "")
            {
                MessageBox.Show("There is no ID selected or inputted.", "No ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT DISTINCT ci.CustomerName, ci.CustomerPhoneNumber, ci.PaymentStatus, " +
                                   "CASE " +
                                   "WHEN ci.IsAppointment = 'YES' THEN a.Downpayment " +
                                   "ELSE 0.00 " +
                                   "END AS Downpayment " +
                                   "FROM customer_info ci " +
                                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                                   "LEFT JOIN Appointments a ON ci.TransactionID = a.ReferenceNumber " +
                                   "WHERE ci.TransactionID = @transactionID";

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
                                    MessageBox.Show("Customer is already paid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                else if (string.Equals(paymentstatus, "VOIDED", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Transaction was voided", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                else if (string.Equals(paymentstatus, "ONGOING", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Service/s is not yet complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                else if (string.Equals(paymentstatus, "INSESSION", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Customer is still in session", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                string Customer_name = reader["CustomerName"].ToString();
                                string Customer_phone = Convert.ToString(reader["CustomerPhoneNumber"]);
                                string Customer_downpayment = Convert.ToString(reader["Downpayment"]);

                                DisplayTransaction(Customer_name, Customer_phone, Customer_downpayment);
                                await FillProductsBoughtAsync(CustomerID, ProductsBoughtDGV);
                                await FillServiceAcquiredAsync(CustomerID, ServiceAcquiredDGV);
                                decimal downpayment = Convert.ToDecimal(DownpaymentTxtB.Text);

                                OverallPrice(downpayment);
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
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void DisplayTransaction(string name, string phoneNumber, string downpayment)
        {
            NameBox.Text = name;
            PhoneNumberBox.Text = phoneNumber;
            DownpaymentTxtB.Text = downpayment;


            TransactionIDBox.Enabled = false;
            LoadBtn.Enabled = false;
            GcashPayment.Enabled = true;
            ClearFieldsBtn.Enabled = true;
            PaymentBtn.Enabled = true;
            VoidBtn.Enabled = true;
            CalculateTotalBtn.Enabled = true;

        }


        /*public async Task VoidedItems(long ID, Guna2DataGridView products)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    foreach (DataGridViewRow row in products.Rows)
                    {
                        string itemName;
                        if (row.Cells["ProdNameCol"].Value != null)
                        {
                            itemName = row.Cells["ProdNameCol"].Value.ToString();
                        }
                        else
                        {
                            continue;
                        }

                        string query = "UPDATE product_group SET isVoided = 'YES' WHERE ProductGroupID = @customerID";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@customerID", ID);
                            await command.ExecuteNonQueryAsync();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in void transaction");
            }
        }*/

        public async Task VoidedItems(long ID, Guna2DataGridView products)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in products.Rows)
                            {
                                string itemName;
                                if (row.Cells["ProdNameCol"].Value != null)
                                {
                                    itemName = row.Cells["ProdNameCol"].Value.ToString();
                                }
                                else
                                {
                                    continue;
                                }

                                string query = "UPDATE product_group SET isVoided = 'YES' WHERE ProductGroupID = @customerID";

                                using (MySqlCommand command = new MySqlCommand(query, conn, transaction))
                                {
                                    command.Parameters.AddWithValue("@customerID", ID);
                                    await command.ExecuteNonQueryAsync();
                                }
                            }

                            // If not admin, commit the transaction
                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Voiding of items rolled back. No changes were made.", "Void Items", MessageBoxButtons.OK);
                            }
                            else
                            {
                                // If admin, rollback the transaction
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show($"Error voiding items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*private async Task VoidServices(long ID, Guna2DataGridView services)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    foreach (DataGridViewRow row in services.Rows)
                    {
                        string serviceName;
                        if (row.Cells["ServiceCol"].Value != null)
                        {
                            serviceName = row.Cells["ServiceCol"].Value.ToString();
                        }
                        else
                        {
                            continue;
                        }

                        decimal amount = Convert.ToDecimal(row.Cells["ServiceAmountCol"].Value);

                        string query = "UPDATE service_group SET IsVoided = 'YES' WHERE ServiceGroupID = @customerID";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@customerID", ID);
                            await command.ExecuteNonQueryAsync();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in void transaction");
            }
        }*/

        private async Task VoidServices(long ID, Guna2DataGridView services)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in services.Rows)
                            {
                                string serviceName;
                                if (row.Cells["ServiceCol"].Value != null)
                                {
                                    serviceName = row.Cells["ServiceCol"].Value.ToString();
                                }
                                else
                                {
                                    continue;
                                }

                                decimal amount = Convert.ToDecimal(row.Cells["ServiceAmountCol"].Value);

                                string query = "UPDATE service_group SET IsVoided = 'YES' WHERE ServiceGroupID = @customerID";

                                using (MySqlCommand command = new MySqlCommand(query, conn, transaction))
                                {
                                    command.Parameters.AddWithValue("@customerID", ID);
                                    await command.ExecuteNonQueryAsync();
                                }
                            }

                            // If not admin, commit the transaction
                            if (!Method.AdminAccess())
                            {
                                transaction.Commit();
                                MessageBox.Show("Services voided successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If admin, rollback the transaction
                                transaction.Rollback();
                                MessageBox.Show("Voiding of service rolled back. No changes were made.", "Void Service", MessageBoxButtons.OK);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show($"Error voiding services: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void VoidBtn_Click(object sender, EventArgs e)
        {

            VoidBtn.Enabled = false;
            long ID = Convert.ToInt64(TransactionIDBox.Text);

            try
            {
                DialogResult result = MessageBox.Show("Do you want to void the transaction?", "Void Items and Services", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ChangePaymentStatus("VOIDED", 0);
                    await VoidedItems(ID, ProductsBoughtDGV);
                    await VoidServices(ID, ServiceAcquiredDGV);
                    MessageBox.Show("Transaction has been voided", "Void Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await GetCustomers(CustomerListDGV);
                    DefaultLoad();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VoidBtn.Enabled = true;
        }

        /* public async Task ChangePaymentStatus(string newStatus, int ratings)
         {
             try
             {
                 using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                 {
                     await connection.OpenAsync();

                     string query = "UPDATE customer_info SET PaymentStatus = @NewStatus WHERE TransactionID = @TransactionID";
                     using (MySqlCommand command = new MySqlCommand(query, connection))
                     {
                         command.Parameters.AddWithValue("@NewStatus", newStatus);
                         command.Parameters.AddWithValue("@TransactionID", TransactionIDBox.Text);
                         int rowsAffected = await command.ExecuteNonQueryAsync();
                     }

                     string ratingsQuery = "UPDATE employee_records SET CustomerRating = @ratings WHERE CustomerID = @customerID";
                     using (MySqlCommand command2 = new MySqlCommand(ratingsQuery, connection))
                     {
                         command2.Parameters.AddWithValue("@customerID", TransactionIDBox.Text);
                         command2.Parameters.AddWithValue("@ratings", ratings);
                         await command2.ExecuteNonQueryAsync();

                     }
                 }
             }
             catch (Exception e)
             {
                 MessageBox.Show($"Error updating payment status: {e.Message}", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        public async Task ChangePaymentStatus(string newStatus, int ratings)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    await connection.OpenAsync();

                    // Start a transaction
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Update payment status query
                            string query = "UPDATE customer_info SET PaymentStatus = @NewStatus WHERE TransactionID = @TransactionID";
                            using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                            {
                                command.Transaction = transaction;

                                command.Parameters.AddWithValue("@NewStatus", newStatus);
                                command.Parameters.AddWithValue("@TransactionID", TransactionIDBox.Text);
                                await command.ExecuteNonQueryAsync();
                            }

                            // Update ratings query
                            string ratingsQuery = "UPDATE employee_records SET CustomerRating = @ratings WHERE CustomerID = @customerID";
                            using (MySqlCommand command2 = new MySqlCommand(ratingsQuery, connection, transaction))
                            {
                                command2.Transaction = transaction;

                                command2.Parameters.AddWithValue("@customerID", TransactionIDBox.Text);
                                command2.Parameters.AddWithValue("@ratings", ratings);
                                await command2.ExecuteNonQueryAsync();
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Working as intended.\nNo changes were made in the database", "Change Payment Status Function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show($"Error updating payment status: {ex.Message}", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error connecting to database: {e.Message}", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PaymentBtn_Click(object sender, EventArgs e)
        {
            PaymentBtn.Enabled = false;

            long CustomerID = Convert.ToInt64(TransactionIDBox.Text);
            decimal cash;

            if (string.IsNullOrWhiteSpace(CustomerMoneyInput.Text))
            {
                MessageBox.Show("Please enter an amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaymentBtn.Enabled = true;
                return;
            }
            else
            {
                cash = Convert.ToDecimal(CustomerMoneyInput.Text);
            }

            if (cash < Convert.ToDecimal(TotalAmountTxtB.Text))
            {
                MessageBox.Show("Not enough cash entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaymentBtn.Enabled = true;
                return;
            }
            else
            {
                if (cash > Convert.ToDecimal(TotalAmountTxtB.Text))
                {
                    MessageBox.Show($"Customer's change: {cash - Convert.ToDecimal(TotalAmountTxtB.Text)}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await ChangePaymentStatus("PAID", ratingsNumber);
                    GeneratePDFBothReceipt();
                    await SendToSales(CustomerID, transaction.GenerateTransactionID());
                    await SubtractItemsInInventoryForPurchase(ProductsBoughtDGV);
                    MessageBox.Show("Payment successful");
                }
                else
                {
                    MessageBox.Show("No change needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await ChangePaymentStatus("PAID", ratingsNumber);
                    GeneratePDFBothReceipt();
                    await SendToSales(CustomerID, transaction.GenerateTransactionID());
                    await SubtractItemsInInventoryForPurchase(ProductsBoughtDGV);
                    MessageBox.Show("Payment successful");
                }
                await GetCustomers(CustomerListDGV);
                DefaultLoad();

            }
            PaymentBtn.Enabled = true;
        }
        /*public async Task SubtractItemsInInventoryForPurchase(Guna2DataGridView productsDataGrid)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string subtractQuery = "UPDATE inventory SET Stock = Stock - @quantity WHERE ItemID = @itemID";

                    foreach (DataGridViewRow row in productsDataGrid.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                        string itemName = Convert.ToString(row.Cells["ProdNameCol"].Value);
                        int productID = await inventory.GetItemIDByName(itemName);
                        using (MySqlCommand command = new MySqlCommand(subtractQuery, conn))
                        {
                            command.Parameters.AddWithValue("@quantity", quantity);
                            command.Parameters.AddWithValue("@itemID", productID);

                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\nat SubtractItemsInInventoryForPurchase()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        public async Task SubtractItemsInInventoryForPurchase(Guna2DataGridView productsDataGrid)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string subtractQuery = "UPDATE inventory SET Stock = Stock - @quantity WHERE ItemID = @itemID";

                            foreach (DataGridViewRow row in productsDataGrid.Rows)
                            {
                                int quantity = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                                string itemName = Convert.ToString(row.Cells["ProdNameCol"].Value);
                                int productID = await inventory.GetItemIDByName(itemName);

                                using (MySqlCommand command = new MySqlCommand(subtractQuery, conn, transaction))
                                {
                                    command.Parameters.AddWithValue("@quantity", quantity);
                                    command.Parameters.AddWithValue("@itemID", productID);
                                    await command.ExecuteNonQueryAsync();
                                }
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Inventory update rolled back. No changes were made.", "Inventory Check Function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFieldsBtn_Click(object sender, EventArgs e)
        {
            DefaultLoad();
            ProductsBoughtDGV.Rows.Clear();
            ServiceAcquiredDGV.Rows.Clear();

        }

        public async Task FillProductsBoughtAsync(long transactionID, Guna2DataGridView productsBoughtDGV)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Select ProductName, Quantity, Amount, Discount from product_group where ProductGroupID = @transactionID AND IsVoided = 'NO'";

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
                                string discount = Convert.ToString(reader["Discount"]);


                                int rowIndex = productsBoughtDGV.Rows.Add();

                                productsBoughtDGV.Rows[rowIndex].Cells["ProdNameCol"].Value = productName;
                                productsBoughtDGV.Rows[rowIndex].Cells["QuantityCol"].Value = quantity;
                                productsBoughtDGV.Rows[rowIndex].Cells["TotAmountCol"].Value = amount;
                                productsBoughtDGV.Rows[rowIndex].Cells["ProductsDiscountCol"].Value = discount;

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

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (CustomerMoneyInput.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && CustomerMoneyInput.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void CalculateTotalBtn_Click(object sender, EventArgs e)
        {
            decimal downpayment = Convert.ToDecimal(DownpaymentTxtB.Text);
            OverallPrice(downpayment);
            PaymentBtn.Enabled = true;
            guna2Button1.Enabled = true;
        }

        private void TransactionIDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and control characters (including backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Get the current text in the textbox
            string currentText = TransactionIDBox.Text;

            // Calculate the total length if the new character is added
            int totalLength = currentText.Length + (e.KeyChar == '\b' ? -1 : 1);

            // Check if the total length exceeds the maximum allowed length
            if (totalLength > 8)
            {
                e.Handled = true;
                return;
            }
        }

        public async Task FillServiceAcquiredAsync(long transactionID, Guna2DataGridView serviceAcquiredDGV)
        {

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Select ServiceVariation, Amount, Discount from service_group where ServiceGroupID = @transactionID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@transactionID", transactionID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string productName = reader["ServiceVariation"].ToString();
                                decimal amount = Convert.ToDecimal(reader["Amount"]);
                                string discount = Convert.ToString(reader["Discount"]);


                                int rowIndex = serviceAcquiredDGV.Rows.Add();

                                serviceAcquiredDGV.Rows[rowIndex].Cells["ServiceCol"].Value = productName;
                                serviceAcquiredDGV.Rows[rowIndex].Cells["ServiceAmountCol"].Value = amount;
                                serviceAcquiredDGV.Rows[rowIndex].Cells["ServiceDiscountCol"].Value = discount;

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

        private void CustomerListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = CustomerListDGV.Rows[e.RowIndex];

                string transactionID = selectedRow.Cells[0].Value.ToString();

                TransactionIDBox.Text = transactionID;
            }
        }

        private async void RefreshListBtn_Click(object sender, EventArgs e)
        {
            await GetCustomers(CustomerListDGV);
            DefaultLoad();
        }

        /*public async Task SendToSales(long transactionID, int salesID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Insert into sales (SaleID, OrderID, SaleDate, Amount) values (@saleID, @orderID, @saleDate, @totAmount)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
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
        }*/

        public async Task SendToSales(long transactionID, int salesID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string query = "INSERT INTO sales (SaleID, OrderID, SaleDate, Amount) VALUES (@saleID, @orderID, @saleDate, @totAmount)";

                            using (MySqlCommand command = new MySqlCommand(query, conn, transaction))
                            {
                                decimal totalAmount = Convert.ToDecimal(AmountBox.Text);
                                command.Transaction = transaction;

                                command.Parameters.AddWithValue("@saleID", salesID);
                                command.Parameters.AddWithValue("@orderID", transactionID);
                                command.Parameters.AddWithValue("@saleDate", DateTime.Now);
                                command.Parameters.AddWithValue("@totAmount", totalAmount);

                                await command.ExecuteNonQueryAsync();
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Working as intended.\nNo changes were made in the database", "Send To Sales Function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error sending transaction to sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetCustomers(Guna2DataGridView customerList)
        {
            customerList.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT TransactionID, CustomerName, PaymentStatus " +
                        "FROM customer_info " +
                        "WHERE DATE(TimeTaken) = CURDATE() AND PaymentStatus != 'VOIDED' AND PaymentStatus != 'PAID'";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string ID = reader["TransactionID"].ToString();
                                string Name = reader["CustomerName"].ToString();
                                string Status = reader["PaymentStatus"].ToString();

                                int rowIndex = customerList.Rows.Add();

                                customerList.Rows[rowIndex].Cells["TransactionIDCol"].Value = ID;
                                customerList.Rows[rowIndex].Cells["CNameCol"].Value = Name;
                                customerList.Rows[rowIndex].Cells["StatusCol"].Value = Status;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetCustomers");
            }
        }


        public void DefaultLoad()
        {
            TransactionIDBox.Text = "";
            NameBox.Text = "";
            PhoneNumberBox.Text = "";

            AmountBox.Text = "";
            DiscountBox.Text = "";
            TotalAmountTxtB.Text = "";
            CustomerMoneyInput.Text = "";

            ProductsBoughtDGV.Rows.Clear();
            ServiceAcquiredDGV.Rows.Clear();
            TransactionIDBox.Enabled = true;
            LoadBtn.Enabled = true;

            GcashPayment.Enabled = false;
            VoidBtn.Enabled = false;
            PaymentBtn.Enabled = false;
            ClearFieldsBtn.Enabled = false;
            CalculateTotalBtn.Enabled = false;
            guna2Button1.Enabled = false;
            OtherTransactionContainer.Controls.Clear();
            ratingsNumber = 0;
        }

        public void GeneratePDFBothReceipt()
        {
            decimal subtotalAmount = decimal.Parse(AmountBox.Text);
            decimal totAmount = decimal.Parse(TotalAmountTxtB.Text);
            decimal discount = decimal.Parse(DiscountBox.Text);
            decimal downpayment = decimal.Parse(DownpaymentTxtB.Text);
            decimal cashEntered = decimal.Parse(CustomerMoneyInput.Text);
            int totalProductQuantity = 0;
            int totalServiceQuantity = ServiceAcquiredDGV.Rows.Count;
            string nameText = NameBox.Text;

            if (!decimal.TryParse(CustomerMoneyInput.Text, out cashEntered))
            {
                MessageBox.Show("Please enter a valid amount for payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cashEntered < totAmount)
            {
                MessageBox.Show("Please enter a valid amount for payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productSummaries = ProductsBoughtDGV.Rows.Cast<DataGridViewRow>()
                        .GroupBy(row => row.Cells["ProdNameCol"].Value.ToString())
                        .Select(group => new
                        {
                            ProductName = group.Key,
                            Quantity = group.Sum(row => Convert.ToInt32(row.Cells["QuantityCol"].Value)),
                            TotalPrice = group.Sum(row => Convert.ToDecimal(row.Cells["TotAmountCol"].Value))
                        })
                        .ToList();

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

                        ImageData pesoImageData = ImageDataFactory.Create(transaction.GetBytesFromImage(Properties.Resources.peso));
                        iText.Layout.Element.Image peso = new iText.Layout.Element.Image(pesoImageData);
                        peso.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);

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
                                string quantity = row.Cells[1].Value.ToString();
                                if (int.TryParse(quantity, out int quantityValue))
                                {
                                    totalProductQuantity += quantityValue;
                                }
                            }
                            foreach (var summary in productSummaries)
                            {
                                string variationCost = transaction.GetVariationCost(summary.ProductName);

                                Paragraph variationcost1 = new Paragraph();
                                variationcost1.Add(new iText.Layout.Element.Image(pesoImageData).SetHeight(9).SetWidth(9));
                                variationcost1.Add(new Text($"{variationCost}"));
                                Paragraph totalprice1 = new Paragraph();
                                totalprice1.Add(new iText.Layout.Element.Image(pesoImageData).SetHeight(9).SetWidth(9));
                                totalprice1.Add(new Text($"{summary.TotalPrice.ToString("0.00")}"));

                                productTable.AddCell(new Cell().Add(new Paragraph(summary.Quantity.ToString())).SetBorder(Border.NO_BORDER));
                                productTable.AddCell(new Cell().Add((variationcost1)).SetBorder(Border.NO_BORDER));
                                productTable.AddCell(new Cell().Add(new Paragraph(summary.ProductName)).SetBorder(Border.NO_BORDER));
                                productTable.AddCell(new Cell().Add((totalprice1)).SetBorder(Border.NO_BORDER));
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

                            Paragraph serviceCostParagraph = new Paragraph();
                            serviceCostParagraph.Add(new iText.Layout.Element.Image(pesoImageData).SetHeight(9).SetWidth(9));
                            serviceCostParagraph.Add(new Text($"{serviceAmount}"));

                            serviceTable.AddCell(new Cell().Add(new Paragraph(service)).SetBorder(Border.NO_BORDER));
                            serviceTable.AddCell(new Cell().Add((serviceCostParagraph)).SetBorder(Border.NO_BORDER));
                            serviceTable.AddCell(new Cell().Add((serviceCostParagraph)).SetBorder(Border.NO_BORDER));
                        }

                        doc.Add(serviceTable);

                        Table summaryTable = new Table(2);
                        summaryTable.SetWidth(UnitValue.CreatePercentValue(100));
                        summaryTable.SetTextAlignment(TextAlignment.LEFT);
                        decimal totalAmount = subtotalAmount - discount;
                        decimal change = cashEntered - totalAmount;

                        transaction.AddReceiptDetailRow(summaryTable, "SUBTOTAL:", $"{subtotalAmount.ToString("0.00")}", pesoImageData);
                        transaction.AddReceiptDetailRow(summaryTable, "DISCOUNT:", $"{discount.ToString("0.00")}", pesoImageData);
                        transaction.AddReceiptDetailRow(summaryTable, "DOWNPAYMENT:", $"{downpayment.ToString("0.00")}", pesoImageData);
                        transaction.AddReceiptDetailRow(summaryTable, "TOTAL:", $"{totalAmount.ToString("0.00")}", pesoImageData);
                        transaction.AddReceiptDetailRow(summaryTable, "CASH:", $"{cashEntered.ToString("0.00")}", pesoImageData);
                        transaction.AddReceiptDetailRow(summaryTable, "CHANGE:", $"{change.ToString("0.00")}", pesoImageData);

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


        private void Guna2CustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomRadioButton radioButton = sender as Guna2CustomRadioButton;

            // Check which radio button triggered the event
            switch (radioButton.Name)
            {
                case "RBtn1":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the first radio button
                        ratingsNumber = 1;
                    }
                    break;

                case "RBtn2":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the second radio button
                        ratingsNumber = 2;
                    }
                    break;

                case "RBtn3":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the third radio button
                        ratingsNumber = 3;
                    }
                    break;

                case "RBtn4":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the fourth radio button
                        ratingsNumber = 4;
                    }
                    break;

                case "RBtn5":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the fifth radio button
                        ratingsNumber = 5;
                    }
                    break;

                default:
                    // Handle the default case if necessary
                    MessageBox.Show("Paano ka nakarating dito");
                    break;
            }
        }
    }
}
