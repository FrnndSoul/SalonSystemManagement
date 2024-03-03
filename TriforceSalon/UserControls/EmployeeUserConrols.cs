using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Web.WebSockets;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Test;

namespace TriforceSalon.UserControls
{
    public partial class EmployeeUserConrols : UserControl
    {
        private EventHandler<CustomerTicket.CustomerSelectedEventArgs> CustomerDetails;
        public static EmployeeUserConrols employeeUserConrolsInstance;
        public EmployeeTicketTransaction transaction = new EmployeeTicketTransaction();
        private RealTimeClock userClock;
        public EmployeeUserConrols()
        {
            InitializeComponent();
            employeeUserConrolsInstance = this;
            string serviceTypeName = ServiceTypeNameLbl.Text;
            LoadCustomers(serviceTypeName);
            userClock = new RealTimeClock(TimerLbl, "dddd, dd MMMM yyyy (hh:mm:ss tt)");

        }

        public void LoadCustomers(string serviceTypeName)
        {

            try
            {
                using (var conn = new MySqlConnection("server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI"))
                {
                    conn.Open();

                    //nandito pa yung preferred Employee for backup purposes
                   /* string query = "SELECT t.CustomerName," +
                                      " t.CustomerAge, " +
                                      " t.CustomerPhoneNumber, " +
                                      " t.ServiceVariation, " +
                                      " t.PreferredEmployee," +
                                      " t.PriorityStatus, " +
                                      " t.TransactionID" +
                                      " FROM transaction t" +
                                      " WHERE ServiceType = @service_type" +
                                      " AND PaymentStatus = 'UNPAID'" +  
                                      " ORDER BY CASE WHEN t.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, t.TimeTaken";*/

                    //removed na dito yung pref employee
                    string query = "SELECT t.CustomerName," +
                                     " t.CustomerAge, " +
                                     " t.CustomerPhoneNumber, " +
                                     " t.ServiceVariation, " +
                                     " t.PriorityStatus, " +
                                     " t.TransactionID" +
                                     " FROM transaction t" +
                                     " WHERE ServiceType = @service_type" +
                                     " AND PaymentStatus = 'UNPAID'" +
                                     " ORDER BY CASE WHEN t.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, t.TimeTaken";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            CustomerListFLowLayout.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrefEmp = row["PreferredEmployee"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();

                                if (CustomerListFLowLayout.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new CustomerTicket(Name, Age, PhoneNumber, Service, PrefEmp, PrioStatus, Ticket);
                                CustomerListFLowLayout.Controls.Add(cutomer);
                                cutomer.CustomerSelected += CustomerDetails;

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in LoadCustomer()");
            }
        }

        private void EmployeeDoneBtn_Click(object sender, EventArgs e)
        {
            transaction.ShowCustomerList();
        }
    }
}