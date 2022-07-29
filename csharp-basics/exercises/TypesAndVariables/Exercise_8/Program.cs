using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertMinutes(993500));
        }

        static string ConvertMinutes(int minutes)
        {
            int minsInYear = 525600;
            int minsInDay = 1440;
            int years = minutes / minsInYear;
            int days = (minutes % minsInYear) / minsInDay;

            if (years < 1 && days < 1)
            {
                return $"{minutes} minutes is not even a one full day.";
            }
            else if (years >= 1)
            {
                return $"{minutes} minutes is {years} year(s) and {days} day(s).";
            }
            else
            {
                return $"{minutes} minutes is {days} day(s).";
            }
        }
    }
}

