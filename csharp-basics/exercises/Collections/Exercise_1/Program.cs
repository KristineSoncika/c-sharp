using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        private static void Main()
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var list = new List<string>();

            foreach (var i in array)
            {
                list.Add(i);
            }

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new String('-', 15));

            var hashset = new HashSet<string>();

            foreach (var i in array)
            {
                hashset.Add(i);
            }

            foreach (var i in hashset)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new String('-', 15));

            var dictionary = new Dictionary<string, string>();

            dictionary.Add("Audi", "Germany");
            dictionary.Add("BMW", "Germany");
            dictionary.Add("Honda", "Japan");
            dictionary.Add("Mercedes", "Germany");
            dictionary.Add("VolksWagen", "Germany");
            dictionary.Add("Tesla", "USA");

            foreach (var i in dictionary)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
    }
}