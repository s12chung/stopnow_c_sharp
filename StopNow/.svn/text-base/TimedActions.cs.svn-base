using System;
using Win32_API;
using System.Windows.Forms;

namespace StopNow
{
    class TimedActions
    {
        public int maxIdle;
        public int alarmTime;
        private static int BREAKTIME = 30;
        private static int BREAKCOUNT = 4;

        private Timer idleTimer = new Timer();
        private Time time;

        #region Constructors Thread
        public TimedActions(Time time, int maxIdle, int alarmTime)
        {
            this.maxIdle = maxIdle;
            this.alarmTime = alarmTime;
            this.time = time;
        }
        #endregion

        #region Events
        public void Check(int intTime)
        {
            CheckAlarm(intTime);
            CheckIdle();
        }

        #region Alarm (make better, int intTime)
        //make better
        private void CheckAlarm(int intTime)
        {
            if (intTime >= (alarmTime - (BREAKTIME * BREAKCOUNT)))
            {
                if (intTime % BREAKTIME == 0)
                {
                    //Console.Beep();
                }
                if (intTime == alarmTime)
                {
                    Alarm();
                }
            }
        }

        public void Alarm()
        {
            Win32.LockWorkStation();
            time.ResetTimer();
        }
        #endregion

        #region Idle
        private void CheckIdle()
        {
            if (Win32.GetIdleTime() >= maxIdle)
            {
                time.StopTimer();
                StartIdleTimer();
            }
        }

        private void StartIdleTimer()
        {
            int interval = 500;

            idleTimer.Interval = interval;
            idleTimer.Tick += new EventHandler(IdleStop);
            idleTimer.Start();
        }
        #endregion
        #endregion

        #region Idle Event Thread
        private void IdleStop(object source, EventArgs args)
        {
            if (Win32_API.Win32.GetIdleTime() < maxIdle)
            {
                idleTimer.Stop();
                time.StartTimer();
            }
        }
        #endregion
    }
}