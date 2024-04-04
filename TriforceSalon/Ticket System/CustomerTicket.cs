using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TriforceSalon.Class_Components;
using TriforceSalon.UserControls;
using TriforceSalon.UserControls.Employee_Controls;

namespace TriforceSalon.Test
{
    public partial class CustomerTicket : UserControl
    {
        EmployeeTicketTransaction empTransaction = new EmployeeTicketTransaction();
        public static CustomerTicket customerTicketInstance;
        SalonServices services = new SalonServices();



        public event EventHandler<ScheduleSelectedEventArgs> TicketChanged;
        public string CustomerName => NameLbl.Text;
        public string CustomerAge => AgeLbl.Text;
        public string CustomerNumber => PhoneNumberLbl.Text;
        public string Service => ServiceVarLbl.Text;
        //public string PredEmp => PreferredEmpLbl.Text;
        public string Status => PrioStatusLbl.Text;
        public string Ticket => TicketLbl.Text;

        public string Queue => QNumberLbl.Text;

        public CustomerTicket(string CustomerName, string CustomerAge, string CustomerNumber, string Service, string Status, string Ticket, string queue)
        {
            InitializeComponent();
            customerTicketInstance = this;

            NameLbl.Text = CustomerName;
            AgeLbl.Text = CustomerAge;
            PhoneNumberLbl.Text = CustomerNumber;
            ServiceVarLbl.Text = Service;
            //PreferredEmpLbl.Text = PredEmp;
            PrioStatusLbl.Text = Status;
            TicketLbl.Text = Ticket;
            QNumberLbl.Text = queue;

        }

        internal EventHandler<CustomerSelectedEventArgs> CustomerSelected { get; set; }


        internal class CustomerSelectedEventArgs
        {

        }

        private async void ProcessCustomerBtn_Click(object sender, EventArgs e)
        {
            ProcessCustomerBtn.Enabled = false;
            int ticketID = Convert.ToInt32(TicketLbl.Text);
            string CName = NameLbl.Text;
            string CAge = AgeLbl.Text;
            string PNumber = PhoneNumberLbl.Text;
            string Cserviec = ServiceVarLbl.Text;
            string serviceName = ServiceVarLbl.Text;
            int serviceID = await services.GetServiceVariationID(serviceName);
            EmployeeUserConrols.employeeUserConrolsInstance.RefreshBtn.Visible = false;
            //string prio = PrioStatusLbl.Text;

            /*MessageBox.Show(Convert.ToString(ticketID));
            MessageBox.Show(CName);
            MessageBox.Show(CAge);
            MessageBox.Show(PNumber);
            MessageBox.Show(Cserviec);
            MessageBox.Show(prio);
*/



            try
            {
                await empTransaction.ProcessTicketAsync(ticketID, serviceID);
                //await empTransaction.FetchServiceImageAsync(serviceName);

                EmployeeLock.employeeLockInstance.CustomerNameTxtB.Text = CName;
                EmployeeLock.employeeLockInstance.CustomerAgeTxtB.Text = CAge;
                EmployeeLock.employeeLockInstance.CustomerPNumTxtB.Text = PNumber;
                EmployeeLock.employeeLockInstance.CustomerServiceTxtB.Text = Cserviec;
                EmployeeLock.employeeLockInstance.CustomerIDTxtB.Text = Convert.ToString(ticketID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ProcessCustomerBtn.Enabled = true;

            }
        }
    }

    public class ScheduleSelectedEventArgs
    {
        public string CustomerName { get; }
        public string CustomerAge { get; }
        public string CustomerNumber { get; }
        public string Service { get; }
        //public string PredEmp { get; }
        public string Status { get; }
        public string Ticket { get; }
        public string Queue {  get; }

        public ScheduleSelectedEventArgs(string customerName, string customerAge, string customerNumber, string service, string status, string ticket, string queue)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            CustomerNumber = customerNumber;
            Service = service;
            //PredEmp = predEmp;
            Status = status;
            Ticket = ticket;
            Queue = queue;
        }
    }

}