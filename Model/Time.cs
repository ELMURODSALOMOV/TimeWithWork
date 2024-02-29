using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeWithWork.Model
{
    public class Time
    {
     
        public Time(int minute, int hour, int year)
        {
            Minute = minute;
            Hour = hour;
            Year = year;
        }
        public int Minute {get; set; }
        public int Hour {get; set; }
        public int Year { get; set; }
    }
}