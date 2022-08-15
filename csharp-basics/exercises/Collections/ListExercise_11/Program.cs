using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_11
{
    class Program
    {
        static void Main()
        {
            var animals = new List<string>();

            animals.AddRange(new string[] { "zebra", "penguin", "elephant", "lion", "alligator", "snake", "pelican", "tiger", "pigeon", "badger" });

            animals.Insert(4, "ferret");

            animals[animals.Count - 1] = "whale";

            animals.Sort();

            Console.WriteLine($"The animals list contains 'Foobar': {animals.Contains("Foobar")}\n");

            foreach (var animal in animals)
            {
                Console.Write($"{animal} ");
            }
        }
    }
}