using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_roject.Sales
{
    internal class SalesClass
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static DateTime sunday, saturday;

        public static async Task<DataTable> GetTransactionsAsync()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                await connection.OpenAsync();

                string query = "SELECT `TransactionID`, `CustomerName`, `CustomerAge`, `CustomerPhoneNumber`, `ServiceVariation`, `EmployeeID`," +
                    "`PriorityStatus`, `ServiceVariationID`, `Amount`, `TimeTaken` FROM `transaction` WHERE `PaymentStatus` = PAID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        await adapter.FillAsync(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static async Task<DataTable> GetPerUser()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                await connection.OpenAsync();

                string query = "SELECT EmployeeID, DATE(TimeTaken) AS TimeTaken, SUM(Amount) AS TotalSale " +
                               "FROM transaction " +
                               "GROUP BY EmployeeID, DATE(TimeTaken)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        await adapter.FillAsync(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static async Task<DataTable> GetPerProduct()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                await connection.OpenAsync();
                string query = "SELECT ManagerID AS EmployeeID, " +
                               "       `Date Shipped` AS TimeTaken, " +
                               "       ShipmentID, " +
                               "       ItemID, " +
                               "       ItemName, " +
                               "       Quantity, " +
                               "       Cost, " +
                               "       Supplier " +
                               "FROM shipments";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        await adapter.FillAsync(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static async Task<DataTable> GetPerServiceVariation()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                await connection.OpenAsync();
                string query = "SELECT ServiceType, " +
                               "       ServiceVariation, " +
                               "       ServiceVariationID, " +
                               "       DATE(TimeTaken) AS TimeTaken, " +
                               "       SUM(Amount) AS TotalAmount " +
                               "FROM transaction " +
                               "GROUP BY ServiceType, ServiceVariation, DATE(TimeTaken)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        await adapter.FillAsync(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
