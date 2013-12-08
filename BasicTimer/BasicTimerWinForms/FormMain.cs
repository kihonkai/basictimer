using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTimerWinForms
{
    public enum ControlState{
        TimerStopped,
        TimerRunning
    }

    public partial class FormMain : Form
    {
        private int secondsLeft;
        const int SecondsPerMinute = 60;
        const int MillisecondsPerSecond = 1000;

        public FormMain()
        {
            InitializeComponent();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            this.secondsLeft -= (this.timerMain.Interval / MillisecondsPerSecond);
            this.TimeToLabel();
            if (this.secondsLeft == 0)
            {
                this.timerMain.Enabled = false;
                using (FormTimerEnd form = new FormTimerEnd())
                {
                    form.ShowDialog();
                }
                SetControlState(ControlState.TimerStopped);
            }
        }

        private void TimeToLabel()
        {
            TimeSpan timeLeft;
            timeLeft = TimeSpan.FromSeconds(this.secondsLeft);
            this.labelTimer.Text = timeLeft.ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int minutes;

            SetControlState(ControlState.TimerRunning);

            minutes = Int32.Parse(button.Tag.ToString());
            StartTimer(minutes);
        }

        private void SetControlState(ControlState state)
        {
            switch (state)
            {
                case ControlState.TimerStopped:
                    this.groupBoxStartTimers.Enabled = true;
                    this.groupBoxControls.Enabled = false;
                    break;
                case ControlState.TimerRunning:
                    this.groupBoxStartTimers.Enabled = false;
                    this.groupBoxControls.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void StartTimer(int minutes)
        {
            this.secondsLeft = minutes * SecondsPerMinute;
            this.TimeToLabel();
            this.timerMain.Enabled = true;
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            this.timerMain.Enabled = false;
            SetControlState(ControlState.TimerStopped);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox form = new AboutBox())
            {
                form.ShowDialog();
            }
        }
    }
}
