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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TriforceSalon.Class_Components
{
    public class QueueMethods
    {
        private string mysqlcon;
        private EventHandler<QueueDisplay.QueueSelectedEventArgs> TicketChanged;

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
                                
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (containerFL.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new QueueDisplay(Ticket, Queue);
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
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (containerFL.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new QueueDisplay(Ticket, Queue);
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
        }

    }
}
