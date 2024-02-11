using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace TriforceSalon
{
    public partial class AdminForm : UserControl
    {
        public static string mysqlcon = "server=localhost;user=root;database=salondb;password=";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public AdminForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadUserData()
        {
            try
            {
                connection.Open();
                string sql = "SELECT `ID`, `Name`, `Username`, `Email`, `Password`, `Birthdate`, `AccountStatus` FROM `users`";
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
    }
}
