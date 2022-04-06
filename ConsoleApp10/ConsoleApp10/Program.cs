using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { '*', '%', '-', '+', };
            int num1 = 10;
            int num2 = 5;

            Console.WriteLine(Math());
        }
        public static int Math(int num1, int num2,char[] chars)
        {
           return num1 *  num2 
        }
    }
}
