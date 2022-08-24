using System;
using System.Net;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa;
        private int _year;
        private bool _grant;

        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
            _year = 1;
            _grant = true;
        }

        public double GetGPA()
        {
            return _gpa;
        }

        public int GetYear()
        {
            return _year;
        }

        public bool ReceivesGrant()
        {
            return _grant;
        }

        public void YearEndCheck()
        {
            if(GetGPA() < 1.0)
            {
                Console.WriteLine("Suspended!");
            }
            else if(GetGPA() > 1.0 && GetGPA() < 2.0)
            {
                _grant = false;
                _year++;
            }
            else
            {
                _year++;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {GetFirstName()} {GetLastName()}");
            Console.WriteLine($"Address: {GetAddress()}");
            Console.WriteLine($"ID: {GetId()}");
            Console.WriteLine($"GPA: {GetGPA()}");
            Console.WriteLine($"Year: {GetYear()}");
            Console.WriteLine($"Receiving grant: {ReceivesGrant()}");
            Console.WriteLine($"{new string('-', 60)}");
        }
    }
}