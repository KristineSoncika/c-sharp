using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_3
{
    class Program
    {
        static void Main()
        {
            var colors = new List<string>();

            colors.Insert(0, "Red");
            colors.Insert(0, "Green");
            colors.Insert(0, "Orange");
            colors.Insert(0, "White");
            colors.Insert(0, "Black");

            Console.WriteLine(string.Join(", ", colors));

            colors.Insert(0, "Gray");
            colors.Insert(2, "Pink");

            Console.WriteLine(string.Join(", ", colors));
        }
    }
}