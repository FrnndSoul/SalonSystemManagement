using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon
{
    internal class UIVisibilityClass
    {
        public static void ShowLogin()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainForm mainForm)
                {
                    mainForm.signinPage1.Visible = false;
                    break;
                }
            }
        }
    }
}
