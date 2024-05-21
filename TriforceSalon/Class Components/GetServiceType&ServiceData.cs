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
        public decimal ExtractAmount(string input)
        {
            string pattern = @"Amount:\s*₱\s*(\d+(\.\d+)?)";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string amountString = match.Groups[1].Value;
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
                                        Location = new System.Drawing.Point(0, 0),
                                        BackgroundImage = serviceImage,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceName"].ToString(),
                                        Location = new System.Drawing.Point(5, 150),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    Label labelAmount = new Label
                                    {
                                        Text = "Amount: ₱" + reader["ServiceAmount"].ToString(),
                                        Location = new System.Drawing.Point(5, 170),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ServiceTypeID"].ToString()
                                    };

                                    EventHandler clickHandler = (sender, e) =>
                                    {
                                        string serviceID = ((Control)sender).Tag.ToString();
                                        serviceTB.Text = labelTitle.Text;
                                        amountTB.Text = ExtractAmount(labelAmount.Text).ToString();
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
                                        Width = 200, // Adjusted panel width
                                        Height = 200, // Adjusted panel height
                                        Margin = new Padding(10)
                                    };
                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 150,
                                        Height = 100,
                                        Location = new Point(10, 10),
                                        BackgroundImage = servicetypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceSubTypeName"].ToString(),
                                        Location = new Point(10, 120), // Adjusted label location
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 16, FontStyle.Regular) // Adjusted font size
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
            servicetypeFL.Controls.Clear();
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
                                        Width = 150,
                                        Height = 100,
                                        Location = new Point(10, 10),
                                        BackgroundImage = servicetypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ServiceSubTypeName"].ToString(),
                                        Location = new Point(10, 120),
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
