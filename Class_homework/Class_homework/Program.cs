using System;

namespace Class_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Islam", "Khalitov", "AP-204", 99, true);
            student.Info();
            student.Exam();
            //student.Info2();
            Student student1 = new Student();
        }
        class Student
        {
            public string Name;
            public string Surname;
            public object Group;
            public byte Point;
            public bool isGraduated;


            public Student(string name, string surname, object group, byte point, bool isGradutaed)
            {
                Name = name;
                Surname = surname;
                Group = group;
                Point = point;
                Boolean isGraduated;


            }

            public Student()
            {
                Console.WriteLine("Student yaradildi");
            }
            public void Info()
            {
                Console.WriteLine($"Name: {Name},Surname: {Surname},Group: {Group},Point: {Point},Tehsil alir.");
            }
            public void Info2()
            {
                Console.WriteLine("Mezun olub");
            }
            public void Exam()
            {
                if (Point > 80) 
                Console.WriteLine("Next Exam");
                if (Point < 80) 
                Console.WriteLine("Failed");
            }
        }
    }
}

