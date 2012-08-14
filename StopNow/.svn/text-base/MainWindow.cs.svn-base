using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace StopNow
{
    public partial class MainWindow : Form
    {
        private Time time;

        #region Constructors Thread
        public MainWindow()
        {
            StartForms();

            StartUp(SetOptions());
        }

        private void StartForms()
        {
            InitializeComponent();

            toolTip1.SetToolTip(timeLabel, "Time Elpased");
            
            toolTip1.SetToolTip(ppButton, ppButton.Text);
            toolTip1.SetToolTip(StopButton, StopButton.Text);

            notifyIcon1.ContextMenuStrip = trayContextStrip;

            SetProgPercentages();
        }

        private Options SetOptions()
        {
            Options options;

            options.alarmTime = new Clock(0, 30, 0);
            options.breakTime = new Clock(0, 2, 0);
            options.maxIdle = new Clock(0, 2, 0);

            options.preAlarmInterval = 30;
            options.preAlarmCount = 6;

            options.alarm = new Alarm(this, AlarmType.LockWorkstation);
            options.alarmMessage = true;
            options.preAlarm = new Alarm(this);
            options.preAlarmMessage = true;

            options.minimizeToTray = true;

            return options;
        }

        private void StartUp(Options options)
        {
            time = new Time(this, options);
        }
        #endregion

        #region Public Methods
        public void SetProgBar(int prog)
        {
            if (progressBar1.Value != prog)
            {
                progressBar1.Value = prog;
                progressBar1.Refresh();

                SetProgPercentages();
            }
        }

        private void SetProgPercentages()
        {
            notifyIcon1.Text = "StopNow - (" + progressBar1.Value + "%)";
            toolTip1.SetToolTip(progressBar1, progressBar1.Value + "%");
        }

        public void printClock(Clock clock)
        {
            timeLabel.Text = clock.ToString();
        }

        public void HideAll()
        {
            notifyIcon1.ContextMenuStrip = null;
            this.Hide();
        }

        public void ShowAll()
        {
            notifyIcon1.ContextMenuStrip = trayContextStrip;
            this.Show();
        }

        public void SwitchTray()
        {
            if (notifyIcon1.ContextMenuStrip == trayContextStrip)
            {
                notifyIcon1.ContextMenuStrip = alarmTrayContextStrip;
            }
            else
            {
                notifyIcon1.ContextMenuStrip = trayContextStrip;
            }
        }

        public void ShowTrayBalloon(string message)
        {
            if (string.IsNullOrEmpty(message) == false)
            {
                notifyIcon1.ShowBalloonTip(3000, this.Text, message, ToolTipIcon.Warning);
            }
        }
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow_FormClosing(this, new FormClosingEventArgs(CloseReason.None, true));
        }

        private void exitTrayContextStripItem_Click(object sender, EventArgs e)
        {
            MainWindow_FormClosing(this, new FormClosingEventArgs(CloseReason.None, true));
        }

        private void exitAlarmTrayContextStripItem_Click(object sender, EventArgs e)
        {
            MainWindow_FormClosing(this, new FormClosingEventArgs(CloseReason.None, true));
        }
        #endregion

        #region Play/Pause
        private void ppButton_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void ppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void ppTrayContextStripItem_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void PlayPause()
        {
            if (time.IsPlaying() == true)
            {
                ppButton.Text = "Play";
                toolTip1.SetToolTip(ppButton, "Play");
                time.PauseTimer();
            }
            else
            {
                ppButton.Text = "Pause";
                toolTip1.SetToolTip(ppButton, "Pause");
                time.StartTimer();
            }
        }
        #endregion

        #region Stop
        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void stopTrayContextStripItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            if (MessageBox.Show(this, "Are you sure you want to start the alarm?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                time.Alarm();
            }
        }
        #endregion

        #region Options
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time.CreateOptionsWindow();
        }
        #endregion

        #region About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }
        #endregion

        #region Minimizes
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (notifyIcon1.ContextMenuStrip != null)
            {
                if (this.Visible == true)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
                else
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Focus();
                }
            }
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (time.CheckMinimizeToTray() && this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        #endregion

        #region Close
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.None)
            {
                e.Cancel = true;
                if (MessageBox.Show(this, "Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
        }
        #endregion
    }
}