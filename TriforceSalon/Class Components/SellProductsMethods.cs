using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TriforceSalon.Class_Components
{
    public class SellProductsMethods
    {
        GetServiceType_ServiceData serviceData = new GetServiceType_ServiceData();
        public delegate void UpdateTotalPriceDelegate();
        public delegate void AddTotalPriceDelegate(int rowIndex);
        private readonly UpdateTotalPriceDelegate updateTotalPrice;
        private readonly AddTotalPriceDelegate addTotalPrice;

        public SellProductsMethods(UpdateTotalPriceDelegate updateTotalPrice, AddTotalPriceDelegate addTotalPrice)
        {
            this.updateTotalPrice = updateTotalPrice;
            this.addTotalPrice = addTotalPrice;
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

        public async Task LoadItemsInSales(FlowLayoutPanel sellFlowlayout, string mysqlcon, Guna2DataGridView datagrid)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                //string query = "select ItemID, ItemName, Photo, SRP from inventory LIMIT 100 WHERE STOCK != 0";
                string query = "SELECT ItemID, ItemName, Photo, SRP FROM inventory WHERE STOCK != 0 LIMIT 100";

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

                                /*using (MemoryStream ms = new MemoryStream(imageBytes))
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
                                    panels.Add(panel);*/

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image serviceTypeImage = Image.FromStream(ms);

                                    Panel panel = new Panel
                                    {
                                        Width = 200,
                                        Height = 250, // Adjusted height to accommodate the layout
                                        Margin = new Padding(10),
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 200,
                                        Height = 150,
                                        BackgroundImage = serviceTypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ItemName"].ToString(),
                                        Location = new Point(10, 160), // Adjusted location to accommodate the layout
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    Label labelTitle1 = new Label
                                    {
                                        Text = "Amount: ₱" + reader["SRP"].ToString(),
                                        Location = new Point(10, 210), // Adjusted location to accommodate the layout
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
                        SubscribeToServiceClickEvents(sellFlowlayout, datagrid);
                    }
                }
            }
        }

        public async Task LoadItemsInSalesForSearch(FlowLayoutPanel sellFlowlayout, string mysqlcon, Guna2DataGridView datagrid, string search)
        {
            sellFlowlayout.Controls.Clear();

            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();
                //string query = "select ItemID, ItemName, Photo, Cost from inventory where ItemName Like @search LIMIT 100";
                //string query = "SELECT ItemID, ItemName, Photo, SRP FROM inventory WHERE ItemName Like @search AND STOCK != 0 LIMIT 100";
                string query = "SELECT ItemID, ItemName, Photo, SRP FROM inventory WHERE ItemName LIKE @search AND STOCK <> 0 LIMIT 100";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        var tasks = new List<Task>();
                        var panels = new List<Panel>();

                        while (await reader.ReadAsync())
                        {
                            tasks.Add(Task.Run(() =>
                            {
                                byte[] imageBytes = (byte[])reader["Photo"];

                                /*using (MemoryStream ms = new MemoryStream(imageBytes))
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
                                    panels.Add(panel);*/
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image serviceTypeImage = Image.FromStream(ms);

                                    Panel panel = new Panel
                                    {
                                        Width = 200,
                                        Height = 250, // Adjusted height to accommodate the layout
                                        Margin = new Padding(10),
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    PictureBox picBox = new PictureBox
                                    {
                                        Width = 200,
                                        Height = 150,
                                        BackgroundImage = serviceTypeImage,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    Label labelTitle = new Label
                                    {
                                        Text = reader["ItemName"].ToString(),
                                        Location = new Point(10, 160), // Adjusted location to accommodate the layout
                                        ForeColor = Color.Black,
                                        AutoSize = true,
                                        Font = new Font("Stanberry", 12, FontStyle.Regular),
                                        Tag = reader["ItemID"].ToString()
                                    };

                                    Label labelTitle1 = new Label
                                    {
                                        //papalitan ito at gagawing srp
                                        Text = "Amount: ₱" + reader["SRP"].ToString(),
                                        Location = new Point(10, 210), // Adjusted location to accommodate the layout
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
                        SubscribeToServiceClickEvents(sellFlowlayout, datagrid);
                    }
                }
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
        public class ItemDetails
        {
            public string ItemName { get; }
            public int Quantity { get; }
            public decimal Cost { get; }

            public decimal Discount { get; }

            public ItemDetails(string itemName, int quantity, decimal cost, decimal discount)
            {

                ItemName = itemName;
                Quantity = quantity;
                Cost = cost * quantity;
                Discount = discount;
            }
        }
        public List<ItemDetails> GetItemDetails(int promoCode, string mysqlcon)
        {
            List<ItemDetails> items = new List<ItemDetails>();

            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = @"
                SELECT bi.ItemName, bi.Quantity, inv.SRP, sp.DiscountPercent
                FROM binded_items bi
                INNER JOIN inventory inv ON bi.ItemName COLLATE utf8mb4_general_ci = inv.ItemName COLLATE utf8mb4_general_ci
                INNER JOIN salon_promos sp ON bi.PromoItemsID = sp.PromoCode
                WHERE bi.PromoItemsID = @PromoCode";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PromoCode", promoCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ItemName"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            decimal cost = Convert.ToDecimal(reader["SRP"]);

                            // Remove the percentage sign (%) and convert to decimal
                            string discountPercentString = reader["DiscountPercent"].ToString().Replace("%", "");
                            decimal discountPercent = Convert.ToDecimal(discountPercentString) / 100m;

                            items.Add(new ItemDetails(itemName, quantity, cost, discountPercent));
                        }
                    }
                }
            }

            return items;
        }

        public (int promoCode, string isValid) GetPromoDetails(int promoCode, string mysqlcon)
        {
            int retrievedPromoCode = 0;
            string isValid = "";

            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT PromoCode, isValid FROM salon_promos WHERE PromoCode = @PromoCode";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PromoCode", promoCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            retrievedPromoCode = Convert.ToInt32(reader["PromoCode"]);
                            isValid = reader["isValid"].ToString();
                        }
                    }
                }
            }

            return (retrievedPromoCode, isValid);
        }

        private void DisplayServiceData(Panel panel, Guna2DataGridView dataGridView)
        {
            string productName = panel.Controls.OfType<Label>().FirstOrDefault()?.Text;
            decimal productAmount = serviceData.ExtractAmount(panel.Controls.OfType<Label>().Skip(1).FirstOrDefault()?.Text);

            if (productName != null && productAmount != null)
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value.ToString() == productName && row.Cells[5].Value.ToString() == "None")
                    {
                        int currentQty = int.Parse(row.Cells[2].Value.ToString());
                        row.Cells[2].Value = (1 + currentQty).ToString();
                        addTotalPrice?.Invoke(row.Index);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    dataGridView.Rows.Add(productName, "-", "1", "+", productAmount, "None", "X");
                    updateTotalPrice?.Invoke();
                }
            }
        }
    }
}
