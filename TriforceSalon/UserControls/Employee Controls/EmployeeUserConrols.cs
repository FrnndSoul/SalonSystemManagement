using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Test;
using TriforceSalon.UserControls.Employee_Controls;

namespace TriforceSalon.UserControls
{
    public partial class EmployeeUserConrols : UserControl
    {
        public static Method method = new Method();
        private EventHandler<CustomerTicket.CustomerSelectedEventArgs> CustomerDetails;
        public static EmployeeUserConrols employeeUserConrolsInstance;
        public EmployeeTicketTransaction transaction = new EmployeeTicketTransaction();
        public TransactionMethods transactionMethods = new TransactionMethods();
        private RealTimeClock userClock;
        string serviceTypeName;

        public EmployeeUserConrols()
        {
            InitializeComponent();
            employeeUserConrolsInstance = this;
            WelcomeLbl.Text = "Welcome " + Method.Name;
            method.GetEmployeeInfo();
            serviceTypeName = ServiceTypeNameLbl.Text;
            userClock = new RealTimeClock(TimerLbl, "dddd, dd MMMM yyyy (hh:mm:ss tt)");
            transaction.ShowCustomerList();

            EmployeeLock employeeLock = new EmployeeLock();
            UserControlNavigator.ShowControl(employeeLock, EmployeeUserConrols.employeeUserConrolsInstance.EmployeeLockContent);
        }
        private async void EmployeeUserConrols_Load(object sender, EventArgs e)
        {
            await LoadSpecialCustomersAsync(serviceTypeName, Convert.ToInt32(Method.AccountID));
            await LoadGeneralCustomersAsync(serviceTypeName, Convert.ToInt32(Method.AccountID));
        }

        public async Task LoadSpecialCustomersAsync(string serviceTypeName, int ID)
        {
            try
            {
                using (var conn = new MySqlConnection("server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI"))
                {
                    await conn.OpenAsync();
                   
                    string testQuery = "SELECT ci.CustomerName, " +
                   "ci.CustomerAge, " +
                   "ci.CustomerPhoneNumber, " +
                   "ci.PriorityStatus, " +
                   "sg.ServiceVariation, " +
                   "ci.TransactionID, " +
                   "sg.QueueNumber " +
                   "FROM customer_info ci " +
                   "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                   "WHERE sg.ServiceType = @service_type " +
                   "AND DATE(TimeTaken) = CURDATE() " +
                   "AND (ci.PaymentStatus = 'UNPAID' " + // Grouping PaymentStatus conditions here
                   "OR ci.PaymentStatus = 'ONGOING') " +
                   "AND sg.IsDone = 'NO' " +
                   "AND sg.EmployeeID = @employee_id " + // Removed EmployeeID from OR condition
                   "ORDER BY CASE WHEN ci.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, ci.TimeTaken";



                    using (MySqlCommand command = new MySqlCommand(testQuery, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        command.Parameters.AddWithValue("@employee_id", ID);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            SpecialCustomerListFLowLayout.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (SpecialCustomerListFLowLayout.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new CustomerTicket(Name, Age, PhoneNumber, Service, PrioStatus, Ticket, Queue);
                                SpecialCustomerListFLowLayout.Controls.Add(cutomer);
                                cutomer.CustomerSelected += CustomerDetails;

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

        public async Task LoadGeneralCustomersAsync(string serviceTypeName, int ID)
        {
            try
            {
                using (var conn = new MySqlConnection("server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI"))
                {
                    await conn.OpenAsync();

                    string testQuery = "SELECT ci.CustomerName, " +
                        "ci.CustomerAge, " +
                        "ci.CustomerPhoneNumber, " +
                        "ci.PriorityStatus, " +
                        "sg.ServiceVariation, " +
                        "ci.TransactionID, " +
                        "sg.QueueNumber " +
                        "FROM customer_info ci " +
                        "JOIN service_group sg ON ci.ServiceGroupID = sg.ServiceGroupID " +
                        "WHERE sg.ServiceType = @service_type " +
                        "AND DATE(TimeTaken) = CURDATE() " +
                        "AND (ci.PaymentStatus = 'UNPAID' " + // Grouping PaymentStatus conditions here
                        "OR ci.PaymentStatus = 'ONGOING') " +
                        "AND sg.IsDone = 'NO' " +
                        "AND sg.EmployeeID = 0 " + // Grouping OR condition here
                        "ORDER BY CASE WHEN ci.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, ci.TimeTaken";



                    using (MySqlCommand command = new MySqlCommand(testQuery, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        //command.Parameters.AddWithValue("@employee_id", ID);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            GeneralCustomerListFLowLayout.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();
                                var Queue = row["QueueNumber"].ToString();

                                if (GeneralCustomerListFLowLayout.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new CustomerTicket(Name, Age, PhoneNumber, Service, PrioStatus, Ticket, Queue);
                                GeneralCustomerListFLowLayout.Controls.Add(cutomer);
                                cutomer.CustomerSelected += CustomerDetails;

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in LoadGeneralCustomersAsync()");
            }
        }

        private void EmployeeLogOutBtn_Click(object sender, EventArgs e)
        {
            Method.LogOutUser();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    //mainForm.ShowLogin();
                    SigninPage signinPage = new SigninPage();
                    UserControlNavigator.ShowControl(signinPage, MainForm.mainFormInstance.MainFormContent);
                    break;
                }
            }
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await EmployeeUserConrols.employeeUserConrolsInstance.LoadSpecialCustomersAsync(ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));
            await EmployeeUserConrols.employeeUserConrolsInstance.LoadGeneralCustomersAsync(ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));

        }
    }
}