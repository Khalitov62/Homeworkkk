using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    internal class Student
    {
        public string Name;
        private string _group;

        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                if (value.Length == 6 && value.Contains("P"))
                {
                    _group = value;
                }
                else
                {
                    Console.WriteLine("Qrup adi teyin olunmadi");
                }
            }
        }

        public Student(string name, string group)
        {
            Name = name;
            Group = group;
        }

    }
}
