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

        public async Task EmployeeProcessCompleteAsync(int CustomerID)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "Update transaction set PaymentStatus = 'PROCESSED' where TransactionID = @custumer_ID;" +
                        "Update employee_records set TimeEnd = @endTime where CustomerID = @custumer_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@custumer_ID", CustomerID);
                        command.Parameters.AddWithValue("@endTime", DateTime.Now);

                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Custoemr Service Complete, Thank You For Your Service!", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowCustomerList();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in EmployeeProcessComplete()");
            }
        }

        public async Task GetServicesAsync(string type)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ServiceName from salon_services where ServiceTypeID = @typeID";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@typeID",transation.GetServiceTypeID(type));
                        using(DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(reader.HasRows)
                            {
                                while(await reader.ReadAsync())
                                {
                                    string servieName = reader["ServiceName"].ToString();
                                    EmployeeLock.employeeLockInstance.ServiceListComB.Items.Add(servieName);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServicesAsync()");

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
                                    EmployeeLock.employeeLockInstance.AServiceAmountTxtB.Text = servieAmount;
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
            EmployeeUserConrols.employeeUserConrolsInstance.GeneralCustomerListFLowLayout.Visible = false;
            //EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = true;

           

        }
        public void ShowCustomerList()
        {
            EmployeeUserConrols.employeeUserConrolsInstance.GeneralCustomerListFLowLayout.Visible = true;
            //EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = false;

           

        }
    }
}
