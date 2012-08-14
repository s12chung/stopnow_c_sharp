using System;
using System.Windows.Forms;

namespace StopNow
{
    public partial class Time
    {
        private Timer timer = new Timer();
        private Clock clock = new Clock();

        private MainWindow mainWindow;

        #region Constructors Thread
        public Time(MainWindow mainWindow, Options options)
        {
            this.mainWindow = mainWindow;
            this.options = options;

            SetTimer();
            timer.Start();
        }
        #endregion

        #region Start, Pause, Stop, Reset, Alarm, IsPlaying
        public void StartTimer()
        {
            timer.Start();
        }

        public void PauseTimer()
        {
            timer.Stop();
        }

        public void StopTimer()
        {
            PauseTimer();
            ResetTimer();
        }

        public void ResetTimer()
        {
            clock.Reset();
            UpdateMainWindow();
        }

        public bool IsPlaying()
        {
            return timer.Enabled;
        }
        #endregion
    }
}