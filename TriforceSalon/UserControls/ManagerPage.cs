using TriforceSalon;
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
using salesreport;
using Guna.UI2.WinForms;

namespace TriforceSalon.UserControls
{
    public partial class ManagerPage : UserControl
    {
        TransactionMethods transactionMethods = new TransactionMethods();
        public ManagerPage()
        {
            InitializeComponent();
            //generalView_Inventory1.Visible = true;
            GeneralView_Inventory viewInventory = new GeneralView_Inventory();
            UserControlNavigator.ShowControl(viewInventory, ManagerContent);
            InventoryBtn.Enabled = false;
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

        public void DisableButtons(bool choice)
        {
            InventoryBtn.Enabled = choice;
            ServicesBtn.Enabled = choice;
            ReportsBtn.Enabled = choice;
            LogoutBtn.Enabled = choice;
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            List<Guna2Button> NavigationButtons = new List<Guna2Button> { InventoryBtn, ServicesBtn, ReportsBtn };

            transactionMethods.LockTransactionNavigation(NavigationButtons, InventoryBtn);
            transactionMethods.EnableTransactionNavigation(NavigationButtons, InventoryBtn);

            GeneralView_Inventory viewInventory = new GeneralView_Inventory();
            UserControlNavigator.ShowControl(viewInventory, ManagerContent);
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            List<Guna2Button> NavigationButtons = new List<Guna2Button> { InventoryBtn, ServicesBtn, ReportsBtn };

            transactionMethods.LockTransactionNavigation(NavigationButtons, ServicesBtn);
            transactionMethods.EnableTransactionNavigation(NavigationButtons, ServicesBtn);

            ServiceType_ServicePage serviceView = new ServiceType_ServicePage();
            UserControlNavigator.ShowControl(serviceView, ManagerContent);
        }

        private async void ReportsBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Parent.Controls.Remove(this);

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    SalesForm sales = new SalesForm();
                    UserControlNavigator.ShowControl(sales, MainForm.mainFormInstance.MainFormContent);
                    break;
                }
            }
        }
    }
}
