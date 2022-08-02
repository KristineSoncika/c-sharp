using System;

namespace LargetsNumber
{
    class Program
    {
        static void Main()
        {
            LargestNumber();
        }

        static void LargestNumber()
        {
            List<int> numList = new();

            Console.WriteLine("Input the 1st number: ");
            numList.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Input the 2nd number: ");
            numList.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Input the 3rd number: ");
            numList.Add(Convert.ToInt32(Console.ReadLine()));

            int largestNum = numList.Aggregate((accVal, currVal) => accVal > currVal ? accVal : currVal);

            Console.WriteLine($"The largest number from the three provided is {largestNum}.");
        }
    }
}