using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        public static void LoadDetails(int referenceNumber)
        {
            TicketDetails details = new TicketDetails();
            ticketviewInstance.Controls.Add(details);
            details.Location = new Point(1070, 100);
            details.BringToFront();
            details.ReadTicketDetails(referenceNumber);
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
            if (TicketDGV.Rows.Count <= 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure this ticket has been resolved?\nConfirm before closing the ticket.",
                "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (TicketDGV.SelectedCells.Count > 0)
                {
                    int ticketRow = TicketDGV.SelectedCells[0].RowIndex;
                    if (ticketRow >= 0 && ticketRow < TicketDGV.Rows.Count)
                    {
                        int selectedRefNum = Convert.ToInt32(TicketDGV.Rows[ticketRow].Cells["ReferenceNumber"].Value);
                        AdminTicketing.CloseTicket(selectedRefNum);
                        Reloadtable();
                    }
                }
            }
        }

        private void LoadTicket_Click(object sender, EventArgs e)
        {
            if (TicketDGV.Rows.Count <= 0)
            {
                return;
            }

            if (TicketDGV.SelectedCells.Count > 0)
            {
                int ticketRow = TicketDGV.SelectedCells[0].RowIndex;
                if (ticketRow >= 0 && ticketRow < TicketDGV.Rows.Count)
                {
                    int RefNum = Convert.ToInt32(TicketDGV.Rows[ticketRow].Cells["ReferenceNumber"].Value);
                    LoadDetails(RefNum);
                }
            }
        }
    }
}