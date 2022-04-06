using System;

namespace Taks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Islam", "Resid", "Malik", "Bahadur", "Baxsheli" };
            for (int i = 0; i < name.Length; i++)

                if (name[i].Length > 5)
                {
                    Console.WriteLine(name[i]);
                }


        }



    }
}






