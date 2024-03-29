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

namespace TriforceSalon.UserControls
{
    public partial class GeneralView_Inventory : UserControl
    {
        ManagerPage manager = new ManagerPage();
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string ItemName;
        public static int ItemRow, ItemID, Stock, Cost, Aggregate, Status, EmployeeID;
        public static byte[] PhotoByteHolder;

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
            if (Status <= 2)
            {
                MessageBox.Show($"There is still ample supply of\n{ItemName}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            requestShipment_Inventory1.Visible = true;
            requestShipment_Inventory1.InitialLoading(ItemName, ItemID, Cost, Aggregate, Status, EmployeeID, Stock);
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
            editProduct_Inventory1.Visible = true;
            editProduct_Inventory1.InitialLoading(ItemName, ItemID, Cost, Aggregate, Status, EmployeeID);
            manager.DisableButtons(false);

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
                string sql = "SELECT `ItemID`, `ItemName`, SRP, `Stock`, `Cost`, `Aggregate`, `Status` FROM `inventory`";
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

        public void ReadRow(int itemRow)
        {
            ItemName = InventoryDGV.Rows[itemRow].Cells["ItemName"].Value.ToString();
            ItemID = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["ItemID"].Value);
            Stock = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Stock"].Value);
            Cost = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Cost"].Value);
            Aggregate = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Aggregate"].Value);
            Status = Convert.ToInt32(InventoryDGV.Rows[itemRow].Cells["Status"].Value);
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
