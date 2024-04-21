using iText.Layout.Element;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls.Admin_Controls;
using TriforceSalon.UserControls.Admin_Controls.Ticketing;

namespace TriforceSalon.Class_Components
{
    internal class AdminTicketing
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string Type, Accounts, Steps;
        public static int ReferenceNumber;
        public static byte[] Proof;
        public DataTable newData;

        public static void UploadData(string type, string account, string step, byte[] proof)
        {
            string query = @"INSERT INTO `AdminTickets`(`ReferenceNumber`, `Type`, `Steps`, `Accounts`, `Proof`)
                            VALUES (@refNumber, @type, @steps, @accounts, @proof)";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@refNumber", RefNumber());
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@steps", step);
                        cmd.Parameters.AddWithValue("@accounts", account);
                        cmd.Parameters.AddWithValue("@proof", proof);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ticket submitted.", "Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n@UploadData", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int RefNumber()
        {
            int reference;
            Random random = new Random();

            do
            {
                reference = random.Next(99999999, 1000000000);
            } while (Method.DuplicateChecker(reference.ToString(), "ReferenceNumber", "AdminTickets"));

            return reference;
        }

        public static DataTable GetAdminTickets()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    string query = "SELECT `ReferenceNumber`, `Type`, `Steps`, `Accounts` FROM `AdminTickets` WHERE `Status` = 'Open'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n@GetAdminTickets", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}
