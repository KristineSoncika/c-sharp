using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_6
{
    class Program
    {
        static void Main()
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.WriteLine(string.Join(", ", colors));

            colors.RemoveAt(2);

            Console.WriteLine("After removing third element from the list:");
            Console.WriteLine(string.Join(", ", colors));
        }
    }
}