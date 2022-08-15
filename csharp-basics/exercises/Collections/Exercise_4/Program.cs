using System;
using System.ComponentModel;

namespace Exercise_4
{
    internal class Program
    {
        static void Main()
        {
            var nameList = new List<string>();
            string name = " ";

            while (name.Length != 0)
            {
                Console.Write("Enter a name: ");
                name = Console.ReadLine();
                nameList.Add(name);
            }

            var distinctNameList = nameList.Distinct();

            Console.WriteLine(String.Join(" ", distinctNameList));
        }
    }
}