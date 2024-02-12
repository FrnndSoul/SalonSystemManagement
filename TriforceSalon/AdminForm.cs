using MySql.Data.MySqlClient;
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

namespace TriforceSalon
{
    public partial class AdminForm : UserControl
    {
        public static byte[] PhotoLocal, PhotoDB;
        public static int AccountStatusReader, IDReader;
        public static string NameReader, UsernameReader, EmailReader,
            SelectedUsername;
        public static DateTime BirthdateReader;
        public static string mysqlcon = "server=localhost;user=root;database=salondb;password=";
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
                string sql = "SELECT `ID`, `Name`, `Username`, `Email`, `Birthdate`, `AccountStatus` FROM `users`";
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
                MessageBox.Show("An error occurred: " + e.Message);
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
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.ShowLogin();
                    break;
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
            int selectedRowIndex = UserDGV.SelectedCells[0].RowIndex;

            if (selectedRowIndex < 0 || selectedRowIndex >= UserDGV.Rows.Count)
            {
                return;
            }
            
            string username = UserDGV.Rows[selectedRowIndex].Cells["Username"].Value.ToString();
            if (username != SelectedUsername)
            {
                ReadUserData(SelectedUsername);
                DisplayUserData(PhotoDB, NameReader, UsernameReader, EmailReader, BirthdateReader, AccountStatusReader, IDReader);
            }
        }

        public static void Timer()
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NameBox.Enabled = true;
                UsernameBox.Enabled = true;
                EmailBox.Enabled = true;
                UploadBtn.Enabled = true;
            }
            else
            {
                NameBox.Enabled = false;
                UsernameBox.Enabled = false;
                EmailBox.Enabled = false;
                UploadBtn.Enabled = false;
                //UserDGV.SelectionMode = DataGridViewSelectionMode(null);
            }
        }

        public static void ReadUserData(string user)
        {
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
                                IDReader = Convert.ToInt32(reader["ID"]);
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

    }
}
