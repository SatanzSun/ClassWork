using System;
using System.Collections.Generic;
using System.Text;


namespace Day7
{
    class Task4
    {
        public static string[] GetNonEmtyArray(string[] names)
        {
            List<string> namesList = new List<string>();
            foreach (string item in names)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    namesList.Add(item);
                }
            }
           
            return namesList.ToArray();
        }
    }
}
