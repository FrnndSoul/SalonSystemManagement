using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriforceSalon.Class_Components
{

    public class KeypressNumbersRestrictions
    {
        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignore the input
            }
        }
    }
    public class KeypressLettersRestrictions
    {
        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow digits, period, and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignore the input
            }
        }
    }

}
