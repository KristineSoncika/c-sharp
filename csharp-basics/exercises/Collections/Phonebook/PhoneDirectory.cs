using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class PhoneDirectory
    {
        private SortedList<string, string> _directory;

        public PhoneDirectory()
        {
            _directory = new();
        }

        public string GetNumber(string name)
        {
            return _directory.ContainsKey(name) ? _directory[name] : "Number not found!";
        }

        public void AddNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            _directory.Add(name, number);
        }
    }
}