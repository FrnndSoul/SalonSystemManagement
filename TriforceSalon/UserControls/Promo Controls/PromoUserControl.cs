using System;
using System.Drawing;
using System.Windows.Forms;
using TriforceSalon.Class_Components;


namespace TriforceSalon.UserControls.Promo_Controls
{
    public partial class PromoUserControl : UserControl
    {
        public static PromoUserControl promoInstance;

        public PromoUserControl()
        {
            InitializeComponent();
            promoInstance = this;
        }

        private void PromoUserControl_Load(object sender, EventArgs e)
        {
            ViewPromosUserControls allPromos = new ViewPromosUserControls(this);
            UserControlNavigator.ShowControl(allPromos, PromoContainer);
        }

        private void SetButtonProperties(Guna.UI2.WinForms.Guna2Button button, Color fillColor, Color foreColor)
        {
            button.FillColor = fillColor;
            button.ForeColor = foreColor;
        }
        public void GoToAll()
        {
            SetButtonProperties(ActivePromosBtn, Color.FromArgb(52, 42, 83), Color.White);
            ActivePromosBtn.BringToFront();

            SetButtonProperties(PProductsBtn, Color.FromArgb(255, 228, 242), Color.Black);
            PProductsBtn.SendToBack();

            SetButtonProperties(PServiceBtn, Color.FromArgb(255, 228, 242), Color.Black);
            PServiceBtn.SendToBack();

            ViewPromosUserControls allPromos = new ViewPromosUserControls(this);
            UserControlNavigator.ShowControl(allPromos, PromoContainer);
        }

        public void GoToService()
        {
            SetButtonProperties(PServiceBtn, Color.FromArgb(52, 42, 83), Color.White);
            PServiceBtn.BringToFront();

            SetButtonProperties(PProductsBtn, Color.FromArgb(255, 228, 242), Color.Black);
            PProductsBtn.SendToBack();

            SetButtonProperties(ActivePromosBtn, Color.FromArgb(255, 228, 242), Color.Black);
            ActivePromosBtn.SendToBack();

            PServicesUserControl servicesP = new PServicesUserControl(this);
            UserControlNavigator.ShowControl(servicesP, PromoContainer);
        }

        public void GoToProducts()
        {
            SetButtonProperties(PProductsBtn, Color.FromArgb(52, 42, 83), Color.White);
            PProductsBtn.BringToFront();

            SetButtonProperties(ActivePromosBtn, Color.FromArgb(255, 228, 242), Color.Black);
            ActivePromosBtn.SendToBack();

            SetButtonProperties(PServiceBtn, Color.FromArgb(255, 228, 242), Color.Black);
            PServiceBtn.SendToBack();

            PItemsUserControls products = new PItemsUserControls(this);
            UserControlNavigator.ShowControl(products, PromoContainer);
        }


        private void ActivePromosBtn_Click(object sender, EventArgs e)
        {

            GoToAll();

        }

        private void PServiceBtn_Click(object sender, EventArgs e)
        {

            GoToService();

        }

        private void PProductsBtn_Click(object sender, EventArgs e)
        {
           
            GoToProducts();
        }
    }
}
