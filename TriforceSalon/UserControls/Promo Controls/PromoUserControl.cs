using System;
using System.Drawing;
using System.Windows.Forms;
using TriforceSalon.Class_Components;


namespace TriforceSalon.UserControls.Promo_Controls
{
    public partial class PromoUserControl : UserControl
    {
        public PromoUserControl()
        {
            InitializeComponent();
        }

        private void PromoUserControl_Load(object sender, EventArgs e)
        {
            PServicesUserControl servicePromo = new PServicesUserControl();
            UserControlNavigator.ShowControl(servicePromo, PromoContainer);
        }

        private void SetButtonProperties(Guna.UI2.WinForms.Guna2Button button, Color fillColor, Color foreColor)
        {
            button.FillColor = fillColor;
            button.ForeColor = foreColor;
        }

        private void PServiceBtn_Click(object sender, EventArgs e)
        {
            SetButtonProperties(PServiceBtn, Color.FromArgb(52, 42, 83), Color.White);
            PServiceBtn.BringToFront();

            SetButtonProperties(PProductsBtn, Color.FromArgb(255, 228, 242), Color.Black);
            PProductsBtn.SendToBack();

            PServicesUserControl servicesP = new PServicesUserControl();
            UserControlNavigator.ShowControl(servicesP, PromoContainer);

        }

        private void PProductsBtn_Click(object sender, EventArgs e)
        {
            SetButtonProperties(PProductsBtn, Color.FromArgb(52, 42, 83), Color.White);
            PProductsBtn.BringToFront();

            SetButtonProperties(PServiceBtn, Color.FromArgb(255, 228, 242), Color.Black);
            PProductsBtn.SendToBack();

            PItemsUserControls products = new PItemsUserControls();
            UserControlNavigator.ShowControl(products, PromoContainer);
        }
    }
}
