using System;

namespace Day3
{
    class Program
    {
        static void Task1()
        {
            int[] masivs = { 1, 6, 7, 78, 9, 9 };
           // Array.ForEach(masivs, Console.WriteLine);
           for(int i = 0; i < masivs.Length; i++)
            {
                Console.Write(masivs[i] + ", ");
            }
        }/// <summary>
        /// 
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Vai tu gribi pusdienas?");
            string x = Console.ReadLine();

            if (true)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            else 
            {
                Console.WriteLine("Jums pusdienas nebūs");
            }
       
        }    
        static void Main(string[] args)
        {
            // Task1();
            Task2();
        }
    }
}
