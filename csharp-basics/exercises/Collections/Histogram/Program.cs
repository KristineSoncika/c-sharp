using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "./midtermscores.txt";

        private static void Main()
        {
            var readText = File.ReadAllText(Path);
            var scoreArray = readText.Split(" ");
            var scores = scoreArray.Select(s => int.Parse(s));
            int counter1 = 0;
            int counter2 = 10;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}0-{i}9: {new string('*', scores.Count(s => s >= counter1 && s <= counter2))}");
                counter1 += 10;
                counter2 += 10;
            }

            Console.WriteLine($"{"100".PadLeft(5)}: {new string('*', scores.Count(s => s == 100))}");
        }
    }
}