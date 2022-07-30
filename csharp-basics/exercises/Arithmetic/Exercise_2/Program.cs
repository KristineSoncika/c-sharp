using System;

namespace Ex_2
{
    class Program
    {
        static void Main()
        {
            CheckOddEven(5);
        }

        static void CheckOddEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("bye!");
        }
    }
}

