using MySql.Data.MySqlClient;
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
using static TriforceSalon.Test.CustomerTicket;

namespace TriforceSalon.Ticket_System
{
    public partial class AppointmentTicket : UserControl
    {
        EditAppointmentUserControl editAppointment = new EditAppointmentUserControl();
        AppointmentsUserControls appointment = new AppointmentsUserControls();
        TransactionMethods transactionMethods = new TransactionMethods();
        SalonServices salonService = new SalonServices();

        public event EventHandler<ScheduleSelectedEventArgs> AppointmentTicketChanged;
        public string transactionID => CustID.Text;
        public string appointmentDate => CustDate.Text;
        public string customerName => CustName.Text;
        public string customerAge => CustAge.Text;
        public string customerNumber => CustNumber.Text;
        public string serviceChosen => ServiceChosen.Text;
        public string serviceAmount => SAmount.Text;

        public string mysqlcon;

        public AppointmentTicket(string transactionID, string appointmentDate, string customerName, string customerAge, string customerNumber, string serviceChosen, string serviceAmount)
        {
            InitializeComponent();
            CustID.Text = transactionID;
            CustDate.Text = appointmentDate;
            CustName.Text = customerName;
            CustAge.Text = customerAge;
            CustNumber.Text = customerNumber;
            ServiceChosen.Text = serviceChosen;
            SAmount.Text = serviceAmount;

            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }
        internal EventHandler<AppointmentCustomerSelectedEventArgs> AppointmentCustomerSelected { get; set; }
        internal class AppointmentCustomerSelectedEventArgs { }

        private async void CancelAppointBtn_Click(object sender, EventArgs e)
        {
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
            string age = CustAge.Text;
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

            editAppointment.GetCustomerInfo(name, age, pNumber, ID, appointmentDate, sChosen, amount, timeNow, isOnTime);
        }

        private async void ActivateCustomerBtn_Click(object sender, EventArgs e)
        {
            TimeSpan allowedWindow = TimeSpan.FromMinutes(5);
            string appointmentDate = CustDate.Text;
            DateTime appointmentTime = Convert.ToDateTime(appointmentDate);
            DateTime earliestArrivalTime = appointmentTime.Subtract(allowedWindow);
            string timeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            string ID = CustID.Text;
            string name = Convert.ToString(CustName.Text);
            string age = CustAge.Text;
            string pNumber = CustNumber.Text;

            string sChosen = ServiceChosen.Text;
            string amount = SAmount.Text;
            string priority = null;

            bool isCustomerOnTime = false;


            if (Convert.ToDateTime(timeNow) >= earliestArrivalTime && Convert.ToDateTime(timeNow) <= appointmentTime)
            {
                isCustomerOnTime = true;
                priority = "PRIORITY";
            }
            else
            {
                isCustomerOnTime = false;
                priority = "NORMAL";
            }
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "Insert into customer_info (TransactionID, CustomerName, CustomerAge, CustomerPhoneNumber, PriorityStatus, ServiceGroupID) " +
                        "VALUES (@transactionID, @customerName, @customerAge, @customerNumber, @prioStatus, @serviceGroupID)";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@transactionID", ID);
                        command.Parameters.AddWithValue("@customerName", name);
                        command.Parameters.AddWithValue("@customerAge", age);
                        command.Parameters.AddWithValue("@prioStatus", priority);
                        command.Parameters.AddWithValue("@customerNumber", pNumber);
                        command.Parameters.AddWithValue("@serviceGroupID", ID);

                        await command.ExecuteNonQueryAsync();
                    }

                    string query2 = "Insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount) " +
                        "VALUES (@serviceGroupID, @serviceType, @employeeID, @serviceVariation, @serviceVariationID, @amount)";

                    using(MySqlCommand command = new MySqlCommand(query2, conn))
                    {
                        command.Parameters.AddWithValue("@serviceGroupID", ID);
                        command.Parameters.AddWithValue("@serviceType", await salonService.GetServiceTypeByName(sChosen));
                        command.Parameters.AddWithValue("@employeeID", 0);
                        command.Parameters.AddWithValue("@serviceVariation", sChosen);
                        command.Parameters.AddWithValue("@serviceVariationID", await salonService.GetServiceVariationID(sChosen));
                        command.Parameters.AddWithValue("@amount", amount);

                        await command.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Customer Activated", "Customer Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                transactionMethods.GeneratePDFTicket(ID, name, age);
                await appointment.LoadPresentCustomer();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ScheduleSelectedEventArgs
    {
        public string transactionID { get; }
        public string appointmentDate { get; }
        public string customerName { get; }
        public string customerAge { get; }
        public string customerNumber { get; }
        public string serviceChosen { get; }
        public string serviceAmount { get; }

        public ScheduleSelectedEventArgs(string TransactionID, string AppointmentDate, string CustomerName, string CustomerAge, string CustomerNumber, string ServiceChosen, string ServiceAmount)
        {
            transactionID = TransactionID;
            appointmentDate = AppointmentDate;
            customerName = CustomerName;
            customerAge = CustomerAge;
            customerNumber = CustomerNumber;
            serviceChosen = ServiceChosen;
            serviceAmount = ServiceAmount;
        }

    }
}
