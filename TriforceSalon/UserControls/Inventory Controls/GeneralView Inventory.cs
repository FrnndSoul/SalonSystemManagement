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
using System.Xml.Linq;
using System.Security.Policy;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.Collections;

namespace TriforceSalon.UserControls
{
    public partial class GeneralView_Inventory : UserControl
    {
        ManagerPage manager = new ManagerPage();
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string ItemName, Status, Unit;
        public static int ItemRow, ItemID, Stock, Cost, EmployeeID;
        public static byte[] PhotoByteHolder;
        public decimal SRP;

        public GeneralView_Inventory()
        {
            InitializeComponent();
            LoadInventory();
            InventoryDGV.Font = new Font("Chinacat", 18f);
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (InventoryDGV.RowCount == 0)
            {
                return;
            }
            ItemRow = InventoryDGV.SelectedCells[0].RowIndex;
            if (ItemRow < 0)
            {
                MessageBox.Show("Select a product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReadRow(ItemRow);

            requestShipment_Inventory1.Visible = true;
            requestShipment_Inventory1.InitialLoading(ItemName, ItemID, Cost, Status, EmployeeID, Stock, Unit);
            manager.DisableButtons(false);
        }

        private void addProduct_Inventory1_VisibleChanged(object sender, EventArgs e)
        {
            LoadInventory();
            if (!addProduct_Inventory1.Visible)
            {
                ShowButtons();
            }
            else
            {
                HideButtons();
            }
        }

        private void requestShipment_Inventory1_VisibleChanged(object sender, EventArgs e)
        {
            LoadInventory();
            if (!requestShipment_Inventory1.Visible)
            {
                ShowButtons();
            }
            else
            {
                HideButtons();
            }
        }

        private void editProduct_Inventory1_VisibleChanged(object sender, EventArgs e)
        {
            LoadInventory();
            if (!editProduct_Inventory1.Visible)
            {
                ShowButtons();
            }
            else
            {
                HideButtons();
            }
        }

        private void PullBtn_Click(object sender, EventArgs e)
        {
            if (InventoryDGV.RowCount == 0)
            {
                return;
            }

            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;

            if (itemRow < 0)
            {
                MessageBox.Show("Select a product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReadRow(itemRow);
            manager.DisableButtons(false);
            pullProductForm1.Visible = true;
            pullProductForm1.InitialLoading(ItemName, ItemID, SRP, Cost, Stock, Unit, EmployeeID);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (InventoryDGV.RowCount == 0)
            {
                return;
            }

            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;

            if (itemRow < 0)
            {
                MessageBox.Show("Select a product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReadRow(itemRow);

            DialogResult result = MessageBox.Show($"Are you sure you want to delete this item?\n\n{ItemName}","Item Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string sql = @"DELETE FROM `inventory` WHERE `ItemID` = @itemID";
                    using (MySqlCommand querycmd = new MySqlCommand(sql, connection))
                    {
                        querycmd.Parameters.AddWithValue("@itemID", ItemID);

                        if (Method.AdminAccess())
                        {
                            MessageBox.Show("Working as intended.\nNo changes were made in the database");
                        }
                        else
                        {
                            querycmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nat DeleteBtn_Click()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void pullProductForm1_VisibleChanged(object sender, EventArgs e)
        {
            LoadInventory();
            if (!pullProductForm1.Visible)
            {
                ShowButtons();
            }
            else
            {
                HideButtons();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (InventoryDGV.RowCount == 0)
            {
                return;
            }

            int itemRow = InventoryDGV.SelectedCells[0].RowIndex;

            if (itemRow < 0)
            {
                MessageBox.Show("Select a product first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReadRow(itemRow);
            manager.DisableButtons(false);
            editProduct_Inventory1.Visible = true;
            editProduct_Inventory1.InitialLoading(ItemName, ItemID, SRP, Cost, Stock, Unit, EmployeeID);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addProduct_Inventory1.Visible = true;
            manager.DisableButtons(false);
        }

        public void LoadInventory()
        {
            Inventory.CheckStatus();
            try
            {
                connection.Open();
                string sql = @"SELECT 
                                    `ItemID`, 
                                    `ItemName`, 
                                    `SRP`, 
                                    `Stock`, 
                                    `Unit`, 
                                    `Cost`, 
                                CASE 
                                    WHEN `Status` = 0 THEN 'Great' 
                                    WHEN `Status` = 1 THEN 'Good' 
                                    WHEN `Status` = 2 THEN 'Critical' 
                                    ELSE 'Empty' 
                                END AS `Status` 
                            FROM 
                                `inventory`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                InventoryDGV.DataSource = dataTable;

                int totalWidth = InventoryDGV.Width - SystemInformation.VerticalScrollBarWidth;
                InventoryDGV.Columns["ItemID"].Width = (int)(totalWidth * 0.1);
                InventoryDGV.Columns["ItemName"].Width = (int)(totalWidth * 0.3);
                InventoryDGV.Columns["SRP"].Width = (int)(totalWidth * 0.1);
                InventoryDGV.Columns["Stock"].Width = (int)(totalWidth * 0.1);
                InventoryDGV.Columns["Unit"].Width = (int)(totalWidth * 0.2);
                InventoryDGV.Columns["Cost"].Width = (int)(totalWidth * 0.1);
                InventoryDGV.Columns["Status"].Width = (int)(totalWidth * 0.1);
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

        public void ReadRow(int itemRow)
        {
            ItemName = InventoryDGV.Rows[itemRow].Cells["ItemName"].Value.ToString();
            ItemID = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["ItemID"].Value);
            SRP = Convert.ToDecimal(InventoryDGV.Rows[itemRow].Cells["SRP"].Value);
            Stock = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Stock"].Value);
            Unit = InventoryDGV.Rows[itemRow].Cells["Unit"].Value.ToString();
            Cost = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Cost"].Value);
            Status = InventoryDGV.Rows[itemRow].Cells["Status"].Value.ToString();
        }

        public void HideButtons()
        {
            RequestBtn.Visible = false;
            AddBtn.Visible = false;
            EditBtn.Visible = false;
            InventoryDGV.Visible = false;
        }

        public void ShowButtons()
        {
            RequestBtn.Visible = true;
            AddBtn.Visible = true;
            EditBtn.Visible = true;
            InventoryDGV.Visible = true;
        }
    }
}
