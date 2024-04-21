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

namespace TriforceSalon.UserControls.Promo_Controls.PromoRecords
{
    public partial class ServiceRecords : UserControl
    {
        PromoMethods promoMethods = new PromoMethods();

        public ServiceRecords()
        {
            InitializeComponent();
        }

        private async void ServiceRecords_Load(object sender, EventArgs e)
        {
            await promoMethods.GetActiveServicePromos(PromoProductsDGV);

        }
        private void EditPromoBtn_Click(object sender, EventArgs e)
        {
            promoMethods.EditServicePromo(PromoProductsDGV);
            promoMethods.SHidePanel(false, true);

            UserControlNavigator.ClearPanel(PServicesUserControl.pServiceInstance.SRecordsContainer);

            ServiceRecords Srecords = new ServiceRecords();
            UserControlNavigator.ShowControl(Srecords, PServicesUserControl.pServiceInstance.SRecordsContainer);
            promoMethods.SHideButtons(false, false, true, true, false);
        }
    }
}
