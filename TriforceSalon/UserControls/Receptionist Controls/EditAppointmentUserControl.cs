using Guna.UI2.WinForms;
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
using TriforceSalon.Class_Components;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class EditAppointmentUserControl : UserControl
    {
        public static EditAppointmentUserControl editAppointmentInstance;
        public readonly string mysqlcon;
        private readonly GetServiceType_ServiceData serviceTypeService = new GetServiceType_ServiceData();
        TransactionMethods transactionMethods = new TransactionMethods();
        private int TypeID;
        private int VariationID;
        private int EmpID;

        public string dateNow = "";
        public bool isOnTime = false;

        public EditAppointmentUserControl()
        {
            InitializeComponent();
            editAppointmentInstance = this;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

        }

        private async void EditAppointmentUserControl_Load(object sender, EventArgs e)
        {
            ServiceFilterComB.Items.Clear();
            ServiceFilterComB.Items.Add("All");
            PEmployeeComB.Items.Clear();
            PEmployeeComB.Items.Add("None");





            await serviceTypeService.GetServiceTypeAsync(mysqlcon);
            ServiceFilterComB.SelectedIndex = 0;
            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, "All", ServiceFL, ServiceTxtB, ServiceAmountTxtB);

            await serviceTypeService.GetAllEmployee(mysqlcon);
            PEmployeeComB.SelectedIndex = 0;
            transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());
        }

        private async void AddLServiceListBtn_Click(object sender, EventArgs e)
        {
            int queueNumber;

            string dateNow = DateTime.Now.ToString("MM-dd-yyyy dddd");
            string serviceName = ServiceTxtB.Text;
            string prefEmp = PEmployeeComB.SelectedItem.ToString();
            decimal amountService = Convert.ToDecimal(ServiceAmountTxtB.Text);
            string serviceType = await transactionMethods.GetServiceType(ServiceTxtB.Text);
            queueNumber = await serviceTypeService.GetLargestQueue(dateNow, serviceType, mysqlcon);

            if (isOnTime == true)
            {
                queueNumber = 0;
            }
            else
            {
                queueNumber = await serviceTypeService.GetLargestQueue(dateNow, serviceType, mysqlcon);

            }

            ServicesGDGVVControl.Rows.Add(serviceType, serviceName, prefEmp, amountService, "X", queueNumber);
        }


        private async void PEmployeeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = ServiceFilterComB.SelectedItem.ToString();
            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, selectedType, ServiceFL, ServiceTxtB, ServiceAmountTxtB);
        }

        private async void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            string search = SearchServiceTxtB.Text;

            try
            {
                await serviceTypeService.GetServiceDataForSearch(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB, search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetCustomerInfo(string name, string age, string pNumber, string transactionID, string appointmentDate, string service, string amount, string dateTaken, bool onTime)
        {
            CustomerNameTxtB.Text = name;
            CustomerAgeTxtB.Text = age;
            CustomerPhoneNTxtB.Text = pNumber;
            transactionIDTxtB.Text = transactionID;
            AppointmentDateTxtB.Text = appointmentDate;
            ServiceTxtB.Text = service;
            ServiceAmountTxtB.Text = amount;
            dateNow = dateTaken;
            isOnTime = onTime;
        }

        private async void ProcessCustomerBtn_Click(object sender, EventArgs e)
        {
            ProcessCustomerBtn.Enabled = false;
            string ID = transactionIDTxtB.Text;
            string name = CustomerNameTxtB.Text;
            string age = CustomerAgeTxtB.Text;

            if (CustomerNameTxtB.Text is null || CustomerAgeTxtB.Text is null || CustomerPhoneNTxtB is null
                || ServiceAmountTxtB.Text is null || ServiceTxtB.Text is null)
            {
                MessageBox.Show("Please fill all the customer information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceName = ServiceTxtB.Text;
                transactionMethods.GetServiceTypeID(serviceName);

                if (isOnTime == true)
                {
                    await TestProcessCustomer(ServicesGDGVVControl, "PRIORITY", Convert.ToInt64(ID));
                }
                else
                {
                    await TestProcessCustomer(ServicesGDGVVControl, "NORMAL", Convert.ToInt64(ID));
                }
                transactionMethods.GeneratePDFTicket(ID, name, age);
            }
            ProcessCustomerBtn.Enabled = true;
        }

        public async Task TestProcessCustomer(Guna2DataGridView serviceDataGrid, string priorityStatus, long ID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string updateQuery = "UPDATE Appointments SET isActivated = 'YES' WHERE = ReferenceNumber = @refNum";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@refNum", ID);
                        await command.ExecuteNonQueryAsync();
                    }

                    string insertToCustomerInfo = "insert into customer_info (TransactionID, CustomerName, CustomerAge, CustomerPhoneNumber, ServiceGroupID, PriorityStatus)" +
                        " Values (@transactionID, @customer_name, @customer_age, @customer_number, @service_groupID, @priorityStatus)";

                    using (MySqlCommand command1 = new MySqlCommand(insertToCustomerInfo, conn))
                    {
                        command1.Parameters.AddWithValue("@transactionID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@customer_name", ServicesUserControl.servicesUserControlInstance.CustomerNameTxtB.Text);
                        command1.Parameters.AddWithValue("@customer_age", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.CustomerAgeTxtB.Text));
                        command1.Parameters.AddWithValue("@customer_number", Convert.ToString(ServicesUserControl.servicesUserControlInstance.CustomerPhoneNTxtB.Text));
                        command1.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@priorityStatus", priorityStatus);

                        await command1.ExecuteNonQueryAsync();
                    }

                    string insertToServiceGroup = "insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount, QueueNumber, AppointmentDate)"
                    + " values(@service_groupID, @service_type, @pref_emp, @service_var, @service_varID, @amount, @queueNumber, @date)";

                    foreach (DataGridViewRow row in serviceDataGrid.Rows)
                    {
                        string serviceType = Convert.ToString(row.Cells["ServiceTypeCol"].Value);
                        string serviceVariation = Convert.ToString(row.Cells["SNameCol"].Value);
                        string preferredEmployee = Convert.ToString(row.Cells["PrefEmpCol"].Value);
                        decimal serviceAMount = Convert.ToDecimal(row.Cells["AmountCol"].Value);
                        int queueNumber = Convert.ToInt32(row.Cells["QueNumCol"].Value);

                        //edit mo ito para mamatch mo yung hinahanap sa database
                        using (MySqlCommand command2 = new MySqlCommand(insertToServiceGroup, conn))
                        {
                            command2.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(ServicesUserControl.servicesUserControlInstance.transactionIDTxtB.Text));
                            command2.Parameters.AddWithValue("@service_type", await transactionMethods.GetServiceType(serviceVariation));
                            command2.Parameters.AddWithValue("@service_var", serviceVariation);
                            command2.Parameters.AddWithValue("@service_varID", transactionMethods.GetServiceVariationID(serviceVariation));
                            command2.Parameters.AddWithValue("@amount", serviceAMount);
                            command2.Parameters.AddWithValue("@queueNumber", queueNumber);
                            command2.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM-dd-yyyy dddd"));

                            if (preferredEmployee == null || string.IsNullOrWhiteSpace(preferredEmployee) || preferredEmployee == "None")
                            {
                                MessageBox.Show("Preferred employee not specified.");
                                command2.Parameters.AddWithValue("@pref_emp", 0);
                            }
                            else
                            {
                                int employeeID = transactionMethods.GetEmployeeID(preferredEmployee);
                                MessageBox.Show($"Employee ID found: {employeeID}");
                                command2.Parameters.AddWithValue("@pref_emp", transactionMethods.GetEmployeeID(preferredEmployee));
                            }


                            await command2.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in TestProcessCustomer");

            }
        }

        private async void ServiceFilterComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = ServiceFilterComB.SelectedItem.ToString();
            await serviceTypeService.FilterServicesByTypeAsync(mysqlcon, selectedType, ServiceFL, ServiceTxtB, ServiceAmountTxtB);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AppointmentsUserControls appointment = new AppointmentsUserControls();
            UserControlNavigator.ShowControl(appointment, WalkInTransactionForm.walkInTransactionFormInstance.ReceptionistContent);
        }

        private void ServicesGDGVVControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ServicesGDGVVControl.Rows.Count)
            {
                DataGridViewCell clickedCell = ServicesGDGVVControl.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "RemoveServiceCol")
                {
                    ServicesGDGVVControl.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
