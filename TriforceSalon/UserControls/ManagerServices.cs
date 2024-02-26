using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls
{
    public partial class ManagerServices : UserControl
    {
        public static ManagerServices managerServicesInstance;
        private ServiceTypes serviceType = new ServiceTypes();
        public ManagerServices()
        {
            InitializeComponent();
            managerServicesInstance = this;
            serviceType.ServiceTypeInfoDGV();
        }

        private void AddImageServiceTypeBtn_Click(object sender, EventArgs e)
        {
            serviceType.AddServiceTypeImage();
        }

        private void AddServiceTypeBtn_Click(object sender, EventArgs e)
        {
            string serviceTypeName = ServiceTypeTxtB.Text;
            serviceType.AddServiceType(serviceTypeName);
        }

        private void EditServiceTBtn_Click(object sender, EventArgs e)
        {
            serviceType.EditServiceTypes();
        }
    }
}
