using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divider());
        }
        public static int Divider()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (number < 50)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                    //else if (number > 50 && number < 100)
                    //{
                    //    for (int j = 51; j <= number; j++)
                    //    {
                    //        count++;
                    //    }
                    //}


                }
            }
            return count;
        }
    }
}




