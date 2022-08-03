using System;

namespace TenBillion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer smaller than ten billion: ");
            var input = Console.ReadLine();

            if (Int64.TryParse(input, out long num))
            {
                if (num < 0)
                {
                    num *= -1;
                }

                if (num >= 10000000000)
                {
                    Console.WriteLine("Number is greater or equal to 10,000,000,000!");
                }
                else
                {
                    int digits = 1;
                    if (num >= 10 && num <= 99)
                    {
                        digits = 2;
                    }
                    else if (num >= 100 && num <= 999)
                    {
                        digits = 3;
                    }
                    else if (num >= 1000 && num <= 9999)
                    {
                        digits = 4;
                    }
                    else if (num >= 10000 && num <= 99999)
                    {
                        digits = 5;
                    }
                    else if (num >= 100000 && num <= 999999)
                    {
                        digits = 6;
                    }
                    else if (num >= 1000000 && num <= 9999999)
                    {
                        digits = 7;
                    }
                    else if (num >= 10000000 && num <= 99999999)
                    {
                        digits = 8;
                    }
                    else if (num >= 100000000 && num <= 999999999)
                    {
                        digits = 9;
                    }
                    else if (num >= 1000000000 && num <= 9999999999)
                    {
                        digits = 10;
                    }
                    Console.WriteLine($"Number of digits in the integer: {digits}");
                }
            }
            else
            {
                Console.WriteLine("The number is not a long");
            }
        }
    }
}