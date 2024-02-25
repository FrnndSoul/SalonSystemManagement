using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.UserControls
{
    public partial class ManagerServices : UserControl
    {
        public static ManagerServices managerServicesInstance;
        public ManagerServices()
        {
            InitializeComponent();
            managerServicesInstance = this;
        }
    }
}
