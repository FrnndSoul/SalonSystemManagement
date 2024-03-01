using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class ServicesUserControl : UserControl
    {
        public ServicesUserControl servicesUserControlInstance;
        public readonly string mysqlcon;
        private PictureBox pic;
        private Label serviceTypeLbl;

        public ServicesUserControl()
        {
            InitializeComponent();
            servicesUserControlInstance = this;
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";

            GetServiceTypeData();
        }

        public void GetServiceTypeData()
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT ServiceTypeName, ServiceTypeImage, ServiceID FROM service_type";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<Control> controls = new List<Control>();

                        while (reader.Read())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceTypeImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image mealImage = Image.FromStream(ms);
                                pic = new PictureBox
                                {
                                    Width = 100,
                                    Height = 100,
                                    BackgroundImage = mealImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceID"].ToString(),
                                    Margin = new Padding(20)
                                };

                                serviceTypeLbl = new Label
                                {
                                    Text = reader["ServiceTypeName"].ToString(),
                                    Width = 25,
                                    Height = 15,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Dock = DockStyle.Right,
                                    BackColor = Color.White,
                                };

                                pic.Controls.Add(serviceTypeLbl);
                                controls.Add(pic);
                            }
                        }
                        ServiceTypeFL.Controls.Clear();
                        ServiceTypeFL.Controls.AddRange(controls.ToArray());
                    }
                }
            }
        }
    }
}
