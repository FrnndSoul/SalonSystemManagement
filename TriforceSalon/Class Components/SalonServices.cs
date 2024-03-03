using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using TriforceSalon.UserControls;
using System.Data;

namespace TriforceSalon.Class_Components
{

    public class SalonServices
    {
        ChangeImageSize newImageSIze = new ChangeImageSize();
        private readonly string mysqlcon;
        private byte[] imageData;
        private bool isNewServiceImageSelected = false;
        private int serviceInt;
        LoadImages loadImages = new LoadImages();

        int serviceVariationID;
        int serviceTypeID;


        public SalonServices()
        {
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
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

                        // Resize the selected image
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

        public void PopulateServiceType()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select ServiceTypeName from service_type";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string serviceTypes = reader["ServiceTypeName"].ToString();
                                    ManagerServices.managerServicesInstance.AddSalonServices.Items.Add(serviceTypes);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("2222222. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int GetServiceTypeID(string serviceType)
        {
            serviceInt = -1;

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "select ServiceID from service_type where ServiceTypeName = @service_name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", serviceType);


                        object result = command.ExecuteScalar();
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



        public void GetSalonServices()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT `ServiceTypeID`, `ServiceVariationID`, `ServiceImage`, `ServiceName`, `ServiceAmount`, `ItemID` FROM `salon_services`";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                ManagerServices.managerServicesInstance.SalonServicesDGV.DataSource = dt;
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

        public void AddSalonServices()
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        ManagerServices.managerServicesInstance.ServiceImagePicB.Image.Save(ms, ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }

                    string query = "Insert into salon_services (ServiceTypeID, ServiceImage, ServiceName, ServiceAmount)" +
                        "Values(@service_type_ID, @service_image, @service_name, @service_ammount)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type_ID", serviceInt);
                        command.Parameters.AddWithValue("@service_name", ManagerServices.managerServicesInstance.ServiceNameTxtB.Text);
                        command.Parameters.AddWithValue("@service_ammount", Convert.ToDecimal(ManagerServices.managerServicesInstance.ServiceAmountTxtb));
                        command.Parameters.AddWithValue("@service_image", imageData);

                        command.ExecuteNonQuery();

                        GetSalonServices();
                        ClearServices();
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
                MessageBox.Show("AddSalonServices() Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditSalonServices()
        {
            if (ManagerServices.managerServicesInstance.SalonServicesDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to edit this service type?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ManagerServices.managerServicesInstance.SalonServicesDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = ManagerServices.managerServicesInstance.SalonServicesDGV.SelectedRows[0];

                    serviceTypeID = Convert.ToInt32(selectedRow.Cells["ServiceTypeID"].Value);
                    serviceVariationID = Convert.ToInt32(selectedRow.Cells["ServiceVariationID"].Value);
                    string serviceName = Convert.ToString(selectedRow.Cells["ServiceName"].Value);
                    decimal serviceAmount = Convert.ToDecimal(selectedRow.Cells["ServiceAmount"].Value);
                    loadImages.ServicesImage(serviceVariationID);

                    ManagerServices.managerServicesInstance.ServiceNameTxtB.Text = serviceName;
                    ManagerServices.managerServicesInstance.ServiceAmountTxtb.Text = Convert.ToString(serviceAmount);

                    try
                    {
                        using (var conn = new MySqlConnection(mysqlcon))
                        {
                            conn.Open();
                            string query = "select ServiceTypeName from service_type where ServiceID = @service_ID";

                            using (MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@service_ID", serviceTypeID);

                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string servTypeName = reader.GetString(0);
                                        ManagerServices.managerServicesInstance.AddSalonServices.SelectedItem = servTypeName;
                                    }
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("EditSalonServices() Error: " + ex.Message);
                    }
                }
            }
        }
       
        public void UpdateSalonServices(int variationID)
        {
            string serviceType = ManagerServices.managerServicesInstance.AddSalonServices.SelectedItem.ToString();
            int serviceTypeID = GetServiceTypeID(serviceType);
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "Update salon_services set ServiceName = @service_name, ServiceAmount = @service_amount, ServiceTypeID = @servicetype_ID";

                    byte[] imageData = null;

                    if (isNewServiceImageSelected)
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
                    query += " where ServiceVariationID = @servicevar_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_name", ManagerServices.managerServicesInstance.ServiceNameTxtB.Text);
                        command.Parameters.AddWithValue("@servicetype_ID", serviceTypeID);
                        command.Parameters.AddWithValue("@service_amount", Convert.ToDecimal(ManagerServices.managerServicesInstance.ServiceAmountTxtb.Text));
                        command.Parameters.AddWithValue("@servicevar_ID", variationID);

                        if (isNewServiceImageSelected)
                        {
                            command.Parameters.AddWithValue(" @service_image", imageData);
                        }
                        command.ExecuteNonQuery();
                        GetSalonServices();
                        ClearServices();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearServices()
        {
            ManagerServices.managerServicesInstance.ServiceNameTxtB.Text = null;
            ManagerServices.managerServicesInstance.ServiceAmountTxtb.Text = null;
            ManagerServices.managerServicesInstance.AddSalonServices.SelectedItem = null;

            ManagerServices.managerServicesInstance.ServiceImagePicB.Image = null;

        }

    }
}