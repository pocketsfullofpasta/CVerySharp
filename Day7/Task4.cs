using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace Day7
{
    class Task4
    {
        public static string[] GetNonEmptyValues(string[] brr)
        {
          
            List<string> list = new List<string>();
            foreach (string item in brr)
            {
                if (!String.IsNullOrWhiteSpace(item))
                {
                    list.Add(item);
                }
                
            }return list.ToArray();
            
        }
    }
}
