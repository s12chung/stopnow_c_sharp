using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StopNow
{
    public partial class OptionsForm : Form
    {
        public OptionsForm(Options options)
        {
            InitializeComponent();

            ExtractOptions(options);
        }

        private void ExtractOptions(Options options)
        {
            alarmTimeHour.Text = options.alarmTime.StringHour();
            alarmTimeMin.Text = options.alarmTime.StringMin();
            alarmTimeSec.Text = options.alarmTime.StringSec();

            maxIdleHour.Text = options.maxIdle.StringHour();
            maxIdleMin.Text = options.maxIdle.StringMin();
            maxIdleSec.Text = options.maxIdle.StringSec();

            if (options.minimizeToTray == true)
            {
                minimizeToTrayCheckBox.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}