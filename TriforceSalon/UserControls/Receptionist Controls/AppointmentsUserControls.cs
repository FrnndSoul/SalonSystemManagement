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
using TriforceSalon.Test;
using TriforceSalon.Ticket_System;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class AppointmentsUserControls : UserControl
    {
        private EventHandler<AppointmentTicket.AppointmentCustomerSelectedEventArgs> AppointmentCustomerDetails;
        public string mysqlcon;

        public AppointmentsUserControls()
        {
            InitializeComponent();
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

        }
        private async void AppointmentsUserControls_Load(object sender, EventArgs e)
        {
            await LoadPresentCustomer();
        }
        public async Task LoadPresentCustomer()
        {
            try
            {
                using(var conn = new MySqlConnection("server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI"))
                {
                    await conn.OpenAsync();

                    /*string query = "SELECT ReferenceNumber, AppointDate, Name, PhoneNumber, Age, ServiceName, ServiceAmount FROM Appointments " +
                        "WHERE AppointDate = CURDATE() AND IsCancelled != 'NO' ";*/

                    string query = "SELECT ReferenceNumber, AppointDate, Name, PhoneNumber, Age, ServiceName, ServiceAmount " +
                        "FROM Appointments " +
                        "WHERE DATE(AppointDate) = CURDATE() AND IsCancelled = 'NO' AND isActivated = 'NO'";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using(var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            AppointmentLIstFL.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var ID = row["ReferenceNumber"].ToString();
                                var AppointDate = row["AppointDate"].ToString();
                                var CName = row["Name"].ToString();
                                var CNumber = row["PhoneNumber"].ToString();
                                var CAge = row["Age"].ToString();
                                var SName = row["ServiceName"].ToString();
                                var SAmount = row["ServiceAmount"].ToString();

                                if (AppointmentLIstFL.Controls.OfType<AppointmentTicket>().Any(P => P.transactionID == ID))
                                {
                                    continue;
                                }
                                var cutomer = new AppointmentTicket(ID, AppointDate, CName, CAge, CNumber, SName, SAmount);
                                AppointmentLIstFL.Controls.Add(cutomer);
                                cutomer.AppointmentCustomerSelected += AppointmentCustomerDetails;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in LoadPresentCustomer()");
            }
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshBtn.Enabled = false;

            await LoadPresentCustomer();

            RefreshBtn.Enabled = true;

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void SearchIDBtn_Click(object sender, EventArgs e)
        {
            string IDSearch = CustomerIDTxtB.Text;
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT ReferenceNumber, AppointDate, Name, PhoneNumber, Age, ServiceName, ServiceAmount " +
                        "FROM Appointments " +
                        "WHERE DATE(AppointDate) = CURDATE() AND IsCancelled = 'NO' AND isActivated = 'NO' AND ReferenceNumber = @refNum";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@refNum", "%" + IDSearch + "%");

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            AppointmentLIstFL.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var ID = row["ReferenceNumber"].ToString();
                                var AppointDate = row["AppointDate"].ToString();
                                var CName = row["Name"].ToString();
                                var CNumber = row["PhoneNumber"].ToString();
                                var CAge = row["Age"].ToString();
                                var SName = row["ServiceName"].ToString();
                                var SAmount = row["ServiceAmount"].ToString();

                                if (AppointmentLIstFL.Controls.OfType<AppointmentTicket>().Any(P => P.transactionID == ID))
                                {
                                    continue;
                                }
                                var cutomer = new AppointmentTicket(ID, AppointDate, CName, CAge, CNumber, SName, SAmount);
                                AppointmentLIstFL.Controls.Add(cutomer);
                                cutomer.AppointmentCustomerSelected += AppointmentCustomerDetails;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
