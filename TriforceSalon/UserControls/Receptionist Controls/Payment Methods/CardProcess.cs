using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    partial class CardProcess : UserControl
    {
        public CardProcess()
        {
            InitializeComponent();
            ExpirationDatePicker.Format = DateTimePickerFormat.Custom;
            ExpirationDatePicker.CustomFormat = "dd/MM/yyyy";

            ExpirationDatePicker.Value = DateTime.Today.AddDays(1);
            ExpirationDatePicker.MinDate = DateTime.Today.AddDays(1);
            ExpirationDatePicker.MaxDate = DateTime.Today.AddYears(5);
        }

        public static string CustomerName, EmployeeName, ServiceVariation, PaymentStatus,
            CardHolder, CardNumber;
        public static int Age, PhoneNumber, Balance, TransactionID, 
            CVC;
        public static DateTime CardExpiration;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public void ThrowData(string customerName, string employeeName, string serviceVariation, string paymentStatus, int age, int phoneNumber, int balance, int transactionID)
        {
            CustomerName = customerName;
            EmployeeName = employeeName;
            ServiceVariation = serviceVariation;
            PaymentStatus = paymentStatus;
            Age = age;
            PhoneNumber = phoneNumber;
            Balance = balance;
            TransactionID = transactionID;
        }

        private void CardNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            if (char.IsDigit(e.KeyChar) && (CardNumberBox.Text.Length == 4 || CardNumberBox.Text.Length == 9 || CardNumberBox.Text.Length == 14))
            {
                CardNumberBox.Text += "-";
                CardNumberBox.SelectionStart = CardNumberBox.Text.Length;
            }

            if (e.KeyChar == '\b')
            {
                if (CardNumberBox.SelectionStart > 1 && CardNumberBox.Text[CardNumberBox.SelectionStart - 2] == '-')
                {
                    if (CardNumberBox.SelectionStart > 4)
                    {
                        CardNumberBox.Text = CardNumberBox.Text.Remove(CardNumberBox.SelectionStart - 1, 1);
                    }
                    else
                    {
                        CardNumberBox.SelectionStart = Math.Max(CardNumberBox.SelectionStart - 1, 0);
                    }

                    CardNumberBox.SelectionStart = CardNumberBox.Text.Length;
                }
            }
            if (CardNumberBox.Text.Length >= 19 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void CVCBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (CVCBox.Text.Length >= 3 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CardNumberBox.Text) || string.IsNullOrEmpty(CVCBox.Text) || string.IsNullOrEmpty(CardNumberBox.Text))
            {
                MessageBox.Show("Please provide the complete information", "Payment Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ExpirationDatePicker.Value == DateTime.MinValue.AddDays(-1))
            {
                MessageBox.Show("Card expired today", "Card Declined", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CardNumber = CardNumberBox.Text;
            CVC = Convert.ToInt32(CVCBox.Text);
            CardHolder = CardNameBox.Text;
            CardExpiration = ExpirationDatePicker.Value;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    foreach (Control control in mainForm.Controls)
                    {
                        if (control is PaymentsUserControls paymentUserControl)
                        {
                            paymentUserControl.ChangePaymentStatus("PAID");
                            break;
                        } else
                        {
                            return;
                        }
                    }
                }
            }

            RecordInCardTransactions();
        }

        private void RecordInCardTransactions()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "INSERT INTO `card_transactions` (`TransactionID`, `CardName`, `CardNumber`, `CVC`, `Expiration`, `Amount`) VALUES (@TransactionID, @CardName, @CardNumber, @CVC, @Expiration, @Amount)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@TransactionID", TransactionID);
                        querycmd.Parameters.AddWithValue("@CardName", CustomerName);
                        querycmd.Parameters.AddWithValue("@CardNumber", CardNumber);
                        querycmd.Parameters.AddWithValue("@CVC", CVC);
                        querycmd.Parameters.AddWithValue("@Expiration", CardExpiration);
                        querycmd.Parameters.AddWithValue("@Amount", Balance);

                        int rowsAffected = querycmd.ExecuteNonQuery();

                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Payment Received", "TriCharm Salon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat RecordInCardTransactions()", "SQL ERROR", MessageBoxButtons.OK);
            }
            this.Visible = false;
        }

        public void DefaultLoad()
        {
            CardNumberBox.Text = "";
            CVCBox.Text = "";
            CardNameBox.Text = "";
            ExpirationDatePicker.Value = DateTime.Now.AddDays(3);
        }
    }
}
