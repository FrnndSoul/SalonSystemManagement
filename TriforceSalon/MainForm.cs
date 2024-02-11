using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void signinPage1_Load(object sender, EventArgs e)
        {

        }

        public void ShowLogin()
        {
            adminForm1.Visible = false;
            signinPage1.Visible = true;
        }

        public void ShowAdmin()
        {
            adminForm1.Visible = true;
            signinPage1.Visible = false;
        }
    }
}
