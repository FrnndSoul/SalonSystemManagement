using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.Microsoft.VisualBasic
{
    internal class BindedServices
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

                dataGridView.Columns.Add("Service", "Service");

                List<string> services = await GetBindedServices(ID);
                foreach (var service in services)
                {
                    dataGridView.Rows.Add(service);
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

        public static async Task<List<string>> GetBindedServices(long ID)
        {
            List<string> serviceList = new List<string>();

            try
            {
                string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT ServiceName FROM binded_services WHERE PromoServiceID = @ID";

                    using (MySqlCommand command = new MySqlCommand(fetchQuery, conn))
                    {
                        command.Parameters.AddWithValue("@ID", ID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string serviceName = reader.GetString(0);
                                serviceList.Add(serviceName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetBindedServices");
            }

            return serviceList;
        }
    }
}
