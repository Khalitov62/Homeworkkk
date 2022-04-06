using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    internal class User
    {
        string _username;
        string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Usernameni uzulugu 6 dan boyuk olmalidir");
                }
            }

        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {

            }
        }

        public static bool CheckPassword(string pw)
        {
            if (pw.Length >= 8)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;

                foreach (char letter in pw)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                    }
                    if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                    }
                    if (char.IsLower(letter))
                    {
                       hasLower = true;
                    }
                }
            }
            return false;
        }
    }
}
