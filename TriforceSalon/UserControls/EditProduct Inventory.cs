using MySql.Data.MySqlClient;
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

namespace TriforceSalon.UserControls
{
    public partial class EditProduct_Inventory : UserControl
    {
        public static byte[] PhotoBytes;
        public static int ItemID;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public EditProduct_Inventory()
        {
            InitializeComponent();
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string Name = NameBox.Text;
            string Cost = CostBox.Text;
            string Aggregate = AggregateBox.Text;
            string ID = IDBox.Text;
            string Stock = StockBox.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Cost) || string.IsNullOrEmpty(Aggregate) || string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(Stock))
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
                        "UPDATE inventory SET ItemName = @itemName, Cost = @cost, Aggregate = @aggregate, Photo = @photo, Stock = @stock " +
                        "WHERE ItemID = @itemID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@itemName", Name);
                        querycmd.Parameters.AddWithValue("@cost", Cost);
                        querycmd.Parameters.AddWithValue("@aggregate", Aggregate);
                        querycmd.Parameters.AddWithValue("@itemID", ID);
                        querycmd.Parameters.AddWithValue("@stock", Stock);
                        querycmd.Parameters.AddWithValue("@photo", PhotoBytes);
                        querycmd.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nat SaveBtn_Click() InventoryPage", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
