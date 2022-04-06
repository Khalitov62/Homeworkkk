using System;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1name = "Kamal";
            //string student1surname = "Ebishli";
            //byte student1age = 20;

            //string studen2name = "Rashid";
            //string studen2surname = "Mammadov";
            //byte studen2age = 19;

            #region Anonymous Type
            //var student = new
            //{
            //    name = "Kamal",
            //    surname = "Ebishli",
            //    age = 20

            //};

            //var student2 = new
            //{
            //    name = "Rashid",
            //    surname = "Mammadov",
            //    age = 19
            //};

            //Console.WriteLine(student.name + " " + student.surname + " " + student.age);
            #endregion


            #region Class
            Student student = new Student("Tural","Hamidzade",20);
            //student.Name = "Tural";
            //student.Surname = "Hamidzade";
            //Console.WriteLine(student.Name);

            //student.Fullname();
            student.Info();


            Student student1 = new Student("Baxsheli","Nazarov",19);
            //student1.Age = 19;
            //student1.Name = "Baxsheli";
            //student1.Surname = "Nazarov";

            student1.Info();

            //Program program = new Program();
            //program.Test();

            Student student3 = new Student();
            

        }
        public void Test()
        {
            Console.WriteLine("Test");
        }
    }

    class Student
    {

        
        public string Name;
        public string Surname;
        public byte Age;
        public Student()
        {
            Console.WriteLine("Student yaradildi");
        }
        public Student(string Name, string Surname, byte age):this(age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = age;
        }

        public void Fullname()
        {

            Console.WriteLine(Name + " " + Surname);
        }

        public void Info()
        {
            //Console.WriteLine("Name: " + Name + "Surname: " + Surname + " " + "Age: " + Age);
            //Console.WriteLine("Name:{0}, Surname;{1}, Age:{2}", Name, Surname, Age);
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");

            
        }
        public Student(byte age )
        {
            Console.WriteLine($"Age:{age}");
        }
        #endregion

    }
}
