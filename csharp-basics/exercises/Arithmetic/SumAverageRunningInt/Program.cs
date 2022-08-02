using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main()
        {
            SumAverageRunningInt();
        }

        static void SumAverageRunningInt()
        {
            const int lowerBound = 1;
            const int upperBound = 100;
            double sum = 0;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }

            double average = sum / upperBound;

            Console.WriteLine(
                $"The sum of {lowerBound} to {upperBound} is {sum}\n" +
                $"The average is {average:F2}");
        }
    }
}

