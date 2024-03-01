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
        public RequestShipment_Inventory()
        {
            InitializeComponent();
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
    }
}
