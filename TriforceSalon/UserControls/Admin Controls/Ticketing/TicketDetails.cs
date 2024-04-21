using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TriforceSalon.UserControls.Admin_Controls.Ticketing
{
    public partial class TicketDetails : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string Type, Accounts, Steps, Status;
        public static int ReferenceNumber;
        public static byte[] Proof;

        public TicketDetails()
        {
            InitializeComponent();
        }

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TicketView.LoadSubmission();
        }

        public async void ReadTicketDetails(int Refnumber)
        {
            await Task.Delay(500);
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    string query = "SELECT `Type`, `Steps`, `Accounts`, `Proof`, `Status` FROM `AdminTickets` WHERE `ReferenceNumber` = @refNumber";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@refNumber", Refnumber);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();

                            Type = reader["Type"].ToString();
                            Accounts = reader["Accounts"].ToString();
                            Steps = reader["Steps"].ToString();
                            Status = reader["Status"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("Proof")))
                            {
                                long byteSize = reader.GetBytes(reader.GetOrdinal("Proof"), 0, null, 0, 0);
                                byte[] photoBytes = new byte[byteSize];
                                reader.GetBytes(reader.GetOrdinal("Proof"), 0, photoBytes, 0, (int)byteSize);
                                Proof = photoBytes;
                            }
                            else
                            {
                                Proof = null;
                            }

                            DisplayDetails();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n@ReadTicketDetails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayDetails()
        {
            if (Proof != null && Proof.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(Proof))
                {
                    Photo.Image = Image.FromStream(stream);
                }
            }
            TypeBox.Text = Type;
            EssayBox.Text = Steps;

            if (Accounts.Contains("None"))
            {
                NoneCheckbox.Checked = true;
            }
            if (Accounts.Contains("Admin"))
            {
                AdminCheckbox.Checked = true;
            }
            if (Accounts.Contains("Manager"))
            {
                ManagerCheckbox.Checked = true;
            }
            if (Accounts.Contains("Receptionist"))
            {
                ReceptionistCheckbox.Checked = true;
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (Proof != null && Proof.Length > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg|All Files|*.*";
                    saveFileDialog.Title = "Save Image";
                    saveFileDialog.FileName = "image";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        try
                        {
                            File.WriteAllBytes(filePath, Proof);
                            MessageBox.Show("Image downloaded successfully.", "Download Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while saving the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to download.", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
