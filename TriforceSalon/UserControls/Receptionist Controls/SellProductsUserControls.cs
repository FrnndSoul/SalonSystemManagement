using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Data.Common;
using System.Drawing;
using System.Transactions;
using System.Web.WebSockets;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using static TriforceSalon.Class_Components.SellProductsMethods;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class SellProductsUserControls : UserControl
    {
        public static SellProductsUserControls sellProductsUserControlsInstance;
        TransactionMethods transaction = new TransactionMethods();
        Inventory inventoryMethods = new Inventory();
        SellProductsMethods sellMethods;
        private readonly string mysqlcon;
        private decimal totalPrice = 0.00m;
        public SellProductsUserControls()
        {
            InitializeComponent();
            sellProductsUserControlsInstance = this;
            UpdateTotalPriceDelegate updateTotalPriceDelegate = UpdateTotalPrice;
            AddTotalPriceDelegate addTotalPriceDelegate = AddTotalPrice;
            sellMethods = new SellProductsMethods(updateTotalPriceDelegate, addTotalPriceDelegate);

            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

        }

        private async void SellProductsUserControls_Load(object sender, EventArgs e)
        {
            try
            {
                await sellMethods.LoadItemsInSales(ProductsFL, mysqlcon, ProductsControlDGV);
                await transaction.GetAllUnfinishedTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void SearchProductsBtn_Click(object sender, EventArgs e)
        {
            string product = ProductSearchTxtB.Text;
            try
            {
                await sellMethods.LoadItemsInSalesForSearch(ProductsFL, mysqlcon, ProductsControlDGV, product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private async void AllProductsBtn_Click(object sender, EventArgs e)
        {
            ProductsFL.Controls.Clear();
            try
            {
                await sellMethods.LoadItemsInSales(ProductsFL, mysqlcon, ProductsControlDGV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ProductsControlDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ProductsControlDGV.Rows.Count) // 
            {
                DataGridViewCell clickedCell = ProductsControlDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "DisposeCol")
                {
                    decimal removedItemPrice = decimal.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["CostCol"].Value.ToString());
                    ProductsControlDGV.Rows.RemoveAt(e.RowIndex);
                    totalPrice -= removedItemPrice;
                    UpdateTotalPrice();
                }
                else if (e.ColumnIndex == ProductsControlDGV.Columns["IncrementCol"].Index)
                {
                    int currentQty = int.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    currentQty++;
                    ProductsControlDGV.Rows[e.RowIndex].Cells[2].Value = currentQty;
                    AddTotalPrice(e.RowIndex);
                }
                else if (e.ColumnIndex == ProductsControlDGV.Columns["DecrementCol"].Index)
                {
                    int currentQty = int.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    SubtractTotalPrice(e.RowIndex);
                }
            }

        }

        private decimal GetUnitPriceForFood(string serviceName)
        {
            decimal unitPrice = 0;

            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT SRP FROM inventory WHERE ItemName = @itemName";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@itemName", serviceName);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unitPrice = decimal.Parse(reader["SRP"].ToString());
                        }
                    }
                }
            }
            return unitPrice;
        }
        private void UpdateTotalPrice() //NEW CODE
        {
            totalPrice = 0.00m;

            foreach (DataGridViewRow row in ProductsControlDGV.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                    totalPrice += rowTotal;
                }
            }
            SubLbl.Text = "Php. " + totalPrice.ToString("0.00");
            TotLbl.Text = SubLbl.Text;
            if (discChckBx.Checked)
            {
                decimal totalPrice = decimal.Parse(SubLbl.Text.Replace("Php. ", ""));
                decimal discount = totalPrice * 0.20m; // 20% discount
                decimal discountedTotal = totalPrice - discount;
                DiscLbl.Text = "Php. " + discount.ToString("0.00");
                TotLbl.Text = "Php. " + discountedTotal.ToString("0.00");
            }
        }

        private void AddTotalPrice(int rowIndex)
        {
            int currentQty = int.Parse(ProductsControlDGV.Rows[rowIndex].Cells[2].Value.ToString());
            string serviceName = ProductsControlDGV.Rows[rowIndex].Cells[0].Value.ToString(); // Get the food name from DataGridView
            decimal unitPrice = GetUnitPriceForFood(serviceName); // Retrieve unit price based on VariationName
            decimal totalPrice = currentQty * unitPrice;
            ProductsControlDGV.Rows[rowIndex].Cells[4].Value = totalPrice.ToString();

            UpdateTotalPrice();
        }

        private void SubtractTotalPrice(int rowIndex)
        {
            int currentQty = int.Parse(ProductsControlDGV.Rows[rowIndex].Cells[2].Value.ToString());
            string foodName = ProductsControlDGV.Rows[rowIndex].Cells[0].Value.ToString();
            decimal unitPrice = GetUnitPriceForFood(foodName);

            if (currentQty > 1)
            {
                currentQty--;
                ProductsControlDGV.Rows[rowIndex].Cells[2].Value = currentQty; // Update the quantity in the DataGridView
                decimal totalPrice = currentQty * unitPrice;
                ProductsControlDGV.Rows[rowIndex].Cells[4].Value = totalPrice.ToString();
            }
            UpdateTotalPrice();
        }

        private void discChckBx_CheckedChanged(object sender, EventArgs e)
        {
            if (discChckBx.Checked)
            {
                decimal totalPrice = decimal.Parse(SubLbl.Text.Replace("Php. ", ""));
                decimal discount = totalPrice * 0.20m;
                decimal discountedTotal = totalPrice - discount;

                DiscLbl.Text = "Php. " + discount.ToString("0.00");
                TotLbl.Text = "Php. " + discountedTotal.ToString("0.00");
            }
            else
            {
                DiscLbl.Text = "Php. 0.00";
                UpdateTotalPrice();
            }
        }

        private void RefreshPlaceButtonState()
        {
            if (ProductsControlDGV.Rows.Count == 0 || !IsAnyProductSelected() || string.IsNullOrEmpty(CashTxtBx.Text) || CashTxtBx.Text == "0.00")
            {
                PaymentBtn.Enabled = false;
            }
            else
            {
                PaymentBtn.Enabled = true;
            }
        }

        private void CheckVoidButtonState()
        {
            if (ProductsControlDGV.Rows.Count == 0)
            {
                VoidBtn.Enabled = false;
            }
            else
            {
                VoidBtn.Enabled = true;
            }
        }

        private bool IsAnyProductSelected()
        {
            foreach (DataGridViewRow row in ProductsControlDGV.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "-")
                {
                    return true;
                }
            }
            return false;
        }

        private void ValidateCashTextbox()
        {
            decimal cashValue;
            if (!decimal.TryParse(CashTxtBx.Text, out cashValue) || cashValue < 0)
            {
                MessageBox.Show("Please enter a valid positive decimal value (xxx.xx).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CashTxtBx.Focus();
                CashTxtBx.SelectAll();
            }
        }

        private void CashTxtBx_TextChanged(object sender, EventArgs e)
        {
            RefreshPlaceButtonState();
        }

        private void CashTxtBx_Enter(object sender, EventArgs e)
        {
            if (CashTxtBx.Text == "0.00")
            {
                CashTxtBx.Text = "";
                CashTxtBx.ForeColor = Color.Black;
            }
        }

        private void CashTxtBx_Leave(object sender, EventArgs e)
        {
            if (CashTxtBx.Text == "")
            {
                CashTxtBx.Text = "0.00";
                CashTxtBx.ForeColor = Color.LightGray;
            }
            ValidateCashTextbox();
        }

        private void CashTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateCashTextbox();
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ProductsControlDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshPlaceButtonState();
            CheckVoidButtonState();
        }

        private void ProductsControlDGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshPlaceButtonState();
            CheckVoidButtonState();

        }

        private void ProductsControlDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RefreshPlaceButtonState();
            CheckVoidButtonState();

        }

        private async void PaymentBtn_Click(object sender, EventArgs e)
        {
            int salesID = transaction.GenerateTransactionID();
            int orderID = transaction.GenerateTransactionID();

            if (CustomerIDComB == null || CustomerIDComB.SelectedIndex == -1)
            {
                if (CustomerNameTxtB.Text == null)
                {
                    MessageBox.Show("Customer's name is required to proceed", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    await transaction.PurchaseToReceipt(orderID, ProductsControlDGV);
                    transaction.ClearContents();
                }

                //dito ilalagay yung method to process na rekta resibo na
            }
            else
            {
                //dito ialagat yung method na ialalgay muna sa database for single resibo nalang
                int ID = Convert.ToInt32(CustomerIDComB.SelectedItem);
                MessageBox.Show(Convert.ToString(ID));
                await transaction.PurchaseToDatabase(Convert.ToInt32(ID), ProductsControlDGV);
            }
        }

        private async void VoidBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to void these items?", "Void Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string enteredPassword = Method.HashString(Microsoft.VisualBasic.Interaction.InputBox("Enter manager password:", "Password Required", ""));

                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT se.AccountAccess, a.Password FROM salon_employees se JOIN accounts a ON se.AccountID = a.AccountID WHERE a.Password = @enteredPassword;";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@enteredPassword", enteredPassword);

                        using(DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                string position = reader["AccountAccess"].ToString();

                                if(position != "Manager")
                                {
                                    MessageBox.Show("Invalid password. You need manager permission to void items.", "Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                //insert void method here

                            }
                            else
                            {
                                MessageBox.Show("Password not found. Please try again or contact your manager.", "Password Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
