using Guna.UI2.WinForms;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls.Receptionist_Controls;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Table = iText.Layout.Element.Table;
using TextAlignment = iText.Layout.Properties.TextAlignment;


namespace TriforceSalon.Class_Components
{
    public class TransactionMethods
    {
        Inventory inventoryMethods = new Inventory();
        private string mysqlcon;
        private int TypeID;
        private int VariationID;
        private int EmpID;
        public TransactionMethods()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        /*public async Task TestProcessCustomer(Guna2DataGridView serviceDataGrid, string priorityStatus, string specialID)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string insertToCustomerInfo = "insert into customer_info (TransactionID, CustomerName, SpecialID, CustomerPhoneNumber, ServiceGroupID, PriorityStatus)" +
                        " Values (@transactionID, @customer_name, @customer_sID, @customer_number, @service_groupID, @priorityStatus)";

                    using(MySqlCommand command1 = new MySqlCommand(insertToCustomerInfo, conn))
                    {
                        command1.Parameters.AddWithValue("@transactionID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@customer_name", ServicesUserControl.servicesUserControlInstance.CustomerNameTxtB.Text);
                        command1.Parameters.AddWithValue("@customer_sID", specialID);
                        command1.Parameters.AddWithValue("@customer_number", Convert.ToString(ServicesUserControl.servicesUserControlInstance.CustomerPhoneNTxtB.Text));
                        command1.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@priorityStatus", priorityStatus);

                        await command1.ExecuteNonQueryAsync();
                    }

                    string insertToServiceGroup = "insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount, Discount, QueueNumber, AppointmentDate)"
                    + " values(@service_groupID, @service_type, @pref_emp, @service_var, @service_varID, @amount, @discount, @queueNumber, @date)";

                    foreach (DataGridViewRow row in serviceDataGrid.Rows)
                    {
                        string serviceType = Convert.ToString(row.Cells["ServiceTypeCol"].Value);
                        string serviceVariation = Convert.ToString(row.Cells["SNameCol"].Value);
                        string preferredEmployee = Convert.ToString(row.Cells["PrefEmpCol"].Value);
                        decimal serviceAMount = Convert.ToDecimal(row.Cells["AmountCol"].Value);
                        int queueNumber = Convert.ToInt32(row.Cells["QueNumCol"].Value);
                        string discount = Convert.ToString(row.Cells["DiscountCol"].Value);

                        //edit mo ito para mamatch mo yung hinahanap sa database
                        using (MySqlCommand command2 = new MySqlCommand(insertToServiceGroup, conn))
                        {
                            command2.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                            command2.Parameters.AddWithValue("@service_type", await GetServiceType(serviceVariation));
                            command2.Parameters.AddWithValue("@service_var", serviceVariation);
                            command2.Parameters.AddWithValue("@service_varID", GetServiceVariationID(serviceVariation));
                            command2.Parameters.AddWithValue("@amount", serviceAMount);
                            command2.Parameters.AddWithValue("@discount", discount);
                            command2.Parameters.AddWithValue("@queueNumber", queueNumber);
                            command2.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM-dd-yyyy dddd"));

                            if (preferredEmployee == null || string.IsNullOrWhiteSpace(preferredEmployee) || preferredEmployee == "None")
                            {
                                command2.Parameters.AddWithValue("@pref_emp", 0);
                            }
                            else
                            {
                                int employeeID = GetEmployeeID(preferredEmployee);
                                command2.Parameters.AddWithValue("@pref_emp", GetEmployeeID(preferredEmployee));
                            }


                            await command2.ExecuteNonQueryAsync();
                        }
                    }
                }
                MessageBox.Show("Customer has been processed", "Process Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in TestProcessCustomer");

            }
        }*/

        public async Task TestProcessCustomer(Guna2DataGridView serviceDataGrid, string priorityStatus)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertToCustomerInfo = "insert into customer_info (TransactionID, CustomerName, CustomerPhoneNumber, ServiceGroupID, PriorityStatus)" +
                                " Values (@transactionID, @customer_name, @customer_number, @service_groupID, @priorityStatus)";

                            using (MySqlCommand command1 = new MySqlCommand(insertToCustomerInfo, conn, transaction))
                            {
                                command1.Parameters.AddWithValue("@transactionID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                                command1.Parameters.AddWithValue("@customer_name", ServicesUserControl.servicesUserControlInstance.CustomerNameTxtB.Text);
                                command1.Parameters.AddWithValue("@customer_number", Convert.ToString(ServicesUserControl.servicesUserControlInstance.CustomerPhoneNTxtB.Text));
                                command1.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                                command1.Parameters.AddWithValue("@priorityStatus", priorityStatus);

                                await command1.ExecuteNonQueryAsync();
                            }

                            string insertToServiceGroup = "insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount, Discount, QueueNumber, AppointmentDate)"
                                + " values(@service_groupID, @service_type, @pref_emp, @service_var, @service_varID, @amount, @discount, @queueNumber, @date)";

                            foreach (DataGridViewRow row in serviceDataGrid.Rows)
                            {
                                string serviceType = Convert.ToString(row.Cells["ServiceTypeCol"].Value);
                                string serviceVariation = Convert.ToString(row.Cells["SNameCol"].Value);
                                string preferredEmployee = Convert.ToString(row.Cells["PrefEmpCol"].Value);
                                decimal serviceAMount = Convert.ToDecimal(row.Cells["AmountCol"].Value);
                                int queueNumber = Convert.ToInt32(row.Cells["QueNumCol"].Value);
                                string discount = Convert.ToString(row.Cells["DiscountCol"].Value);

                                //edit mo ito para mamatch mo yung hinahanap sa database
                                using (MySqlCommand command2 = new MySqlCommand(insertToServiceGroup, conn, transaction))
                                {
                                    command2.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                                    command2.Parameters.AddWithValue("@service_type", await GetServiceType(serviceVariation));
                                    command2.Parameters.AddWithValue("@service_var", serviceVariation);
                                    command2.Parameters.AddWithValue("@service_varID", GetServiceVariationID(serviceVariation));
                                    command2.Parameters.AddWithValue("@amount", serviceAMount);
                                    command2.Parameters.AddWithValue("@discount", discount);
                                    command2.Parameters.AddWithValue("@queueNumber", queueNumber);
                                    command2.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM-dd-yyyy dddd"));

                                    if (preferredEmployee == null || string.IsNullOrWhiteSpace(preferredEmployee) || preferredEmployee == "None")
                                    {
                                        command2.Parameters.AddWithValue("@pref_emp", 0);
                                    }
                                    else
                                    {
                                        int employeeID = GetEmployeeID(preferredEmployee);
                                        command2.Parameters.AddWithValue("@pref_emp", GetEmployeeID(preferredEmployee));
                                    }

                                    await command2.ExecuteNonQueryAsync();
                                }
                            }

                            // If not admin, commit the transaction
                            if (!Method.AdminAccess())
                            {
                                transaction.Commit();
                                MessageBox.Show("Customer has been processed", "Process Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If admin, rollback the transaction
                                transaction.Rollback();
                                MessageBox.Show("Working as intended. No changes were made.", "Process Customer Function", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public async Task<string> GetServiceType(string serviceName)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT st.ServiceTypeName FROM service_type st " +
                        "JOIN salon_subtypes sbt ON st.ServiceID = sbt.ServiceTypeID " +
                        "JOIN salon_services ss ON sbt.CategoryID = ss.ServiceTypeID " +
                        "WHERE ServiceName = @serviceName";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@serviceName", serviceName);

                        object result = await command.ExecuteScalarAsync();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServiceType");
            }
            return null;
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
            SellProductsUserControls.sellProductsUserControlsInstance.CustomerIDComB.Items.Clear();

            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();

                //string query = "SELECT TransactionID FROM customer_info WHERE DATE(TimeTaken) = CURDATE() AND PaymentStatus = 'PROCESSED' or PaymentStatus = 'UNPAID' ";
                string query = "SELECT TransactionID FROM customer_info WHERE DATE(TimeTaken) = CURDATE() AND (PaymentStatus = 'PROCESSED' OR PaymentStatus = 'UNPAID')";

                using (MySqlCommand command = new MySqlCommand(query, conn))
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


        /*public async Task PurchaseToDatabase(int ID, Guna2DataGridView products)
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
                        string discount = Convert.ToString(row.Cells["DiscountComB"].Value);
                        //update customer_info set (ProductsBoughtID) values(@customerID)
                        //Insert into customer_info (ProductsBoughtID) values (@customerID)

                        string query = "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, Discount, EmployeeID, OrderDate) " +
                                        "values (@customerID, @productName, @productID, @quantity, @amount, @discount, @employeeID, @orderDate)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@customerID", ID);
                            command.Parameters.AddWithValue("@productName", itemName);
                            command.Parameters.AddWithValue("@productID", itemid);
                            command.Parameters.AddWithValue("@quantity", qty);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@discount", discount);
                            command.Parameters.AddWithValue("@employeeID", Method.AccountID);
                            command.Parameters.AddWithValue("@orderDate", DateTime.Now);

                            await command.ExecuteNonQueryAsync();
                            //MessageBox.Show("Products has been sent to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    MessageBox.Show("Products has been binded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    string insertQuery = "update customer_info set ProductsBoughtID = @customerID where TransactionID = @customerID";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@customerID", ID);
                        await command.ExecuteNonQueryAsync();
                    }
                    ClearContents();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in PurchaseToDatabase");
            }
        }*/

        public async Task PurchaseToDatabase(int ID, Guna2DataGridView products)
        {
            //bool itemNameFound = false;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
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
                                string discount = Convert.ToString(row.Cells["DiscountComB"].Value);
                                //update customer_info set (ProductsBoughtID) values(@customerID)
                                //Insert into customer_info (ProductsBoughtID) values (@customerID)

                                string query = "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, Discount, EmployeeID, OrderDate) " +
                                                "values (@customerID, @productName, @productID, @quantity, @amount, @discount, @employeeID, @orderDate)";

                                using (MySqlCommand command = new MySqlCommand(query, conn))
                                {
                                    command.Parameters.AddWithValue("@customerID", ID);
                                    command.Parameters.AddWithValue("@productName", itemName);
                                    command.Parameters.AddWithValue("@productID", itemid);
                                    command.Parameters.AddWithValue("@quantity", qty);
                                    command.Parameters.AddWithValue("@amount", amount);
                                    command.Parameters.AddWithValue("@discount", discount);
                                    command.Parameters.AddWithValue("@employeeID", Method.AccountID);
                                    command.Parameters.AddWithValue("@orderDate", DateTime.Now);

                                    await command.ExecuteNonQueryAsync();
                                    //MessageBox.Show("Products has been sent to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            // Update ProductsBoughtID in customer_info table
                            string updateQuery = "update customer_info set ProductsBoughtID = @customerID where TransactionID = @customerID";
                            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                            {
                                command.Parameters.AddWithValue("@customerID", ID);
                                await command.ExecuteNonQueryAsync();
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Working as intended. Proceeding to Rollback data", "Purchase To Database function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                                MessageBox.Show("Products has been binded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            ClearContents();
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Error in PurchaseToDatabase");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in PurchaseToDatabase");
            }
        }


        /* public async Task PurchaseToReceipt(int ID, Guna2DataGridView products)
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
                             string numericValue = totalText.Replace("₱ ", "").Trim();
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

                     await inventoryMethods.SubtractItemsInInventoryForPurchase(products);
                     await InsertToSales(salesID, orderID);
                     MessageBox.Show("Purchase Complete, Handling Receipt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     GeneratePDFReceipt(SellProductsUserControls.sellProductsUserControlsInstance.ProductsControlDGV,
                         SellProductsUserControls.sellProductsUserControlsInstance.SubLbl,
                         SellProductsUserControls.sellProductsUserControlsInstance.DiscLbl,
                         SellProductsUserControls.sellProductsUserControlsInstance.TotLbl,
                         SellProductsUserControls.sellProductsUserControlsInstance.CashTxtBx,
                         SellProductsUserControls.sellProductsUserControlsInstance.CustomerNameTxtB,
                         ID);
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.ToString(), "Error in PurchaseToReceipt");
             }
         }*/

        public async Task PurchaseToReceipt(int ID, Guna2DataGridView products)
        {
            int salesID = GenerateTransactionID();
            int orderID = GenerateTransactionID();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow row in products.Rows)
                            {
                                string itemName;
                                if (row.Cells["ProductCol"].Value != null)
                                {
                                    itemName = row.Cells["ProductCol"].Value.ToString();
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

                                using (MySqlCommand command = new MySqlCommand(query, conn, transaction))
                                {
                                    string totalText = SellProductsUserControls.sellProductsUserControlsInstance.TotLbl.Text;
                                    string numericValue = totalText.Replace("₱ ", "").Trim();
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

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Working as intended. Proceeding to Rollback data", "Purchase to receipt function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                                MessageBox.Show("Purchase Complete, Handling Receipt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await inventoryMethods.SubtractItemsInInventoryForPurchase(products);
                                await InsertToSales(salesID, orderID);
                                GeneratePDFReceipt(SellProductsUserControls.sellProductsUserControlsInstance.ProductsControlDGV,
                                    SellProductsUserControls.sellProductsUserControlsInstance.SubLbl,
                                    SellProductsUserControls.sellProductsUserControlsInstance.DiscLbl,
                                    SellProductsUserControls.sellProductsUserControlsInstance.TotLbl,
                                    SellProductsUserControls.sellProductsUserControlsInstance.CashTxtBx,
                                    SellProductsUserControls.sellProductsUserControlsInstance.CustomerNameTxtB,
                                    ID);
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error in PurchaseToReceipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void GeneratePDFReceipt(Guna2DataGridView guna2DataGridView1, Label sbLbl, Label dscLbl, Label ttlLbl, Guna2TextBox cashtxtBx, Guna2TextBox custName, int ID)
        {
            try
            {
                decimal subtotal = decimal.Parse(sbLbl.Text.Replace("₱ ", ""));
                decimal discount = decimal.Parse(dscLbl.Text.Replace("₱ ", ""));
                decimal totalAmount = decimal.Parse(ttlLbl.Text.Replace("₱ ", ""));
                decimal cashEntered;

                int totalQuantity = 0;

                if (!decimal.TryParse(cashtxtBx.Text, out cashEntered))
                {
                    MessageBox.Show("Please enter a valid amount for payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cashEntered < totalAmount)
                {
                    MessageBox.Show("Please enter a valid amount for payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var productSummaries = guna2DataGridView1.Rows.Cast<DataGridViewRow>()
                    .GroupBy(row => row.Cells["ProductCol"].Value.ToString())
                    .Select(group => new
                    {
                        ProductName = group.Key,
                        Quantity = group.Sum(row => Convert.ToInt32(row.Cells["QuantityCol"].Value)),
                        TotalPrice = group.Sum(row => Convert.ToDecimal(row.Cells["CostCol"].Value))
                    })
                    .ToList();

                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = "PDF Files|*.pdf";
                    saveFileDialog1.Title = "Save PDF File";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog1.FileName;

                        using (PdfWriter writer = new PdfWriter(new FileStream(pdfFilePath, FileMode.Create)))
                        using (PdfDocument pdf = new PdfDocument(writer))
                        using (iText.Layout.Document doc = new iText.Layout.Document(pdf))
                        {
                            doc.SetProperty(Property.TEXT_ALIGNMENT, TextAlignment.JUSTIFIED_ALL);
                            ImageData logoImageData = ImageDataFactory.Create(GetBytesFromImage(Properties.Resources.SignInDesignLogo));
                            iText.Layout.Element.Image logo = new iText.Layout.Element.Image(logoImageData);
                            logo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                            logo.SetWidth(200);
                            logo.SetHeight(200);

                            ImageData pesoImageData = ImageDataFactory.Create(GetBytesFromImage(Properties.Resources.peso));
                            iText.Layout.Element.Image peso = new iText.Layout.Element.Image(pesoImageData);
                            peso.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);

                            doc.Add(logo);
                            doc.Add(new Paragraph("BLOCK 5,  ORANGE STREET, LAKEVIEW, PINAGBUHATAN, PASIG CITY").SetTextAlignment(TextAlignment.CENTER));
                            doc.Add(new Paragraph(" "));
                            doc.Add(new Paragraph(" "));
                            doc.Add(new Paragraph(" "));
                            doc.Add(new Paragraph("Tel NO : (02) 4568-2996").SetTextAlignment(TextAlignment.LEFT));
                            doc.Add(new Paragraph("Mobile NO : (0993) 369-4904").SetTextAlignment(TextAlignment.LEFT));
                            doc.Add(new Paragraph($"Served by: Receiptionist {Method.Name}").SetTextAlignment(TextAlignment.LEFT));
                            doc.Add(new Paragraph($"Served to: {custName}").SetTextAlignment(TextAlignment.LEFT));
                            doc.Add(new Paragraph($"Order #{ID} ").SetTextAlignment(TextAlignment.LEFT));
                            doc.Add(new Paragraph("Date: " + DateTime.Now.ToString("MM/dd/yyyy   hh:mm:ss tt")).SetTextAlignment(TextAlignment.LEFT));
                            doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));

                            Table table = new Table(4);
                            table.SetWidth(UnitValue.CreatePercentValue(100));
                            table.SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph("QUANTITY")).SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().Add(new Paragraph("PRICE")).SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().Add(new Paragraph("PRODUCT")).SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().Add(new Paragraph("TOTAL")).SetBorder(Border.NO_BORDER));


                            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                            {
                                int quantityValue = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                                totalQuantity += quantityValue;
                            }
                            foreach (var summary in productSummaries)
                            {
                                string variationCost = GetVariationCost(summary.ProductName);

                                Paragraph variationcost1 = new Paragraph();
                                variationcost1.Add(new iText.Layout.Element.Image(pesoImageData).SetHeight(9).SetWidth(9));
                                variationcost1.Add(new Text($"{variationCost}"));
                                Paragraph totalprice1 = new Paragraph();
                                totalprice1.Add(new iText.Layout.Element.Image(pesoImageData).SetHeight(9).SetWidth(9));
                                totalprice1.Add(new Text($"{summary.TotalPrice.ToString("0.00")}"));

                                table.AddCell(new Cell().Add(new Paragraph(summary.Quantity.ToString())).SetBorder(Border.NO_BORDER));
                                table.AddCell(new Cell().Add((variationcost1)).SetBorder(Border.NO_BORDER));
                                table.AddCell(new Cell().Add(new Paragraph(summary.ProductName)).SetBorder(Border.NO_BORDER));
                                table.AddCell(new Cell().Add((totalprice1)).SetBorder(Border.NO_BORDER));
                            }
                            doc.Add(table);

                            Table table1 = new Table(2);
                            table1.SetWidth(UnitValue.CreatePercentValue(100));
                            table1.SetTextAlignment(TextAlignment.LEFT);
                            decimal change = cashEntered - totalAmount;

                            AddReceiptDetailRow(table1, "SUBTOTAL:", $"{subtotal.ToString("0.00")}", pesoImageData);
                            AddReceiptDetailRow(table1, "DISCOUNT:", $"{discount.ToString("0.00")}", pesoImageData);
                            AddReceiptDetailRow(table1, "TOTAL:", $"{totalAmount.ToString("0.00")}", pesoImageData);
                            AddReceiptDetailRow(table1, "CASH:", $"{cashEntered.ToString("0.00")}", pesoImageData);
                            AddReceiptDetailRow(table1, "CHANGE:", $"{change.ToString("0.00")}", pesoImageData);

                            doc.Add(new Paragraph($"---------------------------------------{totalQuantity} Item(s)-----------------------------------------"));
                            doc.Add(table1);
                            doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));
                            doc.Add(new Paragraph("THIS RECEIPT SERVES AS YOUR PROOF OF PURCHASE").SetTextAlignment(TextAlignment.CENTER));
                        }

                        MessageBox.Show("Receipt generated successfully and saved to:\n" + pdfFilePath, "🎉 Congrats on your purchase at TriCharm Salon! 🎉", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guna2DataGridView1.Rows.Clear();
                        sbLbl.Text = "₱ 0.00";
                        ttlLbl.Text = "₱ 0.00";
                        dscLbl.Text = "₱ 0.00";
                        cashtxtBx.Text = "";
                        cashtxtBx.ForeColor = Color.LightGray;
                        System.Diagnostics.Process.Start("cmd", $"/c start {pdfFilePath}");

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GeneratePDFTicket(string ID, string name)
        {
            string transactionTB = ID;
            string nameTB = name;
            //string ageTB = age;

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "PDF Files|*.pdf";
                saveFileDialog1.Title = "Save PDF File";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string pdfFilePath = saveFileDialog1.FileName;

                    using (PdfWriter writer = new PdfWriter(new FileStream(pdfFilePath, FileMode.Create)))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document doc = new Document(pdf))
                    {
                        PageSize customPageSize = new PageSize(252f, 612f); // 3.5 * 72, 8.5 * 72
                        pdf.SetDefaultPageSize(customPageSize);

                        ImageData logoImageData = ImageDataFactory.Create(GetBytesFromImage(Properties.Resources.SalonLogo));
                        iText.Layout.Element.Image logo = new iText.Layout.Element.Image(logoImageData);
                        logo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                        ImageData starImageData = ImageDataFactory.Create(GetBytesFromImage(Properties.Resources.star));
                        iText.Layout.Element.Image starImage = new iText.Layout.Element.Image(starImageData)
                            .SetHeight(25)
                            .SetWidth(25);

                        logo.SetWidth(150);
                        logo.SetHeight(150);
                        doc.Add(logo);

                        doc.Add(new Paragraph(("---------------------------------------------")).SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph("TICKET").SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph(("---------------------------------------------")).SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph($"Transaction ID: {transactionTB}                                 Date: {DateTime.Now.ToString("MM/dd/yyyy   hh:mm:ss tt")}").SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph($"Customer Name: {nameTB}").SetTextAlignment(TextAlignment.LEFT));
                        //doc.Add(new Paragraph($"Special ID: {ageTB}").SetTextAlignment(TextAlignment.LEFT));
                        doc.Add(new Paragraph(("---------------------------------------------")).SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph(("SERVICE RATING")).SetTextAlignment(TextAlignment.CENTER));

                        Table starsTable = new Table(5).UseAllAvailableWidth();
                        starsTable.SetBorder(Border.NO_BORDER);
                        for (int i = 0; i < 5; i++)
                        {
                            Cell cell = new Cell().Add(starImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER))
                           .SetBorder(Border.NO_BORDER)
                           .SetTextAlignment(TextAlignment.CENTER);
                            starsTable.AddCell(cell);
                        }

                        // Create a row for text ratings
                        string[] ratings = { "Worst", "Bad", "Neutral", "Good", "Excellent" };
                        foreach (var rating in ratings)
                        {
                            Cell ratingCell = new Cell().Add(new Paragraph(rating).SetFontSize(10))
                                                         .SetBorder(Border.NO_BORDER)
                                                         .SetTextAlignment(TextAlignment.CENTER);
                            starsTable.AddCell(ratingCell);
                        }
                        doc.Add(starsTable);

                        doc.Add(new Paragraph(("(Rate your experience)")).SetTextAlignment(TextAlignment.CENTER).SetFontSize(8));
                        doc.Add(new Paragraph(("---------------------------------------------")).SetTextAlignment(TextAlignment.CENTER));
                        doc.Add(new Paragraph("THIS SERVES AS YOUR PROOF OF APPOINTMENT.").SetTextAlignment(TextAlignment.JUSTIFIED_ALL));
                    }

                    MessageBox.Show("Receipt generated successfully and saved to:\n" + pdfFilePath, "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("cmd", $"/c start {pdfFilePath}");
                }
            }
        }
        public string GetVariationCost(string variationName)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT SRP FROM inventory WHERE ItemName = @ItemName";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ItemName", variationName);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        string variationCost = "0.00";
                        while (reader.Read())
                        {
                            variationCost = reader["SRP"].ToString();
                        }
                        return variationCost;
                    }
                }
            }
        }


        public void AddReceiptDetailRow(Table table, string description, string value, ImageData pesoImageData)
        {
            Paragraph valueParagraph = new Paragraph();
            valueParagraph.Add(new iText.Layout.Element.Image(pesoImageData).SetHeight(9).SetWidth(9));
            valueParagraph.Add(new Text(value));
            table.AddCell(new Cell().Add(new Paragraph(description)).SetBorder(Border.NO_BORDER));
            table.AddCell(new Cell().Add(valueParagraph).SetTextAlignment(TextAlignment.RIGHT).SetBorder(Border.NO_BORDER));
        }

        public byte[] GetBytesFromImage(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
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
                        string numericValue = totalText.Replace("₱ ", "").Trim();
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



        public async Task  VoidOrderButton(int ID, Guna2DataGridView productControl)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    foreach (DataGridViewRow row in productControl.Rows)
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

                        string voidQuery = "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, EmployeeID, OrderDate, IsVoided) " +
                        "values (@productGroupID, @productName, @productID, @quantity, @productGAmount, @employeeID, @orderDate, @void)";

                        using (MySqlCommand command = new MySqlCommand(voidQuery, conn))
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
                        MessageBox.Show("Order is voided.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearContents();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in VoidOrderButton");

            }
        }

        public void ClearContents()
        {
            SellProductsUserControls.sellProductsUserControlsInstance.ProductsControlDGV.Rows.Clear();
            SellProductsUserControls.sellProductsUserControlsInstance.CustomerNameTxtB.Text = null;
            SellProductsUserControls.sellProductsUserControlsInstance.CustomerIDComB.SelectedItem = null;
            SellProductsUserControls.sellProductsUserControlsInstance.CashTxtBx.Text = null;
            SellProductsUserControls.sellProductsUserControlsInstance.ItemPromoComB.Text = null;
            SellProductsUserControls.sellProductsUserControlsInstance.PromoTxtB.Text = null;
        }

        public int GenerateTransactionID()
        {
            Random rnd = new Random();
            int ID = rnd.Next(0, 100000001);

            return ID;
        }
        public async Task <int> GetServiceTypeID(string serviceName)
        {
            TypeID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    /*string query = "SELECT st.ServiceID FROM service_type st " +
                        "JOIN salon_subtypes sbt ON st.ServiceID = sbt.ServiceTypeID " +
                        "JOIN salon_services ss ON sbt.CategoryID = ss.ServiceTypeID " +
                        "WHERE ServiceName = @serviceName";*/

                    string query = "Select ServiceTypeID from salon_services where ServiceName = @service_name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        object result = await command.ExecuteScalarAsync();
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

        public class ServiceDetails
        {
            public string ServiceName { get; }
            public decimal ServiceCost { get; }
            public decimal ServiceDiscount { get; }

            public ServiceDetails(string itemName, decimal cost, decimal discount)
            {

                ServiceName = itemName;
                ServiceCost = cost;
                ServiceDiscount = discount;
            }
        }
        public List<ServiceDetails> GetServiceDetails(int promoCode, string mysqlcon)
        {
            List<ServiceDetails> items = new List<ServiceDetails>();

            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = @"
                SELECT bs.ServiceName, ss.ServiceAmount, sp.DiscountPercent
                FROM binded_services bs
                INNER JOIN salon_services ss ON bs.ServiceID = ss.ServiceVariationID
                INNER JOIN salon_promos sp ON bs.PromoServiceID = sp.PromoCode
                WHERE bs.PromoServiceID = @PromoCode";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PromoCode", promoCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string serviceName = reader["ServiceName"].ToString();
                            decimal serviceCost = Convert.ToDecimal(reader["ServiceAmount"]);

                            // Remove the percentage sign (%) and convert to decimal
                            string discountPercentString = reader["DiscountPercent"].ToString().Replace("%", "");
                            decimal discountPercent = Convert.ToDecimal(discountPercentString) / 100m;

                            items.Add(new ServiceDetails(serviceName, serviceCost, discountPercent));
                        }
                    }
                }
            }

            return items;
        }

        public (int promoCode, string isValid) GetPromoDetails(int promoCode, string mysqlcon)
        {
            int retrievedPromoCode = 0;
            string isValid = "";

            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT PromoCode, isValid FROM salon_promos WHERE PromoCode = @PromoCode";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PromoCode", promoCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            retrievedPromoCode = Convert.ToInt32(reader["PromoCode"]);
                            isValid = reader["isValid"].ToString();
                        }
                    }
                }
            }

            return (retrievedPromoCode, isValid);
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
    }
}