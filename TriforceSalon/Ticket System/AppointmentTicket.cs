using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Test;
using static TriforceSalon.Test.CustomerTicket;

namespace TriforceSalon.Ticket_System
{
    public partial class AppointmentTicket : UserControl
    {
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
        internal class AppointmentCustomerSelectedEventArgs
        {

        }

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
