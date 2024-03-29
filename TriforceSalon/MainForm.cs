using System.Web.UI.WebControls;
using System.Windows.Forms;
using TriforceSalon.Class_Components;

namespace TriforceSalon
{
    public partial class MainForm : Form
    {
        public static MainForm mainFormInstance;
        public MainForm()
        {
            InitializeComponent();
            mainFormInstance = this;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            SigninPage signinPage = new SigninPage();
            UserControlNavigator.ShowControl(signinPage, MainFormContent);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Method.LogOutUser();
        }
    }
}
