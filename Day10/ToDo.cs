using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Day10
{
    enum WeekDayEnum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    class ToDo
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public ToDo Weekday { get; set; }
        public bool Done { get; set; }

        public ToDo(string name, string description, ToDo day, bool done)
        {
            this.Name = name;
            this.Description = description;
            this.Weekday = day;
            this.Done = done;
        }
    }
    
}
