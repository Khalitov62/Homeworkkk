using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 10, 9, 50, 2,1000 };
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) 
                max = arr[i];
                
            }
            Console.WriteLine(max);
        }
        //public static int Array(int[] array)
        //{
        //    int[] arr = new int[] { 1, 10, 7, 21, 3 };
        //    int Bignum = arr[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > Bignum) ;
        //        int Bignum = arr[i];


    }
}






