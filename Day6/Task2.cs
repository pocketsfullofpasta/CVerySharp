using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Day6
{
    class Task2
    {
        public static void PrintMyName(string name, string surname)
        {
            Console.WriteLine($"{ name.Substring(0, 1).ToUpper() }. {surname.Substring(0, 1).ToUpper() + surname.Substring(1)}");
        }

    } 

}
