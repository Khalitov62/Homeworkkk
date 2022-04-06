using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(19));
        }
        public static int  Divide(int num)
        {
            if (num % 7 == 0)
            {
                Console.WriteLine("Eded 7 e bolunur");
            }
            int a = num % 7;
            int b = 7 - a;
            if (a > b)
            {
                return num + b;
            }
            else
            {
                return num - a;
            }
        }
    }
}
