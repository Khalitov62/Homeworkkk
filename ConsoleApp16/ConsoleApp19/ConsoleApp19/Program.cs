using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student  ("Islam", "Xalitov");
            Student student1 = new Student("Ilkin", "Yusubov");

            Console.WriteLine(student.Name);
            Console.WriteLine(student1.Name + "\n");

            Console.WriteLine(student.Id);
            Console.WriteLine(student1.Id);


            Student.StaticGetCount();
        }
    }
}
