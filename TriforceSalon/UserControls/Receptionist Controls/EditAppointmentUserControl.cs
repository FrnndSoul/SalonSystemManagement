using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
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

            await GetServiceTypeAsync(mysqlcon);
            ServiceFilterComB.SelectedIndex = 0;
            await FilterServicesByTypeAsync(mysqlcon, "All", ServiceFL, ServiceTxtB, ServiceAmountTxtB);

            await serviceTypeService.GetAllEmployee(mysqlcon);
            PEmployeeComB.SelectedIndex = 0;
            //transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());
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
            await FilterServicesByTypeAsync(mysqlcon, selectedType, ServiceFL, ServiceTxtB, ServiceAmountTxtB);
        }

        private async void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            string search = SearchServiceTxtB.Text;

            try
            {
                await GetServiceDataForSearch(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB, search);
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
            string IDText = transactionIDTxtB.Text;
            long ID = Convert.ToInt64(IDText);
            string name = CustomerNameTxtB.Text;
            string age = CustomerAgeTxtB.Text;

            if (CustomerNameTxtB.Text is null || CustomerAgeTxtB.Text is null || CustomerPhoneNTxtB is null
                || ServiceAmountTxtB.Text is null || ServiceTxtB.Text is null)
            {
                MessageBox.Show("Please fill all the customer information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProcessCustomerBtn.Enabled = true;
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceName = ServiceTxtB.Text;
                transactionMethods.GetServiceTypeID(serviceName);

                if (isOnTime == true)
                {
                    //await TestProcessCustomer(ServicesGDGVVControl, "PRIORITY", Convert.ToInt64(ID));
                    await TestProcessCustomer(ServicesGDGVVControl, "PRIORITY", ID);

                }
                else
                {
                    //await TestProcessCustomer(ServicesGDGVVControl, "NORMAL", Convert.ToInt64(ID));
                    await TestProcessCustomer(ServicesGDGVVControl, "NORMAL", ID);

                }
                MessageBox.Show("Customer Activated", "Customer Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                transactionMethods.GeneratePDFTicket(IDText, name, age);
            }
            AppointmentsUserControls appointment = new AppointmentsUserControls();
            UserControlNavigator.ShowControl(appointment, WalkInTransactionForm.walkInTransactionFormInstance.ReceptionistContent);

            ProcessCustomerBtn.Enabled = true;
        }

        public async Task TestProcessCustomer(Guna2DataGridView serviceDataGrid, string priorityStatus, long ID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string updateQuery = "UPDATE Appointments SET isActivated = 'YES' WHERE ReferenceNumber = @refNum";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@refNum", ID);
                        await command.ExecuteNonQueryAsync();
                    }

                    string insertToCustomerInfo = "insert into customer_info (TransactionID, CustomerName, CustomerAge, CustomerPhoneNumber, ServiceGroupID, PriorityStatus)" +
                        " Values (@transactionID, @customer_name, @customer_age, @customer_number, @service_groupID, @priorityStatus)";

                    using (MySqlCommand command1 = new MySqlCommand(insertToCustomerInfo, conn))
                    {
                        command1.Parameters.AddWithValue("@transactionID", Convert.ToInt32(transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@customer_name",  CustomerNameTxtB.Text);
                        command1.Parameters.AddWithValue("@customer_age", Convert.ToInt32(CustomerAgeTxtB.Text));
                        command1.Parameters.AddWithValue("@customer_number", Convert.ToString(CustomerPhoneNTxtB.Text));
                        command1.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(transactionIDTxtB.Text));
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
                            command2.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(transactionIDTxtB.Text));
                            command2.Parameters.AddWithValue("@service_type", await transactionMethods.GetServiceType(serviceVariation));
                            command2.Parameters.AddWithValue("@service_var", serviceVariation);
                            command2.Parameters.AddWithValue("@service_varID", transactionMethods.GetServiceVariationID(serviceVariation));
                            command2.Parameters.AddWithValue("@amount", serviceAMount);
                            command2.Parameters.AddWithValue("@queueNumber", queueNumber);
                            command2.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM-dd-yyyy dddd"));

                            if (preferredEmployee == null || string.IsNullOrWhiteSpace(preferredEmployee) || preferredEmployee == "None")
                            {
                                command2.Parameters.AddWithValue("@pref_emp", 0);
                            }
                            else
                            {
                                int employeeID = transactionMethods.GetEmployeeID(preferredEmployee);
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
            await FilterServicesByTypeAsync(mysqlcon, selectedType, ServiceFL, ServiceTxtB, ServiceAmountTxtB);
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

        public async Task GetServiceTypeAsync(string mysqlcon)
        {
            ServiceFilterComB.Items.Clear();
            ServiceFilterComB.Items.Add("All");

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "Select ServiceTypeName from service_type";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string ServiceTypeName = reader["ServiceTypeName"].ToString();
                                    ServiceFilterComB.Items.Add(ServiceTypeName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetServiceTypeAsync()");

            }
        }

        public async Task FilterServicesByTypeAsync(string mysqlcon, string selectedServiceType, FlowLayoutPanel serviceFL, Guna2TextBox serviceTB, Guna2TextBox amountTB)
        {
            serviceFL.Controls.Clear();

            try
            {
                string query;
                if (selectedServiceType == "All")
                {
                    query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services";
                }
                else
                {
                    query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services " +
                            "WHERE ServiceTypeID IN (SELECT ServiceID FROM service_type WHERE ServiceTypeName = @ServiceTypeName)";
                }

                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        if (selectedServiceType != "All")
                        {
                            command.Parameters.AddWithValue("@ServiceTypeName", selectedServiceType);
                        }

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Clear existing services in the FlowLayoutPanel
                            serviceFL.Controls.Clear();

                            while (await reader.ReadAsync())
                            {
                                byte[] imageBytes = (byte[])reader["ServiceImage"];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image serviceImage = Image.FromStream(ms);

                                    // Create UI elements (Panel, PictureBox, Labels) for each service
                                    Panel panel = new Panel
                                    {
                                        Width = 200,
                                        Height = 250,
                                        Margin = new Padding(10),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 180,
                                        Height = 120,
                                        Location = new Point(10, 10),
                                        BackgroundImage = serviceImage,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceName"].ToString(),
                                        Location = new Point(10, 140),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Label labelAmount = new Label
                                    {
                                        Text = "Amount: ₱" + reader["ServiceAmount"].ToString(),
                                        Location = new Point(10, 170),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 10, FontStyle.Regular),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Func<object, EventArgs, Task> clickHandler = async (sender, e) =>
                                    {
                                        string serviceID = ((Control)sender).Tag.ToString();

                                        await AddEmployeesComB(Convert.ToInt32(serviceID), mysqlcon);
                                        serviceTB.Text = labelTitle.Text;
                                        amountTB.Text = serviceTypeService.ExtractAmount(labelAmount.Text).ToString();
                                    };

                                    panel.Click += new EventHandler((sender, e) => clickHandler(sender, e));
                                    picBox.Click += new EventHandler((sender, e) => clickHandler(sender, e));

                                    // Add UI elements to the Panel
                                    panel.Controls.Add(picBox);
                                    panel.Controls.Add(labelTitle);
                                    panel.Controls.Add(labelAmount);

                                    // Add the Panel to the FlowLayoutPanel
                                    serviceFL.Controls.Add(panel);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in FilterServicesByTypeAsync()");
            }
        }

        public async Task GetServiceDataForSearch(FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB, string search)
        {
            serviceFL.Controls.Clear();
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services Where ServiceName LIKE @service";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@service", "%" + search + "%");

                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 200,
                                    Height = 200,
                                    Margin = new Padding(10),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 200,
                                    Height = 150,
                                    Location = new Point(10, 10),
                                    BackgroundImage = servicetypeImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceName"].ToString(),
                                    Location = new Point(10, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle1 = new Label
                                {
                                    Text = reader["ServiceAmount"].ToString(),
                                    Location = new Point(100, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Func<object, EventArgs, Task> clickHandler = async (sender, e) =>
                                {
                                    string serviceID = ((Control)sender).Tag.ToString();

                                    await AddEmployeesComB(Convert.ToInt32(serviceID), mysqlcon);
                                    serviceTB.Text = labelTitle.Text;
                                    amountTB.Text = labelTitle1.Text;
                                };

                                panel.Click += new EventHandler((sender, e) => clickHandler(sender, e));
                                picBox.Click += new EventHandler((sender, e) => clickHandler(sender, e));

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                panel.Controls.Add(labelTitle1);
                                serviceFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }

        public async Task UpdateServiceFL(FlowLayoutPanel serviceFL, string serviceTypeID, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB)
        {
            serviceFL.Controls.Clear();

            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = $"SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services WHERE ServiceTypeID = '{serviceTypeID}'";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image serviceImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 200,
                                    Height = 200,
                                    Margin = new Padding(10),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 200,
                                    Height = 150,
                                    Location = new Point(10, 10),
                                    BackgroundImage = serviceImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceName"].ToString(),
                                    Location = new Point(10, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle1 = new Label
                                {
                                    Text = reader["ServiceAmount"].ToString(),
                                    Location = new Point(100, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                EventHandler clickHandler = (sender, e) =>
                                {
                                    string serviceID = ((Control)sender).Tag.ToString();
                                    serviceTB.Text = labelTitle.Text;
                                    amountTB.Text = labelTitle1.Text;
                                };

                                panel.Click += clickHandler;
                                picBox.Click += clickHandler;

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                panel.Controls.Add(labelTitle1);
                                serviceFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }
        public async Task AddEmployeesComB(int serviceID, string mysqlcon)
        {
            PEmployeeComB.Items.Clear();
            PEmployeeComB.Items.Add("None");
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select Name from salon_employees where ServiceID = @service_ID AND AccountAccess NOT IN ('Receptionist','Manager')";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_ID", serviceID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string EmpName = reader["Name"].ToString();
                                    PEmployeeComB.Items.Add(EmpName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in AddEmployeesComBAsync()");
            }
        }

        public async Task GetAllEmployee(string mysqlcon)
        {
            PEmployeeComB.Items.Clear();
            PEmployeeComB.Items.Add("None");

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT Name FROM salon_employees WHERE AccountAccess NOT IN ('Receptionist', 'Manager')";


                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string EmpName = reader["Name"].ToString();
                                    PEmployeeComB.Items.Add(EmpName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in AddEmployeesComBAsync()");
            }
        }
    }
}
