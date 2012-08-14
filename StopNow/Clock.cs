using System;

namespace StopNow
{
    public class Clock
    {
        private int sec;
        private int min;
        private int hour;

        #region Constructors Thread
        public Clock(int hour, int min, int sec)
        {
            Reset(hour, min, sec);
        }

        public Clock(Clock clock)
        {
            Reset(clock);
        }

        public Clock()
        {
            Reset();
        }
        #endregion

        #region Clock Modifications
        #region Increment/Decrement
        public void SecIncrement()
        {
            this.sec++;

            if (this.sec >= 60)
            {
                this.min++;
                this.sec = this.sec - 60;
                if (this.min >= 60)
                {
                    this.hour++;
                    this.min = this.min - 60;
                    if (this.hour > 60)
                    {
                        this.hour = 0;
                    }
                }
            }
        }

        public void SecDecrement()
        {
            this.sec--;

            if (this.sec <= 0)
            {
                this.min--;
                this.sec = this.sec + 60;
                if (this.min <= 0)
                {
                    this.hour--;
                    this.min = this.min + 60;
                }
            }
        }
        #endregion

        #region Reset
        public void Reset(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }

        public void Reset(Clock clock)
        {
            this.hour = clock.hour;
            this.min = clock.min;
            this.sec = clock.sec;
        }

        public void Reset()
        {
            this.hour = 0;
            this.min = 0;
            this.sec = 0;
        }
        #endregion
        #endregion

        #region Get Information Methods
        public int GetAllSecs()
        {
            return ConvertHourToSec(this.hour) + ConvertMinToSec(this.min) + this.sec;
        }

        public override string ToString()
        {
            return String.Format("{0:d2}:{1:d2}:{2:d2}", this.hour, this.min, this.sec);
        }

        public string StringHour()
        {
            return String.Format("{0:d2}", this.hour);
        }

        public string StringMin()
        {
            return String.Format("{0:d2}", this.min);
        }

        public string StringSec()
        {
            return String.Format("{0:d2}", this.sec);
        }
        #endregion

        #region Conversions
        public static int ConvertHourToMin(int hour)
        {
            return hour * 60;
        }

        public static int ConvertHourToSec(int hour)
        {
            return hour * (60 * 60);
        }

        public static int ConvertMinToHour(int min)
        {
            return min / 60;
        }

        public static int ConvertMinToSec(int min)
        {
            return min * 60;
        }

        public static int ConvertSecToMin(int sec)
        {
            return sec / 60;
        }

        public static int ConvertSecToHour(int sec)
        {
            return sec / (60 * 60);
        }
        #endregion
    }
}
