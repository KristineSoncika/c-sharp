using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_10
{
    class Program
    {
        static void Main()
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.Write("Original array list: ");
            Console.WriteLine(string.Join(", ", colors));

            colors.Clear();

            Console.Write("New array list: ");
            Console.WriteLine(string.Join(", ", colors));
        }
    }
}