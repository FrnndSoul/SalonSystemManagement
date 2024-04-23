using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
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
using TriforceSalon.Class_Components;
using TriforceSalon.Microsoft.VisualBasic;

namespace TriforceSalon.UserControls.Promo_Controls
{
    public partial class ViewPromosUserControls : UserControl
    {
        private string mysqlcon;
        PromoMethods promoMethods = new PromoMethods();
        PromoUserControl promoUserControl;

        //PromoUserControl transition = new PromoUserControl();
        public ViewPromosUserControls(PromoUserControl promoUserControl)
        {
            InitializeComponent();
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            this.promoUserControl = promoUserControl;
        }

        private async void ViewPromosUserControls_Load(object sender, EventArgs e)
        {
            await GetActivePromos(AllPromoProductsDGV);
        }

        public async Task GetActivePromos(Guna2DataGridView viewPromosDGV)
        {
            try
            {
                using (var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string fetchQuery = "SELECT PromoName, PromoCode, DiscountPercent, " +
                        "DATE(PromoStart) AS PromoStart, DATE(PromoEnd) AS PromoEnd, PromoItemsID, PromoType " +
                        "FROM salon_promos " +
                        "WHERE isValid = 'YES'";


                    using (MySqlCommand command = new MySqlCommand(fetchQuery, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            await adapter.FillAsync(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                var PName = row["PromoName"].ToString();
                                var PCode = row["PromoCode"].ToString();
                                var PDiscount = row["DiscountPercent"].ToString();
                                var PStart = row["PromoStart"].ToString();
                                var PEnd = row["PromoEnd"].ToString();
                                var PItemsID = row["PromoItemsID"].ToString();
                                var Ptype = row["PromoType"].ToString();

                                viewPromosDGV.Rows.Add(PName, PCode, Convert.ToDateTime(PStart).ToString("yyyy-MM-dd"),
                                    Convert.ToDateTime(PEnd).ToString("yyyy-MM-dd"), PDiscount, PItemsID, Ptype);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in GetActivePromos");
            }
        }

        private async void EditPromoBtn_Click(object sender, EventArgs e)
        {
            if (AllPromoProductsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = AllPromoProductsDGV.SelectedRows[0];
            string type = Convert.ToString(selectedRow.Cells["TypeCol"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to edit this promo?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                switch (type)
                {
                    case "Item":
                        promoUserControl.GoToProducts();
                        await Task.Delay(500);
                        promoMethods.EditProductPromo(AllPromoProductsDGV);
                        promoMethods.HideButtons(false, false, true, true);
                        break;
                    case "Service":
                        promoUserControl.GoToService();
                        await Task.Delay(500);
                        promoMethods.EditServicePromo(AllPromoProductsDGV);
                        promoMethods.SHideButtons(false, false, true, true);
                        break;
                    default:
                        MessageBox.Show("Invalid promo type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private async void AllPromoProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == BindedItemsCol.Index && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == BindedItemsCol.Index && e.RowIndex >= 0)
                {
                    long promoID = Convert.ToInt64(AllPromoProductsDGV.Rows[e.RowIndex].Cells["BindedItemsCol"].Value);
                    string type = Convert.ToString(AllPromoProductsDGV.Rows[e.RowIndex].Cells["TypeCol"].Value);


                    switch (type)
                    {
                        case "Item":
                            await Interaction.DisplayItems("Selected Items", "Items in the Promo:", promoID);
                            break;
                        case "Service":
                            await BindedServices.DisplayItems("Selected Services", "Services in the Promo:", promoID);
                            break;
                        default:
                            MessageBox.Show("Invalid promo type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        private async void DeactivePromoBtn_Click(object sender, EventArgs e)
        {
            if (AllPromoProductsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row for editing.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = AllPromoProductsDGV.SelectedRows[0];
            long ID = Convert.ToInt64(selectedRow.Cells["PromoCodeCol"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to edit this promo?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await promoMethods.DeactivatePromo(ID);
            }
        }
    }
}
