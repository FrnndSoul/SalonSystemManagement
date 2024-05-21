using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Promo_Controls
{
    public partial class PServicesUserControl : UserControl
    {
        private string mysqlcon;
        public static PServicesUserControl pServiceInstance;
        PromoMethods promo = new PromoMethods();
        ServiceFetchClass fetchServices = new ServiceFetchClass();
        PromoUserControl promoUserControl;

        public PServicesUserControl(PromoUserControl promoUserControl)
        {
            InitializeComponent();
            pServiceInstance = this;
            PStartDTP.Value = DateTime.Now;
            PEndDTP.Value = DateTime.Now;
            GenerateRandomNumber();
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            this.promoUserControl = promoUserControl;
        }

        private async void PServicesUserControl_Load(object sender, EventArgs e)
        {
            await promo.GetSubCategory(CategoryComBox);
        }
        private void GenerateRandomNumber()
        {
            Random rand = new Random();
            PromoCodeTxtB.Text = Convert.ToString(rand.Next(1000000, 9999999));
        }

        public void ClearAllInput()
        {
            ServiceDGV.Rows.Clear();
            PromoNameTxtB.Text = null;
            PercentageTxtB.Text = null;
            PromoCodeTxtB.Text = null;
            PStartDTP.Value = DateTime.Now;
            PEndDTP.Value = DateTime.Now;
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

            if (ServiceDGV.Rows.Count == 0)
            {
                MessageBox.Show("No items has been selected", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Is the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                long ID = Convert.ToInt64(IDLbl.Text);
                await promo.UpdateServiceBindedService(ID, ServiceDGV);
                await promo.CheckVoucherIsValid();
                ClearAllInput();
                GenerateRandomNumber();
                promo.SHideButtons(true, true, false, false);
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

            if (ServiceDGV.Rows.Count == 0)
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

                await promo.AddServicePromo(ServiceDGV, ID, startDate, endDate, percent, Pname);
                await promo.CheckVoucherIsValid();
                ClearAllInput();
                GenerateRandomNumber();
            }
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            ClearAllInput();
            GenerateRandomNumber();
            promo.SHideButtons(true, true, false, false);
            promoUserControl.GoToAll();
        }

        private async void CategoryComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = CategoryComBox.Text;
            await fetchServices.LoadServices(ServiceFL, mysqlcon, ServiceDGV, category);
        }

        private async void SearchProductsBtn_Click(object sender, EventArgs e)
        {
            string target = ProductSearchTxtB.Text;
            await fetchServices.LoadServicesForSearch(ServiceFL, mysqlcon, ServiceDGV, target);
        }

        private void PercentageTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            if (PercentageTxtB.TextLength >= 2 && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }

        private void ServiceDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < ServiceDGV.Rows.Count)
            {
                DataGridViewCell clickedCell = ServiceDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell.OwningColumn.Name == "RemoveCol")
                {
                    ServiceDGV.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
