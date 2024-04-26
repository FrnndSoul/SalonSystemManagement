using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Test;
using TriforceSalon.Ticket_System;
using TriforceSalon.UserControls;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TriforceSalon.Class_Components
{
    public class QueueMethods
    {
        private string mysqlcon;
        private EventHandler<QueueDisplay.QueueSelectedEventArgs> TicketChanged;
        private EventHandler<InSessionDisplay.QueueSelectedEventArgs> QueueChanged;


        public QueueMethods()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public async Task GetEmployee(Guna2DataGridView employeeDGV)
        {
            employeeDGV.Rows.Clear();
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT se.Name, se.AccountID, st.ServiceTypeName " +
                        "FROM salon_employees se " +
                        "JOIN service_type st ON se.ServiceID = st.ServiceID " +
                        "WHERE se.AccountAccess NOT IN ('Receptionist', 'Manager') " +
                        "AND Availability != 'OCCUPIED'";

                    using(MySqlCommand command = new MySqlCommand(fetchQuery, conn))
                    {
                        using(var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            foreach(DataRow row in dataTable.Rows)
                            {
                                var Name = row["Name"].ToString();
                                var AccountID = row["AccountID"].ToString();
                                var TypeName = row["ServiceTypeName"].ToString();

                                employeeDGV.Rows.Add(AccountID, Name, TypeName);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetEmployee");
            }
        }

       /* public async Task PreferredQueue(string serviceTypeName, int ID, FlowLayoutPanel containerFL)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string prefQuery = "SELECT ci.CustomerName, " +
                   "sg.ServiceVariation, " +
                   "ci.PriorityStatus, " +
                   "sg.ServiceVariation, " +
                   "ci.TransactionID, " +
                   "sg.QueueNumber " +
                   "FROM customer_info ci " +
                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                   "WHERE sg.ServiceType = @service_type " +
                   "AND DATE(TimeTaken) = CURDATE() " +
                   "AND (ci.PaymentStatus = 'UNPAID' " +
                   "OR ci.PaymentStatus = 'ONGOING') " +
                   "AND sg.IsDone = 'NO' " +
                   "AND sg.EmployeeID = @employee_id " +
                   "ORDER BY CASE WHEN ci.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, ci.TimeTaken";

                    using (MySqlCommand command = new MySqlCommand(prefQuery, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        command.Parameters.AddWithValue("@employee_id", ID);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            containerFL.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Service = row["ServiceVariation"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (containerFL.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new QueueDisplay(Ticket, Queue, Service);
                                containerFL.Controls.Add(cutomer);
                                cutomer.SelectedQueue += TicketChanged;

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in LoadSpecialCustomersAsync()");
            }
        }

        public async Task GeneralQueue(string serviceTypeName, FlowLayoutPanel containerFL)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string generalQueue = "SELECT ci.TransactionID, " +
                   "sg.ServiceVariation, " +
                   "sg.QueueNumber " +
                   "FROM customer_info ci " +
                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                   "WHERE sg.ServiceType = @service_type " +
                   "AND DATE(TimeTaken) = CURDATE() " +
                   "AND (ci.PaymentStatus = 'UNPAID' " +
                   "OR ci.PaymentStatus = 'ONGOING') " +
                   "AND sg.IsDone = 'NO' " +
                   "AND sg.EmployeeID = 0 " +
                   "ORDER BY CASE WHEN ci.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, ci.TimeTaken";

                    using (MySqlCommand command = new MySqlCommand(generalQueue, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            containerFL.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Service = row["ServiceVariation"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (containerFL.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new QueueDisplay(Ticket, Queue, Service);
                                containerFL.Controls.Add(cutomer);
                                cutomer.SelectedQueue += TicketChanged;
                            }
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GeneralQueue");
            }
        }*/

        public async Task CombinedQueue(string serviceTypeName, FlowLayoutPanel containerFL, int employeeID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT ci.TransactionID, " +
                                   "sg.ServiceVariation, " +
                                   "sg.QueueNumber " +
                                   "FROM customer_info ci " +
                                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                                   "WHERE sg.ServiceType = @service_type " +
                                   "AND DATE(TimeTaken) = CURDATE() " +
                                   "AND (ci.PaymentStatus = 'UNPAID' OR ci.PaymentStatus = 'ONGOING') " +
                                   "AND sg.IsDone = 'NO' " +
                                   "AND (sg.EmployeeID = @employee_id OR sg.EmployeeID = 0) " +
                                   "ORDER BY CASE WHEN ci.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, ci.TimeTaken";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        command.Parameters.AddWithValue("@employee_id", employeeID);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            containerFL.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Service = row["ServiceVariation"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (containerFL.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var customer = new QueueDisplay(Ticket, Queue, Service);
                                containerFL.Controls.Add(customer);
                                customer.SelectedQueue += TicketChanged;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in CombinedQueue");
            }
        }

        public async Task InSessionDisplay(FlowLayoutPanel containerFL)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    /*string query = "SELECT ci.TransactionID, " +
                                   "sg.ServiceVariation, " +
                                   "sg.QueueNumber " +
                                   "er.AccountID " +
                                   "FROM customer_info ci " +
                                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                                   "JOIN employee_records er ON ci.TransactionID = er.CustomerID " +
                                   "WHERE sg.ServiceVariationID = @serviceID " +
                                   "AND er.ServiceID = @serviceID" +
                                   "AND ci.TransactionID = @customerID";*/

                    string query = "SELECT ci.TransactionID, " +
                                    "sg.ServiceVariation, " +
                                    "sg.QueueNumber, " + // Added comma
                                    "er.AccountID " + // Added comma
                                    "FROM customer_info ci " +
                                    "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                                    "JOIN employee_records er ON ci.TransactionID = er.CustomerID " +
                                    "WHERE ci.PaymentStatus = 'INSESSION' " +
                                    "AND DATE(TimeTaken) = CURDATE()";


                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            containerFL.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Service = row["ServiceVariation"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();
                                var EmpID = row["AccountID"].ToString();

                                if (containerFL.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var customer = new InSessionDisplay(Ticket, Queue, Service, EmpID);
                                containerFL.Controls.Add(customer);
                                customer.InSessionQueue += QueueChanged;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in CombinedQueue");
            }
        }

        /*public async Task ProcessCustomerAsync(int ticketID, int serviceID, int accountID)
        {
            DateTime startTime = DateTime.Now;

            DialogResult choices = MessageBox.Show("Are you sure you want to serve this customer?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlcon))
                    {
                        await conn.OpenAsync();

                        string query = "Insert into employee_records (AccountID, TimeStart, CustomerID, ServiceID)" +
                            "Value(@accountID, @timeStart, @customerID, @serviceID)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@accountID", accountID);
                            command.Parameters.AddWithValue("@timeStart", startTime);
                            command.Parameters.AddWithValue("@customerID", ticketID);
                            command.Parameters.AddWithValue("@serviceID", serviceID);

                            await command.ExecuteNonQueryAsync();
                            MessageBox.Show("you have successfully have chosen this customer, Finish the service to servce more customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        string query2 = "UPDATE customer_info SET PaymentStatus = 'INSESSION' WHERE TransactionID = @customerID";

                        using (MySqlCommand command = new MySqlCommand(query2, conn))
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
        }*/

        public async Task ProcessCustomerAsync(int ticketID, int serviceID, int accountID)
        {
            DateTime startTime = DateTime.Now;

            DialogResult choices = MessageBox.Show("Are you sure you want to serve this customer?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
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
                                string query1 = "INSERT INTO employee_records (AccountID, TimeStart, CustomerID, ServiceID) " +
                                                "VALUES (@accountID, @timeStart, @customerID, @serviceID)";

                                using (MySqlCommand command1 = new MySqlCommand(query1, conn))
                                {
                                    command1.Transaction = transaction;

                                    command1.Parameters.AddWithValue("@accountID", accountID);
                                    command1.Parameters.AddWithValue("@timeStart", startTime);
                                    command1.Parameters.AddWithValue("@customerID", ticketID);
                                    command1.Parameters.AddWithValue("@serviceID", serviceID);

                                    await command1.ExecuteNonQueryAsync();
                                }

                                string query2 = "UPDATE customer_info SET PaymentStatus = 'INSESSION' WHERE TransactionID = @customerID";

                                using (MySqlCommand command2 = new MySqlCommand(query2, conn))
                                {
                                    command2.Transaction = transaction;

                                    command2.Parameters.AddWithValue("@customerID", ticketID);
                                    await command2.ExecuteNonQueryAsync();
                                }

                                string query3 = "UPDATE salon_employees SET Availability = 'OCCUPIED' WHERE AccountID = @accountID";

                                using (MySqlCommand command3 = new MySqlCommand(query3, conn))
                                {
                                    command3.Transaction = transaction;

                                    command3.Parameters.AddWithValue("@accountID", accountID);
                                    await command3.ExecuteNonQueryAsync();
                                }

                                    transaction.Commit();

                                MessageBox.Show("You have successfully chosen this customer. Finish the service to serve more customers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show(ex.Message, "Error in ProcessTicket()");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in ProcessTicket()");
                }
            }
        }
        public async Task<int> GetServiceVariationID(string ServiceName)
        {
            int ID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT ServiceVariationID FROM salon_services WHERE ServiceName = @serviceName";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@serviceName", ServiceName);

                        object result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out ID))
                        {
                            return ID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error in GetServiceVariationID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ID;
        }

        /*public async Task EmployeeProcessCompleteAsync(long CustomerID, int serviceVariationID, string accountID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string updateServiceGroupQuery = "UPDATE service_group SET IsDone = 'DONE' WHERE ServiceGroupID = @customer_ID AND ServiceVariationID = @serviceVariationID";
                    using (MySqlCommand updateServiceGroupCommand = new MySqlCommand(updateServiceGroupQuery, conn))
                    {
                        updateServiceGroupCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        updateServiceGroupCommand.Parameters.AddWithValue("@serviceVariationID", serviceVariationID);
                        await updateServiceGroupCommand.ExecuteNonQueryAsync();
                    }

                    string updateEmployeeRecordsQuery = "UPDATE employee_records SET TimeEnd = @endTime WHERE CustomerID = @customer_ID";
                    using (MySqlCommand updateEmployeeRecordsCommand = new MySqlCommand(updateEmployeeRecordsQuery, conn))
                    {
                        updateEmployeeRecordsCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        updateEmployeeRecordsCommand.Parameters.AddWithValue("@endTime", DateTime.Now);

                        await updateEmployeeRecordsCommand.ExecuteNonQueryAsync();
                    }
                    string updateEmployeeAvailability = "UPDATE salon_employees SET Availability = 'Available' WHERE AccountID = @accountID";
                    using (MySqlCommand command = new MySqlCommand(updateEmployeeAvailability, conn))
                    {
                        command.Parameters.AddWithValue("@accountID", accountID);
                        await command.ExecuteNonQueryAsync();
                    }

                    string checkServicesQuery = "SELECT COUNT(*) FROM service_group WHERE ServiceGroupID = @customer_ID AND IsDone != 'DONE'";
                    using (MySqlCommand checkServicesCommand = new MySqlCommand(checkServicesQuery, conn))
                    {
                        checkServicesCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                        int pendingServicesCount = Convert.ToInt32(await checkServicesCommand.ExecuteScalarAsync());

                        if (pendingServicesCount == 0)
                        {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
            }
        }*/

        public async Task EmployeeProcessCompleteAsync(long CustomerID, int serviceVariationID, string accountID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updateServiceGroupQuery = "UPDATE service_group SET IsDone = 'DONE' WHERE ServiceGroupID = @customer_ID AND ServiceVariationID = @serviceVariationID";
                            using (MySqlCommand updateServiceGroupCommand = new MySqlCommand(updateServiceGroupQuery, conn))
                            {
                                updateServiceGroupCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                                updateServiceGroupCommand.Parameters.AddWithValue("@serviceVariationID", serviceVariationID);
                                await updateServiceGroupCommand.ExecuteNonQueryAsync();
                            }

                            string updateEmployeeRecordsQuery = "UPDATE employee_records SET TimeEnd = @endTime WHERE CustomerID = @customer_ID";
                            using (MySqlCommand updateEmployeeRecordsCommand = new MySqlCommand(updateEmployeeRecordsQuery, conn))
                            {
                                updateEmployeeRecordsCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                                updateEmployeeRecordsCommand.Parameters.AddWithValue("@endTime", DateTime.Now);

                                await updateEmployeeRecordsCommand.ExecuteNonQueryAsync();
                            }
                            string updateEmployeeAvailability = "UPDATE salon_employees SET Availability = 'Available' WHERE AccountID = @accountID";
                            using (MySqlCommand command = new MySqlCommand(updateEmployeeAvailability, conn))
                            {
                                command.Parameters.AddWithValue("@accountID", accountID);
                                await command.ExecuteNonQueryAsync();
                            }

                            string checkServicesQuery = "SELECT COUNT(*) FROM service_group WHERE ServiceGroupID = @customer_ID AND IsDone != 'DONE'";
                            using (MySqlCommand checkServicesCommand = new MySqlCommand(checkServicesQuery, conn))
                            {
                                checkServicesCommand.Parameters.AddWithValue("@customer_ID", CustomerID);
                                int pendingServicesCount = Convert.ToInt32(await checkServicesCommand.ExecuteScalarAsync());

                                if (pendingServicesCount == 0)
                                {
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
                            transaction.Commit();
                            MessageBox.Show("Customer Service Complete. Thank You For Your Service!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction if any query fails
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
            }
        }

    }
}
