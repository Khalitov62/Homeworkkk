using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Student
    {
        public string Name;
        public string Surname;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;  

        }
        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }
    }
    
}
