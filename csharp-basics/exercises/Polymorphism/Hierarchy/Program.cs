﻿using System;

namespace Hierarchy
{
    class Program
    {
        private static void Main()
        {
            var animals = new List<Animal>();
            Animal currentAnimal;

            while(true)
            {
                Console.WriteLine("\nTo exit type END");
                Console.WriteLine("To continue press ENTER");

                if (Console.ReadLine().ToLower() == "end")
                {
                    break;
                }

                Console.WriteLine("\nEnter an animal in the following format (separated by a space): Type Name Weight Region Breed(for Type: Cat ONLY)");
                var animal = Console.ReadLine().Split(" ");
                Console.WriteLine("\nEnter food in the following format (separated by a space): Type Quantity");
                var food = Console.ReadLine().Split(" ");

                switch (animal[0])
                {
                    case "Mouse":
                        animals.Add(new Mouse(animal[0], animal[1], double.Parse(animal[2]), animal[3]));
                        break;
                    case "Zebra":
                        animals.Add(new Zebra(animal[0], animal[1], double.Parse(animal[2]), animal[3]));
                        break;
                    case "Tiger":
                        animals.Add(new Tiger(animal[0], animal[1], double.Parse(animal[2]), animal[3]));
                        break;
                    case "Cat":
                        animals.Add(new Cat(animal[0], animal[1], double.Parse(animal[2]), animal[3], animal[4]));
                        break;
                    default:
                        break;
                }

                currentAnimal = animals[animals.Count - 1];
                currentAnimal.MakeSound();

                switch (food[0])
                {
                    case "Meat":
                        currentAnimal.Eat(new Meat(int.Parse(food[1])));
                        break;
                    case "Vegetable":
                        currentAnimal.Eat(new Vegetable(int.Parse(food[1])));
                        break;
                    default:
                        break;
                }

                Console.WriteLine(currentAnimal);
            }

            Console.WriteLine(new String('-', 30));
            Console.WriteLine(String.Join(", ", animals));
        }
    }
}