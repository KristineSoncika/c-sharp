using System;

namespace Exercise_14
{
    class Program
    {
        private static void Main()
        {
            Date date = new();
            date.WeekdayInDutch(1970, 9, 21);
            date.WeekdayInDutch(1945, 9, 2);
            date.WeekdayInDutch(2001, 9, 11);
        }
    }
}