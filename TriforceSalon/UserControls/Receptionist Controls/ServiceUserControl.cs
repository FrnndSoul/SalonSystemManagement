using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using ZstdSharp.Unsafe;

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
        public KeypressLettersRestrictions keypressLettersRestrictions = new KeypressLettersRestrictions();
        public KeypressNumbersRestrictions keypressNumbersRestrictions = new KeypressNumbersRestrictions();

        public ServicesUserControl()
        {
            InitializeComponent();
            servicesUserControlInstance = this;
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";

            serviceTypeService = new GetServiceType_ServiceData();
            CustomerNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            CustomerAgeTxtB.KeyPress += keypressLettersRestrictions.KeyPress;
            CustomerPhoneNTxtB.KeyPress += keypressLettersRestrictions.KeyPress;

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
            if(CustomerNameTxtB.Text is null || CustomerAgeTxtB.Text is null || CustomerPhoneNTxtB is null
                || ServiceAmountTxtB.Text is null || ServiceTxtB.Text is null)
            {
                MessageBox.Show("Please fill all the customer information needed", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure with the information inputted correct?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string serviceName = ServiceTxtB.Text;
                transactionMethods.GetServiceTypeID(serviceName);
                transactionMethods.ProcessCustomer(serviceName, transactionMethods.GetServiceTypeID(serviceName));
            }
        }
    }
}