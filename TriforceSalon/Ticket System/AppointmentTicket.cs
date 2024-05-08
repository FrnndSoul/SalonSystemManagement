using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Test;
using TriforceSalon.UserControls;
using TriforceSalon.UserControls.Receptionist_Controls;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static TriforceSalon.Test.CustomerTicket;

namespace TriforceSalon.Ticket_System
{
    public partial class AppointmentTicket : UserControl
    {
        EditAppointmentUserControl editAppointment = new EditAppointmentUserControl();
        AppointmentsUserControls appointment = new AppointmentsUserControls();
        TransactionMethods transactionMethods = new TransactionMethods();
        SalonServices salonService = new SalonServices();
        private readonly GetServiceType_ServiceData serviceTypeService = new GetServiceType_ServiceData();


        public event EventHandler<ScheduleSelectedEventArgs> AppointmentTicketChanged;
        public string transactionID => CustID.Text;
        public string appointmentDate => CustDate.Text;
        public string customerName => CustName.Text;
        public string customerPNumber => CustNumber.Text;
        public string serviceChosen => ServiceChosen.Text;
        public string serviceAmount => SAmount.Text;

        public string mysqlcon;

        public AppointmentTicket(string transactionID, string appointmentDate, string customerName, string customerNumber, string serviceChosen, string serviceAmount)
        {
            InitializeComponent();
            CustID.Text = transactionID;
            CustDate.Text = appointmentDate;
            CustName.Text = customerName;
            CustNumber.Text = customerNumber;
            ServiceChosen.Text = serviceChosen;
            SAmount.Text = serviceAmount;

            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }
        internal EventHandler<AppointmentCustomerSelectedEventArgs> AppointmentCustomerSelected { get; set; }
        internal class AppointmentCustomerSelectedEventArgs { }

        /*private async void CancelAppointBtn_Click(object sender, EventArgs e)
        {
            CancelAppointBtn.Enabled = false;

            string custID = CustID.Text;
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "UPDATE Appointment SET IsCancelled = 'YES' WHERE ReferenceNumber = @ID";

                    using(MySqlCommand command = new MySqlCommand(query, conn)) 
                    {
                        command.Parameters.AddWithValue("@ID", custID);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in CancelAppointBtn()");
            }
            CancelAppointBtn.Enabled = true;
        }*/

        private async void CancelAppointBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CancelAppointBtn.Enabled = false;

                string custID = CustID.Text;

                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string query = "UPDATE Appointment SET IsCancelled = 'YES' WHERE ReferenceNumber = @ID";
                            using (MySqlCommand command = new MySqlCommand(query, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@ID", custID);
                                await command.ExecuteNonQueryAsync();
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Appointment cancellation is working as intended, Proceeding to rollback", "Appointment activation function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                                MessageBox.Show("Appointment Cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show("Error in CancelAppointBtn(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CancelAppointBtn.Enabled = true;
            }
        }


        private void EditInfoBtn_Click(object sender, EventArgs e)
        {
            bool isOnTime = false;
            TimeSpan allowedWindow = TimeSpan.FromMinutes(5);
            string appointmentDate = CustDate.Text;
            DateTime appointmentTime = Convert.ToDateTime(appointmentDate);
            DateTime earliestArrivalTime = appointmentTime.Subtract(allowedWindow);


            string timeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string ID = CustID.Text;
            string name = Convert.ToString(CustName.Text);
            string pNumber = CustNumber.Text;
            string sChosen = ServiceChosen.Text;
            string amount = SAmount.Text;

            if(Convert.ToDateTime(timeNow) >= earliestArrivalTime && Convert.ToDateTime(timeNow) <= appointmentTime)
            {
                isOnTime = true;
            }
            else
            {
                isOnTime=false;
            }
            EditAppointmentUserControl editAppointment= new EditAppointmentUserControl();
            UserControlNavigator.ShowControl(editAppointment, WalkInTransactionForm.walkInTransactionFormInstance.ReceptionistContent);

            editAppointment.GetCustomerInfo(name, ID, appointmentDate,pNumber, sChosen, amount, timeNow, isOnTime);
        }

        private async void ActivateCustomerBtn_Click(object sender, EventArgs e)
        {
            ActivateCustomerBtn.Enabled = false;

            TimeSpan allowedWindow = TimeSpan.FromMinutes(5);
            TimeSpan lateWindow = TimeSpan.FromMinutes(30);
            string appointmentDate = CustDate.Text;
            DateTime appointmentTime = Convert.ToDateTime(appointmentDate);
            DateTime earliestArrivalTime = appointmentTime.Subtract(allowedWindow);
            DateTime latestArrivalTime = appointmentTime.Add(lateWindow);
            string timeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string dateNow = DateTime.Now.ToString("MM-dd-yyyy dddd");

            string serviceType = await transactionMethods.GetServiceType(ServiceChosen.Text);
            string ID = CustID.Text;
            string name = Convert.ToString(CustName.Text);
            string pNumber = CustNumber.Text;

            string sChosen = ServiceChosen.Text;
            string amount = SAmount.Text;
            string priority = null;
            int queue = await serviceTypeService.GetLargestQueue(dateNow, serviceType, mysqlcon);


            bool isCustomerOnTime = false;


            if (Convert.ToDateTime(timeNow) >= earliestArrivalTime && Convert.ToDateTime(timeNow) <= latestArrivalTime)
            {
                isCustomerOnTime = true;
                priority = "PRIORITY";
                queue = 0;
            }
            else
            {
                isCustomerOnTime = false;
                priority = "NORMAL";
                queue = await serviceTypeService.GetLargestQueue(dateNow, serviceType, mysqlcon);
            }
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updateQuery = "UPDATE Appointments SET isActivated = 'YES' WHERE  ReferenceNumber = @refNum";
                            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                            {
                                command.Parameters.AddWithValue("@refNum", ID);
                                await command.ExecuteNonQueryAsync();
                            }


                            string query = "Insert into customer_info (TransactionID, CustomerName, CustomerPhoneNumber, PriorityStatus, IsAppointment, ServiceGroupID) " +
                                "VALUES (@transactionID, @customerName, @customerNumber, @prioStatus, @isAppointment, @serviceGroupID)";

                            using (MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@transactionID", ID);
                                command.Parameters.AddWithValue("@customerName", name);
                                command.Parameters.AddWithValue("@prioStatus", priority);
                                command.Parameters.AddWithValue("@customerNumber", pNumber);
                                command.Parameters.AddWithValue("@isAppointment", "YES");
                                command.Parameters.AddWithValue("@serviceGroupID", ID);

                                await command.ExecuteNonQueryAsync();
                            }

                            string query2 = "Insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount, QueueNumber) " +
                                "VALUES (@serviceGroupID, @serviceType, @employeeID, @serviceVariation, @serviceVariationID, @amount, @queue)";

                            using (MySqlCommand command = new MySqlCommand(query2, conn))
                            {
                                command.Parameters.AddWithValue("@serviceGroupID", ID);
                                command.Parameters.AddWithValue("@serviceType", await salonService.GetServiceTypeByName(sChosen));
                                command.Parameters.AddWithValue("@employeeID", 0);
                                command.Parameters.AddWithValue("@serviceVariation", sChosen);
                                command.Parameters.AddWithValue("@serviceVariationID", await salonService.GetServiceVariationID(sChosen));
                                command.Parameters.AddWithValue("@amount", amount);
                                command.Parameters.AddWithValue("@queue", queue);

                                await command.ExecuteNonQueryAsync();
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Appointment activation is working as intended, Proceeding to rollback", "Appointment activation function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                                MessageBox.Show("Customer Activated", "Customer Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //transactionMethods.GeneratePDFTicket(ID, name, age);
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                await appointment.LoadPresentCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        ActivateCustomerBtn.Enabled = true;
        }
    }

    public class ScheduleSelectedEventArgs
    {
        public string transactionID { get; }
        public string appointmentDate { get; }
        public string customerName { get; }
        public string customerNumber { get; }
        public string serviceChosen { get; }
        public string serviceAmount { get; }

        public ScheduleSelectedEventArgs(string TransactionID, string AppointmentDate, string CustomerName, string CustomerPNumber, string ServiceChosen, string ServiceAmount)
        {
            transactionID = TransactionID;
            appointmentDate = AppointmentDate;
            customerName = CustomerName;
            customerNumber = CustomerPNumber;
            serviceChosen = ServiceChosen;
            serviceAmount = ServiceAmount;
        }

    }
}
