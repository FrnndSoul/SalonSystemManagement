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
        }

        private void CardPayment_Click(object sender, EventArgs e)
        {
            cardProcess1.Visible = true;
            cardProcess1.ThrowData(CustomerName, EmployeeName, ServiceVariation, PaymentStatus, Age, Phone, Amount);
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


            TransactionIDBox.Enabled = true;
            LoadBtn.Enabled = true;
            CardPayment.Enabled = false;
            CashPayment.Enabled = false;
            GcashPayment.Enabled = false;
            VoidBtn.Enabled = false;

            cardProcess1.Visible = false;
        }

        private void cardProcess1_VisibleChanged(object sender, EventArgs e)
        {
            if (cardProcess1.Visible == false)
            {
                cardProcess1.DefaultLoad();
            }
        }
    }
}
