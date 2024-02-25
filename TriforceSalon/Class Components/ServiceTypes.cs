using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class ServiceTypes
    {
        ChangeImageSize newImageSIze = new ChangeImageSize();
        private readonly string mysqlcon;
        private byte[] imageData;
        private bool isNewServiceImageSelected = false;

        public ServiceTypes()
        {
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
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

        public void AddServiceType()
        {
            //ilagay nalang ito as a parameter sa method mismo
            string serviceType = ManagerServices.managerServicesInstance.ServiceTypeTxtB.Text;

            if (ManagerServices.managerServicesInstance.ServiceTypePicB is null)
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

                        string query = "Insert into salon_type (ServiceTypeName, ServiceTypeImage) values (@service_name, @service_image)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@service_name", serviceType);
                            command.Parameters.AddWithValue("@service)_image", imageData);

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
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
