using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using TriforceSalon.UserControls;
using TriforceSalon.Class_Components;
using System.IO;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TriforceSalon
{
    public class Method
    {

        public static TransactionMethods transaction = new TransactionMethods();

        public static bool IsAdmin;
        public static byte[] Photo, newPhoto;
        public static int AccountStatus, Status, LogReference, AccountID, ServiceID;
        public static string Name, Username, Email, Password,
            newAccountID, newName, newUsername, newEmail, newPassword,
            UsernameInput, PasswordInput,
            Availability, AccountAccess, ServiceType;
        public static DateTime Birthdate;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public static bool AdminAccess()
        {
            return IsAdmin;
        }

        public static async Task RecordShipment(int ShipmentID, int ItemID, string ItemName, int Qty, int Cost, string Supplier)
        {
            string query = @"INSERT INTO shipments (`ManagerID`, `Date Shipped`, `ShipmentID`, `ItemID`, `ItemName`, `Quantity`, `Cost`, `Supplier`) 
                VALUES (@ManagerID, @DateShipped, @ShipmentID, @ItemID, @ItemName, @Quantity, @Cost, @Supplier)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagerID", AccountID);
                        cmd.Parameters.AddWithValue("@DateShipped", DateTime.Now);
                        cmd.Parameters.AddWithValue("@ShipmentID", ShipmentID);
                        cmd.Parameters.AddWithValue("@ItemID", ItemID);
                        cmd.Parameters.AddWithValue("@ItemName", ItemName);
                        cmd.Parameters.AddWithValue("@Quantity", Qty);
                        cmd.Parameters.AddWithValue("@Cost", Cost);
                        cmd.Parameters.AddWithValue("@Supplier", Supplier);

                        if (AdminAccess())
                        {
                            MessageBox.Show("Working as intended.\nNo changes were made in the database");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static async Task ReadUserDataAsync(string user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string accountQuery = "SELECT * FROM `accounts` WHERE AccountID = @accountID";

                    using (MySqlCommand accountCmd = new MySqlCommand(accountQuery, conn))
                    {
                        accountCmd.Parameters.AddWithValue("@accountID", user);

                        using (DbDataReader accountReader = await accountCmd.ExecuteReaderAsync())
                        {
                            if (await accountReader.ReadAsync())
                            {
                                Username = accountReader["Username"].ToString();
                                Password = accountReader["Password"].ToString();

                                AccountID = Convert.ToInt32(accountReader["AccountID"]);
                                Status = Convert.ToInt32(accountReader["Status"]);
                            }
                            else
                            {
                                if (string.Equals(user, "Admin", StringComparison.OrdinalIgnoreCase))
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
                MessageBox.Show(e.Message + "\n\nat ReadUserDataAsync()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async static Task<bool> IsFirstManager()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = @"
                        SELECT COUNT(*)
                        FROM logs 
                        INNER JOIN salon_employees ON salon_employees.AccountID = logs.ID
                        WHERE DATE(logs.TimeIn) = CURRENT_DATE AND salon_employees.AccountAccess = 'Manager';";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    if (count != 0)
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }
        }

        public static async Task ReadEmployeeData(string accountID)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    string query = "SELECT * FROM `salon_employees` WHERE AccountID = @accountID";

                    using (MySqlCommand querycmd = new MySqlCommand(query, conn))
                    {
                        querycmd.Parameters.AddWithValue("@accountID", accountID);
                        using (DbDataReader reader = await querycmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                Name = reader["Name"].ToString(); 
                                Email = reader["Email"].ToString(); 
                                Availability = reader["Availability"].ToString(); 
                                AccountAccess = reader["AccountAccess"].ToString(); 

                                Birthdate = (DateTime)reader["Birthdate"]; 

                                AccountID = Convert.ToInt32(reader["AccountID"]); 
                                AccountStatus = Convert.ToInt32(reader["AccountStatus"]); 
                                ServiceID = Convert.ToInt32(reader["ServiceID"]); 

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
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ReadEmployeeData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ChangeUserData(string newName, string newUsername, string newEmail, string newServiceType, string newAccess, byte[] newPhoto, int accountID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    string accountsQuery = "UPDATE accounts SET Username = @newUsername WHERE AccountID = @accountID";
                    using (MySqlCommand accountsCmd = new MySqlCommand(accountsQuery, connection))
                    {
                        accountsCmd.Parameters.AddWithValue("@newUsername", newUsername);
                        accountsCmd.Parameters.AddWithValue("@accountID", accountID);
                        int accountsRowsAffected = accountsCmd.ExecuteNonQuery();
                        if (accountsRowsAffected <= 0)
                        {
                            MessageBox.Show($"Error updating accounts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    int serviceID = GetServiceIDByName(newServiceType, connection);

                    string employeesQuery = "UPDATE salon_employees SET Name = @newName, Photo = @newPhoto, AccountAccess = @newAccess, ServiceID = @serviceID WHERE AccountID = @accountID";
                    using (MySqlCommand employeesCmd = new MySqlCommand(employeesQuery, connection))
                    {
                        employeesCmd.Parameters.AddWithValue("@newName", newName);
                        employeesCmd.Parameters.AddWithValue("@newPhoto", newPhoto);
                        employeesCmd.Parameters.AddWithValue("@newAccess", newAccess);
                        employeesCmd.Parameters.AddWithValue("@accountID", accountID);
                        employeesCmd.Parameters.AddWithValue("@serviceID", serviceID);
                        int employeesRowsAffected = employeesCmd.ExecuteNonQuery();
                        if (employeesRowsAffected <= 0)
                        {
                            MessageBox.Show($"Error updating salon_employees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    AccountAccess = newAccess;
                    Username = newUsername;
                    ServiceID = serviceID;
                    Photo = newPhoto;
                    Name = newName;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error updating user data: {e.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int GetServiceIDByName(string serviceTypeName, MySqlConnection connection)
        {
            try
            {
                string query = "SELECT ServiceID FROM service_type WHERE ServiceTypeName = @serviceTypeName";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@serviceTypeName", serviceTypeName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Service type not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error GetServiceIDByName: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Service type not found in the database.");
            }
        }

        public static async Task<bool> LoginAsync(string inputID, string inputPassword)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    await connection.OpenAsync();

                    string query = "SELECT Password, Username FROM accounts WHERE AccountID = @accountID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@accountID", inputID);
                        using (DbDataReader accountReader = await cmd.ExecuteReaderAsync())
                        {
                            if (await accountReader.ReadAsync())
                            {
                                string username = accountReader["Username"].ToString();
                                string password = accountReader["Password"].ToString();

                                if (password == HashString(inputPassword))
                                {
                                    IsAdmin = false;
                                    await LogInCompleteAsync(inputID);
                                    return true;
                                } else
                                {
                                    if (password == "Admin123")
                                    {
                                        IsAdmin = true;
                                        await LogInCompleteAsync(inputID);
                                        return true;
                                    }
                                    MessageBox.Show("Wrong password", "Warning", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                                    WrongPassword(inputID);
                                    return false;
                                }
                            } else
                            {
                                MessageBox.Show("User not found.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        public static async Task LogInCompleteAsync(string inputID)
        {
            try
            {
                await ReadEmployeeData(inputID);

                if (string.Equals(AccountAccess, "Manager", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Welcome Manager!");
                    if (await IsFirstManager())
                    {
                        Inventory.PullItems();
                        Inventory.CheckStatus();
                    }
                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is MainForm mainForm)
                        {
                            ManagerPage managerPage = new ManagerPage();

                            mainForm.Invoke((MethodInvoker)delegate
                            {
                                UserControlNavigator.ShowControl(managerPage, MainForm.mainFormInstance.MainFormContent);
                            });
                            break;
                        }
                    }
                }

                else if (string.Equals(AccountAccess, "Receptionist", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Welcome Receptionist!");

                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is MainForm mainForm)
                        {
                            WalkInTransactionForm walkInForm = new WalkInTransactionForm();
                            mainForm.Invoke((MethodInvoker)delegate
                            {
                                UserControlNavigator.ShowControl(walkInForm, MainForm.mainFormInstance.MainFormContent);
                            });
                            break;
                        }
                    }
                }
                else
                {
                    ResetAttempt(inputID);
                    MessageBox.Show($"Welcome Staff!");

                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is MainForm mainForm)
                        {
                            EmployeeUserConrols otherRoleControl = new EmployeeUserConrols();
                            mainForm.Invoke((MethodInvoker)delegate
                            {
                                UserControlNavigator.ShowControl(otherRoleControl, MainForm.mainFormInstance.MainFormContent);
                            });
                            break;
                        }
                    }
                }

                ResetAttempt(inputID);
                await LogUser(AccountID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
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

        public static void UploadEmployeeData(string Name, string Username, string Email, string Password, DateTime Birthdate, byte[] Photo, string Role)
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
                        "(`AccountID`, `Name`, `Email`, `Birthdate`, `Photo`, `AccountStatus`, `ServiceID`, `Availability`) VALUES" +
                        "(@accountID, @name, @email, @birthdate, @photo, @accountStatus, @serviceID, @availability)";
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

        public static async Task LogUser(int IDlog)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    await connection.OpenAsync();

                    string query = "INSERT INTO `logs`(`SessionID`, `ID`, `TimeIn`)" +
                        "VALUES (@sessionID,@id,@timeIn)";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        LogReference = GenerateLog();
                        querycmd.Parameters.AddWithValue("@sessionID", LogReference);
                        querycmd.Parameters.AddWithValue("@id", IDlog);
                        querycmd.Parameters.AddWithValue("@timeIn", DateTime.Now);

                        await querycmd.ExecuteNonQueryAsync();
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

        public  void GetEmployeeInfo()
        {
            EmployeeUserConrols.employeeUserConrolsInstance.EmployeeNameLbl.Text = Name;
            EmployeeUserConrols.employeeUserConrolsInstance.EmpAccNumberLbl.Text = Convert.ToString(AccountID);
            EmployeeUserConrols.employeeUserConrolsInstance.ServiceTypeNameLbl.Text = transaction.GetServiceTypeName(ServiceID);
        }

        /*public static void ReadUserData(string user)
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
                             Name = reader["Name"].ToString();
                             Email = reader["Email"].ToString();
                             Availability = reader["Availability"].ToString();
                             AccountAccess = reader["AccountAccess"].ToString();

                             Birthdate = (DateTime)reader["Birthdate"];

                             AccountID = Convert.ToInt32(reader["AccountID"]);
                             Status = Convert.ToInt32(reader["Status"]);
                             AccountStatus = Convert.ToInt32(reader["AccountStatus"]);
                             ServiceID = Convert.ToInt32(reader["ServiceID"]);

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
                             if (string.Equals(user, "Admin", StringComparison.OrdinalIgnoreCase))
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
     }*/

        /*public static bool Login(string inputID, string inputPassword)
        {
            ReadUserData(inputID);

            if (AccountStatus < 3)
            {
                string HashedPass = HashString(inputPassword);
                if (HashedPass == Password)
                {
                    if (string.Equals(AccountAccess, "Manager", StringComparison.OrdinalIgnoreCase))
                    {
                        ResetAttempt(inputID);
                        Method.LogUser(Convert.ToInt32(inputID));
                        MessageBox.Show($"Welcome Manager, {Username}!");
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is MainForm mainForm)
                            {
                                //mainForm.ShowManager();

                                ManagerPage managerPage = new ManagerPage();
                                UserControlNavigator.ShowControl(managerPage, MainForm.mainFormInstance.MainFormContent);
                                break;
                            }
                        }
                    }
                    else if (string.Equals(AccountAccess, "Receptionist", StringComparison.OrdinalIgnoreCase))
                    {
                        ResetAttempt(inputID);
                        MessageBox.Show($"Welcome Receptionist, {Username}!");
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is MainForm mainForm)
                            {
                                //mainForm.ShowWalkIn();
                                WalkInTransactionForm walkInForm = new WalkInTransactionForm();
                                UserControlNavigator.ShowControl(walkInForm, MainForm.mainFormInstance.MainFormContent);

                                break;
                            }
                        }
                    } else
                    {
                        ResetAttempt(inputID);
                        MessageBox.Show($"Welcome Staff, {Username}!");
                        GetEmployeeInfo();
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is MainForm mainForm)
                            {
                                //mainForm.ShowEmployee();
                                EmployeeUserConrols empControl = new EmployeeUserConrols();
                                UserControlNavigator.ShowControl(empControl, MainForm.mainFormInstance.MainFormContent);

                                break;
                            }
                        }
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
        }*/
    }
}