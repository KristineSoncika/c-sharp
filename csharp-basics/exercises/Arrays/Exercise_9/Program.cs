using System;

namespace Exercise_9
{
    class Program
    {
        private static void Main()
        {
            string[] arr1 = { "mavis", "senaida", "letty" };
            string[] arr2 = { "samuel", "MABELLE", "letitia", "meridith" };
            string[] arr3 = { "Sylvia", "Kristal", "Sharilyn", "Calista" };
            Capitalize(arr1);
            Capitalize(arr2);
            Capitalize(arr3);
        }

        static string[] Capitalize(string[] arr)
        {
            string[] capitalizedArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string formattedWord = arr[i].ToLower();
                formattedWord = Char.ToUpper(formattedWord[0]) + formattedWord[1..];
                capitalizedArr[i] = formattedWord;
            }

            Console.WriteLine(String.Join(", ", capitalizedArr));
            return capitalizedArr;
        }
    }
}