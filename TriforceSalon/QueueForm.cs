using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriforceSalon.Class_Components;
using TriforceSalon.Ticket_System;

namespace TriforceSalon
{
    public partial class QueueForm : Form
    {
        QueueMethods queueMethods = new QueueMethods();

        public QueueForm()
        {
            InitializeComponent();
        }
        private async void QueueForm_Load(object sender, EventArgs e)
        {
            await queueMethods.GetEmployee(EmployeeDGV);
        }
        private async void EmployeeDGV_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = EmployeeDGV.Rows[e.RowIndex];

                string EmpName = Convert.ToString(selectedRow.Cells["EmpNameCol"].Value);
                string EmpID = Convert.ToString(selectedRow.Cells["EmpIDCol"].Value);
                string EmpSpecialistCol = Convert.ToString(selectedRow.Cells["EmpSpecialistCol"].Value);

                await queueMethods.GeneralQueue(EmpSpecialistCol, GeneralQueue);
            }
        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MessageBox.Show("Action not allowed", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ServeBtn_Click(object sender, EventArgs e)
        {
            if (QueueDisplay.TransactionID == null)
            {
                MessageBox.Show("No customer has been selected", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            QueueDisplay.TransactionID = null;
        }
    }
}
