using System;

namespace Day6
{
    class Day6
    {
        static void Main(string[] args)
        {
            //   for(int i = 0; i < 3; i++)
            //   {
            //       Task1.PrintGreeting();
            //   }

            // Console.WriteLine("Ievadi vārdu:");
            // string name = Console.ReadLine();
            // Console.WriteLine("Ievadi uzvārdu:");
            //string surname = Console.ReadLine();
            //Task2.PrintMyName(name, surname);

            Console.WriteLine("ievadi skaitli n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Faktoriāls no {n} ir {Task4.Factorial(n)}");

        }
    }
}
