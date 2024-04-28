using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Web.UI.WebControls.Adapters;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Ticket_System;

namespace TriforceSalon
{
    public partial class QueueForm : Form
    {
        public static QueueForm queueInstance;
        QueueMethods queueMethods = new QueueMethods();
        int EmpID = 0;
        public string EmpSpecialist;

        public QueueForm()
        {
            InitializeComponent();
            queueInstance = this;
        }
        private async void QueueForm_Load(object sender, EventArgs e)
        {
            await queueMethods.GetEmployee(EmployeeDGV);
            await queueMethods.InSessionDisplay(InsessionFL);
        }
        private async void EmployeeDGV_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = EmployeeDGV.Rows[e.RowIndex];

                string EmpName = Convert.ToString(selectedRow.Cells["EmpNameCol"].Value);
                EmpID = Convert.ToInt32(selectedRow.Cells["EmpIDCol"].Value);
                EmpSpecialist = Convert.ToString(selectedRow.Cells["EmpSpecialistCol"].Value);

                await queueMethods.CombinedQueue(EmpSpecialist, QueueFL, EmpID);
            }
        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MessageBox.Show("Closing this form is not allowed", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void ServeBtn_Click(object sender, EventArgs e)
        {
            if (QueueDisplay.TransactionID == -1 || QueueDisplay.ServiceVar == null)
            {
                MessageBox.Show("No customer has been selected", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                int serviceID = await queueMethods.GetServiceVariationID(QueueDisplay.ServiceVar);
                await queueMethods.ProcessCustomerAsync(QueueDisplay.TransactionID, serviceID, EmpID);
                await queueMethods.GetEmployee(EmployeeDGV);
                await queueMethods.CombinedQueue(EmpSpecialist, QueueFL, EmpID);
                await queueMethods.InSessionDisplay(InsessionFL);
            }
            QueueDisplay.TransactionID = -1;
            QueueDisplay.ServiceVar = null;
        }
    }
}
