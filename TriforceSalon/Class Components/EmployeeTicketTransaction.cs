using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TriforceSalon.Test;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class EmployeeTicketTransaction
    {
        private string mysqlcon;
        public byte[] servicePhoto;
        public EmployeeTicketTransaction()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public void ProcessTicket(int ticketID)
        {
            DateTime startTIme = DateTime.Now;
            int accountID = Convert.ToInt32(EmployeeUserConrols.employeeUserConrolsInstance.EmpAccNumberTxtB.Text);


            DialogResult choices = MessageBox.Show("Are you sure you want to serve this customer?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlcon))
                    {
                        conn.Open();
                        string query = "Insert into employee_records (AccountID, TimeStart, CustomerID)" +
                            "Value(@accountID, @timeStart, @customerID)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("accountID", accountID);
                            command.Parameters.AddWithValue("timeStart", startTIme);
                            command.Parameters.AddWithValue("customerID", ticketID);

                            command.ExecuteNonQuery();
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

        public void FetchServiceImage(string serviceName)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                   string query = "select ServiceImage from salon_services where ServiceName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    servicePhoto = (byte[])reader["ServiceImage"];

                                    using (MemoryStream ms = new MemoryStream(servicePhoto))
                                    {
                                        EmployeeUserConrols.employeeUserConrolsInstance.ServicePicPicB.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in FetchServiceImage()");

            }
        }

        public void EmployeeProcessComplete(int CustomerID)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Update transaction set PaymentStatus = 'PROCESSED' where TransactionID = @custumer_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@custumer_ID", CustomerID);

                        command.ExecuteNonQuery();
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

        public void PassValueToLock()
        {
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerNameTxtB.Text = CustomerTicket.customerTicketInstance.NameLbl.Text;
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerAgeTxtB.Text = CustomerTicket.customerTicketInstance.AgeLbl.Text;
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerPNumTxtB.Text = CustomerTicket.customerTicketInstance.PhoneNumberLbl.Text;
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerServiceTxtB.Text = CustomerTicket.customerTicketInstance.ServiceVarLbl.Text;
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerIDTxtB.Text = CustomerTicket.customerTicketInstance.TicketLbl.Text;
        }

        public void ShowEmpLock()
        {
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerListFLowLayout.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = true;

            EmployeeUserConrols.employeeUserConrolsInstance.label3.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label4.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label5.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label6.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label7.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label9.Visible = false;

        }
        public void ShowCustomerList()
        {
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerListFLowLayout.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = false;

            EmployeeUserConrols.employeeUserConrolsInstance.label3.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.label4.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.label5.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.label6.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.label7.Visible = true;
            EmployeeUserConrols.employeeUserConrolsInstance.label9.Visible = true;

        }

        public void HideAllPanels()
        {
            EmployeeUserConrols.employeeUserConrolsInstance.CustomerListFLowLayout.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockPanel.Visible = false;

            EmployeeUserConrols.employeeUserConrolsInstance.label3.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label4.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label5.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label6.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label7.Visible = false;
            EmployeeUserConrols.employeeUserConrolsInstance.label9.Visible = false;
        }
    }
}
