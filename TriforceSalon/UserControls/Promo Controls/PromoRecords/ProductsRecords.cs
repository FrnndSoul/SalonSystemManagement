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
            promoMethods.HidePanel(false, true);

            /*PItemsUserControls.Pitemsinstance.ProductContainer.Visible = true;
            PItemsUserControls.Pitemsinstance.RecordsContainer.Visible = false;*/
            UserControlNavigator.ClearPanel(PItemsUserControls.Pitemsinstance.RecordsContainer);

            ProductsRecords Precords = new ProductsRecords();
            UserControlNavigator.ShowControl(Precords, PItemsUserControls.Pitemsinstance.RecordsContainer);
            promoMethods.HideButtons(false,false,true,true,false);
        }
    }
}
