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
        static string VardaIevade()
        {
            Console.WriteLine("Ievadi Vārdu: ");
            string name = Console.ReadLine();
            return (name.Substring(0, 1).ToUpper() + ". ");
        }
        static string UzvardaIevade()
        {
            Console.WriteLine("Ievadi Uzvārdu: ");
            string surname = Console.ReadLine();
            return (surname.Substring(0, 1).ToUpper() + surname.Substring(1));

        }
        public static void PrintMyName()
        {
            Console.WriteLine(Task2.VardaIevade() + Task2.UzvardaIevade());
        }

    } 

}
