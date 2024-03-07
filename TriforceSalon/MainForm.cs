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
using TriforceSalon.UserControls;

namespace TriforceSalon
{
    public partial class MainForm : Form
    {
        EmployeeUserConrols emp = new EmployeeUserConrols();
        TransactionMethods transactionMethods = new TransactionMethods();
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SigninPage1_Load(object sender, EventArgs e)
        {

        }

        public void ShowLogin()
        {
            walkInTransactionForm1.Visible = false;
            adminForm1.Visible = false;
            managerPage1.Visible = false;
            signinPage1.Visible = true;
            signUpForm1.Visible = false;
            employeeUserConrols1.Visible = false;
        }

        public void ShowAdmin()
        {
            walkInTransactionForm1.Visible = false;
            adminForm1.Visible = true;
            managerPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            employeeUserConrols1.Visible = false;
        }

        public void ShowSignUp()
        {
            walkInTransactionForm1.Visible = false;
            adminForm1.Visible = false;
            managerPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = true;
            employeeUserConrols1.Visible = false;
        }

        public void ShowManager()
        {
            walkInTransactionForm1.Visible = false;
            adminForm1.Visible = false;
            managerPage1.Visible = true;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            employeeUserConrols1.Visible = false;
        }

        public void ShowWalkIn()
        {
            walkInTransactionForm1.Visible = true;
            adminForm1.Visible = false;
            managerPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            employeeUserConrols1.Visible = false;
        }
        public void ShowEmployee()
        {
            emp.LoadCustomers(transactionMethods.GetServiceTypeName(Method.ServiceID));
            walkInTransactionForm1.Visible = false;
            adminForm1.Visible = false;
            managerPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            employeeUserConrols1.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Method.LogOutUser();
        }
    }
}
