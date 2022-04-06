using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //if (number < number2)
            //{
            //    Console.WriteLine("Number2 boyukdur number den");
            //}
            //else if (number > number2)
            //{
            //    Console.WriteLine("Number boyukdur Number2 den");

            //}
            //else
            //{
            //    Console.WriteLine("Ededler Beraberdir");
            //}


            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Salam");
                    break;
                case 5:
                    Console.WriteLine("Privet");
                    break;
                case 6:
                    Console.WriteLine("Hi");
                    break;
                default: Console.WriteLine("As salamu aleykum");
                    break ;


            }
        }

    }


}


