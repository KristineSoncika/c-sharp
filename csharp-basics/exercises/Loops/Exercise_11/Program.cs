using System;

namespace Exercise_11
{
    class Program
    {
        static void Main()
        {
            ReverseCase("Happy Birthday");
            ReverseCase("MANY THANKS");
            ReverseCase("sPoNtAnEoUs");
        }

        static void ReverseCase(string text)
        {
            string reversedText = "";

            foreach(var i in text)
            {
                if (Char.IsUpper(i))
                {
                    reversedText += Char.ToLower(i);
                }
                else if (Char.IsLower(i))
                {
                    reversedText += Char.ToUpper(i);
                }
                else
                {
                    reversedText += i;
                }
            }

            Console.WriteLine(reversedText);
        }
    }
}