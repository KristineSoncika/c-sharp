using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_1
{
    class Program
    {
        private static void Main()
        {
            var colors = new List<string>();

            colors.Add("blue");
            colors.Add("red");
            colors.Add("black");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine(new string('-', 15));

            colors.AddRange(new string[] { "white", "yellow", "green", "gray", "pink" });

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}