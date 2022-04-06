using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int numNatural = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Natural(num,numNatural));
        }
       public static int Natural(int num, int numNatural)
        {
            int numCopy = num;
            int count = 0;
            int ten = 1;
            while (numCopy >= 1)
                count++;
            {
               for (int i = 0; i < count; i++)
                {
                    ten *= 10;
                    {
                        num = (numNatural * ten) + num;
                    }
                }
                return num;
            }
        }
    }
}
