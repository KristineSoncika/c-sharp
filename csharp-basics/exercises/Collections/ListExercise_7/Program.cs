using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_7
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

            Console.WriteLine($"The list contains 'White': {colors.Contains("White")}");
        }
    }
}