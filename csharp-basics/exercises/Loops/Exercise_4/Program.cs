using System;

namespace Exercise_4
{
    class Program
    {
        static void Main()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for(int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }

            foreach(var i in vowels)
            {
                Console.WriteLine(i);
            }
        }
    }
}