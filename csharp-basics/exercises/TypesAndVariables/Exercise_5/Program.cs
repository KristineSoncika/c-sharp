using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCourseSchedule();
        }
        static void PrintCourseSchedule()
        {
            string tableHorizontalBorder = $"{("+").PadRight(61, '-')}+";
            string[] courses = { "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Infomation Systems" };
            string[] teachers = { "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James" };
            int orderNumber = 1;

            Console.WriteLine(tableHorizontalBorder);
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine($"| {orderNumber} | {courses[i],36} | {teachers[i],15} |");
                orderNumber++;
            }
            Console.WriteLine(tableHorizontalBorder);
        }
    }
}

