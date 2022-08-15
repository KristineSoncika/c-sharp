using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNames
{
    class Program
    {
        static void Main()
        {
            DayName(2021, 10, 18);
        }

        static void DayName(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            Console.Write($"The day of the week for {date:d} is {date.DayOfWeek}");
        }
    }
}