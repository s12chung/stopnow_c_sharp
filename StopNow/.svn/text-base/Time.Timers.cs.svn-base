using System;
using System.Collections.Generic;
using System.Text;

namespace StopNow
{
    partial class Time
    {
        AlarmWindow alarmWindow;

        #region Timer Event Thread
        private void TimedActions(object source, EventArgs args)
        {
            IncrementTimer();
            CheckAlarm();
            CheckIdle();
        }

        private void IncrementTimer()
        {
            clock.SecIncrement();
            UpdateMainWindow();
        }

        private void CheckAlarm()
        {
            int intTime = clock.GetAllSecs();

            if (intTime >= (options.alarmTime.GetAllSecs() - (options.preAlarmInterval * options.preAlarmCount)))
            {
                if (intTime == options.alarmTime.GetAllSecs())
                {
                    Alarm();
                }
                else if (intTime % options.preAlarmInterval == 0)
                {
                    PreAlarm();
                }
            }
        }

        #region Trigger Idle
        private void SetTimer()
        {
            ResetTimer();

            int interval = 1000;

            timer.Interval = interval;
            timer.Tick += new EventHandler(TimedActions);
        }

        private void UnsetTimer()
        {
            timer.Tick -= new EventHandler(TimedActions);
        }
        
        private void CheckIdle()
        {
            if (Win32_API.Win32.GetIdleTime() >= options.maxIdle.GetAllSecs())
            {
                UnsetTimer();
                SetIdleTimer();
            }
        }
        #endregion
        #endregion

        #region Idle Event Thread
        private void UnsetIdleTimer()
        {
            timer.Tick -= new EventHandler(IdleStop);
        }

        private void SetIdleTimer()
        {
            int interval = 500;

            timer.Interval = interval;
            timer.Tick += new EventHandler(IdleStop);
        }
        
        private void IdleStop(object source, EventArgs args)
        {
            if (Win32_API.Win32.GetIdleTime() < options.maxIdle.GetAllSecs())
            {
                UnsetIdleTimer();
                SetTimer();
            }
        }
        #endregion

        #region AlarmEventThread
        private void SetAlarmTimer()
        {
            clock.Reset(options.breakTime);

            int interval = 1000;

            timer.Interval = interval;
            timer.Tick += new EventHandler(BreakTimer);
        }

        private void UnsetAlarmTimer()
        {
            timer.Tick -= new EventHandler(BreakTimer);
        }

        private void BreakTimer(object source, EventArgs args)
        {
            clock.SecDecrement();
            alarmWindow.printClock(clock);
            if (clock.GetAllSecs() == 0)
            {
                alarmWindow.Dispose();
                alarmWindow = null;

                mainWindow.ShowAll();

                ResetTimer();
                UnsetAlarmTimer();
                SetTimer();
            }
        }
        #endregion
    }
}
