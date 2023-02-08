using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    internal class Duration
    { 
        int hours , minutes , seconds;

        public Duration()
        {
            hours = 0;
            seconds = 0;
            minutes = 0;
        }
        public Duration(int _hours,int _minutes ,int _seconds)
        {
            minutes= _minutes;
            seconds= _seconds;
            hours= _hours;
        }

        public Duration( int time)
        {
            hours = time / 3600;
            time = time % 3600;
            minutes = time / 60;
            time = time % 60;
            seconds = time;
        }
        public int Hours 
        {
            set { hours= value; }
            get { return hours; }
        }
        public int Minutes
        {
            set { minutes= value; }
            get { return minutes; }
        }
        public int Seconds
        {
            set { seconds= value; }
            get { return seconds; }
        }
        public override string ToString()
        {
            if(hours != 0)
                return $"hours:{hours},minutes :{minutes}  seconds :{seconds} ";
            else
                return $"minutes :{minutes}  seconds :{seconds} ";
        }

        public override bool Equals(object? obj)
        {
            return this.hours == ((Duration)obj).hours && this.minutes == ((Duration)obj).minutes && this.seconds == ((Duration)obj).seconds;
        }

        #region Operator OverLoading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration()
            {
                hours = d1.hours + d2.hours,
                minutes = d1.minutes + d2.minutes,
                seconds = d1.seconds + d2.seconds,
            };
        }

        public static Duration operator +(Duration d1, int time)
        {
            int Temp_hours = time / 3600;
            time = time % 3600;
            int Temp_minutes = time / 60;
            time = time % 60;
            int Temp_seconds = time;

            return new Duration()
            {
                hours = d1.hours + Temp_hours,
                minutes = d1.minutes + Temp_minutes,
                seconds = d1.seconds + Temp_seconds,
            };
        }

        public static Duration operator+(int time , Duration d)
        {
            int Temp_hours = time / 3600;
            time = time % 3600;
            int Temp_minutes = time / 60;
            time = time % 60;
            int Temp_seconds = time;

            return new Duration()
            {
                hours   =  Temp_hours   + d.hours   ,
                minutes =  Temp_minutes + d.minutes ,
                seconds = Temp_seconds  + d.seconds  
            };
        }

        public static Duration operator ++ (Duration d)
        {
            return new Duration()
            {
                hours = d.hours,
                minutes = d.minutes +1,
                seconds = d.seconds,
            };
        }

        public static Duration operator --(Duration d)
        {
            return new Duration()
            {
                hours = d.hours,
                minutes = d.minutes - 1 ,
                seconds = d.seconds,
            };
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration()
            {
                hours = d1.hours - d2.hours,
                minutes = d1.minutes - d2.minutes,
                seconds = d1.seconds - d2.seconds,
            };
        }

        public static bool operator >(Duration left, Duration right)
        {
            if (left.hours > right.hours)
                return true;
            else if ((left.hours == right.hours) && (left.minutes > right.minutes))
                return true;
            else if ((left.hours == right.hours) && (left.minutes == right.minutes) && (left.seconds > right.seconds))
                return true;

            return false;


        }

        public static bool operator <(Duration left, Duration right)
        {
            if (left.hours < right.hours)
                return true;
            else if ((left.hours == right.hours) && (left.minutes < right.minutes))
                return true;
            else if ((left.hours == right.hours) && (left.minutes == right.minutes) && (left.seconds < right.seconds))
                return true;

            return false;

        }

        public static implicit operator bool(Duration d)
        {
            if (d == null)
                return true;
            else
                return false;
            //return d.hours != 0 && d.minutes != 0 && d.seconds != 0;
        }


        public static explicit operator DateTime(Duration d)
        {
            string str = $"{d.hours}:{d.minutes}:{d.seconds}";
            DateTime Condate = DateTime.Parse(str);
            return Condate;
        }

        //public static explicit operator DateTime(Duration D)
        //{
        //    return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, D.hours, D.minutes, D.seconds);
        //}







        #endregion
    }
}
