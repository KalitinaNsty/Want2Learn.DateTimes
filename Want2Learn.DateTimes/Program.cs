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
    }
}
