using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Microsoft.VisualBasic
{
    internal class Interaction
    {
        internal static async Task DisplayItems(string title, string prompt, long ID)
        {
            using (Form displayForm = new Form())
            using (DataGridView dataGridView = new DataGridView())
            using (Button okButton = new Button())
            using (Label label = new Label())
            {
                displayForm.Text = title;
                displayForm.Size = new System.Drawing.Size(400, 300);
                displayForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                displayForm.StartPosition = FormStartPosition.CenterScreen;

                label.Text = prompt;
                label.Size = new System.Drawing.Size(200, 20);
                label.Location = new System.Drawing.Point(50, 10);

                dataGridView.Size = new System.Drawing.Size(300, 150);
                dataGridView.Location = new System.Drawing.Point(50, 30);
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.Columns.Add("Item", "Item");
                dataGridView.Columns.Add("Quantity", "Quantity");

                List<(string, int)> items = await GetBindedItems(ID);
                foreach (var item in items)
                {
                    dataGridView.Rows.Add(item.Item1, item.Item2);
                }

                okButton.DialogResult = DialogResult.OK;
                okButton.Name = "okButton";
                okButton.Size = new System.Drawing.Size(75, 23);
                okButton.Location = new System.Drawing.Point(50, 200);
                okButton.Text = "OK";
                okButton.Click += (sender, e) => displayForm.Close();

                displayForm.Controls.AddRange(new Control[] { label, dataGridView, okButton });

                DialogResult result = displayForm.ShowDialog();
            }
        }

        public static async Task<List<(string, int)>> GetBindedItems(long ID)
        {
            List<(string, int)> itemList = new List<(string, int)>();

            try
            {
                string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT ItemName, Quantity FROM binded_items WHERE PromoItemsID = @ID";

                    using (MySqlCommand command = new MySqlCommand(fetchQuery, conn))
                    {
                        command.Parameters.AddWithValue("@ID", ID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            int itemNameOrdinal = reader.GetOrdinal("ItemName");
                            int quantityOrdinal = reader.GetOrdinal("Quantity");

                            while (await reader.ReadAsync())
                            {
                                string itemName = reader.GetString(itemNameOrdinal);
                                int quantity = reader.GetInt32(quantityOrdinal);

                                itemList.Add((itemName, quantity));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetBindedItems");
            }

            return itemList;
        }
    }
}
