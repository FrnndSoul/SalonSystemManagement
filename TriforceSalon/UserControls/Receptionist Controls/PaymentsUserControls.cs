using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class PaymentsUserControls : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string CustomerName, ServiceType, ServiceVariation, PriorityStatus, EmployeeName, PaymentStatus;
        public static int TransactionID, Age, Phone, EmployeeID, VariationID, Amount;

        public PaymentsUserControls()
        {
            InitializeComponent();
            AdjustCheckBoxSize(PWDCheckbox);
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

        private void PWDCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CardPayment_Click(object sender, EventArgs e)
        {
            cardProcess1.Visible = true;
            cardProcess1.ThrowData(CustomerName, EmployeeName, ServiceVariation, PaymentStatus, Age, Phone, Amount, Convert.ToInt32(TransactionIDBox.Text));
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT * FROM `transaction` WHERE TransactionID = @transacID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@transacID", TransactionIDBox.Text);
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CustomerName = reader["Password"].ToString();
                                ServiceType = reader["ServiceType"].ToString();
                                ServiceVariation = reader["ServiceVariation"].ToString();
                                PriorityStatus = reader["PriorityStatus"].ToString();
                                Age = Convert.ToInt32(reader["Age"]);
                                Phone = Convert.ToInt32(reader["Phone"]);
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                                VariationID = Convert.ToInt32(reader["VariationID"]);
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
            }
        }

        private void DisplayTransaction()
        {
            NameBox.Text = CustomerName;
            AgeBox.Text = Age.ToString();
            PhoneNumberBox.Text = Phone.ToString();
            ServiceTypeBox.Text = ServiceType;
            ServiceVariationBox.Text = ServiceVariation;
            ServiceVariationIDBox.Text = ServiceVariationIDBox.ToString();
            EmployeeIDBox.Text = EmployeeID.ToString();

            if (Age >= 60)
            {
                PWDCheckbox.Checked = true;
                int amountValue = Convert.ToInt32(Amount);
                Amount = (int)(amountValue * 0.8);
                int discount = (int)(amountValue * 0.2);
                DiscountBox.Text = discount.ToString();
            }
            
            AmountBox.Text = Amount.ToString();
            TransactionIDBox.Enabled = false;
            LoadBtn.Enabled = false;
            CardPayment.Enabled = true;
            CashPayment.Enabled = true;
            GcashPayment.Enabled = true;
            VoidBtn.Enabled = true;
        }

        private void PaymentsUserControls_Load(object sender, EventArgs e)
        {

        }

        private void VoidBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirming before voiding this transaction.", "Confirm Void Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }
            ChangePaymentStatus("VOIDED");
        }

        public void ChangePaymentStatus(string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `card_transactions` SET `PaymentStatus` = @NewStatus WHERE `TransactionID` = @TransactionID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", newStatus);
                        command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error updating payment status: {e.Message}", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Not enough cash entered!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                } else
                {
                    if (cash > Convert.ToInt32(AmountBox.Text))
                    {
                        MessageBox.Show($"Customer's change: {Convert.ToInt32(AmountBox.Text) - cash}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("No change needed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
