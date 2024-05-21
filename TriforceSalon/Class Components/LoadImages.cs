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
using TriforceSalon.UserControls.Service_Controls;

namespace TriforceSalon.Class_Components
{
    public class LoadImages
    {
        private readonly string mysqlcon;
        public LoadImages()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }
        public void ServicesType_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                e.ThrowException = false;
                ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV[e.ColumnIndex, e.RowIndex].Value = null;
            }
        }

        public void ServicesType_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ServiceTypeControl.serviceTypeInstance.ServiceTypeDGV.AutoResizeRow(e.RowIndex, DataGridViewAutoSizeRowMode.AllCells);
        }

        public void ServiceTypeImage(int ServiceID)
        {
            byte[] imageData = GetServiceTypeID(ServiceID); 

            try
            {
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        ServiceTypeControl.serviceTypeInstance.ServiceTypePicB.Image = image;
                    }
                }
                else
                {
                    ServiceTypeControl.serviceTypeInstance.ServiceTypePicB.Image = null;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error loading image: Invalid image data format.");
                MessageBox.Show("Exception Details: " + ex.Message);

                ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = null; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);

                ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = null;
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



        public void ServicesImage(int serviceVarID)
        {
            byte[] imageData = GetServiceVarID(serviceVarID);

            try
            {
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = image;
                    }
                }
                else
                {
                    ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = null;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error loading image: Invalid image data format.");
                MessageBox.Show("Exception Details: " + ex.Message);

                ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = null; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = null; 
            }
        }

        public byte[] GetServiceVarID(int serviceVarID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceImage FROM salon_services WHERE ServiceVariationID   = @servicevar_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@servicevar_ID", serviceVarID);

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

        public void CategoryImage(int categoryID)
        {
            byte[] imageData = GetCategoryVarID(categoryID); 

            try
            {
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        ServiceSubTypeControl.categoryInstance.CategoryPicB.Image = image;
                    }
                }
                else
                {
                    ServiceSubTypeControl.categoryInstance.CategoryPicB.Image = null;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error loading image: Invalid image data format.");
                MessageBox.Show("Exception Details: " + ex.Message);

                ServiceSubTypeControl.categoryInstance.CategoryPicB.Image = null; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);

                ServiceSubTypeControl.categoryInstance.CategoryPicB.Image = null;
            }
        }

        public byte[] GetCategoryVarID(int categoryID)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    string query = "SELECT ServiceSubTypeImage FROM salon_subtypes WHERE CategoryID = @category_ID";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@category_ID", categoryID);

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