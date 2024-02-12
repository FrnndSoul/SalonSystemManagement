﻿using System;
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

        private void CreateBtn_Click(object sender, EventArgs e)
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
            } else if (!StrongPassword(Password))
            {
                MessageBox.Show("Your passwords is weak." +
                    "\nYour password should include the following:" +
                    "\n     Upper and Lower Case Letters," +
                    "\n     Numbers, and Special Characters", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidEmail(Email))
            {
                MessageBox.Show("Please provide a valid email address.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Method.DuplicateChecker(Username, "Username") || Method.DuplicateChecker(Email, "Email"))
            {
                MessageBox.Show("The username ad/or email is already registered.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PhotoByteHolder == null)
            {
                DialogResult option = MessageBox.Show("No profile photo selected.\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (option == DialogResult.No)
                {
                    return;
                }
            }
            string hashedPassword = Method.HashString(Password);
            Method.UploadData(Name, Username, Email, hashedPassword, Birthdate, PhotoByteHolder);

            object BackFunction = BackBtn;
            BackBtn_Click(BackFunction, e);
        }

        public static bool StrongPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }

        public static bool ValidEmail(string Email)
        {
            string email = Email.ToLower();
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
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
    }
}