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

namespace TriforceSalon.UserControls
{
    public partial class ServiceType_ServicePage : UserControl
    {
        public static ManagerServices managerServicesInstance;
        private ServiceTypes serviceType = new ServiceTypes();
        private SalonServices salonServices = new SalonServices();

        public ServiceType_ServicePage()
        {
            InitializeComponent();
        }

        private void SetButtonProperties(Guna.UI2.WinForms.Guna2Button button, Color fillColor, Color foreColor, Image image)
        {
            button.FillColor = fillColor;
            button.ForeColor = foreColor;
            button.Image = image;
        }

        private void ServiceTypeBtn_Click(object sender, EventArgs e)
        {
            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_type_icon__2_);
            ServiceTypeBtn.BringToFront();
            ServiceTypePanel.Visible = true;

            SetButtonProperties(ServiceBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceBtn.SendToBack();
            ServicePanel.Visible = false;
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            SetButtonProperties(ServiceBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_icon);
            ServiceBtn.BringToFront();
            ServicePanel.Visible = true;

            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_type_black_icon);
            ServiceTypeBtn.SendToBack();
            ServiceTypePanel.Visible = false;
        }


        //For service type
        private void AddServiceTypeBtn_Click(object sender, EventArgs e)
        {
            string serviceTypeName = ServiceTypeTxtB.Text;
            serviceType.AddServiceType(serviceTypeName);
        }

        private void AddImageServiceTypeBtn_Click(object sender, EventArgs e)
        {
            serviceType.AddServiceTypeImage();

        }

        private void UpdateServiceTBtn_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt32(ServiceTypeDGV.SelectedRows[0].Cells["ServiceID"].Value);
            serviceType.UpdateServiceType(sID);
        }

        private void EditServiceTBtn_Click(object sender, EventArgs e)
        {
            serviceType.EditServiceTypes();

        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            serviceType.ClearServiceTypes();
        }


        //For services
        private void AddServiceImageBtn_Click(object sender, EventArgs e)
        {
            salonServices.AddServiceImage();
        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            string serviceTypeName = AddSalonServices.SelectedItem.ToString();
            salonServices.GetServiceTypeID(serviceTypeName);
            salonServices.AddSalonServices();
        }

        private void UpdateServBtn_Click(object sender, EventArgs e)
        {
            int servarID = Convert.ToInt32(SalonServicesDGV.SelectedRows[0].Cells["ServiceVariationID"].Value);
            salonServices.UpdateSalonServices(servarID);
        }

        private void EditServBtn_Click(object sender, EventArgs e)
        {
            salonServices.EditSalonServices();
        }

        private void CancelEditServiceBtn_Click(object sender, EventArgs e)
        {
            salonServices.ClearServices();
        }
    }
}
