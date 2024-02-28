using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//hi
namespace TriforceSalon
{ //Hi
    public partial class AdminForm : UserControl
    {
        public static byte[] PhotoLocal, PhotoDB;
        public static int AccountStatusReader, IDReader, UserRow;
        public static string NameReader, UsernameReader, EmailReader,
            SelectedUsername;
        public static DateTime BirthdateReader;
        public static string mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public AdminForm()
        {
            InitializeComponent();
            Method.EclipsePhotoBox(Photo);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
            
            object select = UserDGV;
            DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(1,3);
            UserDGV_CellContentClick_1(select, args);  
        }

        public void LoadUserData()
        {
            try
            {
                connection.Open();
                string sql = "SELECT accounts.AccountID, accounts.Username, accounts.Status, " +
                             "salon_employees.Name, salon_employees.Email, salon_employees.Birthdate, " +
                             "salon_employees.AccountStatus, salon_employees.ServiceID, salon_employees.Availability " +
                             "FROM accounts " +
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
        }


        private void UserTab_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            DiscardFunc();
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.ShowLogin();
                    break;
                }
            }
        }

        private void ChangeRoleBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (IDReader < 10000)
            {
                result = MessageBox.Show
                    ($"Promoting the user {UsernameReader}.\n" +
                    $"Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                result = MessageBox.Show
                    ($"Demoting the user {UsernameReader}.\n" +
                    $"Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (result == DialogResult.Yes)
            {
                int newID = Method.GenerateID(IDReader);
                ChangeUserID(UsernameReader, newID);
                LoadUserData();

                object select = UserDGV;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(3, UserRow);
                UserDGV_CellContentClick_1(select, args);
                DiscardFunc();   
            }
        }

        public static void ChangeUserID(string user, int newID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    MySqlCommand cmd = connection.CreateCommand();
                    MySqlTransaction transaction;
                    transaction = connection.BeginTransaction();
                    cmd.Transaction = transaction;

                    try
                    {
                        string query =
                            "UPDATE salon_employees " +
                            "JOIN accounts ON salon_employees.AccountID = accounts.AccountID " +
                            "SET salon_employees.AccountID = @NewAccountID, accounts.AccountID = @NewAccountID " +
                            "WHERE salon_employees.AccountID = @OldAccountID;";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@NewAccountID", newID);
                        cmd.Parameters.AddWithValue("@OldAccountID", user); // Use user parameter instead of IDReader
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\nat ChangeUserID()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Discard changes for the user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DiscardFunc();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ReadUserData(IDReader);
            string tempName = NameBox.Text;
            string tempUsername = UsernameBox.Text;
            string tempEmail = EmailBox.Text;

            if (!Method.ValidEmail(tempEmail))
            {
                MessageBox.Show("Please provide a valid email address.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Save the current changes for user {UsernameReader}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            Method.ChangeUserData(tempName, tempUsername, PhotoLocal, IDReader);
            LoadUserData();

            UserDGV_CellContentClick_1(null, null);
            DiscardFunc();
        }


        private void BirthdayPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            UsernameBox.Enabled = true;
            EmailBox.Enabled = true;
            UploadBtn.Enabled = true;
            SaveBtn.Visible = true;
            ChangeRoleBtn.Visible = true;
            DiscardBtn.Visible = true;
            EditBtn.Visible = false;
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
                    PhotoLocal = ms.ToArray();
                }
            }
        }

        public void DisplayUserData(byte[] PhotoInput, string NameInput, string UsernameInput, string EmailInput, DateTime BirthdateInput, int Status, int IDInput)
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
            StatusBox.Text = Status.ToString();
            IDBox.Text = IDInput.ToString();
        }

        private void UserDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (UserDGV.Rows.Count == 0)
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
                    DisplayUserData(PhotoDB, NameReader, UsernameReader, EmailReader, BirthdateReader, AccountStatusReader, IDReader);
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        public void DiscardFunc()
        {
            EditBtn.Visible = true;
            NameBox.Enabled = false;
            UsernameBox.Enabled = false;
            EmailBox.Enabled = false;
            UploadBtn.Enabled = false;
            SaveBtn.Visible = false;
            ChangeRoleBtn.Visible = false;
            DiscardBtn.Visible = false;

            LoadUserData();

            object select = UserDGV;
            DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(3, UserRow);
            UserDGV_CellContentClick_1(select, args);
        }

        public static void ReadUserData(int accountID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "SELECT accounts.AccountID, accounts.Username, accounts.Password, accounts.Status, " +
                                    "salon_employees.Name, salon_employees.Photo, salon_employees.Email, salon_employees.Birthdate, " +
                                    "salon_employees.AccountStatus, salon_employees.ServiceID, salon_employees.Availability " +
                                    "FROM accounts " +
                                    "JOIN salon_employees ON accounts.AccountID = salon_employees.AccountID " +
                                    "WHERE accounts.AccountID = @accountID";

                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@accountID", accountID);
                        using (MySqlDataReader reader = querycmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IDReader = Convert.ToInt32(reader["AccountID"]);
                                NameReader = reader["Name"].ToString();
                                UsernameReader = reader["Username"].ToString();
                                EmailReader = reader["Email"].ToString();
                                AccountStatusReader = Convert.ToInt32(reader["AccountStatus"]);
                                BirthdateReader = (DateTime)reader["Birthdate"];
                                if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                                {
                                    long byteSize = reader.GetBytes(reader.GetOrdinal("Photo"), 0, null, 0, 0);
                                    byte[] photoBytes = new byte[byteSize];
                                    reader.GetBytes(reader.GetOrdinal("Photo"), 0, photoBytes, 0, (int)byteSize);
                                    PhotoDB = photoBytes;
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
                MessageBox.Show(e.Message + "\n\nat ReadUserData()", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
