using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TriforceSalon
{
    internal class Inventory
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static int ShipmentReference;

        public static void CheckStatus()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `inventory` SET `Status` = " +
                        "CASE " +
                            "WHEN `Stock` = 0 THEN 3 " +
                            "WHEN `Stock` <= 0.25 * `Aggregate` THEN 2 " + 
                            "WHEN `Stock` <= 0.5 * `Aggregate` THEN 1 " + 
                            "ELSE 0 " + 
                            "END;";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat CheckStatus()", "SQL ERROR", MessageBoxButtons.OK);
            }
        }



        public static int ShipmentID()
        {
            Random random = new Random();
            do
            {
                ShipmentReference = random.Next(100000, 1000000);

            } while (Method.DuplicateChecker(ShipmentReference.ToString(), "ShipmentID", "shipments") == true);
            return ShipmentReference;
        }

        public static void AddShippedItems(int ID, int Stock)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `inventory` SET `Stock` = `Stock` + @newStock WHERE `ItemID` = @itemID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@newStock", Stock);
                        querycmd.Parameters.AddWithValue("@itemID", ID);
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat AddShippedItems()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LessUsedProduct(int ID, int Deductions)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    string checkQuery = "SELECT `Stock` FROM `inventory` WHERE `ItemID` = @itemID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@itemID", ID);
                        int currentStock = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (currentStock < Deductions)
                        {
                            MessageBox.Show("Insufficient stock.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "UPDATE `inventory` SET `Stock` = `Stock` - @deductions WHERE `ItemID` = @itemID";
                    using (MySqlCommand queryCmd = new MySqlCommand(query, connection))
                    {
                        queryCmd.Parameters.AddWithValue("@itemID", ID);
                        queryCmd.Parameters.AddWithValue("@deductions", Deductions);
                        queryCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LessUsedProduct()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
