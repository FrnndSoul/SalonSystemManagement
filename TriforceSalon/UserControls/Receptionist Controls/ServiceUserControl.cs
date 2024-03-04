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
        private readonly GetServiceType_ServiceData serviceTypeService;
        public readonly string mysqlcon;
        private PictureBox pic;
        private Label serviceTypeLbl;
        TransactionMethods transactionMethods = new TransactionMethods();

        public ServicesUserControl()
        {
            InitializeComponent();
            servicesUserControlInstance = this;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

            serviceTypeService = new GetServiceType_ServiceData();
            GetServiceTypeData();
            GetServiceData();
        }

        public void GetServiceTypeData()
        {
            serviceTypeService.GetServiceTypeData(ServiceTypeFL, mysqlcon, UpdateServiceFL);
        }

        public void GetServiceData()
        {
            serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
        }

        private void UpdateServiceFL(string serviceTypeID)
        {
            serviceTypeService.UpdateServiceFL(ServiceFL, serviceTypeID, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
        }

        private void ProcessCustomerBtn_Click(object sender, System.EventArgs e)
        {
            string serviceName = ServiceTxtB.Text;
            transactionMethods.GetServiceTypeID(serviceName);
            transactionMethods.ProcessCustomer(serviceName, transactionMethods.GetServiceTypeID(serviceName));
        }
    }
}