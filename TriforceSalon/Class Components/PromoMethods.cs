using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls.Promo_Controls;
using TriforceSalon.UserControls.Service_Controls;
using System.Globalization;

namespace TriforceSalon.Class_Components
{
    public  class PromoMethods
    {
        private string mysqlcon;

        public PromoMethods()
        {
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }
        
        public async Task AddPromo(Guna2DataGridView itemsDataGrid, long ID, DateTime start, DateTime end, string percentage, string name)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    //ang mga random generated dito na mga values ay promo code, promoitemsID)
                    string insertToPromoTable = "INSERT INTO salon_promos (PromoStart, PromoEnd, PromoCode, PromoName, PromoItemsID, DiscountPercent, PromoType) " +
                        "VALUE(@dateStart, @dateEnd, @promoCode, @promoName, @PitemsID, @discount, @type)";

                    using (MySqlCommand command = new MySqlCommand(insertToPromoTable, conn))
                    {
                        command.Parameters.AddWithValue("@dateStart", start);
                        command.Parameters.AddWithValue("@dateEnd", end);
                        command.Parameters.AddWithValue("@promoCode", ID);
                        command.Parameters.AddWithValue("@promoName", name);
                        command.Parameters.AddWithValue("@PitemsID", ID);
                        command.Parameters.AddWithValue("@discount", percentage);
                        command.Parameters.AddWithValue("@type", "Item");


                        await command.ExecuteNonQueryAsync();
                    }

                    string insertToBindedItems = "INSERT INTO binded_items (PromoItemsID, ItemName, ItemID, Quantity) " +
                        "VALUES(@PitemsID, @itemName, @itemID, @quantity)";

                    foreach(DataGridViewRow row in itemsDataGrid.Rows)
                    {
                        string itemsID = Convert.ToString(row.Cells["ItemIDCol"].Value);
                        string itemName = Convert.ToString(row.Cells["ItemNameCol"].Value);
                        string quantity = Convert.ToString(row.Cells["QuantityCol"].Value);

                        using (MySqlCommand command2 = new MySqlCommand(insertToBindedItems, conn))
                        {
                            command2.Parameters.AddWithValue("@PitemsID", ID);
                            command2.Parameters.AddWithValue("@itemName", itemName);
                            command2.Parameters.AddWithValue("@itemID",itemsID );
                            command2.Parameters.AddWithValue("@quantity", quantity);

                            await command2.ExecuteNonQueryAsync();
                        }
                    }
                    MessageBox.Show("Promo has been created", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.ToString(), "Error in AddPromo");
            }
        }
        
        public async void EditProductPromo(Guna2DataGridView productPromoDGV)
        {
            if(productPromoDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to edit this promo?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                if(productPromoDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = productPromoDGV.SelectedRows[0];

                    string Pname = Convert.ToString(selectedRow.Cells["PromoNameCol"].Value);
                    string Pcode = Convert.ToString(selectedRow.Cells["PromoCodeCol"].Value);
                    DateTime PstartDate = Convert.ToDateTime(selectedRow.Cells["DateStartStart"].Value);
                    DateTime PendDate = Convert.ToDateTime(selectedRow.Cells["DateEndCol"].Value);
                    string PDiscount = Convert.ToString(selectedRow.Cells["DiscountCol"].Value);
                    long ProductIDGroup = Convert.ToInt64(selectedRow.Cells["BindedItemsCol"].Value);

                    PItemsUserControls.Pitemsinstance.PromoNameTxtB.Text = Pname;
                    PItemsUserControls.Pitemsinstance.PromoCodeTxtB.Text = Pcode;
                    PItemsUserControls.Pitemsinstance.PercentageTxtB.Text = PDiscount;
                    PItemsUserControls.Pitemsinstance.PStartDTP.Value = PstartDate;
                    PItemsUserControls.Pitemsinstance.PEndDTP.Value = PendDate;
                    PItemsUserControls.Pitemsinstance.IDLbl.Text = Convert.ToString(ProductIDGroup);
                    await FetchBindedItems(ProductIDGroup, PItemsUserControls.Pitemsinstance.ProductsDGV);
                }
            }
        }

        public async Task FetchBindedItems(long ID, Guna2DataGridView bindedTable)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ItemName, ItemID, Quantity FROM binded_items WHERE PromoItemsID = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", ID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            bindedTable.Rows.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string itemName = row["ItemName"].ToString();
                                int itemID = Convert.ToInt32(row["ItemID"]);
                                int quantity = Convert.ToInt32(row["Quantity"]);

                                bindedTable.Rows.Add(itemName, itemID, "-", quantity, "+", "X");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error FetchBindedItems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateBindedService(long ID, Guna2DataGridView newBindedItems)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();


                    string updateQuery = "UPDATE salon_promos SET PromoStart = @start, PromoEnd = @end, PromoName = @pName, DiscountPercent = @discount " +
                                        "WHERE PromoCode = @promoCode";
                    using (MySqlCommand command = new MySqlCommand(@updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@start", PItemsUserControls.Pitemsinstance.PStartDTP.Value.Date);
                        command.Parameters.AddWithValue("@end", PItemsUserControls.Pitemsinstance.PEndDTP.Value.Date);
                        command.Parameters.AddWithValue("@pName", PItemsUserControls.Pitemsinstance.PromoNameTxtB.Text);
                        command.Parameters.AddWithValue("@discount", PItemsUserControls.Pitemsinstance.PercentageTxtB.Text);
                        command.Parameters.AddWithValue("@promoCode", PItemsUserControls.Pitemsinstance.PromoCodeTxtB.Text);

                        await command.ExecuteNonQueryAsync();
                    }

                    string deleteQuery = "DELETE FROM `binded_items` WHERE PromoItemsID = @promoItemsID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
                    {
                        command.Parameters.AddWithValue("@promoItemsID", ID);
                        await command.ExecuteNonQueryAsync();
                    }

                    string insertQuery = "INSERT INTO binded_items (PromoItemsID, ItemName, ItemID, Quantity)" +
                        "VALUES (@promoItemsID, @itemName, @itemID, @quantity)";

                    foreach (DataGridViewRow row in newBindedItems.Rows)
                    {
                        string itemName = Convert.ToString(row.Cells["ItemNameCol"].Value);
                        int itemID = Convert.ToInt32(row.Cells["ItemIDCol"].Value);
                        int quantity = Convert.ToInt32(row.Cells["QuantityCol"].Value);

                        using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                        {
                            command.Parameters.AddWithValue("@promoItemsID", ID);
                            command.Parameters.AddWithValue("@itemName", itemName);
                            command.Parameters.AddWithValue("@itemID", itemID);
                            command.Parameters.AddWithValue("@quantity", quantity);

                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error UpdateBindedService", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GetActivePromos(Guna2DataGridView viewPromosDGV)
        {
            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT PromoName, PromoCode, DiscountPercent, " +
                        "DATE(PromoStart) AS PromoStart, DATE(PromoEnd) AS PromoEnd, PromoItemsID " +
                        "FROM salon_promos " +
                        "WHERE isValid = 'YES' AND PromoType = 'Items'";


                    using (MySqlCommand command = new MySqlCommand(fetchQuery, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var PName = row["PromoName"].ToString();
                                var PCode = row["PromoCode"].ToString();
                                var PDiscount = row["DiscountPercent"].ToString();
                                var PStart = row["PromoStart"].ToString();
                                var PEnd = row["PromoEnd"].ToString();
                                var PItemsID = row["PromoItemsID"].ToString();

                                viewPromosDGV.Rows.Add(PName, PCode, Convert.ToDateTime(PStart).ToString("yyyy-MM-dd"), 
                                    Convert.ToDateTime(PEnd).ToString("yyyy-MM-dd"), PDiscount, PItemsID);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetActivePromos");
            }
        }

        public async Task CheckVoucherIsValid()
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                await conn.OpenAsync();

                string updateQuery = "UPDATE salon_promos " +
                    "SET isValid = CASE " +
                    "WHEN CURDATE() < PromoStart THEN 'NO' " +
                    "WHEN CURDATE() >= PromoStart AND CURDATE() <= PromoEnd THEN 'YES' " +
                    "ELSE 'NO' END " +
                    "WHERE CURDATE() <= PromoEnd AND CURDATE() >= PromoStart";

                using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public void HideButtons(bool add, bool see, bool update, bool discard, bool back)
        {
            PItemsUserControls.Pitemsinstance.AddPromoBtn.Visible = add;
            PItemsUserControls.Pitemsinstance.UpdatePromoBtn.Visible = update;
            PItemsUserControls.Pitemsinstance.DiscardBtn.Visible = discard;
            PItemsUserControls.Pitemsinstance.CancelBtn.Visible = back;
            PItemsUserControls.Pitemsinstance.EditAPromoBtn.Visible = see;
        }

        public void HidePanel(bool records, bool products)
        {
            PItemsUserControls.Pitemsinstance.RecordsContainer.Visible = records;
            PItemsUserControls.Pitemsinstance.ProductContainer.Visible = products;
        }



        public async Task AddServicePromo(Guna2DataGridView itemsDataGrid, long ID, DateTime start, DateTime end, string percentage, string name)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    //ang mga random generated dito na mga values ay promo code, promoitemsID)
                    string insertToPromoTable = "INSERT INTO salon_promos (PromoStart, PromoEnd, PromoCode, PromoName, PromoItemsID, DiscountPercent, PromoType) " +
                        "VALUE(@dateStart, @dateEnd, @promoCode, @promoName, @PitemsID, @discount, @type)";

                    using (MySqlCommand command = new MySqlCommand(insertToPromoTable, conn))
                    {
                        command.Parameters.AddWithValue("@dateStart", start);
                        command.Parameters.AddWithValue("@dateEnd", end);
                        command.Parameters.AddWithValue("@promoCode", ID);
                        command.Parameters.AddWithValue("@promoName", name);
                        command.Parameters.AddWithValue("@PitemsID", ID);
                        command.Parameters.AddWithValue("@discount", percentage);
                        command.Parameters.AddWithValue("@type", "Service");


                        await command.ExecuteNonQueryAsync();
                    }

                    string insertToBindedItems = "INSERT INTO binded_services (PromoServiceID, ServiceName, ServiceID) " +
                        "VALUES(@PServiceID, @serviceName, @serviceID)";

                    foreach (DataGridViewRow row in itemsDataGrid.Rows)
                    {
                        string itemsID = Convert.ToString(row.Cells["ServiceIDCol"].Value);
                        string itemName = Convert.ToString(row.Cells["ServiceNameCol"].Value);

                        using (MySqlCommand command2 = new MySqlCommand(insertToBindedItems, conn))
                        {
                            command2.Parameters.AddWithValue("@PServiceID", ID);
                            command2.Parameters.AddWithValue("@serviceName", itemName);
                            command2.Parameters.AddWithValue("@serviceID", itemsID);

                            await command2.ExecuteNonQueryAsync();
                        }
                    }
                    MessageBox.Show("Promo has been created", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in AddPromo");
            }
        }

        public async Task UpdateServiceBindedService(long ID, Guna2DataGridView newBindedItems)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();


                    string updateQuery = "UPDATE salon_promos SET PromoStart = @start, PromoEnd = @end, PromoName = @pName, DiscountPercent = @discount " +
                                        "WHERE PromoCode = @promoCode";
                    using (MySqlCommand command = new MySqlCommand(@updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@start", PServicesUserControl.pServiceInstance.PStartDTP.Value.Date);
                        command.Parameters.AddWithValue("@end", PServicesUserControl.pServiceInstance.PEndDTP.Value.Date);
                        command.Parameters.AddWithValue("@pName", PServicesUserControl.pServiceInstance.PromoNameTxtB.Text);
                        command.Parameters.AddWithValue("@discount", PServicesUserControl.pServiceInstance.PercentageTxtB.Text);
                        command.Parameters.AddWithValue("@promoCode", PServicesUserControl.pServiceInstance.PromoCodeTxtB.Text);

                        await command.ExecuteNonQueryAsync();
                    }

                    string deleteQuery = "DELETE FROM `binded_services` WHERE PromoServiceID = @promoItemsID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
                    {
                        command.Parameters.AddWithValue("@promoItemsID", ID);
                        await command.ExecuteNonQueryAsync();
                    }

                    string insertQuery = "INSERT INTO binded_services (PromoServiceID, ServiceName, ServiceID)" +
                        "VALUES (@PServiceID, @serviceName, @serviceID)";

                    foreach (DataGridViewRow row in newBindedItems.Rows)
                    {
                        string itemsID = Convert.ToString(row.Cells["ServiceIDCol"].Value);
                        string itemName = Convert.ToString(row.Cells["ServiceNameCol"].Value);

                        using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                        {
                            command.Parameters.AddWithValue("@PServiceID", ID);
                            command.Parameters.AddWithValue("@serviceName", itemName);
                            command.Parameters.AddWithValue("@serviceID", itemsID);

                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error UpdateBindedService", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task FetchBindedService(long ID, Guna2DataGridView bindedTable)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "SELECT ServiceName, ServiceID FROM binded_services WHERE PromoServiceID = @id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", ID);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            bindedTable.Rows.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string itemName = row["ServiceName"].ToString();
                                int itemID = Convert.ToInt32(row["ServiceID"]);

                                bindedTable.Rows.Add(itemName, itemID, "X");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error FetchBindedItems", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task GetActiveServicePromos(Guna2DataGridView viewPromosDGV)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT PromoName, PromoCode, DiscountPercent, " +
                        "DATE(PromoStart) AS PromoStart, DATE(PromoEnd) AS PromoEnd, PromoItemsID " +
                        "FROM salon_promos " +
                        "WHERE isValid = 'YES' AND PromoType = 'Service'";


                    using (MySqlCommand command = new MySqlCommand(fetchQuery, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var PName = row["PromoName"].ToString();
                                var PCode = row["PromoCode"].ToString();
                                var PDiscount = row["DiscountPercent"].ToString();
                                var PStart = row["PromoStart"].ToString();
                                var PEnd = row["PromoEnd"].ToString();
                                var PItemsID = row["PromoItemsID"].ToString();

                                viewPromosDGV.Rows.Add(PName, PCode, Convert.ToDateTime(PStart).ToString("yyyy-MM-dd"),
                                    Convert.ToDateTime(PEnd).ToString("yyyy-MM-dd"), PDiscount, PItemsID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetActiveServicePromos");
            }
        }
        public async void EditServicePromo(Guna2DataGridView productPromoDGV)
        {
            if (productPromoDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to edit this promo?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (productPromoDGV.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = productPromoDGV.SelectedRows[0];

                    string Pname = Convert.ToString(selectedRow.Cells["PromoNameCol"].Value);
                    string Pcode = Convert.ToString(selectedRow.Cells["PromoCodeCol"].Value);
                    DateTime PstartDate = Convert.ToDateTime(selectedRow.Cells["DateStartStart"].Value);
                    DateTime PendDate = Convert.ToDateTime(selectedRow.Cells["DateEndCol"].Value);
                    string PDiscount = Convert.ToString(selectedRow.Cells["DiscountCol"].Value);
                    long ProductIDGroup = Convert.ToInt64(selectedRow.Cells["BindedItemsCol"].Value);

                    PServicesUserControl.pServiceInstance.PromoNameTxtB.Text = Pname;
                    PServicesUserControl.pServiceInstance.PromoCodeTxtB.Text = Pcode;
                    PServicesUserControl.pServiceInstance.PercentageTxtB.Text = PDiscount;
                    PServicesUserControl.pServiceInstance.PStartDTP.Value = PstartDate;
                    PServicesUserControl.pServiceInstance.PEndDTP.Value = PendDate;
                    PServicesUserControl.pServiceInstance.IDLbl.Text = Convert.ToString(ProductIDGroup);
                    await FetchBindedService(ProductIDGroup, PServicesUserControl.pServiceInstance.ServiceDGV);
                }
            }
        }

        public void SHideButtons(bool add, bool see, bool update, bool discard, bool back)
        {
            PServicesUserControl.pServiceInstance.AddPromoBtn.Visible = add;
            PServicesUserControl.pServiceInstance.UpdatePromoBtn.Visible = update;
            PServicesUserControl.pServiceInstance.DiscardBtn.Visible = discard;
            PServicesUserControl.pServiceInstance.CancelBtn.Visible = back;
            PServicesUserControl.pServiceInstance.EditAPromoBtn.Visible = see;
        }

        public void SHidePanel(bool records, bool products)
        {
            PServicesUserControl.pServiceInstance.SRecordsContainer.Visible = records;
            PServicesUserControl.pServiceInstance.ServiceContainer.Visible = products;
        }
    }
}
