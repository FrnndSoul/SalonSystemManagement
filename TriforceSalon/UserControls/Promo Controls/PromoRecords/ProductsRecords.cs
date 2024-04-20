using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Promo_Controls.PromoRecords
{
    public partial class ProductsRecords : UserControl
    {
        PromoMethods promoMethods = new PromoMethods();
        public ProductsRecords()
        {
            InitializeComponent();
        }

        private async void ProductsRecords_Load(object sender, EventArgs e)
        {
            await promoMethods.GetActivePromos(PromoProductsDGV);
        }

        private async void EditPromoBtn_Click(object sender, EventArgs e)
        {
            promoMethods.EditProductPromo(PromoProductsDGV);
            PItemsUserControls.Pitemsinstance.UpdatePromoBtn.Visible = true;
            PItemsUserControls.Pitemsinstance.DiscardBtn.Visible = true;
            PItemsUserControls.Pitemsinstance.EditAPromoBtn.Visible = false;
            PItemsUserControls.Pitemsinstance.AddPromoBtn.Visible = false;
        }
    }
}
