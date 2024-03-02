using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TriforceSalon.Test;

namespace TriforceSalon.UserControls
{
    public partial class EmployeeUserConrols : UserControl
    {
        private EventHandler<CustomerTicket.CustomerSelectedEventArgs> CustomerDetails;
        public EmployeeUserConrols employeeUserConrolsInstance;
        public EmployeeUserConrols()
        {
            InitializeComponent();
            employeeUserConrolsInstance = this;
            LoadCustomers();
        }

        public void LoadCustomers()
        {
            try
            {
                using (var conn = new MySqlConnection("server=localhost;user=root;database=salondatabase;password="))
                {
                    conn.Open();
                    
                    string query = "Select CustomerName, CustomerAge, CustomerPhoneNumber, ServiceVariation, PreferredEmployee, PriorityStatus, TransactionID from transaction";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
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
    }
}
