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
            method.GetEmployeeInfo();
            serviceTypeName = ServiceTypeNameLbl.Text;
            userClock = new RealTimeClock(TimerLbl, "dddd, dd MMMM yyyy (hh:mm:ss tt)");
            transaction.ShowCustomerList();

        }
        private async void EmployeeUserConrols_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync(serviceTypeName, Convert.ToInt32(Method.AccountID));
        }

        public async Task LoadCustomersAsync(string serviceTypeName, int ID)
        {
            try
            {
                using (var conn = new MySqlConnection("server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI"))
                {
                    await conn.OpenAsync();

                    //removed na dito yung pref employee
                    /*string query = "SELECT t.CustomerName," +
                                     " t.CustomerAge, " +
                                     " t.CustomerPhoneNumber, " +
                                     " t.ServiceVariation, " +
                                     " t.PriorityStatus, " +
                                     " t.TransactionID" +
                                     " FROM transaction t" +
                                     " WHERE ServiceType = @service_type" +
                                     " AND PaymentStatus = 'UNPAID'" +
                                     " ORDER BY CASE WHEN t.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, t.TimeTaken";*/

                    //test query
                    string query = "SELECT t.CustomerName," +
                                    " t.CustomerAge, " +
                                    " t.CustomerPhoneNumber, " +
                                    " t.ServiceVariation, " +
                                    " t.PriorityStatus, " +
                                    " t.TransactionID" +
                                    " FROM transaction t" +
                                    " WHERE ServiceType = @service_type" +
                                    " AND PaymentStatus = 'UNPAID'" +
                                    " AND (EmployeeID = @employee_id OR EmployeeID = 0)" +
                                    " ORDER BY CASE WHEN t.PriorityStatus = 'PRIORITY' THEN 1 ELSE 2 END, t.TimeTaken";


                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type", serviceTypeName);
                        command.Parameters.AddWithValue("@employee_id", ID);
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            CustomerListFLowLayout.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();

                                if (CustomerListFLowLayout.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                var cutomer = new CustomerTicket(Name, Age, PhoneNumber, Service, PrioStatus, Ticket);
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

        private async void EmployeeDoneBtn_Click(object sender, EventArgs e)
        {
            int CustID = Convert.ToInt32(CustomerIDTxtB.Text);
            transaction.ShowCustomerList();

            EmployeeDoneBtn.Enabled = false;
            await transaction.EmployeeProcessCompleteAsync(CustID);

            try
            {
                await LoadCustomersAsync(ServiceTypeNameLbl.Text, Convert.ToInt32(Method.AccountID));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                EmployeeDoneBtn.Enabled = true;
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
    }
}