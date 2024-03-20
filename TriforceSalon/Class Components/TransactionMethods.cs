using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Web.Util;
using System.Windows.Forms;
using TriforceSalon.UserControls.Receptionist_Controls;

namespace TriforceSalon.Class_Components
{
    public class TransactionMethods
    {
        private string mysqlcon;
        private int TypeID;
        private int VariationID;
        private int EmpID;
        public TransactionMethods()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public void ProcessCustomer(string serviceName, int serviceID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    /*string query = "insert into transaction (TransactionID, EmployeeID, CustomerName, CustomerAge, CustomerPhoneNumber, ServiceVariation, ServiceType, ServiceVariationID, Amount, TimeTaken)" +
                        "values(@transactionID, @pref_emp, @customer_name, @customer_age, @customer_number, @service_var, @service_type, @service_varID, @amount, @time_taken)";*/

                    string testQuery = "insert into customer_info (TransactionID, CustomerName, CustomerAge, CustomerPhoneNumber, EmployeeID, ServiceType, ServiceGroupID)" +
                            " Values (@transactionID, @customer_name, @customer_age, @customer_number, @pref_emp, @service_type, @service_groupID);" +

                            "insert into service_group (ServiceGroupID, ServiceVariation, ServiceVariationID, Amount)" +
                            " values(@service_groupID, @service_var, @service_varID, @amount);";


                    using (MySqlCommand command = new MySqlCommand(testQuery, conn))
                    {
                        //for custoemr_info
                        command.Parameters.AddWithValue("@transactionID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                        command.Parameters.AddWithValue("@customer_name", ServicesUserControl.servicesUserControlInstance.CustomerNameTxtB.Text);
                        command.Parameters.AddWithValue("@customer_age", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.CustomerAgeTxtB.Text));
                        command.Parameters.AddWithValue("@customer_number", Convert.ToString(ServicesUserControl.servicesUserControlInstance.CustomerPhoneNTxtB.Text));
                        command.Parameters.AddWithValue("@service_type", GetServiceTypeName(serviceID));

                        //for service_group
                        command.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                        command.Parameters.AddWithValue("@service_var", ServicesUserControl.servicesUserControlInstance.ServiceTxtB.Text);
                        command.Parameters.AddWithValue("@service_varID", GetServiceVariationID(serviceName));

                        command.Parameters.AddWithValue("@amount", Convert.ToDecimal(ServicesUserControl.servicesUserControlInstance.ServiceAmountTxtB.Text));

                        //command.Parameters.AddWithValue("@time_taken", DateTime.Now);
                        //palitan ito
                        //command.Parameters.AddWithValue("@pref_emp", GetEmployeeID(Convert.ToString(ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedItem)));

                        if (Convert.ToString(ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedItem) == null ||
                            Convert.ToString(ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedItem) == "None" ||
                            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedIndex == -1)
                        {
                            command.Parameters.AddWithValue("@pref_emp", 0);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@pref_emp", GetEmployeeID(Convert.ToString(ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedItem)));
                        }
                        command.ExecuteNonQuery();


                        MessageBox.Show("Customer Added to the Queue", "Customer Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearProcess();
                        ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text = Convert.ToString(GenerateTransactionID());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in ProcessCustomer");

            }
        }

        public int GetEmployeeID(string name)
        {
            EmpID = -1;

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select AccountID from salon_employees where Name = @name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", name);
                       
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out EmpID))
                        {
                            return EmpID;
                        }
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetEmployeeID");
            }
            return EmpID;
        }

        public async Task GetAllUnfinishedTickets()
        {
            using(var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();

                string query = "SELECT TransactionID FROM customer_info WHERE PaymentStatus = 'PROCESSED' or PaymentStatus = 'UNPAID' ";

                using(MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using(DbDataReader reader = await  command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                string CustomerID = reader["TransactionID"].ToString();
                                SellProductsUserControls.sellProductsUserControlsInstance.CustomerIDComB.Items.Add(CustomerID);
                            }
                        }
                    }
                }
            }
        }

        public async Task<int> GetItemIdAsync(string itemName)
        {
            int item_id = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ItemID from inventory where ItemName = @item_name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@item_name", itemName);

                        object result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out item_id))
                        {
                            return item_id;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error in GetItemId", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return item_id;
        }


        public async Task PurchaseToDatabase(int ID, Guna2DataGridView products)
        {
            //bool itemNameFound = false;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    foreach(DataGridViewRow row in products.Rows)
                    {
                        string itemName;
                        if (row.Cells["ProductCol"].Value != null)
                        {
                            itemName = row.Cells["ProductCol"].Value.ToString();
                            //itemNameFound = true;
                        }
                        else
                        {
                            continue;
                        }

                        int qty = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                        decimal amount = Convert.ToDecimal(row.Cells["CostCol"].Value);
                        int itemid = await GetItemIdAsync(itemName);
                        //update customer_info set (ProductsBoughtID) values(@customerID)
                        //Insert into customer_info (ProductsBoughtID) values (@customerID)

                        string query = "update customer_info set ProductsBoughtID = @customerID where TransactionID = @customerID;" +

                        "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, EmployeeID, OrderDate) " +
                        "values (@customerID, @productName, @productID, @quantity, @amount, @employeeID, @orderDate)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@customerID", ID);
                            command.Parameters.AddWithValue("@productName", itemName);
                            command.Parameters.AddWithValue("@productID", itemid);
                            command.Parameters.AddWithValue("@quantity", qty);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@employeeID", Method.AccountID);
                            command.Parameters.AddWithValue("@orderDate", DateTime.Now);

                            await command.ExecuteNonQueryAsync();
                        }
                        MessageBox.Show("Products has been sent to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearContents();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in PurchaseToDatabase");
            }
        }

        public async Task PurchaseToReceipt(int ID, Guna2DataGridView products)
        {
            int salesID = GenerateTransactionID();
            int orderID = GenerateTransactionID();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    foreach (DataGridViewRow row in products.Rows)
                    {
                        string itemName;
                        if (row.Cells["ProductCol"].Value != null)
                        {
                            itemName = row.Cells["ProductCol"].Value.ToString();
                            //itemNameFound = true;
                        }
                        else
                        {
                            continue;
                        }

                        int qty = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                        decimal amount = Convert.ToDecimal(row.Cells["CostCol"].Value);
                        int itemid = await GetItemIdAsync(itemName);

                        string query = "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, EmployeeID, OrderDate) " +
                        "values (@productGroupID, @productName, @productID, @quantity, @productGAmount, @employeeID, @orderDate)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            string totalText = SellProductsUserControls.sellProductsUserControlsInstance.TotLbl.Text;
                            string numericValue = totalText.Replace("Php.", "").Trim();
                            decimal.TryParse(numericValue, out decimal totalAmount);


                            command.Parameters.AddWithValue("@productGroupID", ID);
                            command.Parameters.AddWithValue("@productName", itemName);
                            command.Parameters.AddWithValue("@productID", itemid);
                            command.Parameters.AddWithValue("@quantity", qty);
                            command.Parameters.AddWithValue("@productGAmount", amount);
                            command.Parameters.AddWithValue("@employeeID", Method.AccountID);
                            command.Parameters.AddWithValue("@orderDate", DateTime.Now);
                            await command.ExecuteNonQueryAsync();
                        }
                    }

                    await InsertToSales(salesID, orderID);

                    MessageBox.Show("Purchase Complete, Handling Receipt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearContents();
                    //GeneratePurchaseOnlyReceipt();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in PurchaseToReceipt");
            }
        }

        public async Task InsertToSales(int saleID, int ID)
        {
           
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "Insert into sales (SaleID, OrderID, SaleDate, Amount) values (@saleID, @orderID, @saleDate, @totAmount)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        string totalText = SellProductsUserControls.sellProductsUserControlsInstance.TotLbl.Text;
                        string numericValue = totalText.Replace("Php.", "").Trim();
                        decimal.TryParse(numericValue, out decimal totalAmount);

                        command.Parameters.AddWithValue("@saleID", saleID);
                        command.Parameters.AddWithValue("@orderID", ID);
                        command.Parameters.AddWithValue("@saleDate", DateTime.Now);
                        command.Parameters.AddWithValue("@totAmount", totalAmount);

                        await command.ExecuteNonQueryAsync();
                    }

                }
            }
            catch( Exception ex ) 
            {
                MessageBox.Show(ex.Message, "Error in InsertToSales");
            }
        }


        public void VoidOrderButton()
        {

        }

        public void ClearContents()
        {
            SellProductsUserControls.sellProductsUserControlsInstance.ProductsControlDGV.Rows.Clear();
            SellProductsUserControls.sellProductsUserControlsInstance.CustomerNameTxtB.Text = null;
            SellProductsUserControls.sellProductsUserControlsInstance.CustomerIDComB.SelectedItem = null;
            SellProductsUserControls.sellProductsUserControlsInstance.CashTxtBx.Text = null;
        }



        public int GenerateTransactionID()
        {
            Random rnd = new Random();
            int ID = rnd.Next(0, 100000001);

            return ID;
        }
        public int GetServiceTypeID(string serviceName)
        {
            TypeID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select ServiceTypeID from salon_services where ServiceName = @service_name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out TypeID))
                        {
                            return TypeID;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServiceType");
            }
            return TypeID;
        }

        public string GetServiceTypeName(int serviceTypeID)
        {
            string TypeName = null;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceTypeName FROM service_type WHERE ServiceID = @service_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_ID", serviceTypeID);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            TypeName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServiceType");
            }

            return TypeName;
        }

        public int GetServiceVariationID(string serviceName)
        {
            VariationID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select ServiceVariationID from salon_services where ServiceName = @service_name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out VariationID))
                        {
                            return VariationID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServiceType");
            }
            return VariationID;
        }

        public void LockTransactionNavigation(List<Guna2Button> buttons, Guna2Button clickedButton)
        {
            foreach (var button in buttons)
            {
                if (button == clickedButton)
                {
                    button.Enabled = false;
                    button.BackColor = Color.FromArgb(255, 228, 242);
                    button.BorderColor = Color.FromArgb(52, 42, 83);
                }
            }
        }

        public void EnableTransactionNavigation(List<Guna2Button> buttons, Guna2Button clickedButton)
        {
            foreach (var button in buttons)
            {
                if (button != clickedButton)
                {
                    button.Enabled = true;
                    button.BackColor = Color.FromArgb(52, 42, 83);
                    button.BorderColor = Color.Black;
                }
            }
        }

        public void ClearProcess()
        {
            ServicesUserControl.servicesUserControlInstance.CustomerNameTxtB.Text = null;
            ServicesUserControl.servicesUserControlInstance.CustomerAgeTxtB.Text = null;
            ServicesUserControl.servicesUserControlInstance.CustomerPhoneNTxtB.Text = null;
            ServicesUserControl.servicesUserControlInstance.ServiceTxtB.Text = null;
            ServicesUserControl.servicesUserControlInstance.ServiceAmountTxtB.Text = null;
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedItem = null;
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedIndex = -1;

        }
    }
}