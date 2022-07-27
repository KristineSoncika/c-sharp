using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sandy = Bio("Sandy", 1960);
            Console.WriteLine(sandy);
        }

        static string Bio(string name, int birthYear)
        {
            return $"My name is {name} and I as born in {birthYear}.";
        }
    }
}
