using System;

namespace Exercise_12
{
    class Program
    {
        private static void Main()
        {
            Testpaper paper1 = new("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            Testpaper paper2 = new("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            Testpaper paper3 = new("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            Student student1 = new();
            Student student2 = new();

            Console.WriteLine(String.Join(" ", student1.TestsTaken));
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            Console.WriteLine(String.Join(" ", student1.TestsTaken));
            student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            Console.WriteLine(String.Join(", ", student2.TestsTaken));
        }
    }
}