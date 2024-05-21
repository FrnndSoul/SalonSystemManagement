using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using System.Data.Common;
using Guna.UI2.WinForms;
using TriforceSalon.UserControls.Service_Controls;

namespace TriforceSalon.Class_Components
{

    public class SalonServices
    {
        ChangeImageSize newImageSIze = new ChangeImageSize();
        private readonly string mysqlcon;
        private byte[] imageData;
        private bool isNewServiceImageSelected = false;
        private int serviceInt;
        private int item_id;
        LoadImages loadImages = new LoadImages();

        int serviceVariationID;
        int serviceTypeID;

        public SalonServices()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
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

                        ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = resizedImage;
                        isNewServiceImageSelected = true; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message);
                    }
                }
            }
        }

        public async Task PopulateServiceType(Guna2ComboBox comboBoxFilter)
        {
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Items.Add("All");
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ServiceSubTypeName from salon_subtypes";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string serviceTypes = reader["ServiceSubTypeName"].ToString();
                                    comboBoxFilter.Items.Add(serviceTypes);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in PopulateServiceType", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task PopulateServiceTypeForInsert()
        {
            ServiceVariationControl.serviceVariationInstance.AddSalonServices.Items.Clear();
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "select ServiceSubTypeName from salon_subtypes";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    string serviceTypes = reader["ServiceSubTypeName"].ToString();
                                    ServiceVariationControl.serviceVariationInstance.AddSalonServices.Items.Add(serviceTypes);
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

        public async Task SearchService(string searchName, Guna2DataGridView serviceDatagrid)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string searchQuery = "SELECT `ServiceTypeID`, `ServiceVariationID`, `ServiceImage`, `ServiceName`, `ServiceAmount` " +
                        "FROM `salon_services` " +
                        "WHERE ServiceName LIKE @name";

                    using(MySqlCommand command = new MySqlCommand(searchQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", "%" + searchName + "%");

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in SearchService");
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
                    string query = "select CategoryID from salon_subtypes where ServiceSubTypeName = @service_name";
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



        public async Task GetSalonServicesAsync(Guna2DataGridView serviceDatagrid)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT `ServiceTypeID`, `ServiceVariationID`, `ServiceImage`, `ServiceName`, `ServiceAmount` " +
                        "FROM `salon_services` " +
                        "LIMIT 10";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
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

        //gawing async ito

        public int GenerateServiceVariationID()
        {
            Random _random = new Random();

            return _random.Next(1000, 10000);
        }
        public async Task AddSalonServices(Guna2DataGridView serviceDatagrid)
        {
            int serviceID = Convert.ToInt32(GenerateServiceVariationID());
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image.Save(ms, ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }

                    string query = "Insert into salon_services (ServiceTypeID, ServiceVariationID, ServiceImage, ServiceName, ServiceAmount, ItemGroupID)" +
                        "Values(@service_type_ID, @serviceVarID ,@service_image, @service_name, @service_amount, @itemGroupID)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@service_type_ID", serviceInt);
                        command.Parameters.AddWithValue("@serviceVarID", serviceID);
                        command.Parameters.AddWithValue("@service_name", ServiceVariationControl.serviceVariationInstance.ServiceNameTxtB.Text);
                        command.Parameters.AddWithValue("@service_amount", Convert.ToDecimal(ServiceVariationControl.serviceVariationInstance.ServiceAmountTxtb.Text));
                        command.Parameters.AddWithValue("@service_image", imageData);
                        command.Parameters.AddWithValue("@itemGroupID", serviceID);

                        if (Method.AdminAccess())
                        {
                            MessageBox.Show("Working as intended.\nNo changes were made in the database");
                        }
                        else
                        {
                            await command.ExecuteNonQueryAsync();
                            MessageBox.Show("Addition of Service Complete", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    await GetSalonServicesAsync(serviceDatagrid);
                }
            }
            catch (MySqlException a)
            {
                if (a.Number == 1062)
                {
                    //MessageBox.Show("Service type already exists", "Add Service Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(a.Message);
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

        public async void EditSalonServices()
        {
            if (ServiceVariationControl.serviceVariationInstance.SalonServicesDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to edit this service type?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ServiceVariationControl.serviceVariationInstance.SalonServicesDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = ServiceVariationControl.serviceVariationInstance.SalonServicesDGV.SelectedRows[0];

                    serviceTypeID = Convert.ToInt32(selectedRow.Cells["ServiveTIDCol"].Value);
                    serviceVariationID = Convert.ToInt32(selectedRow.Cells["ServiceVariationIDCol"].Value);
                    string serviceName = Convert.ToString(selectedRow.Cells["ServiceNameCol"].Value);
                    decimal serviceAmount = Convert.ToDecimal(selectedRow.Cells["ServiceAmountCol"].Value);
                    loadImages.ServicesImage(serviceVariationID);

                    ServiceVariationControl.serviceVariationInstance.ServiceNameTxtB.Text = serviceName;
                    ServiceVariationControl.serviceVariationInstance.ServiceAmountTxtb.Text = Convert.ToString(serviceAmount);

                    HideButton(false, false, true, true);


                    try
                    {
                        using (var conn = new MySqlConnection(mysqlcon))
                        {
                            await conn.OpenAsync();
                            string query = "select ServiceSubTypeName from salon_subtypes where CategoryID = @service_ID";

                            using (MySqlCommand command = new MySqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@service_ID", serviceTypeID);

                                using (DbDataReader reader = await command.ExecuteReaderAsync())
                                {
                                    if (reader.Read())
                                    {
                                        string servTypeName = reader.GetString(0);
                                        ServiceVariationControl.serviceVariationInstance.AddSalonServices.SelectedItem = servTypeName;
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

        public async Task UpdateSalonServices(int variationID, Guna2DataGridView serviceDatagrid)
        {
            string serviceType = ServiceVariationControl.serviceVariationInstance.AddSalonServices.SelectedItem.ToString();
            int serviceTypeID = GetServiceTypeID(serviceType);
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "Update salon_services set ServiceName = @service_name, ServiceAmount = @service_amount, ServiceTypeID = @servicetype_ID";

                    byte[] imageData = null;

                    if (isNewServiceImageSelected)
                    {
                        using (Bitmap bmp = new Bitmap(ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image))
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
                        command.Parameters.AddWithValue("@service_name", ServiceVariationControl.serviceVariationInstance.ServiceNameTxtB.Text);
                        command.Parameters.AddWithValue("@servicetype_ID", serviceTypeID);
                        command.Parameters.AddWithValue("@service_amount", Convert.ToDecimal(ServiceVariationControl.serviceVariationInstance.ServiceAmountTxtb.Text));
                        command.Parameters.AddWithValue("@servicevar_ID", variationID);

                        if (isNewServiceImageSelected)
                        {
                            command.Parameters.AddWithValue("@service_image", imageData);
                        }
                        
                        if (Method.AdminAccess())
                        {
                            MessageBox.Show("Working as intended.\nNo changes were made in the database");
                        }
                        else
                        {
                            await command.ExecuteNonQueryAsync();
                        }
                        
                        await GetSalonServicesAsync(serviceDatagrid);
                        ClearServices();
                        HideButton(true, true, false, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<string> GetServiceTypeByName(string serviceVariation)
        {
            string serviceTypeName = null;
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT st.ServiceTypeName FROM service_type st " +
                        "JOIN salon_subtypes ssb ON st.ServiceID = ssb.ServiceTypeID " +
                        "JOIN salon_services ss ON ssb.CategoryID = ss.ServiceTypeID " +
                        "WHERE ss.ServiceName = @serviceVariation";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@serviceVariation", serviceVariation);

                        var result = await command.ExecuteScalarAsync();

                        if (result != null)
                        {
                            serviceTypeName = result.ToString();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error in GetServiceTypeByName", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serviceTypeName;
        }

        public async Task<int> GetServiceVariationID(string ServiceName)
        {
            int ID = -1;
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT ServiceVariationID FROM salon_services WHERE ServiceName = @serviceName";

                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@serviceName", ServiceName);

                        object result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out ID))
                        {
                            return ID;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message, "Error in GetServiceVariationID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ID;
        }

        public async Task FilterServices(string filter, Guna2DataGridView serviceDatagrid)
        {
            serviceDatagrid.Rows.Clear();
            string selectQuery;

            try
            {
                if (filter == "All")
                {
                    selectQuery = "SELECT `ServiceTypeID`, `ServiceVariationID`, `ServiceImage`, `ServiceName`, `ServiceAmount`, `ItemGroupID` " +
                            "FROM `salon_services` " +
                            "LIMIT 10";
                }
                else
                {
                    selectQuery = "SELECT se.ServiceTypeID, se.ServiceVariationID, se.ServiceImage, se.ServiceName, se.ServiceAmount " +
                            "FROM salon_services se " +
                            "JOIN salon_subtypes ssbt ON se.ServiceTypeID = ssbt.CategoryID " +
                            "WHERE ssbt.ServiceSubTypeName = @categoryName ";
                }

                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    using(MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
                        if(filter != "All")
                        {
                            command.Parameters.AddWithValue("@categoryName", filter);
                        }

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);
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

                                serviceDatagrid.Rows.Add(serviceTypeID, serviceVariationID, serviceImage, serviceName, serviceAmount);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in FilterServices");
            }
        }

        public void HideButton(bool add, bool edit, bool cancel, bool update)
        {
            ServiceVariationControl.serviceVariationInstance.UpdateServBtn.Visible = update;
            ServiceVariationControl.serviceVariationInstance.EditServBtn.Visible = edit;
            ServiceVariationControl.serviceVariationInstance.CancelEditServiceBtn.Visible = cancel;
            ServiceVariationControl.serviceVariationInstance.AddServiceBtn.Enabled = add;

        }

        public void ClearServices()
        {
            ServiceVariationControl.serviceVariationInstance.ServiceNameTxtB.Text = null;
            ServiceVariationControl.serviceVariationInstance.ServiceAmountTxtb.Text = null;
            ServiceVariationControl.serviceVariationInstance.AddSalonServices.SelectedItem = null;
            ServiceVariationControl.serviceVariationInstance.ServiceImagePicB.Image = null;
        }
    }
}