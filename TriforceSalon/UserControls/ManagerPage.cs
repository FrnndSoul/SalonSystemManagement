using sales_roject;
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
    public partial class ManagerPage : UserControl
    {
        public ManagerPage()
        {
            InitializeComponent();
            //generalView_Inventory1.Visible = true;
            GeneralView_Inventory viewInventory = new GeneralView_Inventory();
            UserControlNavigator.ShowControl(viewInventory, ManagerContent);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Method.LogOutUser();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    //mainForm.ShowLogin();
                    SigninPage signinPage = new SigninPage();
                    UserControlNavigator.ShowControl(signinPage, MainForm.mainFormInstance.MainFormContent);
                    break;
                }
            }
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            
            GeneralView_Inventory viewInventory = new GeneralView_Inventory();
            UserControlNavigator.ShowControl(viewInventory, ManagerContent);
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
          
            ServiceType_ServicePage serviceView = new ServiceType_ServicePage();
            UserControlNavigator.ShowControl(serviceView, ManagerContent);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            SalesUI sales = new SalesUI();
            UserControlNavigator.ShowControl(sales, ManagerContent);
        }
    }
}
