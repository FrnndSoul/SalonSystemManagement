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

namespace TriforceSalon.Class_Components
{
    public  class ServiceFetchClass
    {
        private string mysqlcon;

        public ServiceFetchClass()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }
        public async Task LoadServices(FlowLayoutPanel sellFlowlayout, string mysqlcon, Guna2DataGridView datagrid, string target)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ss.ServiceVariationID, ss.ServiceName, ss.ServiceImage, ss.ServiceAmount " +
                        "FROM salon_services ss " +
                        "JOIN salon_subtypes ssbt ON ss.ServiceTypeID = ssbt.CategoryID " +
                        "WHERE ssbt.ServiceSubTypeName = @target";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@target", target);
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            var tasks = new List<Task>();
                            var panels = new List<Panel>();

                            while (await reader.ReadAsync())
                            {
                                tasks.Add(Task.Run(() =>
                                {
                                    byte[] imageBytes = (byte[])reader["ServiceImage"];

                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        Image serviceTypeImage = Image.FromStream(ms);

                                        Panel panel = new Panel
                                        {
                                            Width = 200,
                                            Height = 250, // Adjusted height to accommodate the layout
                                            Margin = new Padding(10),
                                            Tag = reader["ServiceVariationID"].ToString()
                                        };

                                        PictureBox picBox = new PictureBox
                                        {
                                            Width = 200,
                                            Height = 150,
                                            BackgroundImage = serviceTypeImage,
                                            BackgroundImageLayout = ImageLayout.Stretch,
                                            Tag = reader["ServiceVariationID"].ToString()
                                        };

                                        Label labelTitle = new Label
                                        {
                                            Text = reader["ServiceName"].ToString(),
                                            Location = new Point(10, 160), // Adjusted location to accommodate the layout
                                            ForeColor = Color.Black,
                                            AutoSize = true,
                                            Font = new Font("Stanberry", 12, FontStyle.Regular),
                                            Tag = reader["ServiceVariationID"].ToString()
                                        };

                                        Label labelTitle1 = new Label
                                        {
                                            Text = "Amount: ₱" + reader["ServiceAmount"].ToString(),
                                            Location = new Point(10, 210), // Adjusted location to accommodate the layout
                                            ForeColor = Color.Black,
                                            AutoSize = true,
                                            Font = new Font("Stanberry", 12, FontStyle.Regular),
                                            Tag = reader["ServiceVariationID"].ToString()
                                        };

                                        panel.Controls.Add(picBox);
                                        panel.Controls.Add(labelTitle);
                                        panel.Controls.Add(labelTitle1);
                                        panels.Add(panel);
                                    }
                                }));
                            }

                            await Task.WhenAll(tasks);
                            sellFlowlayout.Controls.AddRange(panels.ToArray());
                            SubscribeToServiceClickEvents(sellFlowlayout, datagrid);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in LoadItemsInSales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SubscribeToServiceClickEvents(FlowLayoutPanel serviceFL, Guna2DataGridView dataGridView)
        {
            foreach (Control control in serviceFL.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Click += (sender, e) => DisplayServiceData(panel, dataGridView);
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is PictureBox pictureBox)
                        {
                            pictureBox.Click += (sender, e) => DisplayServiceData(panel, dataGridView);
                        }
                    }
                }
            }
        }

        private async void DisplayServiceData(Panel panel, Guna2DataGridView dataGridView)
        {
            string serviceName = panel.Controls.OfType<Label>().FirstOrDefault()?.Text;
            long ID = await GetServiceId(serviceName);

            if (serviceName != null)
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the new row added by DataGridView

                    if (row.Cells[0].Value.ToString() == serviceName)
                    {
                        int currentQty = int.Parse(row.Cells[3].Value.ToString());
                        row.Cells[3].Value = (currentQty + 1).ToString();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dataGridView.Rows.Add(serviceName, ID, "X");
                }
            }
        }

        public async Task<int> GetServiceId(string serviceName)
        {
            int item_id = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ServiceVariationID  from salon_services where ServiceName = @serv_name";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@serv_name", serviceName);

                        object result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out item_id))
                        {

                            return item_id;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error in GetItemId", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return item_id;
        }
    }
}
