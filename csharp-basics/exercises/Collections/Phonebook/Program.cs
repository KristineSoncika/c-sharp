using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            PhoneDirectory directory = new();
            Console.WriteLine(directory.GetNumber("Barry"));
            directory.AddNumber("Barry", "20217654");
            Console.WriteLine(directory.GetNumber("Barry"));
        }
    }
}