using System;
using System.Collections.Generic;
using System.Text;

namespace Class3
{
    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;


        public Human(string name, string surname, byte age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }


        public Human(byte age)
        {
            Age = age;
        }
        public string Fullname()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }
    }
}
