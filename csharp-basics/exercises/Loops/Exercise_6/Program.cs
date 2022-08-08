using System;

namespace Exercise_6
{
    class Program
    {
        static void Main()
        {
            FizzBuzz(100);
        }

        static void FizzBuzz(int num)
        {
            string fizzbuzz = "";

            for (int i = 1; i <= num; i++)
            {
                if (!(i % 3 == 0) && !(i % 5 == 0))
                {
                    Console.Write($"{i} ");                    
                }
                if (i % 3 == 0)
                {
                    fizzbuzz += "Fizz";
                }
                if (i % 5 == 0)
                {
                    fizzbuzz += "Bazz";
                }

                Console.Write($"{fizzbuzz} ");
                fizzbuzz = "";

                if (i % 20 == 0)
                {
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}