using System;
using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Person bob = new Person();
              bob.name = "Bob";
              bob.age = 20;
              bob.PrintPerson();

              Person someone = new Person();
              someone.PrintPerson();

              Person max = new Person("Max", 18);
              max.PrintPerson();*/
            Car car1 = new Car("Toyota", "Prius", 12000f, "Grey", 2005);
            Car car2 = new Car("Honda", "Accord", 6250.1f, "Blue", 1996);
            Car car3 = new Car("Opel", "Insignia", 13400f, "White", 2015);
            Car car4 = new Car("Ford", "Mustang", 66000.32f, "Red", 2010);
            Car car5 = new Car("ZAZ", "965", 5000000f, "Rusty", 1960);
            
            List<Car> CarList = new List<Car>();
            CarList.Add(car1);
            CarList.Add(car2);
            CarList.Add(car3);
            CarList.Add(car4);
            CarList.Add(car5);

            Car mostExpensive = new Car();
            foreach (Car car in CarList)
            {
                if(car.price > mostExpensive.price)
                {
                    mostExpensive = car;
                }
            }

            Console.WriteLine(mostExpensive.PrintCar());

        }
    }
}
