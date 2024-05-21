using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.Class_Components
{
    public class ServiceTransitions
    {
        private string mysqlcon;
        public ServiceTransitions()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public async Task GetFilteredCategory(Guna2DataGridView categoryDGV, string typeName)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string selectQuery = "SELECT ssbt.ServiceTypeID, ssbt.ServiceSubTypeImage, ssbt.ServiceSubTypeName, ssbt.CategoryID " +
                        "FROM salon_subtypes ssbt " +
                        "JOIN service_type st ON ssbt.ServiceTypeID = st.ServiceID WHERE st.ServiceTypeName = @typeName";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
                        command.Parameters.AddWithValue("@typeName", typeName);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            categoryDGV.Rows.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var serviceTypeID = row["ServiceTypeID"].ToString();
                                byte[] serviceImageBytes = row["ServiceSubTypeImage"] as byte[];
                                var categoryID = row["CategoryID"].ToString();
                                var categoryName = row["ServiceSubTypeName"].ToString();

                                System.Drawing.Image serviceImage = null;
                                if (serviceImageBytes != null && serviceImageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(serviceImageBytes))
                                    {
                                        serviceImage = System.Drawing.Image.FromStream(ms);
                                    }
                                }

                                categoryDGV.Rows.Add(serviceTypeID, null, categoryName, categoryID);
                                categoryDGV.Rows[categoryDGV.Rows.Count - 1].Cells[1].Value = serviceImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetAllCategory");
            }
        }

        public async Task GetFilteredServices(Guna2DataGridView serviceDatagrid, string categoryName)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ss.ServiceTypeID, ss.ServiceVariationID, ss.ServiceImage, ss.ServiceName, ss.ServiceAmount " +
                        "FROM salon_services ss " +
                        "JOIN salon_subtypes ssbt ON ss.ServiceTypeID = ssbt.CategoryID WHERE ssbt.ServiceSubTypeName = @categoryName";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("categoryName", categoryName);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            serviceDatagrid.Rows.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var serviceTypeID = row["ServiceTypeID"].ToString();
                                var serviceVariationID = row["ServiceVariationID"].ToString();
                                byte[] serviceImageBytes = row["ServiceImage"] as byte[];
                                var serviceName = row["ServiceName"].ToString();
                                var serviceAmount = row["ServiceAmount"].ToString();

                                Image serviceImage = null;
                                if (serviceImageBytes != null && serviceImageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(serviceImageBytes))
                                    {
                                        serviceImage = Image.FromStream(ms);
                                    }
                                }

                                serviceDatagrid.Rows.Add(serviceTypeID, serviceVariationID, null, serviceName, serviceAmount);
                                serviceDatagrid.Rows[serviceDatagrid.Rows.Count - 1].Cells[2].Value = serviceImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in GetSalonService()");
            }
        }

    }
}
