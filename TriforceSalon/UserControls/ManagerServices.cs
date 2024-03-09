using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls
{
    public partial class ManagerServices : UserControl
    {
        public static ManagerServices managerServicesInstance;
        private ServiceTypes serviceType = new ServiceTypes();
        private SalonServices salonServices = new SalonServices();
        public ManagerServices()
        {
            InitializeComponent();
            managerServicesInstance = this;
            /*serviceType.ServiceTypeInfoDGV();
            salonServices.PopulateServiceType();
            salonServices.GetSalonServices();*/
        }

        private void AddImageServiceTypeBtn_Click(object sender, EventArgs e)
        {
            serviceType.AddServiceTypeImage();
        }

        private async void AddServiceTypeBtn_Click(object sender, EventArgs e)
        {
            string serviceTypeName = ServiceTypeTxtB.Text;
            await serviceType.AddServiceType(serviceTypeName);
        }

        public void Clear()
        {
            ServiceTypeTxtB.Text = "";
        }

        private void EditServiceTBtn_Click(object sender, EventArgs e)
        {
            serviceType.EditServiceTypes();
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void EditServBtn_Click(object sender, EventArgs e)
        {
            salonServices.EditSalonServices();
        }

        private async void UpdateServBtn_Click(object sender, EventArgs e)
        {
            int servarID = Convert.ToInt32(SalonServicesDGV.SelectedRows[0].Cells["ServiceVariationID"].Value);
            await salonServices.UpdateSalonServices(servarID);
        }

        private async void UpdateServiceTBtn_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt32(ServiceTypeDGV.SelectedRows[0].Cells["ServiceID"].Value);
            await serviceType.UpdateServiceType(sID);
        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            serviceType.ClearServiceTypes();
        }

        private void CancelEditServiceBtn_Click(object sender, EventArgs e)
        {
            salonServices.ClearServices();
        }

        private void AddServiceImageBtn_Click(object sender, EventArgs e)
        {
            salonServices.AddServiceImage();
        }

        private async void AddServiceBtn_Click(object sender, EventArgs e)
        {
            string serviceTypeName = AddSalonServices.SelectedItem.ToString();
            salonServices.GetServiceTypeID(serviceTypeName);
            await salonServices.AddSalonServices();
        }
    }
}
