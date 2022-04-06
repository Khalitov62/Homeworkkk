using System;
using System.Collections.Generic;
using System.Text;

namespace Class3
{
     class Polis:Human
    {
        public string Region;


        public Polis(string name, string surname, byte age, string gender,string region):base(name,surname,age,gender)
        {
            Region = region;
        }

        public string Info()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Gender: {Gender}, Region: {Region}";
        }
    }
}
