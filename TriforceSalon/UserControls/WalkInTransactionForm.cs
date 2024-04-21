using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Test;
using TriforceSalon.UserControls.Receptionist_Controls;

namespace TriforceSalon.UserControls
{
    public partial class WalkInTransactionForm : UserControl
    {
        TransactionMethods transactionM = new TransactionMethods();
        public static WalkInTransactionForm walkInTransactionFormInstance;
        public PopulateDataGridView populateMethods = new PopulateDataGridView();
        private EventHandler<CustomerTicket.CustomerSelectedEventArgs> CustomerDetails;
        private RealTimeClock userClock;
        public WalkInTransactionForm()
        {
            InitializeComponent();
            walkInTransactionFormInstance = this;
            userClock = new RealTimeClock(TimerLbl, "dddd, dd MMMM yyyy (hh:mm:ss tt)");

            ServicesUserControl serviecUC = new ServicesUserControl();
            UserControlNavigator.ShowControl(serviecUC, ReceptionistContent);

            if(Method.isManager == false || Method.AdminAccess())
            {
                ManagerBackBtn.Visible = false;
            }
            else if(Method.isManager == true)
            {
                ManagerBackBtn.Visible = true;
            }
        }

        private void WalkInTransactionForm_Load(object sender, EventArgs e)
        {
            NServicesBtn.Enabled = false;
        }

        private void RecepLogOutBtn_Click(object sender, EventArgs e)
        {
            Method.isManager = false;
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

        private void NPaymentBtn_Click(object sender, EventArgs e)
        {
            List<Guna2Button> NavigationButtons = new List<Guna2Button> { NServicesBtn, NPaymentBtn, NSellProdBtn, NAppointmentsBtn };

            transactionM.LockTransactionNavigation(NavigationButtons, NPaymentBtn);
            transactionM.EnableTransactionNavigation(NavigationButtons, NPaymentBtn);

            PaymentsUserControls paymentUC = new PaymentsUserControls();
            UserControlNavigator.ShowControl(paymentUC, ReceptionistContent);
        }

        private void NServicesBtn_Click(object sender, EventArgs e)
        {
            List<Guna2Button> NavigationButtons = new List<Guna2Button> { NServicesBtn, NPaymentBtn, NSellProdBtn, NAppointmentsBtn };

            transactionM.LockTransactionNavigation(NavigationButtons, NServicesBtn);
            transactionM.EnableTransactionNavigation(NavigationButtons, NServicesBtn);

            ServicesUserControl serviecUC = new ServicesUserControl();
            UserControlNavigator.ShowControl(serviecUC, ReceptionistContent);
        }

        private void NSellProdBtn_Click(object sender, EventArgs e)
        {
            List<Guna2Button> NavigationButtons = new List<Guna2Button> { NServicesBtn, NPaymentBtn, NSellProdBtn, NAppointmentsBtn };

            transactionM.LockTransactionNavigation(NavigationButtons, NSellProdBtn);
            transactionM.EnableTransactionNavigation(NavigationButtons, NSellProdBtn);

            SellProductsUserControls sellProducts = new SellProductsUserControls();
            UserControlNavigator.ShowControl(sellProducts, ReceptionistContent);
        }

        private void NAppointmentsBtn_Click(object sender, EventArgs e)
        {
            List<Guna2Button> NavigationButtons = new List<Guna2Button> { NServicesBtn, NPaymentBtn, NSellProdBtn, NAppointmentsBtn };

            transactionM.LockTransactionNavigation(NavigationButtons, NAppointmentsBtn);
            transactionM.EnableTransactionNavigation(NavigationButtons, NAppointmentsBtn);

            AppointmentsUserControls appointment = new AppointmentsUserControls();
            UserControlNavigator.ShowControl(appointment, ReceptionistContent);
        }

        private void ManagerBackBtn_Click(object sender, EventArgs e)
        {
            ManagerPage managerPage = new ManagerPage();
            UserControlNavigator.ShowControl(managerPage, MainForm.mainFormInstance.MainFormContent);
        }
    }
}