using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls;
using TriforceSalon.UserControls.Receptionist_Controls;

namespace TriforceSalon.Class_Components
{
    internal class GetServiceType_ServiceData
    {

        //original dito
        /*public void GetServiceTypeData(FlowLayoutPanel serviceTypeFL, string mysqlcon, Action<string> updateServiceFL)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT ServiceTypeName, ServiceTypeImage, ServiceID FROM service_type";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceTypeImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 140,
                                    Height = 140,
                                    Margin = new Padding(10),
                                    Tag = reader["ServiceID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 120,
                                    Height = 75,
                                    Location = new Point(10, 10),
                                    BackgroundImage = servicetypeImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceID"].ToString()
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceTypeName"].ToString(),
                                    Location = new Point(10, 95),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 8, FontStyle.Regular),
                                    Tag = reader["ServiceID"].ToString()
                                };

                                EventHandler clickHandler = (sender, e) =>
                                {
                                    string serviceID = ((Control)sender).Tag.ToString();
                                    AddEmployeesComB(Convert.ToInt32(serviceID), mysqlcon);
                                    updateServiceFL?.Invoke(serviceID);
                                };

                                panel.Click += clickHandler;
                                picBox.Click += clickHandler;
                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                serviceTypeFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }*/

        /*public void GetServiceData(FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
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
        }*/

        /*public void UpdateServiceFL(FlowLayoutPanel serviceFL, string serviceTypeID, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB)
        {
            serviceFL.Controls.Clear();

            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = $"SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services WHERE ServiceTypeID = '{serviceTypeID}'";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
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
        }*/

        /*public void AddEmployeesComB(int serviceID, string mysqlcon)
        {
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select Name from salon_employees where ServiceID = @service_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_ID", serviceID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string EmpName = reader["Name"].ToString();
                                    ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Add(EmpName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in addEmployeesComB()");
            }
        }*/
        //Async Dito


        //tulog na muna ito
        /*public async Task GetServiceTypeData(FlowLayoutPanel serviceTypeFL, string mysqlcon, Action<string> updateServiceFL)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = "SELECT ServiceSubTypeName, ServiceSubTypeImage, CategoryID  FROM salon_subtypes";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceSubTypeImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 140,
                                    Height = 140,
                                    Margin = new Padding(10),
                                    Tag = reader["CategoryID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 120,
                                    Height = 75,
                                    Location = new Point(10, 10),
                                    BackgroundImage = servicetypeImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["CategoryID"].ToString()
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceSubTypeName"].ToString(),
                                    Location = new Point(10, 95),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 8, FontStyle.Regular),
                                    Tag = reader["CategoryID"].ToString()
                                };

                                Func<object, EventArgs, Task> clickHandler = async (sender, e) =>
                                {
                                    string serviceID = ((Control)sender).Tag.ToString();
                                    await AddEmployeesComB(Convert.ToInt32(serviceID), mysqlcon);
                                    updateServiceFL?.Invoke(serviceID);
                                };

                                // Attach the async event handler
                                panel.Click += new EventHandler((sender, e) => clickHandler(sender, e));
                                picBox.Click += new EventHandler((sender, e) => clickHandler(sender, e));

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                serviceTypeFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }*/

        /* public async Task GetServiceData(FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                *//*Image servicetypeImage = Image.FromStream(ms);

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
                                };*//*

                                Image serviceImage = Image.FromStream(ms);

                                // Create Panel for each service
                                Panel panel = new Panel
                                {
                                    Width = 200,
                                    Height = 250, // Adjusted height to accommodate additional label
                                    Margin = new Padding(10),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                // Create PictureBox
                                PictureBox picBox = new PictureBox
                                {
                                    Width = 180,
                                    Height = 120,
                                    Location = new Point(10, 10),
                                    BackgroundImage = serviceImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                // Create Label for Service Name
                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceName"].ToString(),
                                    Location = new Point(10, 140), // Adjusted location
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                // Create Label for Service Amount
                                Label labelAmount = new Label
                                {
                                    Text = "Amount: " + reader["ServiceAmount"].ToString(),
                                    Location = new Point(10, 170), // Adjusted location
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
                                    amountTB.Text = labelAmount.Text;
                                    //amountTB.Text = labelTitle1.Text;
                                };

                                panel.Click += new EventHandler((sender, e) => clickHandler(sender, e));
                                picBox.Click += new EventHandler((sender, e) => clickHandler(sender, e));

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                amountTB.Text = labelAmount.Text;
                                //panel.Controls.Add(labelTitle1);
                                serviceFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }*/


        public decimal ExtractAmount(string input)
        {
            string pattern = @"Amount:\s*₱\s*(\d+)";

            // Match the pattern in the input string
            Match match = Regex.Match(input, pattern);

            // Check if a match is found
            if (match.Success)
            {
                // Extract the amount from the match
                string amountString = match.Groups[1].Value;

                // Convert the amount to a decimal
                if (decimal.TryParse(amountString, out decimal extractedAmount))
                {
                    return extractedAmount;
                }
                else
                {
                    throw new ArgumentException("Failed to parse amount.");
                }
            }
            else
            {
                throw new ArgumentException("Pattern not found in input string.");
            }
        }
        //Test Method
        /*public async Task FilterServicesByTypeAsync(string mysqlcon, string selectedServiceType, FlowLayoutPanel serviceFL, Guna2TextBox serviceTB, Guna2TextBox amountTB)
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
                                        amountTB.Text = ExtractAmount(labelAmount.Text).ToString();
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

                            *//*while (await reader.ReadAsync())
                            {
                                byte[] imageBytes = (byte[])reader["ServiceImage"];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image serviceImage = Image.FromStream(ms);

                                    // Create UI elements (Panel, PictureBox, Labels) for each service
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

                                    // Attach click handler to show details or whatever you desire
                                    panel.Click += (sender, e) =>
                                    {
                                        // Handle click event
                                    };

                                    panel.Controls.Add(picBox);
                                    panel.Controls.Add(labelTitle);
                                    panel.Controls.Add(labelTitle1);

                                    // Add panel to the FlowLayoutPanel
                                    serviceFL.Controls.Add(panel);
                                }
                            }*//*
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in FilterServicesByTypeAsync()");
            }
        }*/

        /*public async Task GetServiceDataForSearch(FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB, string search)
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
        }*/

        public async Task UpdateServiceFL(FlowLayoutPanel serviceFL, string serviceTypeID, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB)
        {
            serviceFL.Controls.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID FROM salon_services WHERE ServiceTypeID = @ServiceTypeID";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ServiceTypeID", serviceTypeID);
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
                                        Location = new System.Drawing.Point(10, 10),
                                        BackgroundImage = serviceImage,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceName"].ToString(),
                                        Location = new System.Drawing.Point(10, 160),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 16, FontStyle.Regular),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Label labelAmount = new Label
                                    {
                                        Text = reader["ServiceAmount"].ToString(),
                                        Location = new System.Drawing.Point(100, 160),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 16, FontStyle.Regular),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    EventHandler clickHandler = (sender, e) =>
                                    {
                                        string serviceID = ((Control)sender).Tag.ToString();
                                        serviceTB.Text = labelTitle.Text;
                                        amountTB.Text = labelAmount.Text;
                                    };

                                    panel.Click += clickHandler;
                                    picBox.Click += clickHandler;

                                    panel.Controls.Add(picBox);
                                    panel.Controls.Add(labelTitle);
                                    panel.Controls.Add(labelAmount);
                                    serviceFL.Controls.Add(panel);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in UpdateServiceFL");
            }
        }

        public async Task UpdateServiceCategoryFL(string serviceTypeName, FlowLayoutPanel servicetypefl, FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox service, Guna2TextBox amount)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceID FROM service_type WHERE ServiceTypeName = @ServiceTypeName";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ServiceTypeName", serviceTypeName);
                        object result = await command.ExecuteScalarAsync();
                        if (result != null)
                        {
                            string serviceTypeID = result.ToString();
                            // Use the retrieved ServiceTypeID to filter images in ServiceTypeFL
                            await FilterImagesByServiceType(serviceTypeID, servicetypefl, serviceFL, mysqlcon, service, amount);

                        }
                        else
                        {
                            MessageBox.Show("ServiceTypeID not found for selected ServiceType");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in UpdateServiceTypeFL");
            }
        }
        private async Task FilterImagesByServiceType(string serviceTypeID, FlowLayoutPanel servicetypefl, FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox service, Guna2TextBox amount)
        {
            servicetypefl.Controls.Clear();
            serviceFL.Controls.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ServiceSubTypeName, ServiceSubTypeImage, CategoryID FROM salon_subtypes WHERE ServiceTypeID = @ServiceTypeID";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ServiceTypeID", serviceTypeID);
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                byte[] imageBytes = (byte[])reader["ServiceSubTypeImage"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image servicetypeImage = Image.FromStream(ms);
                                    Panel panel = new Panel
                                    {
                                        Width = 200,
                                        Height = 200,
                                        Margin = new Padding(10)
                                    };
                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 200,
                                        Height = 150,
                                        Location = new Point(10, 10),
                                        BackgroundImage = servicetypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceSubTypeName"].ToString(),
                                        Location = new Point(10, 160),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 16, FontStyle.Regular)
                                    };

                                    picBox.Tag = reader["CategoryID"];
                                    picBox.Click += async (sender, e) =>
                                    {
                                        string categoryID = ((PictureBox)sender).Tag.ToString();
                                        //MessageBox.Show(categoryID);
                                        await UpdateServiceFL(serviceFL, categoryID, mysqlcon, service, amount);
                                    };

                                    panel.Controls.Add(picBox);
                                    panel.Controls.Add(labelTitle);
                                    servicetypefl.Controls.Add(panel);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in FilterImagesByServiceType");
            }
        }

        /*public async Task AddEmployeesComB(string serviceName, string mysqlcon)
        {
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Clear();
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Add("None");
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT se.Name FROM salon_employees se " +
                        "JOIN service_type st ON se.ServiceID = st.ServiceID " +
                        "JOIN salon_subtypes sst ON st.ServiceID = sst.ServiceTypeID " +
                        "JOIN salon_services ss ON sst.CategoryID = ss.ServiceTypeID " +
                        "WHERE ss.ServiceName =  @serviceName AND se.AccountAccess NOT IN ('Receptionist','Manager')";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@serviceName", serviceName);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string EmpName = reader["Name"].ToString();
                                    ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Add(EmpName);
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
        }*/

        public void AddEmployeesComB(string selectedServiceType, Guna2ComboBox employeesCB, string mysqlcon)
        {
            employeesCB.Items.Clear();
            employeesCB.Items.Add("None");

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();

                    string query = "SELECT DISTINCT se.Name FROM salon_employees se " +
                        "JOIN service_type st ON se.ServiceID = st.ServiceID " +
                        "WHERE st.ServiceTypeName = @ServiceTypeName " +
                        "AND se.AccountAccess NOT IN ('Receptionist', 'Manager')";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ServiceTypeName", selectedServiceType);

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string employeeName = reader["Name"].ToString();
                                employeesCB.Items.Add(employeeName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in AddEmployeesComB");
            }
        }

        public async Task GetAllEmployee(string mysqlcon)
        {
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Clear();
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Add("None");

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
                                    ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Add(EmpName);
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

        public async Task GetAllType(Guna2ComboBox serviceType, string mysqlcon)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "select ServiceTypeName from service_type";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string serviceTypes = reader["ServiceTypeName"].ToString();
                                    serviceType.Items.Add(serviceTypes);
                                }
                            }
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetAllCategory");
            }
        }
        public async Task<int> GetLargestQueue(string date, string serviceType, string mysqlcon)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                //string query = "SELECT MAX (QueueNumber) FROM service_group WHERE AppointmentDate = @appointment AND ServiceType = @serviceType";
                string query = "SELECT MAX(CAST(QueueNumber AS UNSIGNED)) FROM service_group WHERE AppointmentDate = @appointment AND ServiceType = @serviceType";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@appointment", date);
                    command.Parameters.AddWithValue("@serviceType", serviceType);

                    object result = await command.ExecuteScalarAsync();
                    int largestNumber = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    if(largestNumber > 0)
                    {
                        largestNumber++;
                    }
                    else
                    {
                        largestNumber = 1;
                    }
                    return largestNumber;
                }
            }
        }

        public async Task DisplayServiceTypeFL(FlowLayoutPanel servicetypeFL, FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB, Guna2ComboBox employeeCB)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ServiceSubTypeName, ServiceSubTypeImage, CategoryID, ServiceTypeID FROM salon_subtypes";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                byte[] imageBytes = (byte[])reader["ServiceSubTypeImage"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image servicetypeImage = Image.FromStream(ms);
                                    Panel panel = new Panel
                                    {
                                        Width = 200,
                                        Height = 200,
                                        Margin = new Padding(10)
                                    };
                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 200,
                                        Height = 150,
                                        Location = new Point(10, 10),
                                        BackgroundImage = servicetypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceSubTypeName"].ToString(),
                                        Location = new Point(10, 160),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 16, FontStyle.Regular)
                                    };

                                    picBox.Tag = new Tuple<string, string>(reader["CategoryID"].ToString(), reader["ServiceTypeID"].ToString());
                                    picBox.Click += async(sender, e) =>
                                    {
                                        Tuple<string, string> tags = ((Tuple<string, string>)((PictureBox)sender).Tag);
                                        string categoryID = tags.Item1;
                                        string serviceTypeID = tags.Item2;

                                        await AddEmployeesComB1(serviceTypeID, employeeCB, mysqlcon);
                                        await UpdateServiceFL(serviceFL, categoryID, mysqlcon, serviceTB, amountTB);
                                    };


                                    panel.Controls.Add(picBox);
                                    panel.Controls.Add(labelTitle);
                                    servicetypeFL.Controls.Add(panel);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in FilterImagesByServiceType");
            }
        }
        public async Task AddEmployeesComB1(string selectedServiceTypeID, Guna2ComboBox employeesCB, string mysqlcon)
        {
            employeesCB.Items.Clear();
            employeesCB.Items.Add("None");

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT DISTINCT se.Name FROM salon_employees se " +
                                   "JOIN salon_subtypes st ON se.ServiceID = st.ServiceTypeID " +
                                   "WHERE st.ServiceTypeID = @ServiceTypeID " +
                                   "AND se.AccountAccess NOT IN ('Receptionist', 'Manager')";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ServiceTypeID", selectedServiceTypeID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string employeeName = reader["Name"].ToString();
                                employeesCB.Items.Add(employeeName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in AddEmployeesComB1");
            }
        }
    }
}
