using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.UserControls.Service_Controls;

namespace TriforceSalon.UserControls
{
    public partial class ServiceType_ServicePage : UserControl
    {
        ManagerPage manager = new ManagerPage();
        public static ServiceType_ServicePage servicePageInstance;
        

        public ServiceType_ServicePage()
        {
            InitializeComponent();
            servicePageInstance = this;
            ServiceTypeControl serviceType = new ServiceTypeControl();
            UserControlNavigator.ShowControl(serviceType, ServiceManagementContainer);
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
            

            SetButtonProperties(ServiceBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceBtn.SendToBack();

            ServiceTypeControl serviceType = new ServiceTypeControl();
            UserControlNavigator.ShowControl(serviceType, ServiceManagementContainer);
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            SetButtonProperties(ServiceBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_icon);
            ServiceBtn.BringToFront();

            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_type_black_icon);
            ServiceTypeBtn.SendToBack();

            ServiceVariationControl serviceVariation = new ServiceVariationControl();
            UserControlNavigator.ShowControl(serviceVariation, ServiceManagementContainer);
        }
    }
}
