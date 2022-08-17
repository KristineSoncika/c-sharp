using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            WordCount();
        }

        static void WordCount()
        {
            string path = "./lear.txt";
            var text = File.ReadAllText(path);

            int lines = text.Split("\n").Count();
            int chars = text.Count() - text.Count(i => i == '\n');

            text = text.Replace("  ", " ").Replace("\n", " ");
            string[] stringSeparators = new string[] { " ", "'" };
            int words = text.Split(stringSeparators, StringSplitOptions.None).Count();

            Console.WriteLine($"Lines = {lines}");
            Console.WriteLine($"Words = {words}");
            Console.WriteLine($"Chars = {chars}");
        }
    }
}