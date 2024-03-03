using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.UserControls.Receptionist_Controls
{
    public partial class PaymentsUserControls : UserControl
    {
        //UNPAID, PAID, VOID
        public static string CustomerName, ServiceType, ServiceVariation, PriorityStatus;
        public static int TransactionID, Age, Phone, EmployeeID, VariationID, Amount;


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        DateTime Time;

        public PaymentsUserControls()
        {
            InitializeComponent();
        }

        private void PaymentsUserControls_Load(object sender, EventArgs e)
        {

        }
    }
}
