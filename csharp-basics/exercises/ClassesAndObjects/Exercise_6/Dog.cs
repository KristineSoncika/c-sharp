using System;

namespace Exercise_6
{
    public class Dog
    {
        private string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string name, string sex, Dog mother, Dog father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public string GetFathersName()
        {
            if (_father == null)
            {
                return "Unknown";
            }
            else
            {
                return _father._name;
            }
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return otherDog._mother == _mother;
        }
    }
}