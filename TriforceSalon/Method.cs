using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;

namespace TriforceSalon
{
    public class Method
    {
        public static byte[] Photo;
        public static int AccountStatus, ID;
        public static string Name, Username, Email, Password,
            newID, newName, newEmail, newPassword,
            UsernameInput, PasswordInput;
        public static DateTime Birthdate;
        public static string mysqlcon = "server=localhost;user=root;database=salondb;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public static void ReadUserData(string user) {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT * from users WHERE Username = @username";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@username", user);
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ID = Convert.ToInt32(reader["ID"]);
                                Name = reader["Name"].ToString();
                                Username = reader["Username"].ToString();
                                Email = reader["Email"].ToString();
                                Password = reader["Password"].ToString();
                                AccountStatus = Convert.ToInt32(reader["AccountStatus"]);
                                Birthdate = (DateTime)reader["Birthdate"];
                                if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                                {
                                    long byteSize = reader.GetBytes(reader.GetOrdinal("Photo"), 0, null, 0, 0);
                                    byte[] photoBytes = new byte[byteSize];
                                    reader.GetBytes(reader.GetOrdinal("Photo"), 0, photoBytes, 0, (int)byteSize);
                                    Photo = photoBytes;
                                }
                                else
                                {
                                    Photo = null;
                                }
                            }
                            else
                            {
                                if (user != "admin")
                                {
                                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ReadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ChangeUserData(string newName, string newUsername, byte[] newPhoto, int newID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query =
                        "UPDATE users SET Name = @Name, Username = @Username, Photo = @Photo " +
                        "WHERE ID = @ID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@Name", newName);
                        querycmd.Parameters.AddWithValue("@Username", newUsername);
                        querycmd.Parameters.AddWithValue("@Photo", newPhoto);
                        querycmd.Parameters.AddWithValue("@ID", newID);
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ChangeUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool Login(string inputUsername, string inputPassword)
        {

            ReadUserData(inputUsername);

            if (string.Equals(inputUsername, "Admin", StringComparison.OrdinalIgnoreCase)
                && string.Equals(inputPassword, "Admin123", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Admin log in success", "Welcome",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is MainForm mainForm)
                    {
                        mainForm.ShowAdmin();
                        break;
                    }
                }
                return false;
            }
            else if (AccountStatus != 3)
            {
                string HashedPass = HashString(inputPassword);
                if (HashedPass == Password)
                {
                    if (1000000 > ID && ID > 9999)
                    {
                        MessageBox.Show($"Login Success, {Username}.\nStaff");
                        return true;
                    } else
                    {
                        MessageBox.Show($"Login Success, {Username}.\nManager");
                        return true;
                    }
                }
                else
                {
                    if (DuplicateChecker(inputUsername, "Username"))
                    {
                        WrongPassword(Username);
                    }
                    else
                    {
                        MessageBox.Show("Username incorrect, please try again");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Your account is currently inactive\ndue to multiple failed login attempts", "Account Inactive",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public static void WrongPassword(string InputUsername)
        {
            AccountStatus++;
            int attemptsLeft = 3 - AccountStatus;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `users` SET `AccountStatus` = @AccountStatus WHERE `Username` = @username";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@username", InputUsername);
                        querycmd.Parameters.AddWithValue("@AccountStatus", AccountStatus);
                        int rowsAffected = querycmd.ExecuteNonQuery();
                        if (rowsAffected != 0)
                        {
                            MessageBox.Show($"Wrong Password!\nYou have {attemptsLeft} attempts left", "Wrong Password",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat AccountStatus()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string HashString(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                string hashedString = BitConverter.ToString(hashBytes).Replace("-", "");
                return hashedString;
            }
        }

        public static int GenerateID(int IDinput)
        {
            Random random = new Random();
            //ReadUserData(Username, PasswordInput);
            int IDNumber = Convert.ToInt32(IDinput);
            int NewID;
            if (999999 > IDNumber && IDNumber > 100000)
            {
                do
                {
                    NewID = random.Next(1000, 9999);
                    IDNumber = NewID;
                }
                while (DuplicateChecker(newID, "ID") == true);
            }
            else
            {
                do
                {
                    NewID = random.Next(100000, 999999);
                    IDNumber = NewID;
                } while (DuplicateChecker(newID, "ID") == true);
            }
            MessageBox.Show($"This is your ID for reference: {IDNumber}");
            return IDNumber;
        }
        

        public static bool DuplicateChecker(string Data, string Column)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM users WHERE {Column} = @data";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@data", Data);
                        int count = Convert.ToInt32(querycmd.ExecuteScalar());
                        if (count != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat DuplicateChecker()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void UploadData(string Name, string Username, string Email, string Password, DateTime Birthdate, byte[] Photo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `users`" +
                        "(`ID`, `Name`, `Username`, `Email`, `Password`, `Birthdate`, `Photo`, `AccountStatus`) VALUES" +
                        "(@id, @name, @username, @email, @password, @birthdate, @photo, @accountStatus)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        int ID = GenerateID(0);
                        int status = 0;
                        querycmd.Parameters.AddWithValue("@id", ID);
                        querycmd.Parameters.AddWithValue("@name", Name);
                        querycmd.Parameters.AddWithValue("@username", Username);
                        querycmd.Parameters.AddWithValue("@email", Email);
                        querycmd.Parameters.AddWithValue("@password", Password);
                        querycmd.Parameters.AddWithValue("@birthdate", Birthdate);
                        querycmd.Parameters.AddWithValue("@photo", Photo);
                        querycmd.Parameters.AddWithValue("@accountStatus", status);

                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat UploadData()", "SQL ERROR", MessageBoxButtons.OK);
            }
        }

        public static void EclipsePhotoBox(PictureBox Photo)
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, Photo.Width, Photo.Height);
            Region rg = new Region(obj);
            Photo.Region = rg;
        }


        public static bool ValidEmail(string Email)
        {
            string email = Email.ToLower();
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        public static bool StrongPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }




    }
}