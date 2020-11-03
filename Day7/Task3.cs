using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task3
    {
        public static void PrintArrayValues(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + ", ");
               
            }
        }
        public static void PrintArrayValues(string[] let)
        {
            for (int i = 0; i < let.Length; i++)
            {
                Console.Write(let[i] + ", ");

            }
        }
    }
}
