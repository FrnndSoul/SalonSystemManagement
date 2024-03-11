﻿using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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
    public class SellProductsMethods
    {
        public SellProductsMethods()
        {

        }

        /*public async Task LoadItemsInSales(FlowLayoutPanel sellFlowlayout, string mysqlcon)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = "select ItemID, ItemName, Photo, Cost from inventory";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            byte[] imageBytes = (byte[])reader["Photo"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 200,
                                    Height = 200,
                                    Margin = new Padding(10),
                                    Tag = reader["ItemID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 200,
                                    Height = 150,
                                    Location = new Point(10, 10),
                                    BackgroundImage = servicetypeImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ItemID"].ToString()
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ItemName"].ToString(),
                                    Location = new Point(10, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ItemID"].ToString()
                                };

                                Label labelTitle1 = new Label
                                {
                                    Text = reader["Cost"].ToString(),
                                    Location = new Point(100, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ItemID"].ToString()
                                };

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                panel.Controls.Add(labelTitle1);
                                sellFlowlayout.Controls.Add(panel);
                            }

                        }
                    }
                }
            }
        }*/

        public async Task LoadItemsInSales(FlowLayoutPanel sellFlowlayout, string mysqlcon)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                string query = "select ItemID, ItemName, Photo, Cost from inventory LIMIT 100";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        var tasks = new List<Task>();
                        var panels = new List<Panel>();

                        while (await reader.ReadAsync())
                        {
                            tasks.Add(Task.Run(() =>
                            {
                                byte[] imageBytes = (byte[])reader["Photo"];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image servicetypeImage = Image.FromStream(ms);

                                    Panel panel = new Panel
                                    {
                                        Width = 200,
                                        Height = 200,
                                        Margin = new Padding(10),
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 200,
                                        Height = 150,
                                        Location = new Point(10, 10),
                                        BackgroundImage = servicetypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ItemName"].ToString(),
                                        Location = new Point(10, 160),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    Label labelTitle1 = new Label
                                    {
                                        Text = reader["Cost"].ToString(),
                                        Location = new Point(100, 160),
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ItemID"].ToString()
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
                    }
                }
            }
        }

    }
}
