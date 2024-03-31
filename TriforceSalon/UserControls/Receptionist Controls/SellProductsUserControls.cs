using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Data.Common;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
        private decimal discount = 0.00m;
        public SellProductsUserControls()
        {
            InitializeComponent();
            sellProductsUserControlsInstance = this;
            UpdateTotalPriceDelegate updateTotalPriceDelegate = UpdateTotalPrice;
            AddTotalPriceDelegate addTotalPriceDelegate = AddTotalPrice;
            sellMethods = new SellProductsMethods(updateTotalPriceDelegate, addTotalPriceDelegate);
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            //ProductsControlDGV.EditingControlShowing += ProductsControlDGV_EditingControlShowing;
            //ProductsControlDGV.CellValueChanged += ProductsControlDGV_CellValueChanged;
            DirectTransactionRBtn.Checked = true;
            CustomerIDComB.Enabled = false;

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
        /*private void ProductsControlDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (ProductsControlDGV.CurrentCell.ColumnIndex == ProductsControlDGV.Columns["DiscountComB"].Index && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }*/





        /*private void ProductsControlDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (ProductsControlDGV.CurrentCell.ColumnIndex == ProductsControlDGV.Columns["DiscountComB"].Index && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectionChangeCommitted -= new EventHandler(ComboBox_SelectedIndexChanged);
                comboBox.SelectionChangeCommitted += new EventHandler(ComboBox_SelectedIndexChanged);

                ComboBox_SelectedIndexChanged(comboBox, EventArgs.Empty);
            }
        }*/












        /*private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = 0.00m;
            discount = 0.00m;
            ComboBox comboBox = sender as ComboBox;
            string selectedValue = comboBox.SelectedItem.ToString();
            foreach (DataGridViewRow row in ProductsControlDGV.Rows)
            {
                if (selectedValue == "Discounted")
                {
                    discount = 0.00m; // Reset discount to recalculate

                    if (row.Cells[4].Value != null)
                    {
                        decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                        discount += DiscountFromProducts(rowTotal);
                    }

                }
                else
                {
                    discount = 0.00m; // No discount
                }
            }
            

            UpdateTotalPrice();
        }*/

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = 0.00m;
            discount = 0.00m;

            foreach (DataGridViewRow row in ProductsControlDGV.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                    decimal discountedPrice = rowTotal; // Default to original price

                    DataGridViewComboBoxCell comboBoxCell = row.Cells["DiscountComB"] as DataGridViewComboBoxCell;
                    if (comboBoxCell != null)
                    {
                        string selectedValue = comboBoxCell.Value.ToString();
                        if (selectedValue == "Discounted")
                        {
                            // Apply discount only if the product is marked as "Discounted"
                            discountedPrice = rowTotal - DiscountFromProducts(rowTotal);
                            discount += DiscountFromProducts(rowTotal);
                        }
                    }

                    totalPrice += discountedPrice;
                }
            }

            UpdateTotalPrice();
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

            //SubLbl.Text = "Php. " + totalPrice.ToString("0.00");


            /*if (discount > 0.00m)
            {
                decimal discountedTotal = totalPrice - discount;
                TotLbl.Text = "Php. " + discountedTotal.ToString("0.00");
                DiscLbl.Text = "Php. " + discount.ToString("0.00");
            }
            else
            {
                DiscLbl.Text = "Php. 0.00"; // No discount applied
                TotLbl.Text = SubLbl.Text;
            }*/
        }

        /*private void UpdateTotalPrice()
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

            if (discount > 0.00m)
            {
                decimal discountedTotal = totalPrice - discount;
                DiscLbl.Text = "Php. " + discount.ToString("0.00");
                TotLbl.Text = "Php. " + discountedTotal.ToString("0.00");
            }
            else
            {
                DiscLbl.Text = "Php. 0.00"; // No discount applied
                TotLbl.Text = SubLbl.Text;
            }
        }*/


        /*private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = 0.00m;
            discount = 0.00m;
            ComboBox comboBox = sender as ComboBox;
            string selectedValue = comboBox.SelectedItem.ToString();
            MessageBox.Show(selectedValue);

            if (selectedValue == "Discounted")
            {
                foreach (DataGridViewRow row in ProductsControlDGV.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                        decimal discountedPrice = rowTotal - DiscountFromProducts(rowTotal);
                        totalPrice += discountedPrice;
                        MessageBox.Show(discountedPrice.ToString());
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in ProductsControlDGV.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        totalPrice += decimal.Parse(row.Cells[4].Value.ToString());
                    }
                }
            }

            UpdateTotalPrice();
        }*/



        private async void ProductsControlDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ProductsControlDGV.Rows.Count)
            {
                DataGridViewCell clickedCell = ProductsControlDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "DisposeCol")
                {
                    DialogResult result = MessageBox.Show("Do you want to remove these item?", "Void Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

                                using (DbDataReader reader = await command.ExecuteReaderAsync())
                                {
                                    if (await reader.ReadAsync())
                                    {
                                        string position = reader["AccountAccess"].ToString();

                                        if (position != "Manager")
                                        {
                                            MessageBox.Show("Invalid password. You need manager permission to void items.", "Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                        else
                                        {
                                            decimal removedItemPrice = decimal.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["CostCol"].Value.ToString());
                                            ProductsControlDGV.Rows.RemoveAt(e.RowIndex);
                                            totalPrice -= removedItemPrice;
                                            UpdateTotalPrice();
                                            PaymentBtn.Enabled = false;
                                        }
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
                else if (e.ColumnIndex == ProductsControlDGV.Columns["IncrementCol"].Index)
                {
                    int currentQty = int.Parse(ProductsControlDGV.Rows[e.RowIndex].Cells["QuantityCol"].Value.ToString());
                    currentQty++;
                    ProductsControlDGV.Rows[e.RowIndex].Cells[2].Value = currentQty;
                    AddTotalPrice(e.RowIndex);
                    PaymentBtn.Enabled = false;
                }
                else if (e.ColumnIndex == ProductsControlDGV.Columns["DecrementCol"].Index)
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
        /*private decimal DiscountFromProducts(decimal rowTotal)
        {
            decimal discountRate = 0.20m; // 20% discount for senior citizens
            decimal vatRate = 0.12m; // 12% VAT in the Philippines

            // Compute the discount
            decimal discount = rowTotal * discountRate;

            // Compute the VAT
            decimal vat = rowTotal * vatRate;

            // Subtract the discount and VAT from the row total
            decimal discountedTotal = rowTotal - discount - vat;

            return discountedTotal;
        }*/

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
        /*private void UpdateTotalPrice() //NEW CODE
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

        }*/

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
            int orderID = transaction.GenerateTransactionID();
            PaymentBtn.Enabled = false;
            decimal cash = Convert.ToDecimal(CashTxtBx.Text);
            decimal extractedAmount = ExtractAmount(TotLbl.Text);
            try
            {
                if (DatabaseTransactionRBtn.Checked == false || CustomerIDComB == null || CustomerIDComB.SelectedIndex == -1)
                {
                    if (extractedAmount < cash)
                    {
                        if (CustomerNameTxtB.Text == null || CustomerNameTxtB.Text == "")
                        {
                            MessageBox.Show("Customer's name is required to proceed", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
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
                    //dito ialagat yung method na ialalgay muna sa database for single resibo nalang
                    int ID = Convert.ToInt32(CustomerIDComB.SelectedItem);
                    MessageBox.Show(Convert.ToString(ID));
                    await transaction.PurchaseToDatabase(Convert.ToInt32(ID), ProductsControlDGV);
                    transaction.ClearContents();
                }
            }
            catch(Exception ex)
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
                string enteredPassword = Method.HashString(Microsoft.VisualBasic.Interaction.InputBox("Enter manager password:", "Password Required", ""));

                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT se.AccountAccess, a.Password FROM salon_employees se JOIN accounts a ON se.AccountID = a.AccountID WHERE a.Password = @enteredPassword;";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@enteredPassword", enteredPassword);

                        using (DbDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string position = reader["AccountAccess"].ToString();

                                if (position != "Manager")
                                {
                                    MessageBox.Show("Invalid password. You need manager permission to void items.", "Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                await VoidedPurchase(orderID, ProductsControlDGV);
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
            VoidBtn.Enabled = true;
        }

        public async Task VoidedPurchase(int ID, Guna2DataGridView products)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

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
                        int itemid = await transaction.GetItemIdAsync(itemName);
                       
                        string query = "Insert into product_group (ProductGroupID, ProductName, ProductID, Quantity, Amount, EmployeeID, OrderDate, IsVoided) " +
                                        "values (@customerID, @productName, @productID, @quantity, @amount, @employeeID, @orderDate, @void)";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
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
                        //MessageBox.Show("Products has been sent to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   /* string insertQuery = "update customer_info set ProductsBoughtID = @customerID where TransactionID = @customerID";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@customerID", ID);
                        await command.ExecuteNonQueryAsync();
                    }
                    transaction.ClearContents();*/
                }
                MessageBox.Show("Products has been voided", "Void Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                products.Rows.Clear();
                SellProductsUserControls.sellProductsUserControlsInstance.CustomerNameTxtB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in PurchaseToDatabase");
            }
        }
        public decimal ExtractAmount(string input)
        {
            string pattern = @"₱\ (\d+(\.\d+)?)";

            // Match the pattern in the input string
            Match match = Regex.Match(input, pattern);

            // Check if a match is found
            if (match.Success)
            {
                // Extract the amount from the match
                string amountString = match.Groups[1].Value;

                // Convert the amount to a decimal
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

        }
        private void CalculateTotalPrice()
        {
            totalPrice = 0.00m;
            decimal discountedTotal = 0.00m;
            decimal normalTotal = 0.00m;

            foreach (DataGridViewRow row in ProductsControlDGV.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    decimal rowTotal = decimal.Parse(row.Cells[4].Value.ToString());
                    string selectedValue = row.Cells["DiscountComB"].Value.ToString();

                    if (selectedValue == "Discounted")
                    {
                        // Apply discount for discounted products
                        discountedTotal += rowTotal - DiscountFromProducts(rowTotal);
                    }
                    else
                    {
                        // Add original price for normal products
                        normalTotal += rowTotal;
                    }

                    totalPrice += rowTotal; // Add to total regardless
                }
            }

            // Update UI with totals
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

            ProductsControlDGV.Columns["DiscountComB"].Visible = false;
            CashTxtBx.Enabled = false;
            CalculateCostBtn.Enabled = false;
            CustomerNameTxtB.Enabled = false;
        }

        private void GcashPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
