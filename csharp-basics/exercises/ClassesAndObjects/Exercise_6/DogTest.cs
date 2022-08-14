using System;

namespace Exercise_6
{
    class DogTest
    {
        private static void Main()
        {
            Dog sparky = new("Sparky", "male");
            Dog sam = new("Sam", "male");
            Dog lady = new("Lady", "female");
            Dog molly = new("Molly", "female");
            Dog buster = new("Buster", "male", lady, sparky);
            Dog rocky = new("Rocky", "male", molly, sam);
            Dog max = new("Max", "male", lady, rocky);
            Dog coco = new("Coco", "female", molly, buster);

            Console.WriteLine(coco.GetFathersName());
            Console.WriteLine(sparky.GetFathersName());

            Console.WriteLine(coco.HasSameMotherAs(rocky));
        }
    }
}