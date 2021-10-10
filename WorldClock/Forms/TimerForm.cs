namespace WorldClock.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class TimerForm : Form
    {
        int timerCount = 0;
        Timer timer = new Timer();
        string endTime = string.Empty;
        public TimerForm()
        {
            InitializeComponent();
            this.startButton.Click += StartTimerOnClick;
            this.pauseButton.Click += PauseButton;
        }

        private void PauseButton(object sender, EventArgs e)
        {
            timer.Stop();
            this.startButton.Enabled = true;
        }

        private void StartTimerOnClick(object sender, EventArgs e)
        {
            this.timerTextBox.Enabled = false;
            this.startButton.Enabled = false;
            endTime = this.timerTextBox.Text;
            timer.Interval = 1000; // 1 sec
            if (timerCount == 0)
            {
                timer.Tick += new EventHandler(OnTick);
            }
            timerCount = int.Parse(this.timerTextBox.Text);
            timer.Start();
            Console.WriteLine("started timer");

        }
        public void OnTick(object sender, EventArgs e)
        {

            timerCount--;
            if (timerCount == 0)
            {
                timer.Stop();
                this.timerTextBox.Text = "Done";
                return;
            }

            this.timerTextBox.Text = timerCount.ToString();
        }

    }
}
