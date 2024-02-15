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
using MySql.Data.MySqlClient;

namespace TriforceSalon
{
    public partial class InventoryPage : UserControl
    {
        public static string mysqlcon = "server=localhost;user=root;database=salondb;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {
            Inventory.CheckStatus();
            LoadInventory();
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
                MessageBox.Show(e.Message + "\n\nat LoadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
