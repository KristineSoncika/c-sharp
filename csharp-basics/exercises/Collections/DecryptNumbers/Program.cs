using System;
using System.Collections.Generic;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main()
        {
            var characters = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var decryptedNumbers = cryptedNumbers.Select(str => String.Join("", str.Select(character => Array.IndexOf(characters, character))));

            foreach (var number in decryptedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}