using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTimer
{
    public partial class frmClock : Form
    {
        private readonly Timer timerclock = new Timer();
        private readonly Timer timerStopWatch = new Timer();
        public frmClock()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            timerclock.Interval = 1000;
            timerclock.Tick += T_Tick;
            timerclock.Start();   
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            var time = DateTime.Now.ToString("hh:mm:ss");

            //update label
            lblClock.Text = time;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblAlert.BackColor = Color.YellowGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtInterVal.Text, out int interval))
            {
                button1.Enabled = false;
                lblAlert.BackColor = Color.YellowGreen;
                timerStopWatch.Stop();
                timerStopWatch.Interval = interval * 60 * 1000;
                timerStopWatch.Start();
                timerStopWatch.Tick -= T2_Tick;
                timerStopWatch.Tick += T2_Tick;
            }
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;

            using (var soundPlayer = new SoundPlayer(@"Done.wav"))
            {
                soundPlayer.Play();
            }
            lblAlert.BackColor = Color.Red;
            timerStopWatch.Stop();
        }
    }
}
