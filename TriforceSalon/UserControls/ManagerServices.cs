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
    public partial class ManagerServices : UserControl
    {
        public static ManagerServices managerServicesInstance;
        private ServiceTypes serviceType = new ServiceTypes();
        public ManagerServices()
        {
            InitializeComponent();
            managerServicesInstance = this;
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
    }
}
