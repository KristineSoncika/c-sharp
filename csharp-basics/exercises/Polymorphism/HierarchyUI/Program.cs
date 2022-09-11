using Hierarchy;

namespace HierarchyUI;

internal static class Program
{
    private static void Main()
    {
        var animals = new List<string>();

        while (true)
        {
            Console.WriteLine("\nTo exit type END");
            Console.WriteLine("To continue press ENTER");

            if (Console.ReadLine().ToLower() == "end")
            {
                break;
            }

            Console.WriteLine("\nEnter an animal in the following format (separated by a space): Type Name Weight Region Breed(for Cat type ONLY)");
            var animal = Console.ReadLine();
            Console.WriteLine("\nEnter food in the following format (separated by a space): Type Quantity");
            var food = Console.ReadLine();

            try
            {
                var currentAnimal = AnimalData.CreateAnimal(animal, food);
                animals.Add(currentAnimal);
                Console.WriteLine(currentAnimal);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine(string.Join(", ", animals));
    }
}