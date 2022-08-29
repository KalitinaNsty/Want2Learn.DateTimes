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

        static DateTime GetEndWeek(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            DateTime endDayWeek = date;
            switch (day)
            {
                case DayOfWeek.Monday:
                    endDayWeek = date.AddDays(6);
                    break;
                case DayOfWeek.Tuesday:
                    endDayWeek = date.AddDays(5);
                    break;
                case DayOfWeek.Wednesday:
                    endDayWeek = date.AddDays(4);
                    break;
                case DayOfWeek.Thursday:
                    endDayWeek = date.AddDays(3);
                    break;
                case DayOfWeek.Friday:
                    endDayWeek = date.AddDays(2);
                    break;
                case DayOfWeek.Saturday:
                    endDayWeek = date.AddDays(1);
                    break;
                default: 
                    return endDayWeek;
                    break;
            }
            return endDayWeek;
        }

        static int CountWeekend(DateTime date1, DateTime date2)
        {
            int count = 0;
            for (DateTime i = date1.Date; i <= date2.Date; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    count++;
                }
            }
            return count;
        }

        static DateTime[] GetArrayWeekends(DateTime date1, DateTime date2)
        {
            int countWeekend = CountWeekend(date1, date2);
            DateTime[] weekendDay = new DateTime[countWeekend];
            int i = 0;
            for (DateTime currentDate = date1.Date; currentDate <= date2.Date; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendDay[i] = currentDate;
                    i++;
                }
            }
            return weekendDay;
        }
    }
}
