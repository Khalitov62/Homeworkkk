using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    internal class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public static int count=0;
        public Student(string name, string surname)
        {
            count++;
            Id = count;
            Name = name;    
            Surname = surname;
            

        }


        public string getName()
        {
            return Name;
        }

        public int GetCount()
        {
            return count;
        }

        public static void StaticGetCount()
        {
            Console.WriteLine($"{count}");

        }
    }
}
