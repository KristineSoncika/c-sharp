using System;

namespace Exercise_4
{
    class Program
    {
        static void Main()
        {
            PrintDayInWords(1);
        }

        // Solution 1
        static void PrintDayInWords(int dayNum)
        {
            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day!");
                    break;
            }
        }

        // Solution 2
        //static void PrintDayInWords(int dayNum)
        //{
        //    if (dayNum < 1 || dayNum > 7)
        //    {
        //        Console.WriteLine("Not a valid day!");
        //    }
        //    else
        //    {
        //        if (dayNum == 1)
        //        {
        //            Console.WriteLine("Monday");
        //        }
        //        if (dayNum == 2)
        //        {
        //            Console.WriteLine("Tuesday");
        //        }
        //        if (dayNum == 3)
        //        {
        //            Console.WriteLine("Wednesday");
        //        }
        //        if (dayNum == 4)
        //        {
        //            Console.WriteLine("Thursday");
        //        }
        //        if (dayNum == 5)
        //        {
        //            Console.WriteLine("Friday");
        //        }
        //        if (dayNum == 6)
        //        {
        //            Console.WriteLine("Saturday");
        //        }
        //        if (dayNum == 7)
        //        {
        //            Console.WriteLine("Sunday");
        //        }
        //    }
        //}
    }
}