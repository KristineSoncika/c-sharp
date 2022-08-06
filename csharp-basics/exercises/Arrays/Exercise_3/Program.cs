using System;

namespace Exercise_3
{
    class Program
    {
        private static void Main()
        {
            int[] numbers = { 20, 30, 25, 35, -16, 60, -100 };
            CalculateAverage(numbers);
        }

        static void CalculateAverage(int[] numbers)
        {
            double average = Queryable.Average(numbers.AsQueryable());
            Console.WriteLine($"Average value of the array elements is : {average:F2}");
        }
    }
}