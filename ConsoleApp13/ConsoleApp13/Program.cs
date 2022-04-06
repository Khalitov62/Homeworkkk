using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max()); 
        }
        public static int Max()
        {
            int[] arr = new int[] { 5, 10, 9, 50, 2000, 1000 };
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
            Console.WriteLine(max);
        }
    }
}
