using System;

namespace Persons
{
    class Program
    {
        static void Main()
        {
            Student student = new("Barry", "Blue", "7036 Mulholland Drive, Los Angeles, CA 90068, USA", 345987465, 3.2);
            Employee employee = new("Sandy", "Mess", "101  Eagle, Fargo, ND 58102, USA", 786543098, "CTO");

            student.Display();
            student.YearEndCheck();
            student.Display();

            employee.Display();
        }
    }
}