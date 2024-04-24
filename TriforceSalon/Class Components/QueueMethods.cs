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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TriforceSalon.Class_Components
{
    public class QueueMethods
    {
        private string mysqlcon;
        public QueueMethods()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public async Task GetEmployee(Guna2DataGridView employeeDGV)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT se.Name, se.AccountID, st.ServiceTypeName " +
                        "FROM salon_employees se " +
                        "JOIN service_type st ON se.ServiceID = st.ServiceID " +
                        "WHERE se.AccountAccess NOT IN ('Receptionist', 'Manager')";

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

                                employeeDGV.Rows.Add(Name, AccountID, TypeName);
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

        public async Task PreferredQueue(string serviceTypeName, int ID, FlowLayoutPanel containerFL)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string prefQuery = "SELECT ci.CustomerName, " +
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
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                //dito ka mag aadd ng mga paglalagyan
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

                    string generalQueue = "SELECT ci.CustomerName, " +
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
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                //dito ka mag aadd ng mga paglalagyan
                            }
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GeneralQueue");
            }
        }

    }
}
