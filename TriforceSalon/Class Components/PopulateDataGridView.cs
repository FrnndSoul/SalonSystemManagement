using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Test;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class PopulateDataGridView
    {
        public readonly string mysqlcon;

        public PopulateDataGridView()
        {
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
        }
        /*public void UpdateEmployees()
        {
            try
            {
                // Assuming "EmployeeListDGV" is the DataGridView
                DataGridView dgv = WalkInTransactionForm.walkInTransactionFormInstance.EmployeeListDGV;

                DataTable dt = (DataTable)dgv.DataSource;

                foreach (DataRow row in dt.Rows)
                {
                    int empID = Convert.ToInt32(row["AccountID"]);
                    DateTime timeEnd = Convert.ToDateTime(row["EndTime"]);

                    if (DateTime.Now > timeEnd)
                    {
                        // Update employee status to 'Available'
                        string updateQuery = "UPDATE salon_employees SET Availability = 'Available' WHERE AccountID = @empID;";
                        using (var conn = new MySqlConnection(mysqlcon))
                        {
                            conn.Open();
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                            {
                                updateCommand.Parameters.AddWithValue("@empID", empID);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        EmployeeDetails();
                        // Update time columns in the DataGridView
                        row["StartTime"] = "00:00:00";
                        row["EndTime"] = "00:00:00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("1. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
*/
        public void PopulateServiceComboBox()
        {
            WalkInTransactionForm.walkInTransactionFormInstance.ServiceTypeComBox.Items.Clear();

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select ServiceTypeName from service_type";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string serviceName = reader["ServiceTypeName"].ToString();
                                    WalkInTransactionForm.walkInTransactionFormInstance.ServiceTypeComBox.Items.Add(serviceName);
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("2. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*public void EmployeeDetails()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT se.Name, se.AccountID, st.ServiceTypeName, se.Availability FROM salon_employees se " +
                        "JOIN service_type st ON se.ServiceID = st.ServiceID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);


                                dt.Columns.Add("StartTime", typeof(string));
                                dt.Columns.Add("EndTime", typeof(string));

                                // Set default time value for each row
                                foreach (DataRow row in dt.Rows)
                                {
                                    row["StartTime"] = "00:00:00";
                                    row["EndTime"] = "00:00:00";
                                }

                                WalkInTransactionForm.walkInTransactionFormInstance.EmployeeListDGV.DataSource = dt;
                            }
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("3. Error sa test method: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }*/

        /*public void FilterEmployees(string serviceName)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT se.Name, se.AccountID, st.ServiceTypeName, se.Availability FROM salon_employees se " +
                                    "JOIN service_type st ON se.ServiceID = st.ServiceID " +
                                    "WHERE ServiceTypeName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);

                                // Check if "StartTime" and "EndTime" columns exist in the DataTable
                                if (!dt.Columns.Contains("StartTime"))
                                    dt.Columns.Add("StartTime", typeof(string));
                                if (!dt.Columns.Contains("EndTime"))
                                    dt.Columns.Add("EndTime", typeof(string));

                                // Set default time value for each row
                                foreach (DataRow row in dt.Rows)
                                {
                                    row["StartTime"] = "00:00:00";
                                    row["EndTime"] = "00:00:00";
                                }

                                WalkInTransactionForm.walkInTransactionFormInstance.EmployeeListDGV.DataSource = dt;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("4. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/

        //public void SetEmployeeStatus(int ID)
       /* {
            DateTime timeStart = DateTime.Now;
            DateTime timeEnd = timeStart.AddSeconds(10);
            string customer = WalkInTransactionForm.walkInTransactionFormInstance.CustomerNameTxtB.Text;

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "update salon_employees set Availability = 'Busy' where AccountID = @emp_ID;" +
                        "Insert Into transaction (EmployeeID, CustomerName) values (@emp_ID, @customer_name)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@emp_ID", ID);
                        command.Parameters.AddWithValue("@customer_name", customer);

                        command.ExecuteNonQuery();

                        // Reload employee details and update time columns
                        EmployeeDetails();
                        DataTable dt = (DataTable)WalkInTransactionForm.walkInTransactionFormInstance.EmployeeListDGV.DataSource;

                        foreach (DataRow row in dt.Rows)
                        {
                            if (Convert.ToInt32(row["AccountID"]) == ID)
                            {
                                row["StartTime"] = timeStart.ToString("HH:mm:ss");
                                row["EndTime"] = timeEnd.ToString("HH:mm:ss");
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("5. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        public void FilterServices(int serviceType)
        {
            WalkInTransactionForm.walkInTransactionFormInstance.ServiceListComB.Items.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceName FROM salon_services LEFT JOIN service_type st ON salon_services.ServiceTypeID = st.ServiceID Where ServiceTypeID = @service_type_ID";
                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type_ID", serviceType);
                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string serviceName = reader["ServiceName"].ToString();
                                WalkInTransactionForm.walkInTransactionFormInstance.ServiceListComB.Items.Add(serviceName);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in FilterServices: ", ex.Message);
            }
        }
        public int GetServiceTypeID(string serviceName)
        {
            int serviceID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select ServiceID from service_type where ServiceTypeName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out serviceID))
                        {
                            return serviceID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetServiceTypeID(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serviceID;
        }

        public int GetServiceID(string selectedService)
        {
            int serviceID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select ServiceVariationID from salon_services where ServiceName = @service_name";
                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", selectedService);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out serviceID))
                        {
                            return serviceID;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in GetServiceID(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serviceID;
        }

        public void InsertTransaction(int serviceVarID)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Insert into transaction (CustomerName, ServiceType, ServiceVariation, ServiceVariationID)" +
                        "Value (@customer_name, @service_type, @service_variation, @service_variation_ID)";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@customer_name", WalkInTransactionForm.walkInTransactionFormInstance.CustomerNameTxtB.Text);
                        command.Parameters.AddWithValue("@service_type", WalkInTransactionForm.walkInTransactionFormInstance.ServiceTypeComBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@service_variation", WalkInTransactionForm.walkInTransactionFormInstance.ServiceListComB.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@service_variation_ID", serviceVarID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Nakaabot dito");
                        //must release something in here

                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show("Error in InsertTransaction in: ", ex.Message);
            }
        }

       /* public void LoadCustomers()
        {
            int testId = 6;
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select CustomerName, TransactionID, ServiceType, ServiceVariation, ServiceVariationID from transaction where TransactionID = @transaction_ID";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@transaction_ID", testId);

                        using(var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            WalkInTransactionForm.walkInTransactionFormInstance.TestEmployee.Controls.Clear();

                            foreach(DataRow row in dataTable.Rows) 
                            {
                                var Name = row["CustomerName"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var ServiceType = row["ServiceType"].ToString();
                                var ServiceVar = row["ServiceVariation"].ToString();
                                var ServiceID = row["ServiceVariationID"].ToString();

                                if (WalkInTransactionForm.walkInTransactionFormInstance.TestEmployee.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new CustomerTicket( Name,  Ticket,  ServiceType,  ServiceVar,  ServiceID);
                                WalkInTransactionForm.walkInTransactionFormInstance.TestEmployee.Controls.Add( cutomer );
                                cutomer.CustomerSelected += CustomerDetails;

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error in LoadCustomer()", ex.Message);
            }
        }*/

    }
}
