using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls;
using TriforceSalon.UserControls.Service_Controls;

namespace TriforceSalon.Class_Components
{
    public class ServiceTypes
    {
        LoadImages loadImages = new LoadImages();
        ChangeImageSize newImageSIze = new ChangeImageSize();
        private readonly string mysqlcon;
        public byte[] imageData;
        private bool isNewServiceImageSelected = false;
        public int serviceTypeID;
        SalonServices salonServices = new SalonServices();
        //public List<ServiceTypesInfo> serviceTypes;

        public ServiceTypes()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        public async Task ServiceTypeInfoDGV(Guna2DataGridView serviceTypeDGV)
        {
            serviceTypeDGV.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "Select ServiceTypeImage, ServiceTypeName, ServiceID from service_type";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);


                            foreach (DataRow row in dataTable.Rows)
                            {
                                var serviceID = row["ServiceID"].ToString();
                                byte[] serviceTypeImageBytes = row["ServiceTypeImage"] as byte[];
                                var serviceTypeName = row["ServiceTypeName"].ToString();

                                Image serviceImage = null;
                                if (serviceTypeImageBytes != null && serviceTypeImageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(serviceTypeImageBytes))
                                    {
                                        serviceImage = Image.FromStream(ms);
                                    }
                                }

                                serviceTypeDGV.Rows.Add(null, serviceTypeName, serviceID);
                                serviceTypeDGV.Rows[serviceTypeDGV.Rows.Count - 1].Cells[0].Value = serviceImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in ServiceTypeInfoDGV(): " + ex.Message);
            }
        }
        public async Task SearechServiceType(Guna2DataGridView serviceTypeDGV, string search)
        {
            serviceTypeDGV.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ServiceTypeImage, ServiceTypeName, ServiceID FROM service_type " +
                        "WHERE ServiceTypeName LIKE @search";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            serviceTypeDGV.Controls.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var serviceID = row["ServiceID"].ToString();
                                byte[] serviceTypeImageBytes = row["ServiceTypeImage"] as byte[];
                                var serviceTypeName = row["ServiceTypeName"].ToString();

                                Image serviceImage = null;
                                if (serviceTypeImageBytes != null && serviceTypeImageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(serviceTypeImageBytes))
                                    {
                                        serviceImage = Image.FromStream(ms);
                                    }
                                }

                                serviceTypeDGV.Rows.Add(null, serviceTypeName, serviceID);
                                serviceTypeDGV.Rows[serviceTypeDGV.Rows.Count - 1].Cells[0].Value = serviceImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in ServiceTypeInfoDGV(): " + ex.Message);
            }
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
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);

                        // Resize the selected image
                        int newWidth = 163;
                        int newHeight = 128;

                        Image resizedImage = newImageSIze.ResizeImages(selectedImage, newWidth, newHeight);

                        ServiceTypeControl.serviceTypeInstance.ServiceTypePicB.Image = resizedImage;
                        isNewServiceImageSelected = true; //flag ito para sa image
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message);
                    }
                }
            }
        }

        public async Task AddServiceType(string serviceType)
        {
            if (ServiceTypeControl.serviceTypeInstance.ServiceTypePicB == null)
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text) || ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text == "Service Type Name")
            {
                MessageBox.Show("Please fill out all the required data", "Missing Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult choices = MessageBox.Show("Are you sure the information you have entered is correct?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlcon))
                    {
                        await conn.OpenAsync();

                        using (MemoryStream ms = new MemoryStream())
                        {
                            ServiceTypeControl.serviceTypeInstance.ServiceTypePicB.Image.Save(ms, ImageFormat.Jpeg);
                            imageData = ms.ToArray();
                        }

                        string query = "Insert into service_type (ServiceTypeName, ServiceTypeImage) values (@service_name, @service_image)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@service_name", serviceType);
                            command.Parameters.AddWithValue("@service_image", imageData);

                            if (Method.AdminAccess())
                            {
                                MessageBox.Show("Working as intended.\nNo changes were made in the database");
                            }
                            else
                            {
                                await command.ExecuteNonQueryAsync();
                            }
                        }
                        await salonServices.PopulateServiceTypeForInsert();
                        await ServiceTypeInfoDGV(ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV);
                        ClearServiceTypes();
                    }
                }

                catch (MySqlException a)
                {
                    if (a.Number == 1062)
                    {
                        MessageBox.Show("Service type already exists", "Add Service Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Database Error: " + a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error in AddServiceTypeAsync(): " + ex.Message);
                }
            }
        }

        public void EditServiceTypes()
        {
            if (ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to edit this service type?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV.SelectedRows[0];

                    string ServiceTypeName = selectedRow.Cells["CategoryNameCol"].Value.ToString();
                    serviceTypeID = Convert.ToInt32(selectedRow.Cells["CategoryIDCol"].Value);

                    ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text = ServiceTypeName;
                    loadImages.ServiceTypeImage(serviceTypeID);

                    HideButton(false, false, true, true);

                    try
                    {
                        using (var conn = new MySqlConnection(mysqlcon))
                        {
                            conn.Open();
                            string query = "select ServiceTypeName from service_type where ServiceID = @service_ID";

                            using (MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@service_ID", serviceTypeID);

                                MySqlDataReader reader = command.ExecuteReader();

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in EditServiceTypes(): " + ex.Message);
                    }
                }
            }
            serviceTypeID = 0;
        }

        public async Task UpdateServiceType(int serviceID)
        {

            if (string.IsNullOrWhiteSpace(ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text) || ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text == "Service Type Name")
            {
                MessageBox.Show("Please fill out all the required data", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult choices = MessageBox.Show("Are you sure the information you have entered is correct?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choices == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(mysqlcon))
                    {
                        await conn.OpenAsync();
                        string query = "UPDATE service_type SET ServiceTypeName = @service_name";
                        byte[] imageData = null;
                        if (isNewServiceImageSelected)
                        {
                            using (Bitmap bmp = new Bitmap(ServiceTypeControl.serviceTypeInstance.ServiceTypePicB.Image))
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    bmp.Save(ms, ImageFormat.Jpeg); // You can choose the format you want
                                    imageData = ms.ToArray();
                                    query += ", ServiceTypeImage = @service_image";
                                }
                            }
                        }

                        query += " WHERE ServiceID = @service_ID";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@service_name", ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text);
                            command.Parameters.AddWithValue("@service_ID", serviceID);

                            if (isNewServiceImageSelected)
                            {
                                command.Parameters.AddWithValue("@service_image", imageData);
                            }

                            else
                            {

                                if (Method.AdminAccess())
                                {
                                    MessageBox.Show("Working as intended.\nNo changes were made in the database");

                                }
                                else
                                {
                                    await command.ExecuteNonQueryAsync();
                                }
                            }
                        }
                        await salonServices.PopulateServiceTypeForInsert();
                        await ServiceTypeInfoDGV(ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV);
                        ClearServiceTypes();
                        HideButton(true, true, false, false);

                    }
                }
                catch (MySqlException a)
                {
                    if (a.Number == 1062)
                    {
                        MessageBox.Show("Menu name already exists.", "Add variation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(a.Message, "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in UpdateServiceTypeAsync(): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearServiceTypes()
        {
            ServiceTypeControl.serviceTypeInstance.ServiceTypeTxtB.Text = null;
            ServiceTypeControl.serviceTypeInstance.ServiceTypePicB.Image = null;

        }


        public void HideButton(bool add, bool edit, bool cancel, bool update)
        {
            ServiceTypeControl.serviceTypeInstance.UpdateServiceTBtn.Visible = update;
            ServiceTypeControl.serviceTypeInstance.EditServiceTBtn.Visible = edit;
            ServiceTypeControl.serviceTypeInstance.CancelEditBtn.Visible = cancel;
            ServiceTypeControl.serviceTypeInstance.AddServiceTypeBtn.Enabled = add;

        }

    }
}