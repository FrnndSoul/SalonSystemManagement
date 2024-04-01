using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TriforceSalon.UserControls
{
    public partial class AddProduct_Inventory : UserControl
    {
        ManagerPage manager = new ManagerPage();
        public static byte[] PhotoBytes;
        public static int ItemID;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public AddProduct_Inventory()
        {
            InitializeComponent();
            ItemID = Inventory.GenerateID();
            IDBox.Text = ItemID.ToString();
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
                    PhotoBytes = ms.ToArray();
                }
            }
        }

        private async void AddProduct_Click(object sender, EventArgs e)
        {
            string Name = NameBox.Text;
            string ID = IDBox.Text;
            string Cost = CostBox.Text;
            string Aggregate = AggregateBox.Text;
            string SRP = SRPTxtB.Text;

            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Cost) || string.IsNullOrEmpty(Aggregate) || string.IsNullOrEmpty(SRP))
            {
                MessageBox.Show("Please complete all details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if (PhotoBytes == null)
            {
                MessageBox.Show("Please upload a product photo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    await connection.OpenAsync();
                    string query = "INSERT INTO `inventory` " +
                                   "(`ItemID`, `ItemName`, `Stock`, `Cost`, `SRP`, `Aggregate`, `Status`, `Photo`) VALUES " +
                                   "(@itemID, @itemName, @stock, @cost, @srp, @aggregate, @status, @photo)";

                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@itemID", ID);
                        querycmd.Parameters.AddWithValue("@itemName", Name);
                        querycmd.Parameters.AddWithValue("@stock", 0);
                        querycmd.Parameters.AddWithValue("@cost", Cost);
                        querycmd.Parameters.AddWithValue("@srp", SRP);
                        querycmd.Parameters.AddWithValue("@aggregate", Aggregate);
                        querycmd.Parameters.AddWithValue("@status", 3);
                        querycmd.Parameters.AddWithValue("@photo", PhotoBytes);
                        await querycmd.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("Item has been added", "Item Insertion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ItemID = Inventory.GenerateID();
                IDBox.Text = ItemID.ToString();
                manager.DisableButtons(true);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nat AddProduct_Click", "SQL ERROR", MessageBoxButtons.OK);
            }
        }

        private void Clear()
        {
            NameBox.Text = null;
            CostBox.Text = null;
            AggregateBox.Text = null;
            SRPTxtB.Text = null;
            PhotoBox.Image = null;
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager.DisableButtons(true);
        }
    }
}