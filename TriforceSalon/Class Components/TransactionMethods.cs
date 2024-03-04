using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "insert into transaction (CustomerName, CustomerAge, CustomerPhoneNumber, ServiceVariation, ServiceType, ServiceVariationID)" +
                    "values(@customer_name, @customer_age, @customer_number, @service_var, @service_type, @service_varID)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@customer_name", ServicesUserControl.servicesUserControlInstance.CustomerNameTxtB.Text);
                    command.Parameters.AddWithValue("@customer_age", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.CustomerAgeTxtB.Text));
                    command.Parameters.AddWithValue("@customer_number", Convert.ToString(ServicesUserControl.servicesUserControlInstance.CustomerPhoneNTxtB.Text));

                    //palitan ito
                    command.Parameters.AddWithValue("@pref_emp", GetEmployeeID(Convert.ToString(ServicesUserControl.servicesUserControlInstance.PEmployeeComB.SelectedItem)));
                    command.Parameters.AddWithValue("@service_var", ServicesUserControl.servicesUserControlInstance.ServiceTxtB.Text);
                    command.Parameters.AddWithValue("@service_type", GetServiceTypeName(serviceID));
                    command.Parameters.AddWithValue("@service_varID", GetServiceVariationID(serviceName));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Added to the Queue", "Customer Process", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                    string query = "Select AccountID from salon_employee where Name = @name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", name);

                        using(MySqlDataReader reader =  command.ExecuteReader())
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out EmpID))
                            {
                                return EmpID;
                            }
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
    }
}