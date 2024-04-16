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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace TriforceSalon.UserControls.Inventory_Controls
{
    public partial class PullProductForm : UserControl
    {
        ManagerPage manager = new ManagerPage();
        public static string ItemName, PerDay, Unit;
        public static int ItemID, Stock, Cost, Status, EmployeeID;
        public static byte[] PhotoByteHolder;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            QuantityBox.Text = "0";
            manager.DisableButtons(true);
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to pull a new batch of {NameBox.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            await Inventory.DeductItems(IDBox.Text, QuantityBox.Text);
            DiscardBtn_Click(null, null);
        }

        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public PullProductForm()
        {
            InitializeComponent();
        }

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

        private async void AddQtyBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            int x = Convert.ToInt32(QuantityBox.Text);
            int y = Convert.ToInt32(StockBox.Text);

            if (x<y)
            {
                x++;
                QuantityBox.Text = x.ToString();
            }
        }

        private async void SubQtyBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            int x = Convert.ToInt32(QuantityBox.Text);
            if (x > 0)
            {
                x--;
                QuantityBox.Text = x.ToString();
            }
        }

    }
}
