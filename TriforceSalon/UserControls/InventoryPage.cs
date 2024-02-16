using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TriforceSalon
{
    public partial class InventoryPage : UserControl
    {
        public static string mysqlcon = "server=localhost;user=root;database=salondb;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string ItemName;
        public static int ItemID, Stock, Cost, Aggregate, Status;
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method.LogOutUser();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.ShowLogin();
                    break;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {
            Inventory.CheckStatus();
            LoadInventory();
            LoadShipments();
        }

        public void LoadInventory()
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM `inventory`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                InventoryDGV.DataSource = dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LoadInventory()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void LoadShipments()
        {
            try
            {
                connection.Open();
                string sql = "SELECT * FROM `shipments`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                ShipmentDGV.DataSource = dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LoadShipments()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;
            if (itemRow < 0)
            {
                MessageBox.Show("Select a product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemName = InventoryDGV.Rows[itemRow].Cells["ItemName"].Value.ToString();
            int status = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Status"].Value);

            if (status <= 1)
            {
                MessageBox.Show($"There is still ample supply of\n{itemName}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Do you want to ship a new batch of {itemName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "INSERT INTO `shipments`(`DateShipped`,`ShipmentID`, `ItemID`, `ItemName`, `Quantity`, `Cost`)" +
                        "VALUES (@dateShipped, @shipmentID, @itemID, @itemName, @quantity, @cost)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        int itemID = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["ItemID"].Value);
                        int aggregate = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Aggregate"].Value);
                        int cost = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Cost"].Value);
                        int totalCost = cost * aggregate;

                        querycmd.Parameters.AddWithValue("@dateShipped", DateTime.Now);
                        querycmd.Parameters.AddWithValue("@shipmentID", Inventory.ShipmentID());
                        querycmd.Parameters.AddWithValue("@itemID", itemID);
                        querycmd.Parameters.AddWithValue("@itemName", itemName);
                        querycmd.Parameters.AddWithValue("@quantity", aggregate);
                        querycmd.Parameters.AddWithValue("@cost", totalCost);
                        querycmd.ExecuteNonQuery();
                        Inventory.AddShippedItems(itemID, aggregate);
                        Inventory.CheckStatus();
                        LoadInventory();
                        LoadShipments();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nat OrderShipmentBtn()", "SQL ERROR", MessageBoxButtons.OK);
            }

        }

        private void InventoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;
            string selectedItem = InventoryDGV.Rows[itemRow].Cells["ItemID"].Value.ToString();
            try
            {
                connection.Open();
                string sql = "SELECT `ItemName`, `Stock`, `Cost`, `Aggregate`, `Status` FROM `inventory` WHERE `ItemID` = @itemID";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@itemID", selectedItem);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ItemName = reader["ItemName"].ToString();
                        Stock = Convert.ToInt32(reader["Stock"]);
                        Cost = Convert.ToInt32(reader["Cost"]);
                        Aggregate = Convert.ToInt32(reader["Aggregate"]);
                        Status = Convert.ToInt32(reader["Status"]);
                        ItemID = Convert.ToInt32(selectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nat LoadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
