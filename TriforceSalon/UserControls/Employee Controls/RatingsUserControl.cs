﻿using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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

namespace TriforceSalon.UserControls.Employee_Controls
{
    public partial class RatingsUserControl : UserControl
    {
        EmployeeTicketTransaction ticket = new EmployeeTicketTransaction();
        private int ratingsNumber;
        private int customerNumber = 0;
        public long ID = 0;
        public int serviceID = 0;
        private string mysqlcon;
        public RatingsUserControl()
        {
            InitializeComponent();
            mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
            EmpID.Text = Convert.ToString(Method.AccountID);
            ServiceVarID.Text = Convert.ToString(EmployeeLock.serviceID);
            Cnum.Text = Convert.ToString(EmployeeLock.customerID);

            RBtn1.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn2.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn3.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn4.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;
            RBtn5.CheckedChanged += Guna2CustomRadioButton_CheckedChanged;

        }

        private void Guna2CustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomRadioButton radioButton = sender as Guna2CustomRadioButton;

            // Check which radio button triggered the event
            switch (radioButton.Name)
            {
                case "RBtn1":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the first radio button
                        RatingsLbl.Text = "Unsatisfied";
                        SatisfactionImagePicB.Image = Properties.Resources.Unsatisfied;
                        ratingsNumber = 1;
                    }
                    break;

                case "RBtn2":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the second radio button
                        RatingsLbl.Text = "Bad";
                        SatisfactionImagePicB.Image = Properties.Resources.Bad;
                        ratingsNumber = 2;
                    }
                    break;

                case "RBtn3":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the third radio button
                        RatingsLbl.Text = "Neutral";
                        SatisfactionImagePicB.Image = Properties.Resources.Neutral;
                        ratingsNumber = 3;
                    }
                    break;

                case "RBtn4":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the fourth radio button
                        RatingsLbl.Text = "Satisfied";
                        SatisfactionImagePicB.Image = Properties.Resources.Satisfied;
                        ratingsNumber = 4;
                    }
                    break;

                case "RBtn5":
                    if (radioButton.Checked)
                    {
                        // Perform actions for the fifth radio button
                        RatingsLbl.Text = "Very Satisfied";
                        SatisfactionImagePicB.Image = Properties.Resources.Very_Satisfied;
                        ratingsNumber = 5;
                    }
                    break;

                default:
                    // Handle the default case if necessary
                    MessageBox.Show("Paano ka nakarating dito");
                    break;
            }
        }

        public void GetCustomerService(long a_ID, int a_serviceID)
        {
            ID = a_ID;
            serviceID = a_serviceID;
        }

        private async void SubmitResponseBtn_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(EmpID.Text);
            string n_serviceID = Convert.ToString(ServiceVarID.Text);
            long n_cNum = Convert.ToInt64(Cnum.Text);

            try
            {
                using(var conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();
                    string query = "Update employee_records SET CustomerRating = @rating WHERE CustomerID = @customerID AND AccountID = @empID AND ServiceID = @serviceID";
                    using(MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@rating", ratingsNumber);
                        command.Parameters.AddWithValue("@customerID", n_cNum);
                        command.Parameters.AddWithValue("@empID", empID);
                        command.Parameters.AddWithValue("@serviceID", n_serviceID);


                        await command.ExecuteNonQueryAsync();
                    }
                    MessageBox.Show("Rating have been submitted", "Employee Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ticket.ShowCustomerList();
                    EmployeeUserConrols.employeeUserConrolsInstance.RefreshBtn.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
