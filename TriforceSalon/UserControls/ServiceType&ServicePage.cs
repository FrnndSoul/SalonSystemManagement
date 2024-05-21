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
        public static bool isFiltered = false;


        public ServiceType_ServicePage()
        {
            InitializeComponent();
            servicePageInstance = this;
            ServiceTypeControl serviceType = new ServiceTypeControl(this);
            UserControlNavigator.ShowControl(serviceType, ServiceManagementContainer);
        }

        private void SetButtonProperties(Guna.UI2.WinForms.Guna2Button button, Color fillColor, Color foreColor, Image image)
        {
            button.FillColor = fillColor;
            button.ForeColor = foreColor;
            button.Image = image;
        }

        public void GoToType()
        {
            isFiltered = false;
            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_type_icon__2_);
            ServiceTypeBtn.BringToFront();


            SetButtonProperties(ServiceBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceBtn.SendToBack();

            SetButtonProperties(ServiceSubTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceSubTypeBtn.SendToBack();


            ServiceTypeControl serviceType = new ServiceTypeControl(this);
            UserControlNavigator.ShowControl(serviceType, ServiceManagementContainer);
        }

        public void GoToCategory()
        {
            isFiltered = false;
            SetButtonProperties(ServiceSubTypeBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_icon);
            ServiceSubTypeBtn.BringToFront();

            SetButtonProperties(ServiceBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceBtn.SendToBack();

            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_type_black_icon);
            ServiceTypeBtn.SendToBack();

            ServiceSubTypeControl serviceSubType = new ServiceSubTypeControl(this);
            UserControlNavigator.ShowControl(serviceSubType, ServiceManagementContainer);
        }

        public void GoToVariation()
        {
            isFiltered = false;
            SetButtonProperties(ServiceBtn, Color.FromArgb(52, 42, 83), Color.White, Properties.Resources.service_icon);
            ServiceBtn.BringToFront();

            SetButtonProperties(ServiceTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_type_black_icon);
            ServiceTypeBtn.SendToBack();

            SetButtonProperties(ServiceSubTypeBtn, Color.FromArgb(255, 228, 242), Color.Black, Properties.Resources.service_black_icon);
            ServiceSubTypeBtn.SendToBack();


            ServiceVariationControl serviceVariation = new ServiceVariationControl();
            UserControlNavigator.ShowControl(serviceVariation, ServiceManagementContainer);
        }

        private void ServiceTypeBtn_Click(object sender, EventArgs e)
        {
            GoToType();
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            GoToVariation();
        }

        private void ServiceSubTypeBtn_Click(object sender, EventArgs e)
        {
            GoToCategory();
        }
    }
}
