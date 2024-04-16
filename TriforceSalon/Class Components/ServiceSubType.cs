using Guna.UI2.WinForms;
using iText.IO.Image;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TriforceSalon.UserControls.Service_Controls;

namespace TriforceSalon.Class_Components
{
    public class ServiceSubType
    {
        private string mysqlcon;
        private byte[] imageData;
        private int serviceInt;
        private bool isNewServiceImageSelected = false;
        ChangeImageSize newImageSize = new ChangeImageSize();
        LoadImages loadImage = new LoadImages();

        int serviceCategoryID;
        int serviceTypeID;

        public ServiceSubType()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public void AddServiceTypeImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.Drawing.Image selectedImage = System.Drawing.Image.FromFile(openFileDialog.FileName);

                        // Resize the selected image
                        int newWidth = 163;
                        int newHeight = 128;

                        System.Drawing.Image resizedImage = newImageSize.ResizeImages(selectedImage, newWidth, newHeight);

                        ServiceSubTypeControl.categoryInstance.CategoryPicB.Image = resizedImage;
                        isNewServiceImageSelected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message);
                    }
                }
            }
        }

        public async Task GetAllServiceType(Guna2ComboBox comboBoxFilter)
        {
            comboBoxFilter.Items.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string selectQuery = "select ServiceTypeName from service_type";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string serviceTypes = reader["ServiceTypeName"].ToString();
                                    comboBoxFilter.Items.Add(serviceTypes);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetAllServiceType");
            }
        }

        public async Task GetAllCategory(Guna2DataGridView categoryDGV)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string selectQuery = "SELECT ServiceTypeID, ServiceSubTypeImage, ServiceSubTypeName, CategoryID " +
                        "FROM salon_subtypes";

                    using(MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetAllCategory");
            }
        }

        public async Task AddCategory(string categoryName)
        {

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        ServiceSubTypeControl.categoryInstance.CategoryPicB.Image.Save(ms, ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                    string insertQuery = "INSERT INTO salon_subtypes (ServiceTypeID, ServiceSubTypeImage, ServiceSubTypeName) " +
                        "VALUES (@typeID, @image, @subTypeName)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@typeID", serviceInt);
                        command.Parameters.AddWithValue("@image", imageData);
                        command.Parameters.AddWithValue("@subTypeName", categoryName);

                        await command.ExecuteNonQueryAsync();
                    }

                }
                MessageBox.Show("Category Added Successfully", "Operationg Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in AddCategory");
            }

        }

        public async Task UpdateCategory(long categoryID, long serviceTypeID, string categoryName, Guna2DataGridView categoryDGV)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string updateQuery = "UPDATE salon_subtypes SET " +
                        "ServiceTypeID = @typeID, " +
                        "ServiceSubTypeName = @typeName";

                    byte[] imageData = null;

                    if (isNewServiceImageSelected)
                    {
                        using (Bitmap bmp = new Bitmap(ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                bmp.Save(ms, ImageFormat.Jpeg);
                                imageData = ms.ToArray();
                                updateQuery += ", ServiceSubTypeImage = @categoryImage";
                            }
                        }
                    }
                    updateQuery += " where CategoryID  = @categoryID";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@typeID", serviceTypeID);
                        command.Parameters.AddWithValue("@typeName", categoryName);
                        command.Parameters.AddWithValue("@categoryID", categoryID);

                        if (isNewServiceImageSelected)
                        {
                            command.Parameters.AddWithValue("@categoryImage", imageData);

                        }
                        await command.ExecuteNonQueryAsync();
                        ClearCategory();
                        HideCategoryButtons(true, true, false, false);
                        await GetAllCategory(categoryDGV);
                    }
                }
                MessageBox.Show("Category Updated Successfully", "Operationg Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in UpdateCategory");

            }
        }

        public async Task EditCategory(Guna2DataGridView categoryDGV, Guna2TextBox nameTxtb, Guna2ComboBox categoryComb)
        {
            if (categoryDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to edit this service type?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (categoryDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = categoryDGV.SelectedRows[0];

                    serviceTypeID = Convert.ToInt32(selectedRow.Cells["ServiceTypeIDCol"].Value);
                    serviceCategoryID = Convert.ToInt32(selectedRow.Cells["CategoryIDCol"].Value);
                    string categoryName = Convert.ToString(selectedRow.Cells["CategoryNameCol"].Value);
                    loadImage.CategoryImage(serviceCategoryID);


                    nameTxtb.Text = categoryName;

                    HideCategoryButtons(false, false, true, true);

                    try
                    {
                        using (var conn = new MySqlConnection(mysqlcon))
                        {
                            await conn.OpenAsync();
                            string query = "select ServiceTypeName from service_type where ServiceID = @service_ID";

                            using (MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@service_ID", serviceTypeID);

                                using (DbDataReader reader = await command.ExecuteReaderAsync())
                                {
                                    if (reader.Read())
                                    {
                                        string servTypeName = reader.GetString(0);
                                        categoryComb.SelectedItem = servTypeName;
                                    }
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("EditCategory() Error: " + ex.Message);
                    }
                }
            }
        }

        public async Task SearchCategory(string search, Guna2DataGridView categoryDGV)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string searchQuery = "SELECT ServiceTypeID, ServiceSubTypeImage, ServiceSubTypeName, CategoryID " +
                        "FROM salon_subtypes " +
                        "WHERE ServiceSubTypeName LIKE @search";

                    using (MySqlCommand command = new MySqlCommand(searchQuery, conn))
                    {
                        command.Parameters.AddWithValue("@search", "%" + search + "%");

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in SearchCategory");
            }
        }

        public async Task<int> GetServiceTypeID(string serviceType)
        {
            serviceInt = -1;

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ServiceID FROM service_type WHERE ServiceTypeName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceType);

                        object result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out serviceInt))
                        {
                            return serviceInt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetServiceTypeID Error", ex.Message);
            }
            return serviceInt;
        }

        public void ClearCategory()
        {
            ServiceSubTypeControl.categoryInstance.ServiceCategoryTxtB.Text = null;
            ServiceSubTypeControl.categoryInstance.ServiceTypeComB.SelectedIndex = -1;
            ServiceSubTypeControl.categoryInstance.ServiceTypeComB.Text = null;
            ServiceSubTypeControl.categoryInstance.SearchCategoryTxtB.Text = null;
            ServiceSubTypeControl.categoryInstance.CategoryPicB.Image = null;
        }

        public void HideCategoryButtons(bool add, bool edit, bool cancel, bool update)
        {
            ServiceSubTypeControl.categoryInstance.UpdateCategoryBtn.Visible = update;
            ServiceSubTypeControl.categoryInstance.EditCategoryBtn.Visible = edit;
            ServiceSubTypeControl.categoryInstance.CancelEditBtn.Visible = cancel;
            ServiceSubTypeControl.categoryInstance.AddCategoryBtn.Enabled = add;
        }

    }
}
