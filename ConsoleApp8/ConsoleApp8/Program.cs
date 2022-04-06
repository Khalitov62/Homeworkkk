using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide());
        }
        public static int Divide()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (number < 50)
            {
                for (int i = 1; i < number; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                   else if (number >= 50 && number < 100)
                    {
                        for (int j = 1; j < number; j++)
                        {
                            if (j % 5 == 0)
                            {
                                count++;
                            }
                            else if (number > 100)
                            {
                                for (int k = 0; k < number; k++)
                                {
                                    if (j % 8 == 0)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
