using System;

namespace Exercise_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"The first 10 natural numbers are: {CreateNumberList(10)}");
        }

        static string CreateNumberList(int num)
        {
            List<int> numberList = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                numberList.Add(i);
            }

            string numbers = String.Join(" ", numberList);
            return numbers;
        }
    }
}