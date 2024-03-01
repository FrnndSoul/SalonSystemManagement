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

        /*public void PopulateServiceComboBox()
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
        }*/

        /*public void FilterServices(int serviceType)
        {
            WalkInTransactionForm.walkInTransactionFormInstance.ServiceListComB.Items.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceName FROM salon_services LEFT JOIN service_type st ON salon_services.ServiceTypeID = st.ServiceID Where ServiceTypeID = @service_type_ID";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type_ID", serviceType);
                        using (MySqlDataReader reader = command.ExecuteReader())
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
            catch (Exception ex)
            {
                MessageBox.Show("Error in FilterServices: ", ex.Message);
            }
        }*/

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
                    using (MySqlCommand command = new MySqlCommand(query, conn))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetServiceID(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serviceID;
        }

       /* public void InsertTransaction(int serviceVarID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Insert into transaction (CustomerName, ServiceType, ServiceVariation, ServiceVariationID)" +
                        "Value (@customer_name, @service_type, @service_variation, @service_variation_ID)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error in InsertTransaction in: ", ex.Message);
            }
        }*/

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