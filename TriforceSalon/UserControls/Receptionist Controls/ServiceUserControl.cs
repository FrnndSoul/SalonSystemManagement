using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class ServicesUserControl : UserControl
    {
        public static ServicesUserControl servicesUserControlInstance;
        public readonly string mysqlcon;
        private PictureBox pic;
        private Label serviceTypeLbl;
        TransactionMethods transactionMethods = new TransactionMethods();

        public ServicesUserControl()
        {
            InitializeComponent();
            servicesUserControlInstance = this;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

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

        private void ProcessCustomerBtn_Click(object sender, System.EventArgs e)
        {
            string serviceName = ServiceTxtB.Text;
            transactionMethods.GetServiceTypeID(serviceName);
            transactionMethods.ProcessCustomer(serviceName, transactionMethods.GetServiceTypeID(serviceName));
        }
    }
}