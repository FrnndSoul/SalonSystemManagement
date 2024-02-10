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

namespace TriforceSalon
{
    public class Method
    {
        public static byte[] Photo;
        public static int FailedLogIn;
        public static string ID, Name, Username, Email, Password, Birthdate,
            newID, newName, newEmail, newPassword,
            UsernameInput, PasswordInput;
        public static string mysqlcon = "server=localhost;user=root;database=salondb;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

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

        public static void ReadUserData(string InputUsername, string InputPassword) //reads data in db via username
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT * from users WHERE Username = @username";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@username", InputUsername);
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            ID = reader["ID"].ToString();
                            Name = reader["Name"].ToString();
                            Username = reader["Username"].ToString();
                            Email = reader["Email"].ToString();
                            Password = reader["Password"].ToString();
                            FailedLogIn = Convert.ToInt32(reader["FailedAttempts"]);
                            Birthdate = reader["Birthdate"].ToString();

                            PasswordInput = HashString(InputPassword);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ReadUserData()", "SQL ERROR", MessageBoxButtons.OK);
            }
        }

        public static void ChangeUserData() //changes user data via username
        {
            if (string.IsNullOrEmpty(newID) || string.IsNullOrEmpty(newName) ||
                string.IsNullOrEmpty(newEmail) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Information Incomplete.\nPlease provide all information", "User Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query =
                        "UPDATE users SET ID = @ID, Name = @Name, Email = @Email, Password = @Password," +
                        "WHERE Username = @Username";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@ID", newID);
                        querycmd.Parameters.AddWithValue("@Name", newName);
                        querycmd.Parameters.AddWithValue("@Email", newEmail);
                        querycmd.Parameters.AddWithValue("@Password", newPassword);
                        querycmd.Parameters.AddWithValue("@Username", Username);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ReadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool Login(string UsernameInput, string PasswordInput)
        {
            if (string.Equals(UsernameInput, "Admin", StringComparison.OrdinalIgnoreCase)
                && string.Equals(PasswordInput, "Admin123", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Admin log in success", "Welcome",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (FailedLogIn != 3)
            {
                if (PasswordInput == Password)
                {
                    MessageBox.Show($"Login Success, {Username}.");
                    return true;
                }
                else
                {
                    if (DuplicateChecker(UsernameInput, "Username"))
                    {
                        WrongPassword(Username);
                        MessageBox.Show("Dup");
                    }
                    else
                    {
                        MessageBox.Show("No Dup");
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
            FailedLogIn++;
            int attemptsLeft = 3 - FailedLogIn;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE `users` SET `FailedAttempts` = @failedAttempts WHERE `Username` = @username";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@username", InputUsername);
                        querycmd.Parameters.AddWithValue("@failedAttempts", FailedLogIn);
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
                MessageBox.Show(e.Message + "\n\nat FailedLogin()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearFields()
        {

        }

        public byte[] GetImageDataByUsername(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT Photo FROM user WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return (byte[])result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat GetImageDataByUsername()", "SQL ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int GenerateID()
        {
            Random random = new Random();
            ReadUserData(Username, PasswordInput);
            int IDNumber = Convert.ToInt32(ID);
            int NewID;
            string IDstring;
            if (999999 > IDNumber && IDNumber > 100000)
            {
                do
                {
                    NewID = random.Next(1000, 9999);
                    IDstring = newID.ToString();
                }
                while (DuplicateChecker(newID, "ID") == true);
            }
            else
            {
                do
                {
                    NewID = random.Next(100000, 999999);
                    IDstring = newID.ToString();
                } while (DuplicateChecker(IDstring, "ID") == true);
            }
            return NewID;
        }


        public static bool DuplicateChecker(string Data, string Column)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT * from users WHERE @column = @data";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@data", Data);
                        querycmd.Parameters.AddWithValue("@column", Column);
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ReadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}