﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main()
        {
            var random = new Random();
            var numbers = new List<int>();
            
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var numberList = numbers.Where(num => num > 30);

            Console.WriteLine(String.Join(" ", numberList));               
        }
    }
}