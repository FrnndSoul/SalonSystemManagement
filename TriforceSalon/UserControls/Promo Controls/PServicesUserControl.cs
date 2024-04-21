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
using TriforceSalon.UserControls.Promo_Controls.PromoRecords;

namespace TriforceSalon.UserControls.Promo_Controls
{
    public partial class PServicesUserControl : UserControl
    {
        private string mysqlcon;
        public static PServicesUserControl pServiceInstance;
        PromoMethods promo = new PromoMethods();
        ServiceFetchClass fetchServices = new ServiceFetchClass();

        public PServicesUserControl()
        {
            InitializeComponent();
            pServiceInstance = this;
            PStartDTP.Value = DateTime.Now;
            PEndDTP.Value = DateTime.Now;
            GenerateRandomNumber();
            SRecordsContainer.Visible = false;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        }

        private async void PServicesUserControl_Load(object sender, EventArgs e)
        {
            await fetchServices.LoadServices(ServiceFL, mysqlcon, ServiceDGV);
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

        private void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            promo.SHidePanel(false, true);
            promo.SHideButtons(true, true, false, false, false);

            UserControlNavigator.ClearPanel(SRecordsContainer);
        }

        private void EditAPromoBtn_Click(object sender, EventArgs e)
        {
            promo.SHideButtons(true, false, false, false, true);
            promo.SHidePanel(true, false);

            ServiceRecords Srecords = new ServiceRecords();
            UserControlNavigator.ShowControl(Srecords, SRecordsContainer);
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
                promo.SHideButtons(true, true, false, false, false);
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
                string percent = PercentageTxtB.Text;

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
            promo.SHidePanel(false, true);
            promo.SHideButtons(true, true, false, false, false);
            UserControlNavigator.ClearPanel(SRecordsContainer);
        }
    }
}
