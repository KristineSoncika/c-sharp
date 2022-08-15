using System;
using System.Collections.Generic;

namespace UniqueValues
{
    internal class Program
    {
        static void Main()
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var uniqueValues = values
                .GroupBy(value => value)
                .Where(group => group.Count() == 1)
                .Select(unique => unique.Key);

            Console.WriteLine(String.Join(", ", uniqueValues));
        }
    }
}