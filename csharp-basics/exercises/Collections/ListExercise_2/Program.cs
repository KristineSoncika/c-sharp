using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_2
{
    class Program
    {
        private static void Main()
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}