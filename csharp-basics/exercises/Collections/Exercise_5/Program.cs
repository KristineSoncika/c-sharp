using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();
            var number = double.Parse(inputNumber);
            var usedNumbers = new List<double>();
            usedNumbers.Add(number);

            while (number != 1)
            {
                var sum = number
                    .ToString()
                    .Select(i => Math.Pow(Convert.ToDouble(Char.GetNumericValue(i)), 2))
                    .Sum();

                if (sum == 1)
                {
                    Console.WriteLine($"{inputNumber} is a happy number!");
                    break;
                }
                else if (usedNumbers.Contains(sum))
                {
                    Console.WriteLine($"{inputNumber} is not a happy number!");
                    break;
                }
                else
                {
                    usedNumbers.Add(sum);
                }

                number = sum;
            }
        }
    }
}