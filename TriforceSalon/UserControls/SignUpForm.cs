using MySql.Data.MySqlClient;
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
        public static string mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public SignUpForm()
        {
            InitializeComponent();
            BirthdayPicker.MinDate = DateTime.Now.AddYears(-59);
            BirthdayPicker.MaxDate = DateTime.Now.AddYears(-18);

            PasswordBox.PasswordChar = '*';
            PasswordBox1.PasswordChar = '*';
            Method.EclipsePhotoBox(Photo);
            this.RoleBox.Style = (Guna.UI2.WinForms.Enums.TextBoxStyle)ComboBoxStyle.DropDownList;
            SetRoles(RoleBox);
        }

        public static void SetRoles(Guna.UI2.WinForms.Guna2ComboBox roleBox)
        {
            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT ServiceTypeName FROM service_type";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string serviceTypeName = reader["ServiceTypeName"].ToString();
                            _ = roleBox.Items.Add(serviceTypeName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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


            this.RoleBox.Style = (Guna.UI2.WinForms.Enums.TextBoxStyle)ComboBoxStyle.DropDownList;
            RoleBox.SelectedIndex = -1;

            this.AccessBox.Style = (Guna.UI2.WinForms.Enums.TextBoxStyle)ComboBoxStyle.DropDownList;
            AccessBox.SelectedIndex = -1;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.ShowLogin();
                    break;
                }
            }
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
            string Name, Username, Email, Password, Password1, Role, Access;
            DateTime Birthdate = BirthdayPicker.Value;

            Name = NameBox.Text;
            Username = UsernameBox.Text;
            Email = EmailBox.Text;
            Password = PasswordBox.Text;
            Password1 = PasswordBox1.Text;
            Role = RoleBox.Text;
            Access = AccessBox.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Password1) || string.IsNullOrEmpty(Role) || string.IsNullOrEmpty(Access))
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
            } else if (!Method.ValidEmail(Email))
            {
                MessageBox.Show("Please provide a valid email address.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (Method.DuplicateChecker(Username, "Username", "accounts") || Method.DuplicateChecker(Email, "Email", "salon_employees"))
            {
                MessageBox.Show("The username and/or email is already registered.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (PhotoByteHolder == null)
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

            if (result != DialogResult.Yes)
            {
                return;
            }
            string hashedPassword = Method.HashString(Password);

            Method.UploadEmployeeData(Name, Username, Email, hashedPassword, Birthdate, PhotoByteHolder, Role, Access);
            MessageBox.Show($"Employee Data Uploaded");
            object BackFunction = BackBtn;
            BackBtn_Click(BackFunction, e);
        }

        public void RoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}