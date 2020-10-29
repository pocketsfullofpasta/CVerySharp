using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Ivo Markuss");
        }

        static void Task2()
        {
            int x;
            double y;
            bool z = true;
            string q = "Divi zirgi";
            x = 3;
            y = 2.5;

            if (x - y != 0.5)
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine(q);
            }
            
        }

        static void Task3() 
        {
            int x = 10;
            int y = 15;
            int z = x + y;

            Console.WriteLine(z);


        }
        static void Task4()
        {
            Console.WriteLine("Ievadi vārdu:");
            string vards = Console.ReadLine();
            Console.WriteLine(vards);
        }

        static void Task5()
        {
            Console.WriteLine("Ievadi vārdu:");
            string vards = Console.ReadLine();
            Console.WriteLine("Ievadi uzvārdu:");
            string uzvards = Console.ReadLine();
            Console.WriteLine(vards.Substring(0,1) + ". " + uzvards);

        }

        static void Task6()
        {
            
            Console.WriteLine("Ievadi vērtību a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a = " + a);
            Console.WriteLine("Ievadi vērtību b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("b = " + b);

            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine("b = " + b + "; a = " + a);
        }
        static void Main(string[] args)
        {
            //   Task1();
            //   Task2();
            //   Task3();
            //   Task4();
            //   Task5();
            //   Task6();
            //   Pabeigt šito iekš switch

            Console.WriteLine("Ievadi skaitli no 1 - 6!");
            string nr = Console.ReadLine();

            switch(nr.Trim()) 
            {

                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                default:
                    Console.WriteLine("Out of range!");
                    break;

            }

        }
    }
}
