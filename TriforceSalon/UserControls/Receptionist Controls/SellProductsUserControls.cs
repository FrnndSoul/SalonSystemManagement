using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.UserControls.Receptionist_Controls.Payment_Methods;
using static TriforceSalon.Class_Components.SellProductsMethods;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class SellProductsUserControls : UserControl
    {
        public static SellProductsUserControls sellProductsUserControlsInstance;
        TransactionMethods transaction = new TransactionMethods();
        Inventory inventoryMethods = new Inventory();
        SellProductsMethods sellMethods;
        private readonly PromoMethods promoMethods = new PromoMethods();
        private readonly string mysqlcon;
        private decimal totalPrice = 0.00m;
        private decimal discount = 0.00m;
        public SellProductsUserControls()
        {
            InitializeComponent();
            sellProductsUserControlsInstance = this;
            UpdateTotalPriceDelegate updateTotalPriceDelegate = UpdateTotalPrice;
            AddTotalPriceDelegate addTotalPriceDelegate = AddTotalPrice;
            sellMethods = new SellProductsMethods(updateTotalPriceDelegate, addTotalPriceDelegate);
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            DirectTransactionRBtn.Checked = true;
            CustomerIDComB.Enabled = false;
        }
        private async void SellProductsUserControls_Load(object sender, EventArgs e)
        {
            try
            {
                await sellMethods.LoadItemsInSales(ProductsFL, mysqlcon, ProductsControlDGV);
                await transaction.GetAllUnfinishedTickets();
                await promoMethods.GetActiveProductPromos(ItemPromoComB);
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
        private void UpdateTotalPrice()
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
        }

        private void ProductsControlDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ProductsControlDGV.Rows.Count)
            {
                DataGridViewCell clickedCell = ProductsControlDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "DisposeCol")
                {
                    string removedItemDiscountLabel = ProductsControlDGV.Rows[e.RowIndex].Cells["DiscountComB"].Value.ToString();
                    decimal removedItemDiscount;

                    if (removedItemDiscountLabel == "None")
                    {
                        decimal removedItemPrice = decimal.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["CostCol"].Value.ToString());
                        ProductsControlDGV.Rows.RemoveAt(e.RowIndex);
                        totalPrice -= removedItemPrice;
                    }
                    else if (removedItemDiscountLabel == "Senior/PWD")
                    {
                        decimal removedItemPrice = decimal.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["CostCol"].Value.ToString());
                        ProductsControlDGV.Rows.RemoveAt(e.RowIndex);
                        totalPrice -= removedItemPrice;
                    }
                    else if (decimal.TryParse(removedItemDiscountLabel, out removedItemDiscount))
                    {
                        for (int i = 0; i < ProductsControlDGV.Rows.Count; i++)
                        {
                            decimal currentDiscount;
                            if (decimal.TryParse(ProductsControlDGV.Rows[i].Cells["DiscountComB"].Value.ToString(), out currentDiscount))
                            {
                                if (currentDiscount == removedItemDiscount)
                                {
                                    decimal currentItemPrice = decimal.Parse(ProductsControlDGV.Rows[i].Cells["CostCol"].Value.ToString());
                                    totalPrice -= currentItemPrice;
                                    ProductsControlDGV.Rows.RemoveAt(i);
                                    ItemPromoComB.Text = null;
                                    PromoTxtB.Text = null;
                                    ActivateBtn.Enabled = true;
                                    i--; 
                                }
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == ProductsControlDGV.Columns["IncrementCol"].Index && ProductsControlDGV.Rows[e.RowIndex].Cells["DiscountComB"].Value.ToString() == "None")
                {
                    int currentQty = int.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    currentQty++;
                    ProductsControlDGV.Rows[e.RowIndex].Cells[2].Value = currentQty;
                    AddTotalPrice(e.RowIndex);
                    PaymentBtn.Enabled = false;
                }
                else if (e.ColumnIndex == ProductsControlDGV.Columns["DecrementCol"].Index && ProductsControlDGV.Rows[e.RowIndex].Cells["DiscountComB"].Value.ToString() == "None")
                {
                    int currentQty = int.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    SubtractTotalPrice(e.RowIndex);
                    PaymentBtn.Enabled = false;
                }
            }
        }

        private decimal DiscountFromProducts(decimal amount)
        {
            decimal VAT = amount * 0.12m;
            decimal PriceWithoutVAT = amount - VAT;
            decimal discountPrice = PriceWithoutVAT * 0.20m;
            return discountPrice + VAT;
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

            if (sender is TextBox textBox)
            {
                // Allow digits, control characters, and a single period
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // Allow the backspace key
                if (e.KeyChar == '\b')
                {
                    return;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    ValidateCashTextbox();
                }

                // Prevent multiple periods
                if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
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
            int orderID = transaction.GenerateTransactionID();
            PaymentBtn.Enabled = false;

            try
            {
                if (DatabaseTransactionRBtn.Checked == false || CustomerIDComB == null || CustomerIDComB.SelectedIndex == -1)
                {
                    decimal cash = Convert.ToDecimal(CashTxtBx.Text);
                    decimal extractedAmount = ExtractAmount(TotLbl.Text);

                    if (extractedAmount <= cash)
                    {
                        if (CustomerNameTxtB.Text == null || CustomerNameTxtB.Text == "")
                        {
                            MessageBox.Show("Customer's name is required to proceed", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            MessageBox.Show($"Customer's change: {cash - extractedAmount}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await transaction.PurchaseToReceipt(orderID, ProductsControlDGV);
                            transaction.ClearContents();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Amount Entered", " Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else if (DatabaseTransactionRBtn.Checked == true)
                {
                    int ID = Convert.ToInt32(CustomerIDComB.SelectedItem);
                    await transaction.PurchaseToDatabase(Convert.ToInt32(ID), ProductsControlDGV);
                    transaction.ClearContents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operation Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                PaymentBtn.Enabled = true;
            }
        }

        private async void VoidBtn_Click(object sender, EventArgs e)
        {
            VoidBtn.Enabled = false;

            int orderID = transaction.GenerateTransactionID();
            DialogResult result = MessageBox.Show("Do you want to void these items?", "Void Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await VoidedPurchase(orderID, ProductsControlDGV);
            }
            VoidBtn.Enabled = true;
        }

       
        public async Task VoidedPurchase(int ID, Guna2DataGridView products)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    // Start a transaction
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            var transactionMethod = new TransactionMethods();
                            foreach (DataGridViewRow row in products.Rows)
                            {
                                string itemName;
                                if (row.Cells["ProductCol"].Value != null)
                                {
                                    itemName = row.Cells["ProductCol"].Value.ToString();
                                }
                                else
                                {
                                    continue;
                                }

                                int qty = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                                decimal amount = Convert.ToDecimal(row.Cells["CostCol"].Value);
                                int itemid = await transactionMethod.GetItemIdAsync(itemName);

                                string query = "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, EmployeeID, OrderDate, IsVoided) " +
                                                "values (@customerID, @productName, @productID, @quantity, @amount, @employeeID, @orderDate, @void)";

                                using (MySqlCommand command = new MySqlCommand(query, conn, transaction))
                                {
                                    command.Parameters.AddWithValue("@customerID", ID);
                                    command.Parameters.AddWithValue("@productName", itemName);
                                    command.Parameters.AddWithValue("@productID", itemid);
                                    command.Parameters.AddWithValue("@quantity", qty);
                                    command.Parameters.AddWithValue("@amount", amount);
                                    command.Parameters.AddWithValue("@employeeID", Method.AccountID);
                                    command.Parameters.AddWithValue("@orderDate", DateTime.Now);
                                    command.Parameters.AddWithValue("@void", "YES");

                                    await command.ExecuteNonQueryAsync();
                                }
                            }

                            if (Method.AdminAccess())
                            {
                                transaction.Rollback();
                                MessageBox.Show("Customer process working as intended", "Voided Purchase function", MessageBoxButtons.OK);
                            }
                            else
                            {
                                transaction.Commit();
                                MessageBox.Show("Product/s have been voided", "Void Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // Clear the products grid and reset customer name
                            products.Rows.Clear();
                            SellProductsUserControls.sellProductsUserControlsInstance.CustomerNameTxtB.Text = "";
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error in VoidedPurchase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal ExtractAmount(string input)
        {
            string pattern = @"₱\ (\d+(\.\d+)?)";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                string amountString = match.Groups[1].Value;

                if (decimal.TryParse(amountString, out decimal extractedAmount))
                {
                    return extractedAmount;
                }
                else
                {
                    throw new ArgumentException("Failed to parse amount.");
                }
            }
            else
            {
                throw new ArgumentException("Pattern not found in input string.");
            }
        }

        private void CalculateCostBtn_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
            PaymentBtn.Enabled = true;
            guna2Button1.Enabled = true;
            GcashPayment.Enabled = true;

        }
       
        private void CalculateTotalPrice()
        {
            totalPrice = 0.00m;
            decimal discountedTotal = 0.00m;
            decimal normalTotal = 0.00m;

            foreach (DataGridViewRow row in ProductsControlDGV.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells["DiscountComB"].Value.ToString() != "None")
                {
                    decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                    string discountValue = row.Cells["DiscountComB"].Value.ToString();

                    if (decimal.TryParse(discountValue, out decimal discountAmount))
                    {
                        // Apply discount for items with a decimal discount
                        decimal discountedPrice = rowTotal * (1 - discountAmount);
                        discountedTotal += discountedPrice;
                    }
                    else if(discountValue == "Senior/PWD")
                    {
                        decimal discountedPrice = rowTotal - DiscountFromProducts(rowTotal);
                        discountedTotal += discountedPrice;
                    }
                    else
                    {
                        normalTotal += rowTotal;
                    }
                }
                else
                {
                    decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                    normalTotal += rowTotal;
                }
                totalPrice += decimal.Parse(row.Cells[4].Value.ToString());
            }

            SubLbl.Text = "₱ " + totalPrice.ToString("0.00");
            TotLbl.Text = "₱ " + (discountedTotal + normalTotal).ToString("0.00");
            DiscLbl.Text = "₱ " + (totalPrice - (discountedTotal + normalTotal)).ToString("0.00");
        }

        private void DirectTransactionRBtn_CheckedChanged(object sender, EventArgs e)
        {
            CustomerIDComB.Enabled = false;

            ProductsControlDGV.Columns["DiscountComB"].Visible = true;
            CashTxtBx.Enabled = true;
            CalculateCostBtn.Enabled = true;
            CustomerNameTxtB.Enabled = true;
        }

        private void DatabaseTransactionRBtn_CheckedChanged(object sender, EventArgs e)
        {
            CustomerIDComB.Enabled = true;

            CashTxtBx.Enabled = false;
            CalculateCostBtn.Enabled = false;
            CustomerNameTxtB.Enabled = false;
            PaymentBtn.Enabled = true;
        }

        private void GcashPayment_Click(object sender, EventArgs e)
        {
            Gcash2 gcash = new Gcash2();
            UserControlNavigator.ShowControl(gcash, OtherTransactionContainer);

            AllProductsBtn.Visible = false;
            ProductsFL.Visible = false;
            SearchProductsBtn.Visible = false;
            ProductSearchTxtB.Visible = false;

            OtherTransactionContainer.Visible = true;
            guna2HtmlLabel12.Visible = true;
            BackBtn.Visible = true;
        }

        private void CustomerNameTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, space, and backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            // Check if the length exceeds the maximum allowed length (30 characters)
            if (CustomerNameTxtB.Text.Length >= 30 && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AllProductsBtn.Visible = true;
            ProductsFL.Visible = true;
            SearchProductsBtn.Visible = true;
            ProductSearchTxtB.Visible = true;

            OtherTransactionContainer.Visible = false;
            guna2HtmlLabel12.Visible = false;
            BackBtn.Visible = false;
        }

        private void PromoTxtB_TextChanged(object sender, EventArgs e)
        {
            if (PromoTxtB.Text.Length == 7)
            {
                ActivateBtn.Enabled = true;
            }
            else if (PromoTxtB.Text.Length > 7)
            {
                PromoTxtB.Text = PromoTxtB.Text.Substring(0, 7);
                PromoTxtB.SelectionStart = 7;
            }
            else if (PromoTxtB.Text.Length < 7)
            {
                ActivateBtn.Enabled = false;
            }
        }

        private async void ActivateBtn_Click(object sender, EventArgs e)
        {
            string promoName = ItemPromoComB.Text;
            await promoMethods.GetPromoCode(promoName, PromoTxtB);
            string promoInput = PromoTxtB.Text.Substring(0, 7);

            if (int.TryParse(promoInput, out int promoCode))
            {
                var promoDetails = sellMethods.GetPromoDetails(promoCode, mysqlcon);

                if (promoDetails.isValid == "YES")
                {
                    var itemDetails = sellMethods.GetItemDetails(promoCode, mysqlcon);

                    // Check if any of the items from the promo are already present in the DataGridView
                    bool itemsAlreadyAdded = false;
                    foreach (var item in itemDetails)
                    {
                        foreach (DataGridViewRow row in ProductsControlDGV.Rows)
                        {
                            if (row.Cells["ProductCol"].Value != null && row.Cells["ProductCol"].Value.ToString() == item.ItemName && row.Cells["DiscountComB"].Value != "None")
                            {
                                itemsAlreadyAdded = true;
                                break;
                            }
                        }
                        if (itemsAlreadyAdded)
                            break; 
                    }

                    if (!itemsAlreadyAdded)
                    {
                        foreach (var item in itemDetails)
                        {
                            ProductsControlDGV.Rows.Add(item.ItemName, "", item.Quantity, "", item.Cost, item.Discount.ToString(), "X");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Promo items are already added.");
                    }

                    PromoTxtB.Clear();
                }
                else if (promoDetails.isValid == "NO")
                {
                    MessageBox.Show($"Promo Code {promoDetails.promoCode} is not available right now.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid promo code.");
                }
            }
        }

        private void ProductsControlDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked cell is in the "DiscountComB" column and the row index is valid
            if (e.ColumnIndex == ProductsControlDGV.Columns["DiscountComB"].Index && e.RowIndex >= 0)
            {
                var cell = ProductsControlDGV.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewTextBoxCell;

                if (cell != null)
                {
                    // Get the current value of the cell
                    string currentValue = cell.Value?.ToString() ?? "None";

                    // Determine the next value to set
                    string nextValue = currentValue == "Senior/PWD" ? "None" : "Senior/PWD";

                    // Update the cell value
                    cell.Value = nextValue;
                }
            }
        }
    }
}
