using System;
using System.Windows.Forms;

namespace StopNow
{
    public enum AlarmType
    {
        None = 0x01,
        Beep = 0x02,
        LockWorkstation = 0x03,
    }

    public class Alarm
    {
        private MainWindow mainWindow;
        private EventHandler alarm;

        #region Constructors Thread
        public Alarm(MainWindow mainWindow)
        {
            alarm = new EventHandler(None);
            this.mainWindow = mainWindow;
        }

        public Alarm(MainWindow mainWindow, AlarmType alarm)
        {
            ChangeAlarm(alarm);
            this.mainWindow = mainWindow;
        }
        #endregion

        #region Public Methods
        public void ChangeAlarm(AlarmType alarm)
        {
            switch (alarm)
            {
                case AlarmType.None:
                    this.alarm = new EventHandler(None);
                    break;
                case AlarmType.Beep:
                    this.alarm = new EventHandler(Beep);
                    break;
                case AlarmType.LockWorkstation:
                    this.alarm = new EventHandler(LockWorkstation);
                    break;
            }
        }

        public void Invoke(string message)
        {
            this.alarm.Invoke(this, EventArgs.Empty);
            mainWindow.ShowTrayBalloon(message);
        }
        #endregion

        #region Actions
        private void None(object source, EventArgs args)
        {
        }

        private void Beep(object source, EventArgs args)
        {
            Console.Beep();
        }

        private void LockWorkstation(object source, EventArgs args)
        {
            Win32_API.Win32.LockWorkStation();
        }
        #endregion
    }
}
