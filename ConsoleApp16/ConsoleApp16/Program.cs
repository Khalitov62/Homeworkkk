using System;
using System.Text;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stringbuldier
            //int[] arr = { 1, 2, 3, };
            //Change(arr);
            //Console.WriteLine(arr[0]);
            //string word = "Okay";
            //Change(word);
            //Console.WriteLine(word);
            //for (int i = 0; i < 5; i++)
            //{
            //    word += i;
            //        Console.WriteLine(word);
            //}
            //    StringBuilder stringBuilder = new StringBuilder();
            //    stringBuilder.Append(word);
            //}
            //public static void Change(int[] arr)
            //{
            //    arr[0] = 15;
            //    Console.WriteLine(arr[0]);
            //}

            //public static void Change(string word)
            //{
            //    word = "Change";
            //    Console.WriteLine(word);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello world ");

            //stringBuilder.Insert(6, "today ");

            //stringBuilder.Remove(2,5);

            //Console.WriteLine(stringBuilder);

            //stringBuilder.AppendFormat("{0:c}", 515);

            DateTime dateTime = new DateTime(2022,03,15);
            stringBuilder.AppendFormat("{0:d}", dateTime);
            Console.WriteLine(stringBuilder);

            Console.WriteLine(DateTime.Now);
            #endregion

            Student student = new Student("Fatima", "AP-204");
            student.Group = "AP-205";
            Console.WriteLine(student.Group);
           
        }
    }

}
