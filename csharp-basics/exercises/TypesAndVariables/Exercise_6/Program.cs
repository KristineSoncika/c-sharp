using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSum();
        }
        static void PrintSum()
        {
            Console.WriteLine("Enter a series of single digit numbers without any spaces: ");
            string numberSeries = Console.ReadLine();
            double sum = 0;
            for(int i = 0; i < numberSeries.Length; i++)
            {
                sum += Char.GetNumericValue(numberSeries[i]);
            }
            Console.WriteLine($"The sum is {sum}.");
        }
    }
}

