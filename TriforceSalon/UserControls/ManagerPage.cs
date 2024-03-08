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
    public partial class ManagerPage : UserControl
    {
        public ManagerPage()
        {
            InitializeComponent();
            generalView_Inventory1.Visible = true;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Method.LogOutUser();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    //mainForm.ShowLogin();
                    break;
                }
            }
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            generalView_Inventory1.Visible = true;
            serviceType_ServicePage1.Visible = false;
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            serviceType_ServicePage1.Visible = true;
            generalView_Inventory1.Visible = false;
        }
    }
}
