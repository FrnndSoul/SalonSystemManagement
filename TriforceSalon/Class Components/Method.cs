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
using Org.BouncyCastle.Ocsp;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace TriforceSalon
{
    public class Method
    {
        /*
         * accounts - Username, Password, AccountlD, Status
         * salon_employees - AccountlD, Name, Email, Birthdate, Photo, AccountStatus, ServicelD, Availability
         */

        public static byte[] Photo, newPhoto;
        public static int AccountStatus, Status, LogReference, AccountID, ServiceID;
        public static string Name, Username, Email, Password,
            newAccountID, newName, newUsername, newEmail, newPassword,
            UsernameInput, PasswordInput,
            Availability, Access;
        public static DateTime Birthdate;
        public static string mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public static void ReadUserData(string user)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT * FROM `accounts` JOIN `salon_employees` ON accounts.AccountID = salon_employees.AccountID WHERE accounts.AccountID = @accountID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@accountID", user);
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Username = reader["Username"].ToString();
                                Password = reader["Password"].ToString();
                                AccountID = Convert.ToInt32(reader["AccountID"]);
                                Status = Convert.ToInt32(reader["Status"]);
                                Name = reader["Name"].ToString();
                                Email = reader["Email"].ToString();
                                Birthdate = (DateTime)reader["Birthdate"];
                                AccountStatus = Convert.ToInt32(reader["AccountStatus"]);
                                ServiceID = Convert.ToInt32(reader["ServiceID"]);
                                Availability = reader["Availability"].ToString();
                                Access = reader["AccountAccess"].ToString();

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
                                    MessageBox.Show("UserID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        } //empty

        public static bool Login(string inputID, string inputPassword)
        {
            ReadUserData(inputID);

            if (AccountStatus < 3)
            {
                string HashedPass = HashString(inputPassword);
                if (HashedPass == Password)
                {
                    if (string.Equals(Access, "Manager", StringComparison.OrdinalIgnoreCase))
                    {
                        ResetAttempt(inputID);
                        InventoryPage.StoreID(Convert.ToInt32(inputID));
                        MessageBox.Show($"Welcome Manager, {Username}!");
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is MainForm mainForm)
                            {
                                mainForm.ShowInventory();
                                break;
                            }
                        }
                    }
                    else if (string.Equals(Access, "Receptionist", StringComparison.OrdinalIgnoreCase))
                    {
                        ResetAttempt(inputID);
                        MessageBox.Show("Call receptionist's transaction at\nLine 124: Method.cs", "receptionist",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (string.Equals(Access, "Staff", StringComparison.OrdinalIgnoreCase))
                    {
                        ResetAttempt(inputID);
                        MessageBox.Show("Call staff's transaction at\nLine 130: Method.cs", "Staff",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LogUser(AccountID);
                }
                else
                {
                    if (DuplicateChecker(inputID, "AccountID", "salon_employees"))
                    {
                        WrongPassword(inputID);
                    }
                    else
                    {
                        MessageBox.Show("ID incorrect, please try again");
                    }
                }
            }
            else if (AccountStatus == 4)
            {
                MessageBox.Show($"Your account has already been archived", "Account Archived",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else 
            {
                MessageBox.Show($"Your account is currently inactive\ndue to multiple failed login attempts", "Account Inactive",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public static void WrongPassword(string wrongID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE salon_employees SET AccountStatus = AccountStatus + 1 WHERE AccountID = @wrongID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@wrongID", wrongID);
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat WrongPassword()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ResetAttempt(string correctID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE salon_employees SET AccountStatus = 0 WHERE AccountID = @correctID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@correctID", correctID);
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ResetAttempt()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int NewID;

            if (10000 <= IDinput && IDinput <= 99999)
            {
                do
                {
                    NewID = random.Next(1000, 10000);
                } while (DuplicateChecker(NewID.ToString(), "AccountID", "accounts") || DuplicateChecker(NewID.ToString(), "AccountID", "salon_employees"));
            }
            else
            {
                do
                {
                    NewID = random.Next(10000, 100000);
                } while (DuplicateChecker(NewID.ToString(), "AccountID", "accounts") || DuplicateChecker(NewID.ToString(), "AccountID", "salon_employees"));
            }
            return NewID;
        }

        public static bool DuplicateChecker(string Data, string Column, string Table)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM {Table} WHERE {Column} = @data";
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

        public static void UploadEmployeeData(string Name, string Username, string Email, string Password, DateTime Birthdate, byte[] Photo, string Role, string Access)
        {
            int accountID = GenerateID(0);
            UploadMemberData(Username, accountID, Password);

            List<Tuple<string, int>> serviceTypes = new List<Tuple<string, int>>();

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ServiceTypeName, ServiceID FROM service_type";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string serviceTypeName = reader["ServiceTypeName"].ToString();
                            int serviceID = Convert.ToInt32(reader["ServiceID"]);
                            serviceTypes.Add(new Tuple<string, int>(serviceTypeName, serviceID));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int selectedServiceID = -1;
            foreach (Tuple<string, int> serviceType in serviceTypes)
            {
                if (serviceType.Item1 == Role)
                {
                    selectedServiceID = serviceType.Item2;
                    break;
                }
            }

            if (selectedServiceID == -1)
            {
                MessageBox.Show("Selected role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "INSERT INTO `salon_employees`" +
                        "(`AccountID`, `Name`, `Email`, `Birthdate`, `Photo`, `AccountStatus`, `ServiceID`, `Availability`, `AccountAccess`) VALUES" +
                        "(@accountID, @name, @email, @birthdate, @photo, @accountStatus, @serviceID, @availability, @access)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@accountID", accountID);
                        querycmd.Parameters.AddWithValue("@name", Name);
                        querycmd.Parameters.AddWithValue("@email", Email);
                        querycmd.Parameters.AddWithValue("@password", Password);
                        querycmd.Parameters.AddWithValue("@birthdate", Birthdate);
                        querycmd.Parameters.AddWithValue("@photo", Photo);
                        querycmd.Parameters.AddWithValue("@accountStatus", 0);
                        querycmd.Parameters.AddWithValue("@serviceID", selectedServiceID);
                        querycmd.Parameters.AddWithValue("@availability", "Offline");
                        querycmd.Parameters.AddWithValue("@access", Access);

                        int rowsaffected = querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat UploadEmployeeData()", "SQL ERROR", MessageBoxButtons.OK);
            }
        }


        public static void UploadMemberData(string Username, int AccountID, string Password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "INSERT INTO `accounts` (`Username`, `Password`, `AccountID`, `Status`)" +
                        "VALUES (@username, @password, @AccountID, @status)";

                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@username", Username);
                        querycmd.Parameters.AddWithValue("@password", Password);
                        querycmd.Parameters.AddWithValue("@AccountID", AccountID);
                        querycmd.Parameters.AddWithValue("@status", 0);
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat InsertMemberData()", "SQL ERROR", MessageBoxButtons.OK);
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

        public static void LogUser(int IDlog)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "INSERT INTO `logs`(`SessionID`, `ID`, `TimeIn`)" +
                        "VALUES (@sessionID,@id,@timeIn)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        LogReference = GenerateLog();
                        querycmd.Parameters.AddWithValue("@sessionID", LogReference);
                        querycmd.Parameters.AddWithValue("@id", IDlog);
                        querycmd.Parameters.AddWithValue("@timeIn", DateTime.Now);

                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LogUser()", "SQL ERROR", MessageBoxButtons.OK);
            }
        }

        public static int GenerateLog()
        {
            Random random = new Random();
            int Ref;
            do
            {
                Ref = random.Next(99999999, 1000000000);
            } while (DuplicateChecker(Ref.ToString(), "SessionID", "logs") == true);
            return Ref;
        }

        public static void LogOutUser()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE logs SET TimeOut = @timeOut WHERE SessionID = @sessionID";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@sessionID", LogReference);
                        querycmd.Parameters.AddWithValue("@timeOut", DateTime.Now);
                        querycmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LogOutUser()", "SQL ERROR", MessageBoxButtons.OK);
            }
        }
    }
}