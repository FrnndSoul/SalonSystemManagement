using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TriforceSalon
{
    public partial class SignUpForm : UserControl
    {
        public static byte[] PhotoByteHolder;

        public SignUpForm()
        {
            InitializeComponent();
            BirthdayPicker.MinDate = DateTime.Now.AddYears(-59);
            BirthdayPicker.MaxDate = DateTime.Now.AddYears(-18);

            PasswordBox.PasswordChar = '*';
            PasswordBox1.PasswordChar = '*';
            Method.EclipsePhotoBox(Photo);
            this.RoleBox.Style = (Guna.UI2.WinForms.Enums.TextBoxStyle)ComboBoxStyle.DropDownList;
        }

        private void TogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = TogglePassword.Checked ? '\0' : '*';
            PasswordBox1.PasswordChar = TogglePassword.Checked ? '\0' : '*';
        }

        public void BackBtn_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            UsernameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
            PasswordBox1.Text = "";
            Photo.Image = null;
            PhotoByteHolder = null;
            TogglePassword.Checked = false;
            BirthdayPicker.Value = BirthdayPicker.MaxDate;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.ShowLogin();
                    break;
                }
            }
        }


        public void Reset()
        {
            RoleBox.Text = null;
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                Image image = Image.FromFile(selectedFile);
                Photo.Image = image;

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    PhotoByteHolder = ms.ToArray();
                }
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void EmailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void CreateBtn_Click_1(object sender, EventArgs e)
        {
            string Name, Username, Email, Password, Password1;
            DateTime Birthdate = BirthdayPicker.Value;

            Name = NameBox.Text;
            Username = UsernameBox.Text;
            Email = EmailBox.Text;
            Password = PasswordBox.Text;
            Password1 = PasswordBox1.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Password1))
            {
                MessageBox.Show("Kindly fill up all the information \nneeded, thank you.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Password != Password1)
            {
                MessageBox.Show("Your passwords do not match.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Method.StrongPassword(Password))
            {
                MessageBox.Show("Your passwords is weak." +
                    "\nYour password should include the following:" +
                    "\n     Upper and Lower Case Letters," +
                    "\n     Numbers, and Special Characters", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Method.ValidEmail(Email))
            {
                MessageBox.Show("Please provide a valid email address.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Method.DuplicateChecker(Username, "Username", "users") || Method.DuplicateChecker(Email, "Email", "users"))
            {
                MessageBox.Show("The username and/or email is already registered.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PhotoByteHolder == null)
            {
                MessageBox.Show("No profile photo selected, please upload a photo?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Please review your information below:\n\n" +
                $"Name: {Name}\n" +
                $"Username: {Username}\n" +
                $"Email: {Email}\n" +
                $"Birthdate: {Birthdate}",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                string hashedPassword = Method.HashString(Password);

                int RoleID;
                if (RoleBox.Text == "Member")
                {
                    RoleID = 0; //using 0 to generate member id
                }
                else if (RoleBox.Text == "Staff")
                {
                    RoleID = 123456; //using 6 digit to generate 4 digit
                }
                else
                {
                    RoleID = 1234; //using 4 digit to generate 6 digit
                }
                Method.UploadData(Name, Username, Email, hashedPassword, Birthdate, PhotoByteHolder, RoleID);

                object BackFunction = BackBtn;
                BackBtn_Click(BackFunction, e);
            }

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void RoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}