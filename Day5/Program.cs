using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Day5
{
    class Program
    {
        static void Task1()
        {
            int[] masivs = new int[] { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };
            for (int i = 0; i == masivs.Length; i++)  //mēģinu atrast veidu kā izvilkt "22" netaisot i < 6;
            {
                if (i == 22)
                {
                  Console.Write(" " + masivs);
                }
               
                
            }
        }
        static void Task2()
        {
            string[] Vards = new string[] { "Vards1", "Vards2", "Vards3", "Vards4", "Vards5"};
            string[] Uzvards = new string[] { "Uzvards1", "Uzvards2", "Uzvards3", "Uzvards4", "Uzvards5"};
            var VU = new List<string>();
            VU.AddRange(Vards);
            VU.AddRange(Uzvards);
            string[] VardsUzvards = VU.ToArray();
            Console.Write(String.Join(" ", VardsUzvards));
        }
        static void Main(string[] args)
        {
           // Task1();
            Task2();
        }

    }
}
