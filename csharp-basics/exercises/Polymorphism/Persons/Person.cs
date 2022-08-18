using System;

namespace Persons
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetAddress()
        {
            return _address;
        }

        public int GetId()
        {
            return _id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {GetFirstName()} {GetLastName()}");
            Console.WriteLine($"Address: {GetAddress()}");
            Console.WriteLine($"ID: {GetId()}");
        }
    }
}