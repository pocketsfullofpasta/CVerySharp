using System;
using System.Collections.Generic;
using System.Linq;
namespace Day10
{
    class Day10
    {
        static void Main(string[] args)
        {

            /*  Chair chair1 = new Chair("Soft", 1.25f, "Brown", 2.25f, 35f);
              Chair chair2 = new Chair("semiSoft", 3.2f, "alsoBrown", 3.4f, 12.6f);
              Chair chair3 = new Chair("rockHard", 2.2f, "darkBrown", 3.15f, 62f);
              Chair chair4 = new Chair("broken", 0.12f, "Brown", 13.6f, 1.22f);


              var newList = new List<Chair>();
              newList.Add(chair1);
              newList.Add(chair2);
              newList.Add(chair3);
              newList.Add(chair4);

              Chair theFattest = newList.Where(theFattest => theFattest.Weight == 62f).First();
              Console.WriteLine(theFattest);

              */

            ToDo item1 = new ToDo("Dishes", "Wash the dishes", ToDo.Friday, false);
            List<ToDo> itemList = new List<ToDo>();
            itemList.Add(item1);

            List<ToDo> undoneItems = itemList.Where(item => item.Done != true).ToList();
            foreach(ToDo item in undoneItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
