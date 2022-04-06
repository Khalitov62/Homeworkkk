using System;
using System.Collections.Generic;
using System.Text;

namespace Class3
{
     class Teacher:Human
    {
        public string Profession;
        public int Salary;


        //public string Info()
        //{
        //    return $"Profession: {Profession}, Salary: {Salary}";
        //}

        public Teacher (string name, string surname, byte age, string gender,int salary, string profession):base(name,surname,age,gender)
        {
            
            Salary = salary;
            Profession = profession;
        }
        public string Info()
        {
            return $"Name: {Name}, Surname {Surname}, Age: {Age}, Gender: {Gender}, Salary:{Salary}, Profession: {Profession}";
        }
    }
}
