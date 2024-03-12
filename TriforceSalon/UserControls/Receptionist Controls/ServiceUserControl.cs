using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class ServicesUserControl : UserControl
    {
        public static ServicesUserControl servicesUserControlInstance;
        private readonly GetServiceType_ServiceData serviceTypeService = new GetServiceType_ServiceData();
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

            //serviceTypeService = new GetServiceType_ServiceData();
            CustomerNameTxtB.KeyPress += keypressNumbersRestrictions.KeyPress;
            CustomerAgeTxtB.KeyPress += keypressLettersRestrictions.KeyPress;
            CustomerPhoneNTxtB.KeyPress += keypressLettersRestrictions.KeyPress;

           /* GetServiceTypeData();
            GetServiceData();*/
        }

        private async void ServicesUserControl_Load(object sender, System.EventArgs e)
        {
            await serviceTypeService.GetServiceTypeData(ServiceTypeFL, mysqlcon, UpdateServiceFL);
            await serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);

            await serviceTypeService.GetAllEmployee(mysqlcon);
            transactionIDTxtB.Text = Convert.ToString(transactionMethods.GenerateTransactionID());

        }

        /*public void GetServiceTypeData()
        {
            serviceTypeService.GetServiceTypeData(ServiceTypeFL, mysqlcon, UpdateServiceFL);
        }

        public void GetServiceData()
        {
            serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
        }*/

        private async void UpdateServiceFL(string serviceTypeID)
        {
            await serviceTypeService.UpdateServiceFL(ServiceFL, serviceTypeID, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
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

        private async void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            string search = SearchServiceTxtB.Text;

            try {
                await serviceTypeService.GetServiceDataForSearch(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB, search);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void GetAllServiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceFL.Controls.Clear();
                await serviceTypeService.GetServiceData(ServiceFL, mysqlcon, ServiceTxtB, ServiceAmountTxtB);
                await serviceTypeService.GetAllEmployee(mysqlcon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}