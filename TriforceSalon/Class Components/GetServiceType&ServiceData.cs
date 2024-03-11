using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        public async Task GetServiceTypeData(FlowLayoutPanel serviceTypeFL, string mysqlcon, Action<string> updateServiceFL)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = "SELECT ServiceTypeName, ServiceTypeImage, ServiceID FROM service_type";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
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
        }

        public async Task GetServiceData(FlowLayoutPanel serviceFL, string mysqlcon, Guna2TextBox serviceTB, Guna2TextBox amountTB)
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

                                /*EventHandler clickHandler = (sender, e) =>
                                {
                                    string serviceID = ((Control)sender).Tag.ToString();
                                    serviceTB.Text = labelTitle.Text;
                                    amountTB.Text = labelTitle1.Text;
                                };*/

                                /*panel.Click += clickHandler;
                                picBox.Click += clickHandler;*/

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
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Clear();
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Add("None");
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

    }
}
