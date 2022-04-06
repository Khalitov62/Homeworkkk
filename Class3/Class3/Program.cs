using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human human = new Human ();

            // human.Age = 20;
            //Console.WriteLine(human);

            //Student student = new Student("Bahadur", "Umarov", "Male", "AP204", 51, 19);
            //Console.WriteLine(student.Gender);

            //Teacher teacher = new Teacher("Javid", "Asadullayev", 24, "Male", 5670, "Programming");
            //Console.WriteLine(teacher.Fullname());


            Polis polis = new Polis("Rashid", "Mammadov", 19, "Male", "Narimanov");
            Console.WriteLine(polis.Info());

            Teacher teacher = new Teacher("Islam", "Khalitov", 20, "Male", 570, "Programming");
            Console.WriteLine(teacher.Info());
        }
    }
}
