using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise_9
{
    class Program
    {
        static void Main()
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(", ", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(", ", secondList));

            var joinedList = new List<string>(firstList);
            joinedList.AddRange(secondList);

            Console.WriteLine(string.Join(", ", joinedList));
        }
    }
}