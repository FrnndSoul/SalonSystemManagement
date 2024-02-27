using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        public DateTime TimeEnd { get; set; }
    }

    public class PopulateDataGridView
    {
        public readonly string mysqlcon;
        public List<Employees> busyEmployees;

        public PopulateDataGridView()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            busyEmployees = GetEmployees();
        }

        public List<Employees> GetEmployees()
        {
            List<Employees> busyEmployees = new List<Employees>();

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT u.Emp_ID, t.TimeEnd FROM users u " +
                                   "JOIN transaction t ON u.Emp_ID = t.Emp_ID " +
                                   "WHERE Emp_Status = 'Busy'";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employees employee = new Employees
                                {
                                    EmployeeID = Convert.ToInt32(reader["Emp_ID"].ToString()),
                                    TimeEnd = Convert.ToDateTime(reader["TimeEnd"])
                                };
                                busyEmployees.Add(employee);
                            }
                        }
                    }
                }
                return busyEmployees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void UpdateEmployees(List<Employees> employees)
        {
            foreach (Employees employee in employees)
            {
                if (DateTime.Now > employee.TimeEnd)
                {
                    try
                    {
                        using (var conn = new MySqlConnection(mysqlcon))
                        {
                            conn.Open();
                            string query = "UPDATE users SET Availability = 'Available' WHERE ID = @empID;" +
                                "DELETE FROM transaction where Emp_ID = @empID ";
                            using (MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@empID", employee.EmployeeID);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("1. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        public void PopulateServiceComboBox()
        {
            WalkInTransactionForm.walkInTransactionFormInstance.ServicesComBox.Items.Clear();

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select servicename from services";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string serviceName = reader["servicesname"].ToString();
                                    WalkInTransactionForm.walkInTransactionFormInstance.ServicesComBox.Items.Add(serviceName);
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
        public void EmployeeDetails()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT u.Name, u.ID, s.ServicesName, u.Availability, t.TimeStart, t.TimeEnd FROM users u " +
                        "JOIN services s ON u.Service_ID = s.Service_ID LEFT JOIN transaction t ON u.ID = t.Emp_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
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
        }
        public void FilterEmployees(string serviceName)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT u.Name, u.ID, s.ServiceName, u.Availability, t.TimeStart, t.TimeEnd FROM users u " +
                                   "JOIN services s ON u.ServiceID = s.ServiceID LEFT JOIN transaction t ON u.ID = t.Emp_ID " +
                                   "WHERE ServiceName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
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
        }
        public void SetEmployeeStatus(int ID)
        {
            DateTime timeStart = DateTime.Now;
            DateTime timeEnd = timeStart.AddSeconds(10);
            string customer = WalkInTransactionForm.walkInTransactionFormInstance.CustomerNameTxtB.Text;

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "update users set Availability = 'Busy' where ID = @emp_ID;" +
                        "Insert Into transaction (TimeStart, TimeEnd, Emp_ID, Customer_Name) values (@time_start, @time_end, @emp_ID, @customer_name)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@emp_ID", ID);
                        command.Parameters.AddWithValue("@time_start", timeStart);
                        command.Parameters.AddWithValue("@time_end", timeEnd);
                        command.Parameters.AddWithValue("@customer_name", customer);

                        command.ExecuteNonQuery();
                        EmployeeDetails();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("5. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
