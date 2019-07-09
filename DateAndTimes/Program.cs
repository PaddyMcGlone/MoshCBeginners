using System;

namespace DateAndTimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var myBirthday = new DateTime(1985, 05, 26);

            var currentDateTime = DateTime.Now;
            var currentDate = DateTime.Today;

            var currentHour = DateTime.Now.Hour;
            var currentMinute = DateTime.Now.Minute;

            // Datetime objects are immutable in C#, if you want to change them you have
            // to use the .Add() method.

            // 1 Hour, 20 Minutes, 45 Seconds
            TimeSpan time = new TimeSpan(1, 20, 45);

            // It is possible to Parse a timeSpan using the parse method
            var timeSpan = TimeSpan.Parse("1:20:45");
        }
    }
}
