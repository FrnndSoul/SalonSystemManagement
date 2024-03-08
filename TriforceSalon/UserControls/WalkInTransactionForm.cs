﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
using TriforceSalon.Test;
using TriforceSalon.UserControls.Receptionist_Controls;

namespace TriforceSalon.UserControls
{
    public partial class WalkInTransactionForm : UserControl
    {
        public static WalkInTransactionForm walkInTransactionFormInstance;
        public PopulateDataGridView populateMethods = new PopulateDataGridView();
        private EventHandler<CustomerTicket.CustomerSelectedEventArgs> CustomerDetails;
        private RealTimeClock userClock;

        public WalkInTransactionForm()
        {
            InitializeComponent();
            walkInTransactionFormInstance = this;
            userClock = new RealTimeClock(TimerLbl, "dddd, dd MMMM yyyy (hh:mm:ss tt)");
        }

        private void WalkInTransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void RecepLogOutBtn_Click(object sender, EventArgs e)
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

        private void NPaymentBtn_Click(object sender, EventArgs e)
        {
            paymentsUserControls1.Visible = true;
            servicesUserControl1.Visible = false;
        }

        private void NServicesBtn_Click(object sender, EventArgs e)
        {
            paymentsUserControls1.Visible = false;
            servicesUserControl1.Visible = true;
        }
    }
}