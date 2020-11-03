using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task2
    {
        public static void PrintNameSurname(string name)
        {
            Console.WriteLine(name.Substring(0, 1).ToUpper() + name.Substring(1));
        }
        public static void PrintNameSurname(string name, string surname)
        {
            Console.WriteLine(name.Substring(0, 1).ToUpper() + name.Substring(1) + " " + surname.Substring(0, 1).ToUpper() + surname.Substring(1));
        }
        public static void PrintNameAge(string name, string age = "99")
        {
            Console.WriteLine(name.Substring(0, 1).ToUpper() + name.Substring(1) + " " + age);
        }
    }
}
