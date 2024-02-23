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

namespace TriforceSalon.UserControls
{
    public partial class WalkInTransactionForm : UserControl
    {
        public static WalkInTransactionForm walkInTransactionFormInstance;
        public PopulateDataGridView populateMethods;
        public WalkInTransactionForm()
        {
            InitializeComponent();
            walkInTransactionFormInstance = this;
        }

        private void ServicesComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ServicesComBox.SelectedItem.ToString();
            populateMethods.filterEmployees(value);
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(EmployeeListDGV.SelectedRows[0].Cells["Emp_ID"].Value);
            populateMethods.SetEmployeeStatus(empID);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populateMethods.UpdateEmployees(populateMethods.GetEmployees());
            populateMethods.EmployeeDetails();
        }
    }
}
