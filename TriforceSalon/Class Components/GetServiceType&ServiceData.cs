﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        public void GetServiceTypeData(FlowLayoutPanel serviceTypeFL, string mysqlcon, Action<string> updateServiceFL)
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
                                    Width = 100,
                                    Height = 100,
                                    Margin = new Padding(10),
                                    Tag = reader["ServiceID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 100,
                                    Height = 75,
                                    Location = new Point(10, 10),
                                    BackgroundImage = servicetypeImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceID"].ToString()
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceTypeName"].ToString(),
                                    Location = new Point(10, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 14, FontStyle.Regular),
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
        }

        public void AddEmployeesComB(int serviceID, string mysqlcon) 
        {
            ServicesUserControl.servicesUserControlInstance.PEmployeeComB.Items.Clear();
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select Name from salon_employees where ServiceID = @service_ID";

                    using(MySqlCommand command = new MySqlCommand(query, conn)) 
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in addEmployeesComB()");
            }

        }

        public void GetServiceData(FlowLayoutPanel serviceFL, string mysqlcon)
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
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle1 = new Label
                                {
                                    Text = reader["ServiceAmount"].ToString(),
                                    Location = new Point(100, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                EventHandler clickHandler = (sender, e) =>
                                {
                                    string serviceID = ((Control)sender).Tag.ToString();
                                    AddEmployeesComB(Convert.ToInt32(serviceID), mysqlcon);
                                    updateServiceFL?.Invoke(serviceID);
                                };

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

        public void UpdateServiceFL(FlowLayoutPanel serviceFL, string serviceTypeID, string mysqlcon)
        {
            // Clear existing panels in ServiceFL
            serviceFL.Controls.Clear();

            // Retrieve and display panels based on the selected ServiceTypeID
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
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle1 = new Label
                                {
                                    Text = reader["ServiceAmount"].ToString(),
                                    Location = new Point(100, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

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
    }
}
