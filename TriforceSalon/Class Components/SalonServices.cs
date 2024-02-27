using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class Services
    {
        public int ServiceTypeID { get; set; }
        public byte[] ServiceImage { get; set; }
        public string ServiceName { get; set; }
        public decimal ServiceAmount { get; set; }

    }
    public class SalonServices
    {
        ChangeImageSize newImageSIze = new ChangeImageSize();
        private readonly string mysqlcon;
        private byte[] imageData;
        private bool isNewServiceImageSelected = false;

        public List<Services> services;

        public SalonServices()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            services = GetServiceInfo();
        }
        public void AddServiceImage()
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

                        int newWidth = 163;
                        int newHeight = 128;

                        Image resizedImage = newImageSIze.ResizeImages(selectedImage, newWidth, newHeight);

                        ManagerServices.managerServicesInstance.ServiceImagePicB.Image = resizedImage;
                        isNewServiceImageSelected = true; //flag ito para sa image
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message);
                    }
                }
            }
        }
        public int GetServiceID(string serviceName)
        {
            int serviceID = -1;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select ServiceID from service_type where ServiceTypeName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceName);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out serviceID))
                        {
                            return serviceID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serviceID;
        }
        public void AddSalonServices()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Insert into salon_services (ServiceTypeID, ServiceImage, ServiceName, ServiceAmount)" +
                        "Values(@service_type_ID, @service_image, @service_name, @service_ammount)";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Services> GetServiceInfo()
        {
            List<Services> services = new List<Services>();

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Select ServiceTypeID, ServiceImage, ServiceName, ServiceAmount from salon_services" +
                        "Where ServiceTypeID = @service_ID";
                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Services service = new Services 
                                { 
                                    ServiceTypeID = Convert.ToInt32(reader["ServiceTypeID"]),
                                    ServiceName = Convert.ToString(reader["ServiceName"]),
                                    ServiceAmount = Convert.ToDecimal(reader["ServiceAmount"]),
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
                                    service.ServiceImage = buffer;
                                }
                            }
                        }
                    }
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return services;
        }
        public void UpdateSalonServices()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Update salon_services set ServiceName = @service_name, ServiceAmount = @service_amount";

                    byte[] imageData = null;

                    if(isNewServiceImageSelected)
                    {
                        using (Bitmap bmp = new Bitmap(ManagerServices.managerServicesInstance.ServiceImagePicB.Image))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                bmp.Save(ms, ImageFormat.Jpeg); // You can choose the format you want
                                imageData = ms.ToArray();
                                query += ", ServiceImage = @service_image";
                            }
                        }
                    }
                    query += " where ServiceTypeID = @service_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        foreach(Services service in services)
                        {
                            command.Parameters.Clear(); // Clear previous parameters
                            command.Parameters.AddWithValue("@service_name", service.ServiceName);
                            command.Parameters.AddWithValue("@service_amount", service.ServiceAmount);

                            if (isNewServiceImageSelected)
                            {
                                if (service.ServiceImage != null)
                                {
                                    command.Parameters.AddWithValue("@service_image", service.ServiceImage);
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@service_image", DBNull.Value);
                                }
                            }
                            command.Parameters.AddWithValue("@service_ID", service.ServiceTypeID);

                            command.ExecuteNonQuery();

                        }
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
