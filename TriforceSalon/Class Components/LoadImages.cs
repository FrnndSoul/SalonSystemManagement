﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls;

namespace TriforceSalon.Class_Components
{
    public class LoadImages
    {
        private readonly string mysqlcon;
        public LoadImages()
        {
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
        }
        public void ServicesType_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0) // Assuming column index for "AccountPfp" is 1
            {
                // Set the cell value to null to display an empty cell
                e.ThrowException = false;
                ManagerServices.managerServicesInstance.ServiceTypeDGV[e.ColumnIndex, e.RowIndex].Value = null;
            }
        }

        public void ServicesType_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ManagerServices.managerServicesInstance.ServiceTypeDGV.AutoResizeRow(e.RowIndex, DataGridViewAutoSizeRowMode.AllCells);
        }

        public void ServiceTypeImage(int ServiceID)
        {
            byte[] imageData = GetServiceTypeID(ServiceID); // Call a new method to get image data

            try
            {
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        // Set the PictureBox image only if the conversion succeeds
                        ManagerServices.managerServicesInstance.ServiceTypePicB.Image = image;
                    }
                }
                else
                {
                    // Set PictureBox image to a default image or null if there's no image data
                    ManagerServices.managerServicesInstance.ServiceTypePicB.Image = null;
                }
            }
            catch (ArgumentException ex)
            {
                // Handle the exception if the byte array does not represent a valid image format
                MessageBox.Show("Error loading image: Invalid image data format.");
                MessageBox.Show("Exception Details: " + ex.Message);

                // Set PictureBox image to a default image or show an error image
                ManagerServices.managerServicesInstance.ServiceImagePicB.Image = null; // Set pictureBox image to default or show an error image
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error loading image: " + ex.Message);

                // Set PictureBox image to a default image or show an error image
                ManagerServices.managerServicesInstance.ServiceImagePicB.Image = null; // Set pictureBox image to default or show an error image
            }
        }
        public byte[] GetServiceTypeID(int ServiceTypeID)
        {

            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceTypeImage FROM service_type WHERE ServiceID  = @service_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_ID", ServiceTypeID);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return (byte[])result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ito?: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}