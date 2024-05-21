using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.UserControls.Receptionist_Controls.Payment_Methods
{
    public partial class GcashProcessB : UserControl
    {
        public static int ReferenceNumber, TransactionID;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public GcashProcessB()
        {
            InitializeComponent();
        }

        private void ReferenceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (ReferenceBox.Text.Length >= 13 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (ReferenceBox.Text.Length == 13)
            {
                PaymentBtn.Enabled = true;
            } else
            {
                PaymentBtn.Enabled = false;
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            long TransactionID = Convert.ToInt64(PaymentsUserControls.paymentInstance.TransactionIDBox.Text);
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "INSERT INTO `gcash_transactions` (`TransactionID`, `ReferenceNumber`) VALUES (@TransactionID, @ReferenceNumber)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@TransactionID", TransactionID);
                        querycmd.Parameters.AddWithValue("@ReferenceNumber", ReferenceBox.Text);

                        int rowsAffected = querycmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment Received", "TriCharm Salon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nat RecordInCardTransactions()", "SQL ERROR", MessageBoxButtons.OK);
            }
            this.Visible = false;
        }
    }
}
