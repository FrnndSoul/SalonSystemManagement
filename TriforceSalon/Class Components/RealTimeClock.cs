using System;
using System.Threading;
using System.Windows.Forms;

namespace TriforceSalon.Class_Components
{
    public class RealTimeClock
    {
        private System.Threading.Timer timer;
        private Label label;
        private string dateTimeFormat;

        public RealTimeClock(Label targetLabel, string format)
        {
            label = targetLabel;
            dateTimeFormat = format;
            timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
        }
        private void TimerCallback(object state)
        {
            UpdateClockLabel();
        }

        private void UpdateClockLabel()
        {
            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString(dateTimeFormat);
            if (label.InvokeRequired)
            {
                label.BeginInvoke((Action)(() => label.Text = formattedDateTime));
            }
            else
            {
                label.Text = formattedDateTime;
            }
        }
    }
}
