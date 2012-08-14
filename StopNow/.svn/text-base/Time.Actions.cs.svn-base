using System;
using System.Collections.Generic;
using System.Text;

namespace StopNow
{
    partial class Time
    {
        private Options options;

        public bool CheckMinimizeToTray()
        {
            return options.minimizeToTray;
        }

        public void CreateOptionsWindow()
        {
            OptionsForm a = new OptionsForm(options);
            a.Show();
        }

        private void UpdateMainWindow()
        {
            mainWindow.printClock(clock);
            mainWindow.SetProgBar(100 * clock.GetAllSecs() / options.alarmTime.GetAllSecs());
        }

        #region Do Actions
        public void Alarm()
        {
            alarmWindow = new AlarmWindow();
            alarmWindow.Show();

            mainWindow.HideAll();

            UnsetTimer();
            SetAlarmTimer();

            string alarmMessage = "";
            if (options.alarmMessage == true)
            {
                alarmMessage = "The alarm time has been reached. Starting alarm...";
            }
            options.alarm.Invoke(alarmMessage);
        }

        public void PreAlarm()
        {
            string preAlarmMessage = "";
            if (options.preAlarmMessage == true)
            {
                preAlarmMessage = (options.preAlarmInterval * options.preAlarmCount) + "seconds until alarm time is reached.";
            }
            options.preAlarm.Invoke(preAlarmMessage);
        }
        #endregion
    }
}
