using System;

namespace Want2Learn.DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static DateTime GetRadomDate(int year)
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            int dayOfMonth = DateTime.DaysInMonth(year, month);
            int dayNumber = rnd.Next(1, dayOfMonth + 1);
            DateTime date = new DateTime(year, month, dayNumber);
            return date;
        }

        static DateTime GetBeginWeek(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            DateTime firstDayOfWeek = date;
            if (day == DayOfWeek.Tuesday)
            {
                firstDayOfWeek = firstDayOfWeek.AddDays(-1);
            }
            if (day == DayOfWeek.Wednesday)
            {
                firstDayOfWeek = firstDayOfWeek.AddDays(-2);
            }
            if (day == DayOfWeek.Thursday)
            {
                firstDayOfWeek = firstDayOfWeek.AddDays(-3);
            }
            if (day == DayOfWeek.Friday)
            {
                firstDayOfWeek = firstDayOfWeek.AddDays(-4);
            }
            if (day == DayOfWeek.Saturday)
            {
                firstDayOfWeek = firstDayOfWeek.AddDays(-5);
            }
            if (day == DayOfWeek.Sunday)
            {
                firstDayOfWeek = firstDayOfWeek.AddDays(-6);
            }
            else
            {
                return firstDayOfWeek;
            }
            return firstDayOfWeek;
        }
    }
}
