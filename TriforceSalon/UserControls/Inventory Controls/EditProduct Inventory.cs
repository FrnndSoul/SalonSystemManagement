using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.UserControls
{
    public partial class EditProduct_Inventory : UserControl
    {
        ManagerPage manager = new ManagerPage();
        public static string ItemName, Status, Unit;
        public static int ItemID, Stock, Cost, EmployeeID;
        public static byte[] PhotoByteHolder;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public EditProduct_Inventory()
        {
            InitializeComponent();
        }
        //editProduct_Inventory1.InitialLoading(ItemName, ItemID, SRP, Cost, Stock, Unit, EmployeeID);
        public void InitialLoading(string name, int id, decimal srp, int cost, int stock, string unit, int userID)
        {
            Name = name;
            ItemID = id;
            Cost = cost;
            Stock = stock;
            Unit = unit;
            EmployeeID = userID;

            NameBox.Text = name;
            UnitBox.Text = unit;
            IDBox.Text = id.ToString();
            CostBox.Text = cost.ToString();
            StockBox.Text = stock.ToString();
            editSRPTxtB.Text = srp.ToString("0.00");

            using (MemoryStream ms = new MemoryStream(LoadPhoto(id)))
            {
                PhotoBox.Image = Image.FromStream(ms);
                PhotoByteHolder = ms.ToArray();
            }
        }

        private void UploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                Image image = Image.FromFile(selectedFile);
                PhotoBox.Image = image;

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    PhotoByteHolder = ms.ToArray();
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string newName = NameBox.Text;
            string newCost = CostBox.Text;
            string newID = IDBox.Text;
            string newStock = StockBox.Text;
            string newSRP = editSRPTxtB.Text;
            string newUnit = UnitBox.Text;


            if (string.IsNullOrEmpty(newUnit) || string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newCost) || string.IsNullOrEmpty(newID) || string.IsNullOrEmpty(newStock) || string.IsNullOrEmpty(newSRP))
            {
                MessageBox.Show("Please complete all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Do you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query =
                        "UPDATE inventory SET ItemName = @itemName, Cost = @cost, Photo = @photo, Stock = @stock, Unit = @unit, SRP = @srp " +
                        "WHERE ItemID = @itemID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@itemName", newName);
                        querycmd.Parameters.AddWithValue("@cost", newCost);
                        querycmd.Parameters.AddWithValue("@srp", newSRP);
                        querycmd.Parameters.AddWithValue("@unit", newUnit);
                        querycmd.Parameters.AddWithValue("@itemID", newID);
                        querycmd.Parameters.AddWithValue("@stock", newStock);
                        querycmd.Parameters.AddWithValue("@photo", PhotoByteHolder);

                        if (Method.AdminAccess())
                        {
                            MessageBox.Show("Working as intended.\nNo changes were made in the database");
                        }
                        else
                        {
                            querycmd.ExecuteNonQuery();
                            MessageBox.Show("Item update info success", "Item Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                ClearFields();
                manager.DisableButtons(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nat SaveBtn_Click() InventoryPage", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editSRPTxtB_TextChanged(object sender, EventArgs e)
        {

        }

        public byte[] LoadPhoto(int itemID)
        {
            try
            {
                string query = "SELECT `Photo` FROM `inventory` WHERE `ItemID` = @ItemID";
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", itemID);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return (byte[])result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nat LoadPhoto InventoryPage", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void perDayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CurentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CostBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AggregateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager.DisableButtons(true);

        }

        private void ClearFields()
        {
            PhotoBox.Image = null;
            IDBox.Text = null;
            NameBox.Text = null;
            StockBox.Text = null;
            CostBox.Text = null;
            editSRPTxtB.Text = null;

            this.Visible = false;
            manager.DisableButtons(true);
        }
    }
}
