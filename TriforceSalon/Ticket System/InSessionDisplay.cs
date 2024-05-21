using System;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.Ticket_System
{
    public partial class InSessionDisplay : UserControl
    {
        QueueMethods queueMethods = new QueueMethods();

        public event EventHandler<ScheduleSelectedEventArgs> TicketChanged;

        public string ServiceVariation => ServiceVarLbl.Text;
        public string Ticket => TransactionIDLbl.Text;
        public string Queue => QueueNumLbl.Text;
        public string EmpID => EmpIDLbl.Text;
        public InSessionDisplay(string ticket, string queue, string serviceVariation, string empID)
        {
            InitializeComponent();
            ServiceVarLbl.Text = serviceVariation;
            TransactionIDLbl.Text = ticket;
            QueueNumLbl.Text = queue;
            EmpIDLbl.Text = empID;
        }
        internal EventHandler<QueueSelectedEventArgs> InSessionQueue { get; set; }

        internal class QueueSelectedEventArgs
        {

        }

        public class ScheduleSelectedEventArgs
        {
            public string TransactionID { get; }
            public string Queue { get; }
            public string ServiceVariation { get; }
            public string EmpID { get; }

            public ScheduleSelectedEventArgs(string ticket, string queue, string serviceVariation,string empID)
            {
                ServiceVariation = serviceVariation;
                TransactionID = ticket;
                Queue = queue;
                EmpID = empID;
            }
        }

        private async void ServiceDoneBtn_Click(object sender, EventArgs e)
        {
            long customerID = Convert.ToInt64(TransactionIDLbl.Text);
            int serviceVarID = await queueMethods.GetServiceVariationID(ServiceVarLbl.Text);
            string accountID = EmpIDLbl.Text;

            await queueMethods.EmployeeProcessCompleteAsync(customerID,serviceVarID,accountID);
            await queueMethods.InSessionDisplay(QueueForm.queueInstance.InsessionFL);
            await queueMethods.GetEmployee(QueueForm.queueInstance.EmployeeDGV);

        }
    }
}
