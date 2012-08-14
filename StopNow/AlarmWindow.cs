using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StopNow
{
    public partial class AlarmWindow : Form
    {
        public AlarmWindow()
        {
            InitializeComponent();
        }

        public void printClock(Clock clock)
        {
            timeLabel.Text = clock.ToString();
        }

        private void AlarmWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}