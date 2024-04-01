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

            // Initialize the timer
            timer = new System.Threading.Timer(TimerCallback, null, 0, 1000); // Update every 1000 milliseconds (1 second)
        }

        private void TimerCallback(object state)
        {
            // Update the label with the current date and time
            UpdateClockLabel();
        }

        private void UpdateClockLabel()
        {
            // Get the current date and time
            DateTime currentTime = DateTime.Now;

            // Format the date and time as a string
            string formattedDateTime = currentTime.ToString(dateTimeFormat);

            // Update the label in the UI
            if (label.InvokeRequired)
            {
                // If called from a different thread, invoke it on the UI thread
                label.BeginInvoke((Action)(() => label.Text = formattedDateTime));
            }
            else
            {
                label.Text = formattedDateTime;
            }
        }

        public void Stop()
        {
            // Stop the timer when needed
            timer?.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}
