using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon
{
    public partial class SigninPage : UserControl
    {

        public static SigninPage signinInstatnce;
        public SigninPage()
        {
            InitializeComponent();
            signinInstatnce = this;
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

        private void TogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTxtbox.PasswordChar = TogglePassword.Checked ? '\0' : '*';
        }

        private async void SigninBtn_Click_1(object sender, EventArgs e)
        {
            if (UsernameTxtbox.ReadOnly == true || PasswordTxtbox.ReadOnly == true)
            {
                return;
            }

            UsernameTxtbox.ReadOnly = true;
            PasswordTxtbox.ReadOnly = true;

            await Task.Delay(1000);

            string Username = UsernameTxtbox.Text;
            string Password = PasswordTxtbox.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Kindly fill up all the information \nneeded, thank you.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernameTxtbox.ReadOnly = false;
                PasswordTxtbox.ReadOnly = false;
                return;
            }

            if (string.Equals(Username, "Admin", StringComparison.OrdinalIgnoreCase)
                && string.Equals(Password, "Admin123", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Admin log in success", "Welcome",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is MainForm mainForm)
                    {
                        AdminForm adminForm = new AdminForm();
                        UserControlNavigator.ShowControl(adminForm, MainForm.mainFormInstance.MainFormContent);
                        break;
                    }
                }
                Clear();
                return;
            }

            try
            {
                await Method.LoginAsync(Username, Password);
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UsernameTxtbox.ReadOnly = false;
            PasswordTxtbox.ReadOnly = false;
        }
    }
}
