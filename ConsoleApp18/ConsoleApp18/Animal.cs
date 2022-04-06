using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal  class Animal
    {
        public string Sort;
        public virtual void Sound()
        {
            Console.WriteLine("Animal make sound");
        }
    }
}
