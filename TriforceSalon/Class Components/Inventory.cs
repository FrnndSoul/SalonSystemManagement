using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
                    string query = @"UPDATE `inventory` SET `Status` = 
                        CASE
                            WHEN `Stock` = 0 THEN 3 
                            WHEN `Stock` = 3 THEN 2 
                            WHEN `Stock` = 5 THEN 1 
                            ELSE 0 
                            END; ";
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

        public static int GenerateID()
        {
            Random random = new Random();
            int id = random.Next(10000, 100000);
            return id;
        }

        public static void PullStocks()
        {
            try
            {

            } catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Error");
            }
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

                        if (Method.AdminAccess())
                        {
                            MessageBox.Show("Working as intended.\nNo changes were made in the database");
                        }
                        else
                        {
                            querycmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat AddShippedItems()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async static void PullItems(int qty)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = @"
                        UPDATE inventory
                        SET Stock = Stock - @quantity";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("quantity", qty);
                        int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public async Task <int> GetItemIDByName(string productName)
        {
            int itemID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Select ItemID from inventory WHERE ItemName = @itemName";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@itemName", productName);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out itemID))
                        {
                            return itemID;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nat GetItemIDByName()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return itemID;
        }

        public async Task SubtractItemsInInventoryForPurchase(Guna2DataGridView productsDataGrid)
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
                        string itemName = Convert.ToString(row.Cells["ProductCol"].Value);
                        int productID = await GetItemIDByName(itemName);
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
        }

        public async static Task DeductItems(string id, string qty)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string subtractQuery = "UPDATE inventory SET Stock = Stock - @quantity WHERE ItemID = @itemID";
                   
                    using (MySqlCommand command = new MySqlCommand(subtractQuery, conn))
                    {
                        command.Parameters.AddWithValue("@quantity", qty);
                        command.Parameters.AddWithValue("@itemID", id);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\nat DeductItems()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
