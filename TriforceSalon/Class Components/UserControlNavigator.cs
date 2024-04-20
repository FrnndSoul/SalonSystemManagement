using System.Windows.Forms;

namespace TriforceSalon.Class_Components
{
    public class UserControlNavigator
    {
        public static void ShowControl(System.Windows.Forms.Control control, System.Windows.Forms.Control Content)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);

        }

        public static void ClearPanel(Control Content)
        {
            Content.Controls.Clear();
        }
    }
}
