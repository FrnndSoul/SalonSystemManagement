﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class ServiceTypesInfo
    {
        public string ServiceTypeName { get; set; }
        public int ServiceID { get; set; }
        public byte[] ServiceTypeImage { get; set; }
    }
    public class ServiceTypes
    {
        LoadImages loadImages = new LoadImages();
        ChangeImageSize newImageSIze = new ChangeImageSize();
        private readonly string mysqlcon;
        public byte[] imageData;
        private bool isNewServiceImageSelected = false;
        public int serviceTypeID;

        public List<ServiceTypesInfo> serviceTypes;

        public ServiceTypes()
        {
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
            serviceTypes = GetServiceTypeInfo();
        }
        public void ServiceTypeInfoDGV()
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select ServiceTypeImage, ServiceTypeName, ServiceID from service_type";
                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                ManagerServices.managerServicesInstance.ServiceTypeDGV.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
        public List<ServiceTypesInfo> GetServiceTypeInfo()
        {
            List<ServiceTypesInfo> service_type = new List<ServiceTypesInfo>();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    string query = "Select ServiceID, ServiceTypeImage, ServiceTypeName from service_type where ServiceID = @service_ID";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ServiceTypesInfo service_types = new ServiceTypesInfo
                                {
                                    ServiceTypeName = Convert.ToString(reader["ServiceTypeName"]),
                                    ServiceID = Convert.ToInt32(reader["ServiceID"]),

                                };

                                int imageColumnIndex = reader.GetOrdinal("ServiceImage");
                                if (!reader.IsDBNull(imageColumnIndex))
                                {
                                    byte[] buffer = new byte[4096];

                                    long bytesRead = reader.GetBytes(imageColumnIndex, 0, buffer, 0, buffer.Length);

                                    if (bytesRead < buffer.Length)
                                    {
                                        byte[] finalBuffer = new byte[bytesRead];
                                        Array.Copy(buffer, finalBuffer, bytesRead);
                                        buffer = finalBuffer;
                                    }
                                    service_types.ServiceTypeImage = buffer;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return service_type;
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

                        ManagerServices.managerServicesInstance.ServiceTypePicB.Image = resizedImage;
                        isNewServiceImageSelected = true; //flag ito para sa image
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message);
                    }
                }
            }
        }

        public void AddServiceType(string serviceType)
        {
            if (ManagerServices.managerServicesInstance.ServiceTypePicB == null)
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(ManagerServices.managerServicesInstance.ServiceTypeTxtB.Text) || ManagerServices.managerServicesInstance.ServiceTypeTxtB.Text == "Service Type Name")
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
                        conn.Open();

                        using (MemoryStream ms = new MemoryStream())
                        {
                            ManagerServices.managerServicesInstance.ServiceTypePicB.Image.Save(ms, ImageFormat.Jpeg);
                            imageData = ms.ToArray();
                        }

                        string query = "Insert into service_type (ServiceTypeName, ServiceTypeImage) values (@service_name, @service_image)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@service_name", serviceType);
                            command.Parameters.AddWithValue("@service_image", imageData);

                            command.ExecuteNonQuery();
                        }
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
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void EditServiceTypes()
        {
            if (ManagerServices.managerServicesInstance.ServiceTypeDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to edit this service type?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if(ManagerServices.managerServicesInstance.ServiceTypeDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = ManagerServices.managerServicesInstance.ServiceTypeDGV.SelectedRows[0];

                    string ServiceTypeName = selectedRow.Cells["ServiceTypeName"].Value.ToString();
                    serviceTypeID = Convert.ToInt32(selectedRow.Cells["ServiceID"].Value);

                    loadImages.ServiceTypeImage(serviceTypeID);

                    try
                    {
                        using(var conn = new MySqlConnection(mysqlcon))
                        {
                            conn.Open();
                            string query = "select ServiceTypeName from service_type where ServiceID = @service_ID";

                            using(MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@service_ID", serviceTypeID);

                                MySqlDataReader reader = command.ExecuteReader();

                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            serviceTypeID = 0;
        }

        public void UpdateServiceType()
        {
            string serviceType = ManagerServices.managerServicesInstance.ServiceTypeTxtB.Text;
            int serviceID = 0; //need pa ng isang variable, gawin bukas

            if (string.IsNullOrWhiteSpace(ManagerServices.managerServicesInstance.ServiceTypeTxtB.Text) || ManagerServices.managerServicesInstance.ServiceTypeTxtB.Text == "Service Type Name")
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
                        conn.Open();
                        string query = "UPDATE service_type SET ServiceTypeName = @service_name";
                        byte[] imageDatae = null;

                        if (isNewServiceImageSelected)
                        {
                            using (Bitmap bmp = new Bitmap(ManagerServices.managerServicesInstance.ServiceTypePicB.Image))
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    bmp.Save(ms, ImageFormat.Jpeg); // You can choose the format you want
                                    imageData = ms.ToArray();
                                    query += ", ServiceTypeImage = @service_image";
                                }
                            }
                        }

                        query += " Where ServiceID = @service_ID";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            foreach (ServiceTypesInfo serviceT in serviceTypes)
                            {
                                command.Parameters.AddWithValue("@service_name", serviceType);
                                command.Parameters.AddWithValue("@service_ID", serviceID);

                                if (isNewServiceImageSelected)
                                {
                                    command.Parameters.AddWithValue("@service_image", imageData);
                                }

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (MySqlException a)
                {
                    if (a.Number == 1062)
                    {
                        MessageBox.Show("Menu name already exist.", "Add variation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(a.Message, "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
 