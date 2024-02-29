using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TimeWithWork.Model;

namespace TimeWithWork.Service
{
    public class TimeService
    {
        private Time time;
        public TimeService(int minute, int hour, int year)
        {
            time = new Time(minute, hour, year);
        }   

        public void GetInfo()
        {
            System.Console.WriteLine($"Vaqt: {time.Hour}:{time.Minute}.{time.Year}");
        }

        public void TimeDifference()
        {
            System.Console.WriteLine($"For Hour: {Math.Abs(DateTime.Now.Hour - time.Hour)}");
            System.Console.WriteLine($"For Minute: {Math.Abs(DateTime.Now.Minute - time.Minute)}");
            System.Console.WriteLine($"For Year: {Math.Abs(DateTime.Now.Year - time.Year)}");
        } 

        public int FullHour()
        {
            if(time.Minute != 0)
            {
                return 60 - time.Minute;
            
            }
            return 0;
        }


    }
}