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
        }

        public void SigninPage_Load(object sender, EventArgs e)
        {
            UsernameTxtbox.Text = "";
            PasswordTxtbox.Text = "";
            TogglePassword.Checked = false;
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            string Username = UsernameTxtbox.Text;
            string Password = PasswordTxtbox.Text;
            if (Method.Login(Username, Password))
            {
                MessageBox.Show("Hi");
                return;
            }
            this.Hide();
        }
    }
}
