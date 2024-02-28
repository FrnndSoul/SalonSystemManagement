using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.UserControls;

namespace TriforceSalon
{
    public partial class MainForm : Form
    {
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
            adminForm1.Visible = false;
            inventoryPage1.Visible = false;
            signinPage1.Visible = true;
            signUpForm1.Visible = false;
            walkInTransactionForm1.Visible = false;

        }

        public void ShowAdmin()
        {
            adminForm1.Visible = true;
            inventoryPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            walkInTransactionForm1.Visible = false;

        }

        public void ShowSignUp()
        {
            adminForm1.Visible = false;
            inventoryPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = true;
            walkInTransactionForm1.Visible = false;

        }

        public void ShowInventory()
        {
            adminForm1.Visible = false;
            inventoryPage1.Visible = true;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            walkInTransactionForm1.Visible = false;

        }

        public void ShowWalkIn()
        {
            adminForm1.Visible = false;
            inventoryPage1.Visible = false;
            signinPage1.Visible = false;
            signUpForm1.Visible = false;
            walkInTransactionForm1.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Method.LogOutUser();
        }
    }
}
