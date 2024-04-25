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
        public static string TransactionID;
        private bool ticketSelected = false;

        public event EventHandler<ScheduleSelectedEventArgs> TicketChanged;

        
        public string Ticket => TransactionIDLbl.Text;
        public string Queue => QueueNumLbl.Text;

        public QueueDisplay(string ticket, string queue)
        {
            InitializeComponent();
            TransactionIDLbl.Text = ticket;
            QueueNumLbl.Text = queue;
        }

        internal EventHandler<QueueSelectedEventArgs> SelectedQueue { get; set; }

        internal class QueueSelectedEventArgs
        {

        }

        public class ScheduleSelectedEventArgs
        {
            public string TransactionID { get; }
            public string Queue { get; }

            public ScheduleSelectedEventArgs(string ticket, string queue)
            {
                TransactionID = ticket;
                Queue = queue;
            }
        }

        private void QueueTicket_Click(object sender, EventArgs e)
        {
            TransactionID = TransactionIDLbl.Text;


            if (ticketSelected)
            {
                TransactionID = TransactionIDLbl.Text;
                QueueTicket.FillColor = Color.White;

                TransactionIDLbl.ForeColor = Color.Black;
                QueueNumLbl.ForeColor = Color.Black;
                RefLbl.ForeColor = Color.Black;
            }
            else
            {
                TransactionID = null;
                QueueTicket.FillColor = Color.FromArgb(140, 113, 209);

                TransactionIDLbl.ForeColor = Color.White;
                QueueNumLbl.ForeColor = Color.White;
                RefLbl.ForeColor = Color.White;
            }

            ticketSelected = !ticketSelected;
        }
    }
}
