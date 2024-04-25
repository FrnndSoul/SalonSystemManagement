using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.Ticket_System
{
    public partial class QueueDisplay : UserControl
    {
        public event EventHandler<ScheduleSelectedEventArgs> TicketChanged;

        public string CustomerName => NameLbl.Text;
        public string Service => ServiceLbl.Text;
        public string Status => StatusLbl.Text;
        public string Ticket => TransactionIDLbl.Text;
        public string Queue => QueueNumLbl.Text;

        public QueueDisplay(string customerName, string service, string status, string ticket, string queue)
        {
            InitializeComponent();
            NameLbl.Text = customerName;
            ServiceLbl.Text = service;
            StatusLbl.Text = status;
            TransactionIDLbl.Text = ticket;
            QueueNumLbl.Text = queue;
        }

        internal EventHandler<QueueSelectedEventArgs> SelectedQueue { get; set; }

        internal class QueueSelectedEventArgs
        {

        }

        public class ScheduleSelectedEventArgs
        {
            public string CustomerName { get; }
            public string Service { get; }
            public string Status { get; }
            public string TransactionID { get; }
            public string Queue { get; }

            public ScheduleSelectedEventArgs(string customerName, string service, string status, string ticket, string queue)
            {
                CustomerName = customerName;
                Service = service;
                Status = status;
                TransactionID = ticket;
                Queue = queue;
            }
        }

        private void ServeBtn_Click(object sender, EventArgs e)
        {

        }
    }


}
