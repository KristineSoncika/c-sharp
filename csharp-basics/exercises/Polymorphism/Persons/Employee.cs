using System;

namespace Persons
{
    public class Employee : Person
    {
        private string _jobTitle;

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public string GetJobTitle()
        {
            return _jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {GetFirstName()} {GetLastName()}");
            Console.WriteLine($"Address: {GetAddress()}");
            Console.WriteLine($"ID: {GetId()}");
            Console.WriteLine($"Job Title: {GetJobTitle()}");
            Console.WriteLine($"{new string('-', 60)}");
        }
    }
}