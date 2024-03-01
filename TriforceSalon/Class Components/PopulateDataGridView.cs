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
            //busyEmployees = GetEmployees();
        }

        /* public List<Employees> GetEmployees()
         {
             List<Employees> busyEmployees = new List<Employees>();

             try
             {
                 using (var conn = new MySqlConnection(mysqlcon))
                 {
                     conn.Open();
                     string query = "SELECT u.Emp_ID FROM users u " +
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
                 MessageBox.Show("fhgfh Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return null;
             }
         }*/
        /*public void UpdateEmployees(List<Employees> employees)
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
        }*/

        public void UpdateEmployees()
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

        public void PopulateServiceComboBox()
        {
            WalkInTransactionForm.walkInTransactionFormInstance.ServicesComBox.Items.Clear();

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
        }

        public void FilterEmployees(string serviceName)
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
        }





        /* public void FilterEmployees(string serviceName)
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
                                 WalkInTransactionForm.walkInTransactionFormInstance.EmployeeListDGV.DataSource = dt;
                             }
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("4. sdfsdfsdfdsf Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
         }*/
        /* public void SetEmployeeStatus(int ID)
         {
             DateTime timeStart = DateTime.Now;
             DateTime timeEnd = timeStart.AddSeconds(10);
             string customer = WalkInTransactionForm.walkInTransactionFormInstance.CustomerNameTxtB.Text;

             try
             {
                 using (var conn = new MySqlConnection(mysqlcon))
                 {
                     conn.Open();
                     string query = "update salon_employees set Availability = 'Busy' where AccountID = @emp_ID;" +
                         "Insert Into transaction (Emp_ID, Customer_Name) values (@emp_ID, @customer_name)";
                     using (MySqlCommand command = new MySqlCommand(query, conn))
                     {
                         command.Parameters.AddWithValue("@emp_ID", ID);
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
         }*/

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
        }


    }
}
