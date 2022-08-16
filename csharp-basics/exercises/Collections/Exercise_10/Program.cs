using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            HashSet<string> fruits = new();
            fruits.Add("Lemon");
            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Plum");
            fruits.Add("Pear");

            Console.WriteLine(String.Join(" | ", fruits));

            fruits.Clear();

            Console.WriteLine(String.Join(" | ", fruits));

            fruits.Add("Lemon");
            fruits.Add("Lemon");

            Console.WriteLine(String.Join(" | ", fruits));
        }
    }
}