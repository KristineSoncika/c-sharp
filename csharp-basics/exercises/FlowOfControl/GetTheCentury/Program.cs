using System;

namespace GetTheCentury
{
    class Program
    {
        static void Main()
        {
            GetCentury(1756);
            GetCentury(1555);
            GetCentury(1000);
            GetCentury(1001);
            GetCentury(2005);
        }

        static void GetCentury(int year)
        {
            switch (year)
            {
                case >= 901 and <= 1000:
                    Console.WriteLine("10th century");
                    break;
                case >= 1001 and <= 1100:
                    Console.WriteLine("11th century");
                    break;
                case >= 1101 and <= 1200:
                    Console.WriteLine("12th century");
                    break;
                case >= 1201 and <= 1300:
                    Console.WriteLine("13th century");
                    break;
                case >= 1301 and <= 1400:
                    Console.WriteLine("14th century");
                    break;
                case >= 1401 and <= 1500:
                    Console.WriteLine("15th century");
                    break;
                case >= 1501 and <= 1600:
                    Console.WriteLine("16th century");
                    break;
                case >= 1601 and <= 1700:
                    Console.WriteLine("17th century");
                    break;
                case >= 1701 and <= 1800:
                    Console.WriteLine("18th century");
                    break;
                case >= 1801 and <= 1900:
                    Console.WriteLine("19th century");
                    break;
                case >= 1901 and <= 2000:
                    Console.WriteLine("20th century");
                    break;
                case >= 2001 and <= 2010:
                    Console.WriteLine("21th century");
                    break;
                default:
                    Console.WriteLine("Enter a year between 1000 and 2010.");
                    break;
            }
        }
    }
}