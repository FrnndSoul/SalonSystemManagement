﻿using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon.Test
{
    public partial class CustomerTicket : UserControl
    {
        EmployeeTicketTransaction empTransaction = new EmployeeTicketTransaction();
        public static CustomerTicket customerTicketInstance;


        public event EventHandler<ScheduleSelectedEventArgs> TicketChanged;
        public string CustomerName => NameLbl.Text;
        public string CustomerAge => AgeLbl.Text;
        public string CustomerNumber => PhoneNumberLbl.Text;
        public string Service => ServiceVarLbl.Text;
        //public string PredEmp => PreferredEmpLbl.Text;
        public string Status => PrioStatusLbl.Text;
        public string Ticket => TicketLbl.Text;

        public CustomerTicket(string CustomerName, string CustomerAge, string CustomerNumber, string Service, string Status, string Ticket)
        {
            InitializeComponent();
            customerTicketInstance = this;

            NameLbl.Text = CustomerName;
            AgeLbl.Text = CustomerAge;
            PhoneNumberLbl.Text = CustomerNumber;
            ServiceVarLbl.Text = Service;
            //PreferredEmpLbl.Text = PredEmp;
            PrioStatusLbl.Text = Status;
            TicketLbl.Text = Ticket;

        }

        internal EventHandler<CustomerSelectedEventArgs> CustomerSelected { get; set; }


        internal class CustomerSelectedEventArgs
        {

        }

        private async void ProcessCustomerBtn_Click(object sender, EventArgs e)
        {
            ProcessCustomerBtn.Enabled = false;
            int ticketID = Convert.ToInt32(TicketLbl.Text);
            string serviceName = ServiceVarLbl.Text;

            try
            {
                await empTransaction.ProcessTicketAsync(ticketID);
                await empTransaction.FetchServiceImageAsync(serviceName);
                empTransaction.PassValueToLock();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                

        }
    }

    public class ScheduleSelectedEventArgs
    {
        public string CustomerName { get; }
        public string CustomerAge { get; }
        public string CustomerNumber { get; }
        public string Service { get; }
        //public string PredEmp { get; }
        public string Status { get; }
        public string Ticket { get; }

        public ScheduleSelectedEventArgs(string customerName, string customerAge, string customerNumber, string service, string status, string ticket)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            CustomerNumber = customerNumber;
            Service = service;
            //PredEmp = predEmp;
            Status = status;
            Ticket = ticket;

        }
    }

}