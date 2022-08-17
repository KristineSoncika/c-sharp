using System;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main()
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var modifiedWords = words.Select(word => word.Replace("ea", "*"));
            Console.WriteLine(String.Join(", ", modifiedWords));
        }
    }
}