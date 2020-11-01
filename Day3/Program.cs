using System;
using System.Threading.Tasks.Dataflow;

namespace Day3
{
    class Program
    {
        static void Task1()
        {
            int[] masivs = { 1, 6, 7, 78, 9, 9 };

           for(int i = 0; i < masivs.Length; i++)
            {
                Console.Write(masivs[i] + ", ");
            }
        }
        
        
        static void Task2()
        {
            Console.WriteLine("Vai tu gribi pusdienas?");
            bool x = Convert.ToBoolean(Console.ReadLine());
            
            if ( x == true)
               Console.WriteLine("Jūsu pusdienas ir gatavas!");
            else
                Console.WriteLine("Jums pusdienas nebūs!");
        }
        static void Task3()
        {
            bool x = true;

            int i = 0;
            while (i < 20 )
            { 
                Console.WriteLine(x);
                i++;
            }
        }
        static void Task4()
        {
            Console.WriteLine("Ievadi skaiti: ");
            int x = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Hello World!");
            }

        }
        static void Task5()
        {
            int[] masivs = new int[] { 100, 200, 233, 66, 77, 98 };
            Console.WriteLine(masivs[0] + " " + masivs[masivs.Length - 1]);
        }
        static void Task6()
        {
            int[] masivs = new int[] { 7, 4, 7, 3, 6, 9, 2 };
            masivs[3] = 10;
            Console.Write(String.Join(", ", masivs));
        }
        static void Task7()
        {
            string[] masivs = new string[] { "Jānis", "Pēteris", "Andris" };
            Console.WriteLine(masivs[1]);
            masivs[2] = "Jēkabs";
            Console.WriteLine(String.Join(", ", masivs));
        }
        enum Task8
        {
            Pirmdiena,
            Otrdiena,
            Trešdiena,
            Ceturtdiena,
            Piektdiena,
            Sestdiena,
            Svētdiena,
        }
        /*   static void Task9()
           {
               Console.WriteLine("Ievadi skaitli no 1 - 20: ");
               int x = Convert.ToInt32(Console.ReadLine());

               if (x < 1 || x > 20)
                   Console.WriteLine("Out of range!");                 //Pagaidām padoodos, nav vairs laika
               else
              {
                   int i = 0;
                   int j = 0;

                   while (i < x)
                   {
                       Console.Write(i + " " + i * x);
                       i++;
                       Console.Write(j + " " + j * x);
                       j++;
                   }

               }
           }*/
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi skaitli no 1 - 9!");
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
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                case "7":
                    Task7();
                    break;
                case "8":
                    Console.WriteLine(Task8.Piektdiena);
                    break;
                case "9":
                    Console.WriteLine("Still in progress");
                    break;
                default:
                    Console.WriteLine("Out of range!");
                    break;
            }
        }
    }
}
