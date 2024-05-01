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
        PromoMethods promoMethods = new PromoMethods();
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
            PEmployeeComB.Items.Clear();
            PEmployeeComB.Items.Add("None");

            await serviceTypeService.GetAllEmployee(mysqlcon);
            PEmployeeComB.SelectedIndex = 0;
            await GetEmployeeAtStart();
            await serviceTypeService.GetAllType(ServiceTypeComB, mysqlcon);
            await promoMethods.GetActiveServicePromos(ServicePromoComB);
            DisplayServiceTypeFL();
        }
        public async void DisplayServiceTypeFL()
        {
            await serviceTypeService.DisplayServiceTypeFL(CategoryFL, ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB, PEmployeeComB);
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

            //ServicesGDGVVControl.Rows.Add(serviceType, serviceName, prefEmp, amountService, "X", queueNumber);
            ServicesGDGVVControl.Rows.Add(serviceType, serviceName, prefEmp, amountService, "None", "X", queueNumber);

            ServiceTxtB.Clear();
            ServiceAmountTxtB.Clear();
            PEmployeeComB.SelectedIndex = 0;

        }


        private async void PEmployeeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedType = ServiceFilterComB.SelectedItem.ToString();
            //await FilterServicesByTypeAsync(mysqlcon, selectedType, ServiceFL, ServiceTxtB, ServiceAmountTxtB);
        }

        public void GetCustomerInfo(string name, string transactionID, string appointmentDate,string pNumber, string service, string amount, string dateTaken, bool onTime)
        {
            CustomerNameTxtB.Text = name;
            transactionIDTxtB.Text = transactionID;
            AppointmentDateTxtB.Text = appointmentDate;
            CustomerPhoneNTxtB.Text = pNumber;
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

            if (CustomerNameTxtB.Text is null || CustomerPhoneNTxtB is null
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
                await transactionMethods.GetServiceTypeID(serviceName);

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
                transactionMethods.GeneratePDFTicket(IDText, name);
            }
            AppointmentsUserControls appointment = new AppointmentsUserControls();
            UserControlNavigator.ShowControl(appointment, WalkInTransactionForm.walkInTransactionFormInstance.ReceptionistContent);

            ProcessCustomerBtn.Enabled = true;
        }

        /*public async Task TestProcessCustomer(Guna2DataGridView serviceDataGrid, string priorityStatus, long ID)
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

                    string insertToCustomerInfo = "insert into customer_info (TransactionID, CustomerName, CustomerPhoneNumber, ServiceGroupID, PriorityStatus)" +
                        " Values (@transactionID, @customer_name, @customer_number, @service_groupID, @priorityStatus)";

                    using (MySqlCommand command1 = new MySqlCommand(insertToCustomerInfo, conn))
                    {
                        command1.Parameters.AddWithValue("@transactionID", Convert.ToInt32(transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@customer_name",  CustomerNameTxtB.Text);
                        command1.Parameters.AddWithValue("@customer_number", Convert.ToString(CustomerPhoneNTxtB.Text));
                        command1.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(transactionIDTxtB.Text));
                        command1.Parameters.AddWithValue("@priorityStatus", priorityStatus);

                        await command1.ExecuteNonQueryAsync();
                    }

                    string insertToServiceGroup = "insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount, Discount, QueueNumber, AppointmentDate)"
                    + " values(@service_groupID, @service_type, @pref_emp, @service_var, @service_varID, @amount, @discount, @queueNumber, @date)";

                    foreach (DataGridViewRow row in serviceDataGrid.Rows)
                    {
                        string serviceType = Convert.ToString(row.Cells["ServiceTypeCol"].Value);
                        string serviceVariation = Convert.ToString(row.Cells["SNameCol"].Value);
                        string preferredEmployee = Convert.ToString(row.Cells["PrefEmpCol"].Value);
                        decimal serviceAmount = Convert.ToDecimal(row.Cells["AmountCol"].Value);
                        int queueNumber = Convert.ToInt32(row.Cells["QueNumCol"].Value);
                        string discount = Convert.ToString(row.Cells["DiscountCol"].Value);

                        using (MySqlCommand command2 = new MySqlCommand(insertToServiceGroup, conn))
                        {
                            command2.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(transactionIDTxtB.Text));
                            command2.Parameters.AddWithValue("@service_type", await transactionMethods.GetServiceType(serviceVariation));
                            command2.Parameters.AddWithValue("@service_var", serviceVariation);
                            command2.Parameters.AddWithValue("@service_varID", transactionMethods.GetServiceVariationID(serviceVariation));
                            command2.Parameters.AddWithValue("@amount", serviceAmount);
                            command2.Parameters.AddWithValue("@discount", discount);
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
        }*/

        public async Task TestProcessCustomer(Guna2DataGridView serviceDataGrid, string priorityStatus, long ID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updateQuery = "UPDATE Appointments SET isActivated = 'YES' WHERE ReferenceNumber = @refNum";
                            using (MySqlCommand command = new MySqlCommand(updateQuery, conn, transaction))
                            {
                                command.Parameters.AddWithValue("@refNum", ID);
                                await command.ExecuteNonQueryAsync();
                            }

                            string insertToCustomerInfo = "insert into customer_info (TransactionID, CustomerName, CustomerPhoneNumber, ServiceGroupID, PriorityStatus, IsAppointment)" +
                                " Values (@transactionID, @customer_name, @customer_number, @service_groupID, @priorityStatus, @isAppointment)";

                            using (MySqlCommand command1 = new MySqlCommand(insertToCustomerInfo, conn, transaction))
                            {
                                command1.Parameters.AddWithValue("@transactionID", Convert.ToInt32(transactionIDTxtB.Text));
                                command1.Parameters.AddWithValue("@customer_name", CustomerNameTxtB.Text);
                                command1.Parameters.AddWithValue("@customer_number", Convert.ToString(CustomerPhoneNTxtB.Text));
                                command1.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(transactionIDTxtB.Text));
                                command1.Parameters.AddWithValue("@priorityStatus", priorityStatus);
                                command1.Parameters.AddWithValue("@isAppointment", "YES");


                                await command1.ExecuteNonQueryAsync();
                            }

                            string insertToServiceGroup = "insert into service_group (ServiceGroupID, ServiceType, EmployeeID, ServiceVariation, ServiceVariationID, Amount, Discount, QueueNumber, AppointmentDate)"
                                + " values(@service_groupID, @service_type, @pref_emp, @service_var, @service_varID, @amount, @discount, @queueNumber, @date)";

                            foreach (DataGridViewRow row in serviceDataGrid.Rows)
                            {
                                string serviceType = Convert.ToString(row.Cells["ServiceTypeCol"].Value);
                                string serviceVariation = Convert.ToString(row.Cells["SNameCol"].Value);
                                string preferredEmployee = Convert.ToString(row.Cells["PrefEmpCol"].Value);
                                decimal serviceAmount = Convert.ToDecimal(row.Cells["AmountCol"].Value);
                                int queueNumber = Convert.ToInt32(row.Cells["QueNumCol"].Value);
                                string discount = Convert.ToString(row.Cells["DiscountCol"].Value);

                                using (MySqlCommand command2 = new MySqlCommand(insertToServiceGroup, conn, transaction))
                                {
                                    command2.Parameters.AddWithValue("@service_groupID", Convert.ToInt32(transactionIDTxtB.Text));
                                    command2.Parameters.AddWithValue("@service_type", await transactionMethods.GetServiceType(serviceVariation));
                                    command2.Parameters.AddWithValue("@service_var", serviceVariation);
                                    command2.Parameters.AddWithValue("@service_varID", transactionMethods.GetServiceVariationID(serviceVariation));
                                    command2.Parameters.AddWithValue("@amount", serviceAmount);
                                    command2.Parameters.AddWithValue("@discount", discount);
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

                            if (!Method.AdminAccess())
                            {
                                transaction.Commit();
                                MessageBox.Show("Customer processed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // If admin, rollback the transaction
                                transaction.Rollback();
                                MessageBox.Show("Service process rolled back. No changes were made.", "Process Customer Function", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            /*                            // Commit the transaction if no exceptions occur
                                                        transaction.Commit();
                                                        MessageBox.Show("Customer processed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            */
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an exception occurs
                            transaction.Rollback();
                            MessageBox.Show($"Error in TestProcessCustomer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        /*public async Task GetServiceTypeAsync(string mysqlcon)
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
        }*/

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
        private async Task GetEmployeeAtStart()
        {
            string serviceChosen = ServiceTxtB.Text;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT se.Name " +
                        "FROM salon_employees se " +
                        "JOIN service_type st ON se.ServiceID = st.ServiceID " +
                        "JOIN salon_services ss ON st.ServiceID = ss.ServiceTypeID " +
                        "WHERE ss.ServiceName = @service  AND AccountAccess NOT IN ('Receptionist', 'Manager')";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service", serviceChosen);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetEmployeeAtStart()");

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

        private void ActivateBtn_Click(object sender, EventArgs e)
        {
            string promoInput = ServicePromoTxtB.Text.Substring(0, 7);

            if (int.TryParse(promoInput, out int promoCode))
            {
                var promoDetails = transactionMethods.GetPromoDetails(promoCode, mysqlcon);

                if (promoDetails.isValid == "YES")
                {
                    var serviceDetails = transactionMethods.GetServiceDetails(promoCode, mysqlcon);

                    // Check if any of the items from the promo are already present in the DataGridView
                    bool serviceAlreadyAdded = true; // Assume all services are already added
                    foreach (var service in serviceDetails)
                    {
                        bool found = false;
                        foreach (DataGridViewRow row in ServicesGDGVVControl.Rows)
                        {
                            if (row.Cells["SNameCol"].Value != null && row.Cells["SNameCol"].Value.ToString() == service.ServiceName)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            serviceAlreadyAdded = false;
                            break;
                        }
                    }

                    if (serviceAlreadyAdded)
                    {
                        foreach (var service in serviceDetails)
                        {
                            foreach (DataGridViewRow row in ServicesGDGVVControl.Rows)
                            {
                                if (row.Cells["SNameCol"].Value != null && row.Cells["SNameCol"].Value.ToString() == service.ServiceName)
                                {
                                    row.Cells["DiscountCol"].Value = service.ServiceDiscount;
                                }
                            }
                        }
                        MessageBox.Show("Discount applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select all the services from the promo before applying the discount.", "Service(s) not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    ServicePromoTxtB.Clear();
                }
                else if (promoDetails.isValid == "NO")
                {
                    MessageBox.Show($"Promo Code {promoDetails.promoCode} is not available right now.", "Invalid Promo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid promo code.", "Invalid Promo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void ServicePromoComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string promoName = ServicePromoComB.Text;
            await promoMethods.GetPromoCode(promoName, ServicePromoTxtB);
        }

        private async void ServiceTypeComB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServiceType = ServiceTypeComB.SelectedItem.ToString();
            await serviceTypeService.UpdateServiceCategoryFL(selectedServiceType, CategoryFL, ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
            serviceTypeService.AddEmployeesComB(selectedServiceType, PEmployeeComB, mysqlcon);

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DisplayServiceTypeFL();
            ServiceFL.Controls.Clear();
            ServiceTypeComB.Text = null;
        }
    }
}
