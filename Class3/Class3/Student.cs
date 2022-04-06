using System;
using System.Collections.Generic;
using System.Text;

namespace Class3
{
     class Student:Human
    {
        //public string Name;
        //public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;

        public Student(string name, string surname, string gender, string group, byte point, byte age, bool isGraduated=false):base(name,surname,age,gender)
        {
            Group = group;
            Point = point;
            isGraduated = isGraduated;
            
        }
    }
    
}
