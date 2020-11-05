using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "Unknown";
            this.age = 99;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"{this.name} {this.age}");
        }

    }
}
