using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class SellProductsUserControls : UserControl
    {
        SellProductsMethods sellMethods = new SellProductsMethods();
        private readonly string mysqlcon;
        public SellProductsUserControls()
        {
            InitializeComponent();
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

        }

        private async void SellProductsUserControls_Load(object sender, EventArgs e)
        {
            try
            {
                await sellMethods.LoadItemsInSales(ProductsFL, mysqlcon, ProductsControlDGV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
