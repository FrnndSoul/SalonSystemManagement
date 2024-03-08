using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Test;
using TriforceSalon.UserControls.Receptionist_Controls;

namespace TriforceSalon.UserControls
{
    public partial class WalkInTransactionForm : UserControl
    {
        public static WalkInTransactionForm walkInTransactionFormInstance;
        public PopulateDataGridView populateMethods = new PopulateDataGridView();
        private EventHandler<CustomerTicket.CustomerSelectedEventArgs> CustomerDetails;
        public WalkInTransactionForm()
        {
            InitializeComponent();
            walkInTransactionFormInstance = this;
            //populateMethods.EmployeeDetails();
            //populateMethods.PopulateServiceComboBox();
            //LoadCustomers();
        }

        /*public void LoadCustomers()
        {
            //int testId = 6;
            try
            {
                using (var conn = new MySqlConnection("server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI"))
                {
                    conn.Open();
                    //string query = "Select CustomerName, TransactionID, ServiceType, ServiceVariation, ServiceVariationID from transaction where TransactionID = @transaction_ID";
                    //string query = "Select CustomerName, TransactionID, ServiceType, ServiceVariation, ServiceVariationID from transaction";
                    string query = "Select CustomerName, CustomerAge, CustomerPhoneNumber, ServiceVariation, PreferredEmployee, PriorityStatus, TransactionID from transaction";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        //command.Parameters.AddWithValue("@transaction_ID", testId);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            WalkInTransactionForm.walkInTransactionFormInstance.TestEmployee.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var Name = row["CustomerName"].ToString();
                                var Age = row["CustomerAge"].ToString();
                                var PhoneNumber = row["CustomerPhoneNumber"].ToString();
                                var Service = row["ServiceVariation"].ToString();
                                var PrefEmp = row["PreferredEmployee"].ToString();
                                var PrioStatus = row["PriorityStatus"].ToString();
                                var Ticket = row["TransactionID"].ToString();






                                var ServiceType = row["ServiceType"].ToString();
                                var ServiceVar = row["ServiceVariation"].ToString();
                                var ServiceID = row["ServiceVariationID"].ToString();

                                if (WalkInTransactionForm.walkInTransactionFormInstance.TestEmployee.Controls.OfType<CustomerTicket>().Any(P => P.Ticket == Ticket))
                                {
                                    continue;
                                }
                                *//*var cutomer = new CustomerTicket(Name, Ticket, ServiceType, ServiceVar, ServiceID);
                                WalkInTransactionForm.walkInTransactionFormInstance.TestEmployee.Controls.Add(cutomer);
                                cutomer.CustomerSelected += CustomerDetails;*//*

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error in LoadCustomer()", ex.Message);
            }
        }*/



        /*private void ServicesComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ServiceTypeComBox.SelectedItem.ToString();
            int value2 = populateMethods.GetServiceTypeID(value);
            //populateMethods.FilterEmployees(value);
            populateMethods.FilterServices(value2);
        }*/

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            //populateMethods.UpdateEmployees();
        }

       /* private void ServiceListComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serviceName = ServiceListComB.SelectedItem.ToString();
            int serviceNameValue = populateMethods.GetServiceID(serviceName);
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WalkInTransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecepLogOutBtn_Click(object sender, EventArgs e)
        {
            Method.LogOutUser();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    //mainForm.ShowLogin();
                    break;
                }
            }
        }

        private void NPaymentBtn_Click(object sender, EventArgs e)
        {
            paymentsUserControls1.Visible = true;
            servicesUserControl1.Visible = false;
        }

        private void NServicesBtn_Click(object sender, EventArgs e)
        {
            paymentsUserControls1.Visible = false;
            servicesUserControl1.Visible = true;
        }
    }
}