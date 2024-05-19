using Guna.UI2.WinForms;
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

namespace TriforceSalon.UserControls.Promo_Controls
{
    public partial class PItemsUserControls : UserControl
    {
        private string mysqlcon;
        PromoFetchItemsClass promoFetch = new PromoFetchItemsClass();
        PromoMethods promo = new PromoMethods();
        public static PItemsUserControls Pitemsinstance;
        PromoUserControl promoUserControl;

        public PItemsUserControls(PromoUserControl promoUserControl)
        {
            InitializeComponent();
            Pitemsinstance = this;
            PStartDTP.Value = DateTime.Now;
            PEndDTP.Value = DateTime.Now;
            GenerateRandomNumber();
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            this.promoUserControl = promoUserControl;
        }

        private async void PItemsUserControls_Load(object sender, EventArgs e)
        {
            await promoFetch.LoadItemsInSales(ProductsFL, mysqlcon, ProductsDGV);
        }

        private void PercentageTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key is a digit or backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // If not a digit or backspace, handle the keypress
                e.Handled = true;
                return;
            }

            // Check if the current length of the text is already 2
            if (PercentageTxtB.TextLength >= 2 && e.KeyChar != '\b')
            {
                // If so, handle the keypress
                e.Handled = true;
                return;
            }
        }

        private async void AddPromoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PromoNameTxtB.Text) ||
                string.IsNullOrWhiteSpace(PercentageTxtB.Text) ||
                string.IsNullOrWhiteSpace(PromoCodeTxtB.Text))
            {
                MessageBox.Show("Please fill up all the necessary details needed", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ProductsDGV.Rows.Count == 0)
            {
                MessageBox.Show("No items has been selected", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Is the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                long ID = Convert.ToInt64(PromoCodeTxtB.Text);
                string Pname = PromoNameTxtB.Text;
                DateTime startDate = PStartDTP.Value.Date;
                DateTime endDate = PEndDTP.Value.Date;
                string percent = PercentageTxtB.Text + "%";

                await promo.AddPromo(ProductsDGV, ID, startDate, endDate, percent, Pname);
                await promo.CheckVoucherIsValid();
                ClearAllInput();
                GenerateRandomNumber();
            }
        }

        private void GenerateRandomNumber()
        {
            Random rand = new Random();
            PromoCodeTxtB.Text =  Convert.ToString(rand.Next(1000000, 9999999));
        }

        public void ClearAllInput()
        {
            ProductsDGV.Rows.Clear();
            PromoNameTxtB.Text = null;
            PercentageTxtB.Text = null;
            PromoCodeTxtB.Text = null;
            PStartDTP.Value = DateTime.Now;
            PEndDTP.Value = DateTime.Now;
        }

        private async void SearchProductsBtn_Click(object sender, EventArgs e)
        {
            string product = ProductSearchTxtB.Text;
            try
            {
                await promoFetch.LoadItemsInSalesForSearch(ProductsFL, mysqlcon, ProductsDGV, product);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in Search");
            }
        }

        
        private async void UpdatePromoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PromoNameTxtB.Text) ||
                string.IsNullOrWhiteSpace(PercentageTxtB.Text) ||
                string.IsNullOrWhiteSpace(PromoCodeTxtB.Text))
            {
                MessageBox.Show("Please fill up all the necessary details needed", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ProductsDGV.Rows.Count == 0)
            {
                MessageBox.Show("No items has been selected", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Is the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                long ID = Convert.ToInt64(IDLbl.Text);
                await promo.UpdateBindedService(ID, ProductsDGV);
                await promo.CheckVoucherIsValid();

                ClearAllInput();
                GenerateRandomNumber();
                promo.HideButtons(true, true, false, false);
            }
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            ClearAllInput();
            GenerateRandomNumber();
            promo.HideButtons(true, true, false, false);
            promoUserControl.GoToAll();
        }

        private void ProductsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ProductsDGV.Rows.Count)
            {
                DataGridViewCell clickedCell = ProductsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "RemoveCol")
                {
                    ProductsDGV.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == ProductsDGV.Columns["IncrementCol"].Index)
                {
                    int currentQty = int.Parse(ProductsDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    currentQty++;
                    ProductsDGV.Rows[e.RowIndex].Cells[3].Value = currentQty;
                }
                else if (e.ColumnIndex == ProductsDGV.Columns["DecrementCol"].Index)
                {
                    int currentQty = int.Parse(ProductsDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    if (currentQty > 1)
                    {
                        currentQty--;
                        ProductsDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value = currentQty;
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClearAllInput();
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await promoFetch.LoadItemsInSales(ProductsFL, mysqlcon, ProductsDGV);
        }
    }
}
