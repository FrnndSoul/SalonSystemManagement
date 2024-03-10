using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon
{
    public partial class AdminForm : UserControl
    {
        public static byte[] PhotoDB, newUpload;
        public static int AccountStatusReader, IDReader, UserRow, ServiceIDReader;
        public static string NameReader, UsernameReader, EmailReader,
            SelectedUsername, AccountAccessReader, AvailabilityReader;
        public static DateTime BirthdateReader;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public AdminForm()
        {
            InitializeComponent();
            Method.EclipsePhotoBox(Photo);
            this.ServiceTypeBox.Style = (Guna.UI2.WinForms.Enums.TextBoxStyle)ComboBoxStyle.DropDownList;
            this.ServiceTypeBox.Items.Clear();
            SetRoles(ServiceTypeBox);
        }

        private async void AdminForm_Load(object sender, EventArgs e)
        {
            await LoadUserData();

            object select = UserDGV;
            DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(1, 3);
            UserDGV_CellContentClick(select, args);
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

        /*public void LoadUserData()
        {
            foreach (DataGridViewRow row in UserDGV.SelectedRows)
            {
                UserDGV.Rows.Remove(row);
            }
            try
            {
                connection.Open();
                string sql = "SELECT accounts.Username, accounts.AccountID, " +
                             "salon_employees.AccountAccess, salon_employees.Name, salon_employees.Email, " +
                             "salon_employees.Birthdate, salon_employees.AccountStatus, " +
                             "salon_employees.ServiceID, salon_employees.Availability FROM accounts " +
                             "JOIN salon_employees ON accounts.AccountID = salon_employees.AccountID";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                UserDGV.DataSource = dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LoadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }*/

        public async Task LoadUserData()
        {
            foreach (DataGridViewRow row in UserDGV.SelectedRows)
            {
                UserDGV.Rows.Remove(row);
            }

            try
            {
                await connection.OpenAsync();

                string sql = "SELECT accounts.Username, accounts.AccountID, " +
                             "salon_employees.AccountAccess, salon_employees.Name, salon_employees.Email, " +
                             "salon_employees.Birthdate, salon_employees.AccountStatus, " +
                             "salon_employees.ServiceID, salon_employees.Availability FROM accounts " +
                             "JOIN salon_employees ON accounts.AccountID = salon_employees.AccountID";

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                System.Data.DataTable dataTable = new System.Data.DataTable();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    await adapter.FillAsync(dataTable);
                }

                UserDGV.DataSource = dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat LoadUserDataAsync()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            DiscardFunc();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    //mainForm.ShowLogin();
                    SigninPage signinPage = new SigninPage();
                    UserControlNavigator.ShowControl(signinPage, MainForm.mainFormInstance.MainFormContent);
                    break;
                }
            }
        }

        private async void DiscardBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Discard changes for the user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DiscardFunc();
            }
            await LoadUserData();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    //mainForm.ShowSignUp();
                    SignUpForm signUp = new SignUpForm();
                    UserControlNavigator.ShowControl(signUp, MainForm.mainFormInstance.MainFormContent);
                    break;
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserDGV.Rows.Count <= 0)
            {
                return;
            }

            if (UserDGV.SelectedCells.Count > 0)
            {
                int userRow = UserDGV.SelectedCells[0].RowIndex;
                if (userRow >= 0 && userRow < UserDGV.Rows.Count)
                {
                    int selectedAccountID = Convert.ToInt32(UserDGV.Rows[userRow].Cells["AccountID"].Value);
                    ReadUserData(selectedAccountID);
                    DisplayUserData(PhotoDB, NameReader, UsernameReader, EmailReader, BirthdateReader, AccountStatusReader, IDReader, AccountAccessReader, ServiceIDReader);
                }
            }
        }

        private async void SaveBtn_Click_1(object sender, EventArgs e)
        {
            string tempName = NameBox.Text;
            string tempUsername = UsernameBox.Text;
            string tempEmail = EmailBox.Text;
            string tempServiceType = ServiceTypeBox.Text;
            string tempAccountAccess = AccessBox.Text;

            if (!Method.ValidEmail(tempEmail))
            {
                MessageBox.Show("Please provide a valid email address.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Save the current changes for user {UsernameReader}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Method.ChangeUserData(tempName, tempUsername, tempEmail, tempServiceType, tempAccountAccess, newUpload, Convert.ToInt32(IDBox.Text));
            await LoadUserData();
            DiscardFunc();                                                                  
        }

        private void DiscardBtn_Click_1(object sender, EventArgs e)
        {
            DiscardFunc();
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            UsernameBox.Enabled = true;
            EmailBox.Enabled = true;
            UploadBtn.Enabled = true;
            AccessBox.Enabled = true;
            ServiceTypeBox.Enabled = true;

            UserDGV.Enabled = false;

            CreateBtn.Visible = false;
            SaveBtn.Visible = true;
            DiscardBtn.Visible = true;
            EditBtn.Visible = false;
        }

        private void UploadBtn_Click_1(object sender, EventArgs e)
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
                    newUpload = ms.ToArray();
                }
            }
            else
            {
                newUpload = PhotoDB;
            }
        }

        public void DisplayUserData(byte[] PhotoInput, string NameInput, string UsernameInput, string EmailInput, DateTime BirthdateInput, int Status, int IDInput, string Access, int ServiceID)
        {
            if (PhotoInput != null && PhotoInput.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(PhotoInput))
                {
                    Photo.Image = Image.FromStream(stream);
                }
            }
            NameBox.Text = NameInput;
            UsernameBox.Text = UsernameInput;
            EmailBox.Text = EmailInput;
            BirthdayPicker.Value = BirthdateInput;

            if (Status == 0)
            {
                StatusBox.Text = "Great";
            } else if (Status == 1)
            {
                StatusBox.Text = "Good";
            } else if (Status == 2)
            {
                StatusBox.Text = "Critical";
            } else if (Status == 3)
            {
                StatusBox.Text = "Inactive";
            } else
            {
                StatusBox.Text = "Deactivated";
            }

            IDBox.Text = IDInput.ToString();
            AccessBox.Text = Access;

            string roleName = GetServiceTypeName(ServiceID);
            ServiceTypeBox.Text = roleName;
        }

        public async void DiscardFunc()
        {
            EditBtn.Visible = true;
            NameBox.Enabled = false;
            UsernameBox.Enabled = false;
            EmailBox.Enabled = false;
            UploadBtn.Enabled = false;
            SaveBtn.Visible = false;
            DiscardBtn.Visible = false;
            UserDGV.Enabled = true;
            AccessBox.Enabled = false;
            ServiceTypeBox.Enabled = false;

            await LoadUserData();
        }

        public static void ReadUserData(int accountID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    string query = "SELECT accounts.Username, accounts.AccountID, " +
                                   "salon_employees.AccountAccess, salon_employees.Name, salon_employees.Email, " +
                                   "salon_employees.Birthdate, salon_employees.Photo, salon_employees.AccountStatus, " +
                                   "salon_employees.ServiceID, salon_employees.Availability " +
                                   "FROM accounts " +
                                   "JOIN salon_employees ON accounts.AccountID = salon_employees.AccountID " +
                                   "WHERE accounts.AccountID = @accountID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@accountID", accountID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UsernameReader = reader["Username"].ToString();
                                IDReader = Convert.ToInt32(reader["AccountID"]);
                                AccountAccessReader = reader["AccountAccess"].ToString();
                                NameReader = reader["Name"].ToString();
                                EmailReader = reader["Email"].ToString();
                                BirthdateReader = (DateTime)reader["Birthdate"];
                                AccountStatusReader = Convert.ToInt32(reader["AccountStatus"]);
                                ServiceIDReader = Convert.ToInt32(reader["ServiceID"]);
                                AvailabilityReader = reader["Availability"].ToString();

                                if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                                {
                                    long byteSize = reader.GetBytes(reader.GetOrdinal("Photo"), 0, null, 0, 0);
                                    byte[] photoBytes = new byte[byteSize];
                                    reader.GetBytes(reader.GetOrdinal("Photo"), 0, photoBytes, 0, (int)byteSize);
                                    PhotoDB = photoBytes;
                                    newUpload = photoBytes;
                                }
                                else
                                {
                                    PhotoDB = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ReadUserData() admin form", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetServiceTypeName(int serviceID)
        {
            string serviceTypeName = "";

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ServiceTypeName FROM service_type WHERE ServiceID = @serviceID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@serviceID", serviceID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            serviceTypeName = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return serviceTypeName;
        }
    }
}