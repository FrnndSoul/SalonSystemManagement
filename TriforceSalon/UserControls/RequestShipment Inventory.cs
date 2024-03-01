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

namespace TriforceSalon.UserControls
{
    public partial class RequestShipment_Inventory : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string ItemName;
        public static int ItemRow, ItemID, Stock, Cost, Aggregate, Status, EmployeeID;
        public static byte[] PhotoByteHolder;
        public RequestShipment_Inventory()
        {
            InitializeComponent();
        }

        public void InitialLoading(string name, int id, int cost, int aggregate, int status, int userID, int stock)
        {
            Name = name;
            ItemID = id;
            Cost = cost;
            Aggregate = aggregate;
            Status = status;
            EmployeeID = userID;

            NameBox.Text = name;
            IDBox.Text = id.ToString();
            CostBox.Text = cost.ToString();
            AggregateBox.Text = aggregate.ToString();
            StockBox.Text = stock.ToString();

            if(status == 0)
            {
                StatusBox.Text = "Great";
            } else if (status == 1)
            {
                StatusBox.Text = "Half";
            } else if (status == 2)
            {
                StatusBox.Text = "Critical";
            } else
            {
                StatusBox.Text = "Empty";
            }
        }

        private void AddQtyBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(QuantityBox.Text);
            if (x != Convert.ToInt32(AggregateBox.Text))
            {
                x++;
                QuantityBox.Text = x.ToString();
            }
        }

        private void SubQtyBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(QuantityBox.Text);
            if (x > 0)
            {
                x--;
                QuantityBox.Text = x.ToString();
            }
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(QuantityBox.Text) == 0)
            {
                MessageBox.Show("Cannot ship zero quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(SupplierBox.Text))
            {
                MessageBox.Show($"No supplier indicated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Do you want to ship a new batch of {NameBox.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Inventory.AddShippedItems(Convert.ToInt32(IDBox.Text), Convert.ToInt32(QuantityBox.Text));
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
