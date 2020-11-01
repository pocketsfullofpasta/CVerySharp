using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Ievadi x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && x <= 20 || y >= 30 && y <= 50)
                Console.WriteLine(x + y);
            else
                Console.WriteLine("Kļūda!");
        }
        static void Task2()
        {
            Console.WriteLine("Ievadi priekšmetu: ");
            string item = Console.ReadLine().Trim();

            if ((item.StartsWith("a")) || (item.StartsWith("b")) || (item.StartsWith("c")) || (item.StartsWith("d")))
            {
                var lieta = new List<string>();
                string[] floor1 = lieta.ToArray();
                Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1) + " novietots/a 1. stāvā!");
            }
            else if ((item.StartsWith("e")) || (item.StartsWith("f")) || (item.StartsWith("g")) || (item.StartsWith("h")))
            {
                var lieta = new List<string>();
                string[] floor2 = lieta.ToArray();
                Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1) + " novietots/a 2. stāvā!");
            }
            else if ((item.StartsWith("i")) || (item.StartsWith("j")) || (item.StartsWith("k")) || (item.StartsWith("l")))
            {
                var lieta = new List<string>();
                string[] floor3 = lieta.ToArray();
                Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1) + " novietots/a 3. stāvā!");
            }
            else if ((item.StartsWith("m")) || (item.StartsWith("n")) || (item.StartsWith("o")) || (item.StartsWith("p")))
            {
                var lieta = new List<string>();
                string[] floor4 = lieta.ToArray();
                Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1) + " novietots/a 4. stāvā!");
            }
            else if ((item.StartsWith("r")) || (item.StartsWith("s")) || (item.StartsWith("t")) || (item.StartsWith("u")))
            {
                var lieta = new List<string>();
                string[] floor5 = lieta.ToArray();
                Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1) + " novietots/a 5. stāvā!");
            }
            else
            {
                var lieta = new List<string>();
                string[] basement = lieta.ToArray();
                Console.WriteLine(item.Substring(0, 1).ToUpper() + item.Substring(1) + " novietots/a pagrabā!");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Apsveicam, tu nopirki eglīti, jo biji pārāk slinks pats uz mežu aiziet!\n" + 
                "Tagad tikai jāizdomā kur viņu bāzt.\n" + "Kāds ir egles augstums?");
            int x = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Diametrs?");
            int y = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Tā ir egle vai sudrabegle?");
            string tips = Console.ReadLine().Trim().ToLower();

            if (tips == "egle")
            {
                if ((x >= 50 && x <= 100) || (y >= 100 && y <= 150))
                {
                    var egle = new List<string>();
                    string[] room1 = egle.ToArray();
                    Console.WriteLine(tips.Substring(0, 1).ToUpper() + tips.Substring(1) + " novietota viesistabā Nr. 1!");
                }
                else if ((x >= 100 && x <= 150) || (y >= 150 && y <= 200))
                {
                    var egle = new List<string>();
                    string[] room2 = egle.ToArray();
                    Console.WriteLine(tips.Substring(0, 1).ToUpper() + tips.Substring(1) + " novietota viesistabā Nr. 2!");
                }
                else if ((x >= 150 && x <= 200) || (y >= 200 && y <= 300))
                {
                    var egle = new List<string>();
                    string[] room3 = egle.ToArray();
                    Console.WriteLine(tips.Substring(0, 1).ToUpper() + tips.Substring(1) + " novietota kamīntelpā!");
                }
                else if (x > 100 || y > 300)
                {
                    var egle = new List<string>();
                    string[] outside = egle.ToArray();
                    Console.WriteLine("Tā nav egle - tas ir monstrs. Nes ārā!");
                }
                else if (x < 50 || y < 150)
                {
                    var egle = new List<string>();
                    string[] reject = egle.ToArray();
                    Console.WriteLine("Tā nav egle - tas ir izsmiekls. Nes atpakaļ!");
                }
            }
            else if (tips == "sudrabegle")
            {
                var egle = new List<string>();
                string[] room3 = egle.ToArray();
                Console.WriteLine(tips.Substring(0, 1).ToUpper() + tips.Substring(1) + " novietota kamīntelpā!");
            }
            else
                Console.WriteLine("Tā nav egle. Nes atpakaļ!");

        }
        static void Task4()
        {
            Console.WriteLine("Ievadi pirmā spēlētāja vārdu: ");
                string player1 = Console.ReadLine().Trim();
            Console.WriteLine("Ievadi otrā spēlētāja vārdu: ");
                string player2 = Console.ReadLine().Trim();

            Console.WriteLine("Ievadi " + player1.Substring(0, 1).ToUpper() + player1.Substring(1) + " pirmās kārtas punktus: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi " + player1.Substring(0, 1).ToUpper() + player1.Substring(1) + " otrās kārtas punktus: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi " + player1.Substring(0, 1).ToUpper() + player1.Substring(1) + " trešās kārtas punktus: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int x = (x1 + x2 + x3);

            Console.WriteLine("Ievadi " + player2.Substring(0, 1).ToUpper() + player2.Substring(1) + " pirmās kārtas punktus: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi " + player2.Substring(0, 1).ToUpper() + player2.Substring(1) + " otrās kārtas punktus: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi " + player2.Substring(0, 1).ToUpper() + player2.Substring(1) + " trešās kārtas punktus: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int y = (y1 + y2 + y3);

            if (x > y)
                Console.WriteLine(player1.Substring(0, 1).ToUpper() + player1.Substring(1) + " ir uzvarētājs ar " + x + " punktiem, pret " + player2.Substring(0, 1).ToUpper() + player2.Substring(1) + " " + y + " punktiem!");
            else if (x < y)
                Console.WriteLine(player2.Substring(0, 1).ToUpper() + player2.Substring(1) + " ir uzvarētājs ar " + y + " punktiem, pret " + player1.Substring(0, 1).ToUpper() + player1.Substring(1) + " " + x + " punktiem!");
            else
                Console.WriteLine("Abiem spēlētājiem ir vienāds punktu skaits - " + x + ". Abi zaudēja!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi skaitli no 1 - 4!");
            string nr = Console.ReadLine();

            switch (nr.Trim())
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
                default:
                    Console.WriteLine("Out of range!");
                    break;

            }
        }
    }
}
