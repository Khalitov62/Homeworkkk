using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound();

            Eagle eagle = new Eagle();
            eagle.Sound();

            Shark shark = new Shark();
            shark.Sound();

            Student student = new Student("Islam", "Xalitov");
            Console.WriteLine(student.ToString());
        }

    }
}
