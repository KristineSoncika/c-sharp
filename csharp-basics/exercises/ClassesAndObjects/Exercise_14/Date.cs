using System;
using System.Globalization;

namespace Exercise_14
{
    class Date
    {
        public void WeekdayInDutch(int year, int month, int date)
        {
            CultureInfo culture = new CultureInfo("nl-NL");
            DateTime dt = new DateTime(year, month, date);
            var day = culture.DateTimeFormat.GetDayName(dt.DayOfWeek);
            Console.WriteLine(day);
        }
    }
}