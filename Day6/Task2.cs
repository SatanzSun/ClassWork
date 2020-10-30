using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task2
    {
        public static void PrintMyName(string name, string surname)
        {
            name = name.Substring(0, 1).ToUpper();
            surname = char.ToUpper(surname[0]) + surname.Substring(1);
            Console.WriteLine(name + ". " + surname);
        }
    }
}
