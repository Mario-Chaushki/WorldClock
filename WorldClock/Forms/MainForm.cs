namespace WorldClock.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.timerButton.Click += TimerButtonOnClick;
        }

        private void TimerButtonOnClick(object sender, EventArgs e)
        {
            new TimerForm().ShowDialog(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Console.WriteLine("Loaded base");
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 sec
            timer.Tick += new EventHandler(StartClock);
            timer.Start();
            Console.WriteLine("started timer");
        }

        public void StartClock(object sender, EventArgs e)
        {
            this.timeBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
