using System;

namespace Exercise_8
{
    class Program
    {
        static void Main()
        {
            WageCalculator(7.50, 35);
            WageCalculator(8.20, 47);
            WageCalculator(10.00, 73);
        }

        static void WageCalculator(double basepay, int hours)
        {
            double minWage = 8.00;
            double overtimeRatio = 1.5;
            int regularHoursPerWeek = 40;
            int maxHoursPerWeek = 60;

            if (basepay < minWage)
            {
                Console.WriteLine($"Hourly pay cannot be lower than ${minWage:F2}.");
            }
            else if (hours > maxHoursPerWeek)
            {
                Console.WriteLine($"Working week cannot exceed {maxHoursPerWeek} hours.");
            }
            else
            {
                double overtime = hours > regularHoursPerWeek ? hours - regularHoursPerWeek : 0;
                double overtimePay = basepay * overtimeRatio;
                double overtimeWage = overtime * overtimePay;
                double baseWage = hours <= regularHoursPerWeek ? hours * basepay : (hours - overtime) * basepay;
                double totalPay = baseWage + overtimeWage;

                Console.WriteLine($"Total pay is ${totalPay:F2}.");
            }
        }
    }
}