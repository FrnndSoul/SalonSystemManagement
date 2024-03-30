using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Test;
using TriforceSalon.UserControls;
using TriforceSalon.UserControls.Employee_Controls;
using TriforceSalon.UserControls.Receptionist_Controls;

namespace TriforceSalon.Class_Components
{
    public class EmployeeTicketTransaction
    {
        private string mysqlcon;
        public byte[] servicePhoto;
        public TransactionMethods transation = new TransactionMethods();
        public EmployeeTicketTransaction()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public async Task ProcessTicketAsync(int ticketID)
        {
            DateTime startTime = DateTime.Now;
            int accountID = Convert.ToInt32(EmployeeUserConrols.employeeUserConrolsInstance.EmpAccNumberLbl.Text);


            DialogResult choices = MessageBox.Show("Are you sure you want to serve this customer?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlcon))
                    {
                        await conn.OpenAsync();

                        string query = "Insert into employee_records (AccountID, TimeStart, CustomerID)" +
                            "Value(@accountID, @timeStart, @customerID)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@accountID", accountID);
                            command.Parameters.AddWithValue("@timeStart", startTime);
                            command.Parameters.AddWithValue("@customerID", ticketID);

                            await command.ExecuteNonQueryAsync();
                            MessageBox.Show("you have successfully have chosen this customer, Finish the service to servce more customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowEmpLock();
                        }

                        string query2 = "UPDATE customer_info SET PaymentStatus = 'INSESSION' WHERE TransactionID = @customerID";

                        using(MySqlCommand command = new MySqlCommand(query2, conn))
                        {
                            command.Parameters.AddWithValue("@customerID", ticketID);
                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in ProcessTicket()");
                }
            }
        }

        //lagyan ito ng itemID para mabilis
        /*public async Task FetchServiceImageAsync(string serviceName)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "select ServiceImage from salon_services where ServiceName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    servicePhoto = (byte[])reader["ServiceImage"];

                                    using (MemoryStream ms = new MemoryStream(servicePhoto))
                                    {
                                        await Task.Run(() =>
                                        {
                                            EmployeeUserConrols.employeeUserConrolsInstance.ServicePicPicB.Image = Image.FromStream(ms);
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in FetchServiceImage()");
            }
        }*/

        /*public async Task EmployeeProcessCompleteAsync(long CustomerID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    //original query
                    *//*string query = "Update transaction set PaymentStatus = 'PROCESSED' where TransactionID = @custumer_ID;" +
                        "Update employee_records set TimeEnd = @endTime where CustomerID = @custumer_ID";*//*

                    //test query
                    *//*string query = "Update customer_info set PaymentStatus = 'PROCESSED where TransactionID = @customer_ID";

                    if(EmployeeLock.employeeLockInstance.AddServiceChckB.Checked == true)
                    {
                        query += " Insert into service_group (ServiceGroupID, ServiceVariation, ServiceVariationID, Amount)" +
                            "values (@service_groupID, @service_variation, @service_varID, @amount);" +
                            "Update employee_records set TimeEnd = @endTime where CustomerID = @customer_ID";
                    }
                    else
                    {
                        query += "Update employee_records set TimeEnd = @endTime where CustomerID = @customer_ID";
                    }*//*

                    string query = "UPDATE customer_info SET PaymentStatus = 'PROCESSED' WHERE TransactionID = @customer_ID";

                    if (EmployeeLock.employeeLockInstance.AddServiceChckB.Checked == true)
                    {
                        query += "; INSERT INTO service_group (ServiceGroupID, ServiceVariation, ServiceVariationID, Amount) " +
                                 "VALUES (@service_groupID, @service_variation, @service_varID, @amount);" +

                                 " UPDATE employee_records SET TimeEnd = @endTime WHERE CustomerID = @customer_ID";
                    }
                    else
                    {

                        query += "; UPDATE employee_records SET TimeEnd = @endTime WHERE CustomerID = @customer_ID";
                    }


                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_groupID", Convert.ToInt64(CustomerID));
                        command.Parameters.AddWithValue("@service_variation", Convert.ToString(EmployeeLock.employeeLockInstance.ServiceListComB.SelectedItem));
                        command.Parameters.AddWithValue("@service_varID", transation.GetServiceVariationID(Convert.ToString(EmployeeLock.employeeLockInstance.ServiceListComB.SelectedItem)));
                        command.Parameters.AddWithValue("@amount", Convert.ToDecimal(EmployeeLock.employeeLockInstance.AServiceAmountTxtB.Text));

                        command.Parameters.AddWithValue("@customer_ID", Convert.ToInt64(CustomerID));
                        command.Parameters.AddWithValue("@endTime", DateTime.Now);

                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Custoemr Service Complete, Thank You For Your Service!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowCustomerList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
            }
        }*/

        public async Task GetServicesAsync(int type)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ServiceName from salon_services where ServiceTypeID = @typeID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@typeID", type);
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string servieName = reader["ServiceName"].ToString();
                                    //EmployeeLock.employeeLockInstance.ServiceListComB.Items.Add(servieName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServicesAsync()");
            }
        }

        public async Task EmployeeProcessCompleteAsync(long CustomerID, string serviceVariation)
        {
            //initial code
            /*try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string updateCustomerQuery = "UPDATE service_group SET IsDone = 'PROCESSED' WHERE ServiceGroupID = @customer_ID AND WHERE ServiceVariation = @serviceVariation";
                    using (MySqlCommand updateCustomerCommand = new MySqlCommand(updateCustomerQuery, conn))
                    {
                        updateCustomerCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        updateCustomerCommand.Parameters.AddWithValue("@serviceVariation", serviceVariation);
                        await updateCustomerCommand.ExecuteNonQueryAsync();
                    }

                    string updateEmployeeRecordsQuery = "UPDATE employee_records SET TimeEnd = @endTime WHERE CustomerID = @customer_ID";
                    using (MySqlCommand updateEmployeeRecordsCommand = new MySqlCommand(updateEmployeeRecordsQuery, conn))
                    {
                        updateEmployeeRecordsCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        updateEmployeeRecordsCommand.Parameters.AddWithValue("@endTime", DateTime.Now);

                        await updateEmployeeRecordsCommand.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("Customer Service Complete. Thank You For Your Service!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowCustomerList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
            }*/

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    // Update the IsDone status for the service group
                    string updateServiceGroupQuery = "UPDATE service_group SET IsDone = 'DONE' WHERE CustomerID = @customer_ID AND ServiceVariation = @serviceVariation";
                    using (MySqlCommand updateServiceGroupCommand = new MySqlCommand(updateServiceGroupQuery, conn))
                    {
                        updateServiceGroupCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        updateServiceGroupCommand.Parameters.AddWithValue("@serviceVariation", serviceVariation);
                        await updateServiceGroupCommand.ExecuteNonQueryAsync();

                        GetBindedItems(serviceVariation);
                    }

                    // Update the end time for the employee records
                    string updateEmployeeRecordsQuery = "UPDATE employee_records SET TimeEnd = @endTime WHERE CustomerID = @customer_ID";
                    using (MySqlCommand updateEmployeeRecordsCommand = new MySqlCommand(updateEmployeeRecordsQuery, conn))
                    {
                        updateEmployeeRecordsCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        updateEmployeeRecordsCommand.Parameters.AddWithValue("@endTime", DateTime.Now);

                        await updateEmployeeRecordsCommand.ExecuteNonQueryAsync();
                    }
                    // Check if all services for the given CustomerID and serviceVariation are marked as "done"
                    string checkServicesQuery = "SELECT COUNT(*) FROM service_group WHERE ServiceGroupID = @customer_ID AND IsDone != 'DONE'";
                    using (MySqlCommand checkServicesCommand = new MySqlCommand(checkServicesQuery, conn))
                    {
                        checkServicesCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        //checkServicesCommand.Parameters.AddWithValue("@serviceVariation", serviceVariation);
                        int pendingServicesCount = Convert.ToInt32(await checkServicesCommand.ExecuteScalarAsync());

                        if (pendingServicesCount == 0)
                        {
                            // All services are done, update the customer status to PROCESSED
                            string updateCustomerQuery = "UPDATE customer_info SET PaymentStatus = 'PROCESSED' WHERE TransactionID = @customer_ID";
                            using (MySqlCommand updateCustomerCommand = new MySqlCommand(updateCustomerQuery, conn))
                            {
                                updateCustomerCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                                await updateCustomerCommand.ExecuteNonQueryAsync();
                            }
                        }
                        else
                        {
                            string updateCustomerQuery = "UPDATE customer_info SET PaymentStatus = 'ONGOING' WHERE TransactionID = @customer_ID";
                            using (MySqlCommand updateCustomerCommand = new MySqlCommand(updateCustomerQuery, conn))
                            {
                                updateCustomerCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                                await updateCustomerCommand.ExecuteNonQueryAsync();
                            }
                        }
                    }
                }
                MessageBox.Show("Customer Service Complete. Thank You For Your Service!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
            }
        }

        public async void GetBindedItems(string serviceName)
        {
            string query = @"SELECT 
                    bi.ItemID, 
                    bi.Quantity 
                FROM 
                    binded_items bi 
                INNER JOIN 
                    salon_services ss ON ss.ItemGroupID = bi.ItemGroupID 
                WHERE 
                    ss.ServiceName = @serviceName";
            try
            {
                using (MySqlConnection con = new MySqlConnection(mysqlcon))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@serviceName", serviceName);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemID = reader["ItemID"].ToString();
                                string quantity = reader["Quantity"].ToString();

                                //deduct in the database
                                await Inventory.DeductItems(itemID, quantity);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        public async Task GetServiceAmountAsync(string name)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ServiceAmount from salon_services where ServiceName = @sName";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@sName", name);
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string servieAmount = reader["ServiceAmount"].ToString();
                                    //EmployeeLock.employeeLockInstance.AServiceAmountTxtB.Text = servieAmount;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServiceAmountAsync()");

            }
        }


        public void ShowEmpLock()
        {
            //EmployeeUserConrols.employeeUserConrolsInstance.GeneralCustomerListFLowLayout.Visible = false;
            //EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = true;

            EmployeeLock employeeLock = new EmployeeLock();
            UserControlNavigator.ShowControl(employeeLock, EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockContent);

            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockContent.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.GeneralQPanel.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.SpecialQPanel.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLogOutBtn.Visible = false;
        }
        public void ShowCustomerList()
        {
            //EmployeeUserConrols.employeeUserConrolsInstance.GeneralCustomerListFLowLayout.Visible = true;
            //EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = false;

            EmployeeUserConrols.employeeUserConrolsInstance.GeneralQPanel.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.SpecialQPanel.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLogOutBtn.Visible = true;

            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockContent.Visible = false;



        }
    }
}
