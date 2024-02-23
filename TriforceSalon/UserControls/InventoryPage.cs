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

        private void Button2_Click(object sender, EventArgs e)
        {
            DefaultLoad();
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

        private void TabPage2_Click(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {
            Inventory.CheckStatus();
            LoadInventory();
            LoadShipments();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
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
            if (Convert.ToInt32(RequestBox.Text)==0)
            {
                MessageBox.Show("Cannot ship zero quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        querycmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(RequestBox.Text));
                        querycmd.Parameters.AddWithValue("@cost", totalCost);
                        querycmd.ExecuteNonQuery();
                        Inventory.AddShippedItems(itemID, Convert.ToInt32(RequestBox.Text));
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

        private void Add_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(RequestBox.Text);
            if (x != Convert.ToInt32(AggregateBox.Text))
            {
                x++;
                RequestBox.Text = x.ToString();
            }
        }

        private void Less_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(RequestBox.Text);
            if (x>0)
            {
                x--;
                RequestBox.Text = x.ToString();
            }
        }

        private void ShipmentPanel_Paint(object sender, PaintEventArgs e)
        {
            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;
            string selectedID = InventoryDGV.Rows[itemRow].Cells["ItemID"].Value.ToString();
            string selectedName = InventoryDGV.Rows[itemRow].Cells["ItemName"].Value.ToString();
            string selectedStock = InventoryDGV.Rows[itemRow].Cells["Stock"].Value.ToString();
            string selectedCost = InventoryDGV.Rows[itemRow].Cells["Cost"].Value.ToString();
            string selectedAggregate = InventoryDGV.Rows[itemRow].Cells["Aggregate"].Value.ToString();
            string selectedStatus = InventoryDGV.Rows[itemRow].Cells["Status"].Value.ToString();

            NameBox.Text = selectedName;
            StockBox.Text = selectedStock;
            CostBox.Text = selectedCost;
            AggregateBox.Text = selectedAggregate;
            CodeBox.Text = selectedID;
            if (Convert.ToInt32(selectedStatus) == 0)
            {
                StatusBox.Text = "Good";
            }
            else if (Convert.ToInt32(selectedStatus) == 1)
            {
                StatusBox.Text = "Fair";
            }
            else if (Convert.ToInt32(selectedStatus) == 2)
            {
                StatusBox.Text = "Critical";
            }
            else
            {
                StatusBox.Text = "Empty";
            }
        }

        private void ShipmentBackBtn_Click(object sender, EventArgs e)
        {
            DefaultLoad();
        }

        public void DefaultLoad()
        {
            NameBox.Text = "";
            StockBox.Text = "";
            CostBox.Text = "";
            AggregateBox.Text = "";
            CodeBox.Text = "";
            StatusBox.Text = "";

            EditNameBox.Text = "";
            EditStockBox.Text = "";
            EditCostBox.Text = "";
            EditAggregateBox.Text = "";
            EditIDBox.Text = "";

            InventoryPanel.Visible = true;
            ShipmentPanel.Visible = false;
            EditPanel.Visible = false;

            Inventory.CheckStatus();
            LoadInventory();
            LoadShipments();
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;
            string selectedID = InventoryDGV.Rows[itemRow].Cells["ItemID"].Value.ToString();
            string selectedName = InventoryDGV.Rows[itemRow].Cells["ItemName"].Value.ToString();
            string selectedStock = InventoryDGV.Rows[itemRow].Cells["Stock"].Value.ToString();
            string selectedCost = InventoryDGV.Rows[itemRow].Cells["Cost"].Value.ToString();
            string selectedAggregate = InventoryDGV.Rows[itemRow].Cells["Aggregate"].Value.ToString();

            EditPanel.Visible = true;
            InventoryPanel.Visible = false;

            EditNameBox.Text = selectedName;
            EditStockBox.Text = selectedStock;
            EditCostBox.Text = selectedCost;
            EditAggregateBox.Text = selectedAggregate;
            EditIDBox.Text = selectedID;
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            DefaultLoad();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
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
                        "UPDATE inventory SET ItemName = @itemName, Cost = @cost, Aggregate = @aggregate " +
                        "WHERE ItemID = @itemID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@itemName", EditNameBox.Text);
                        querycmd.Parameters.AddWithValue("@cost", EditCostBox.Text);
                        querycmd.Parameters.AddWithValue("@aggregate", EditAggregateBox.Text);
                        querycmd.Parameters.AddWithValue("@itemID", EditIDBox.Text);
                        querycmd.ExecuteNonQuery();
                        DefaultLoad();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nat ChangeUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditCostBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditAggregateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            ShipmentPanel.Visible = true;
            InventoryPanel.Visible = false;
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
                            NameBox.Text = ItemName;
                        Stock = Convert.ToInt32(reader["Stock"]);
                            StockBox.Text = Stock.ToString();
                        Cost = Convert.ToInt32(reader["Cost"]);
                            CostBox.Text = Cost.ToString();
                        Aggregate = Convert.ToInt32(reader["Aggregate"]);
                            AggregateBox.Text = Aggregate.ToString();
                        Status = Convert.ToInt32(reader["Status"]);
                            if (Status == 0)
                            {
                                StatusBox.Text = "Good";
                            } else if (Status == 1)
                            {
                                StatusBox.Text = "Fair";
                            } else if (Status == 2)
                            {
                                StatusBox.Text = "Critical";
                            } else
                            {
                                StatusBox.Text = "Empty";
                            }
                        ItemID = Convert.ToInt32(selectedItem);
                            CodeBox.Text = ItemID.ToString();
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
