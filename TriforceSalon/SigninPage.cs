using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon
{
    public partial class SigninPage : UserControl
    {
        public SigninPage()
        {
            InitializeComponent();
            PasswordTxtbox.PasswordChar = '*';
        }

        public void SigninPage_Load(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            UsernameTxtbox.Text = "";
            PasswordTxtbox.Text = "";
            TogglePassword.Checked = false;
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxtbox.Text;
            string Password = PasswordTxtbox.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Kindly fill up all the information \nneeded, thank you.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Method.Login(Username, Password);
            Clear();
        }

        private void CreateAccountLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.ShowSignUp();
                    break;
                }
            }
            Clear();
        }

        private void TogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTxtbox.PasswordChar = TogglePassword.Checked ? '\0' : '*';
        }
    }
}
