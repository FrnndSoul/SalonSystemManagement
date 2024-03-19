using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class PaymentsUserControls : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string CustomerName, ServiceType, ServiceVariation, PriorityStatus, EmployeeName, PaymentStatus, Phone;
        public static int TransactionID, Age, EmployeeID, VariationID, Amount;


        public PaymentsUserControls()
        {
            InitializeComponent();
            AdjustCheckBoxSize(PWDCheckbox);
        }

        private void PaymentsUserControls_Load(object sender, EventArgs e)
        {

        }

        private void GcashPayment_Click(object sender, EventArgs e)
        {
            gcashProcess1.Visible = true;
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

        }

        private void CardPayment_Click(object sender, EventArgs e)
        {
            cardProcess1.Visible = true;
            cardProcess1.ThrowData(CustomerName, EmployeeName, ServiceVariation, PaymentStatus, Age, Phone, Amount, Convert.ToInt32(TransactionIDBox.Text));
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            long CustomerID = Convert.ToInt64(TransactionIDBox.Text);
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "select CustomerName, CustomerAge, CustomerPhoneNumber, PriorityStatus, PaymentStatus, TimeTaken, EmployeeID, ServiceType " +
                        "from customer_info " +
                        "where TransactionID = @transactionID";

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
                                }

                                else if (string.Equals(paymentstatus, "VOIDED", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Transaction ID was voided", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                CustomerName = reader["CustomerName"].ToString();
                                ServiceType = reader["ServiceType"].ToString();
                                Age = Convert.ToInt32(reader["CustomerAge"]);
                                Phone = Convert.ToString(reader["CustomerPhoneNumber"]);
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]);

                                DisplayTransaction();
                                await FillProductsBoughtAsync(CustomerID, ProductsBoughtDGV);
                                await FillServiceAcquiredAsync(CustomerID, ServiceAcquiredDGV);
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
            ServiceTypeBox.Text = ServiceType;
            //ServiceVariationBox.Text = ServiceVariation;
            //ServiceVariationIDBox.Text = VariationID.ToString();
            EmployeeIDBox.Text = EmployeeID.ToString();
            //AmountBox.Text = Amount.ToString();


            PaymentPanel.Enabled = true;
            TransactionIDBox.Enabled = false;
            LoadBtn.Enabled = false;
            CardPayment.Enabled = true;
            CashPayment.Enabled = true;
            GcashPayment.Enabled = true;
            VoidBtn.Enabled = true;

            if (Age >= 60)
            {
                PWDCheckbox.Checked = true;
                int amountValue = Convert.ToInt32(Amount);
                Amount = (int)(amountValue * 0.8);
                int discount = (int)(amountValue * 0.2);
                DiscountBox.Text = discount.ToString();
            }
        }



        private void VoidBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirming before voiding this transaction.", "Confirm Void Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }
            ChangePaymentStatus("VOIDED");
            DefaultLoad();
        }

        public void ChangePaymentStatus(string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `transaction` SET `PaymentStatus` = @NewStatus WHERE `TransactionID` = @TransactionID";
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

        public async Task FillProductsBoughtAsync(long transactionID, Guna2DataGridView productsBoughtDGV)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Select ProductName, Quantity, Amount from product_group where ProductGroupID = @transactionID";

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

        public void DefaultLoad()
        {
            TransactionIDBox.Text = "";
            NameBox.Text = "";
            AgeBox.Text = "";
            PhoneNumberBox.Text = "";
            ServiceTypeBox.Text = "";
            ServiceVariationBox.Text = "";
            ServiceVariationIDBox.Text = "";
            EmployeeIDBox.Text = "";
            AmountBox.Text = "";
            DiscountBox.Text = "";

            PaymentPanel.Enabled = false;

            PWDCheckbox.Checked = false;

            TransactionIDBox.Enabled = true;
            LoadBtn.Enabled = true;
            CardPayment.Enabled = false;
            CashPayment.Enabled = false;
            GcashPayment.Enabled = false;
            VoidBtn.Enabled = false;

            cardProcess1.Visible = false;
            gcashProcess1.Visible = false;
        }

        private void cardProcess1_VisibleChanged(object sender, EventArgs e)
        {
            if (cardProcess1.Visible == false)
            {
                cardProcess1.DefaultLoad();
            }
        }

        private void CashPayment_Click(object sender, EventArgs e)
        {
            string userInput = ShowInputDialog("Enter the amount of customer's money:", "Cash Payment");

            if (!string.IsNullOrEmpty(userInput))
            {
                int cash = Convert.ToInt32(userInput);
                if (cash < Convert.ToInt32(AmountBox.Text))
                {
                    MessageBox.Show("Not enough cash entered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cash > Convert.ToInt32(AmountBox.Text))
                    {
                        //MessageBox.Show($"Customer's change: {Convert.ToInt32(AmountBox.Text) - cash}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"Customer's change: {cash - Convert.ToInt32(AmountBox.Text)}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangePaymentStatus("PAID");

                    }
                    else
                    {
                        MessageBox.Show("No change needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangePaymentStatus("PAID");

                    }
                    ChangePaymentStatus("PAID");
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
    }
}
