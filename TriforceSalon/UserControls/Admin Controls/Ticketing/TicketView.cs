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
using TriforceSalon.UserControls.Admin_Controls.Ticketing;

namespace TriforceSalon.UserControls.Admin_Controls
{
    public partial class TicketView : UserControl
    {
        public static TicketView ticketviewInstance;

        public TicketView()
        {
            InitializeComponent();
            ticketviewInstance = this;
            Reloadtable();
            LoadSubmission();
        }

        public static void LoadSubmission()
        {
            Submission submission = new Submission();
            ticketviewInstance.Controls.Add(submission);
            submission.Location = new Point(1070, 100);
        }

        public void Reloadtable()
        {
            TicketDGV.DataSource = AdminTicketing.GetAdminTickets();
            TicketDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            TicketDGV.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(ticketviewInstance);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            TicketDGV.DataSource = AdminTicketing.GetAdminTickets();
            TicketDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            TicketDGV.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void CloseTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
