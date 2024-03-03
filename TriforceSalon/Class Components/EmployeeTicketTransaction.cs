using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class EmployeeTicketTransaction
    {
        private string mysqlcon;
        public EmployeeTicketTransaction()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public void ProcessTicket(int ticketID)
        {
            DateTime startTIme = DateTime.Now;
            int accountID = 13018;


            DialogResult choices = MessageBox.Show("Are you sure you want to serve this customer?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlcon))
                    {
                        conn.Open();
                        string query = "Insert into employee_records (AccountID, TimeStart, CustomerID)" +
                            "Value(@accountID, @timeStart, @customerID)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("accountID", accountID);
                            command.Parameters.AddWithValue("timeStart", startTIme);
                            command.Parameters.AddWithValue("customerID", ticketID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Nakaabot Dito, check the database");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in ProcessTicket()");
                }
            }
        }
    }
}
