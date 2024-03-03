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
        //UNPAID, PAID, VOID
        public static string CustomerName, ServiceType, ServiceVariation, PriorityStatus;
        public static int TransactionID, Age, Phone, EmployeeID, VariationID, Amount;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public PaymentsUserControls()
        {
            InitializeComponent();
        }

        private void TransactionIDBox_KeyPress(object sender, KeyPressEventArgs e)
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
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nat TransactionIDBox Key Press","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }


        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void PaymentsUserControls_Load(object sender, EventArgs e)
        {

        }
    }
}
