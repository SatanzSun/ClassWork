using System;
using System.Collections.Generic;

namespace Day5
{
    class Program
    {
        static void Task1()
        {
            int[] x = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ", ");
                if (x[i] == 22)
                {
                    break;
                }
            }
        }
        static void Task2()
        {
            string[] x = { "Janis", "Peteris", "Arturs", "Juris", "Oskars", "Antons", "Aldis", "Nils", "Uldis", "Kārlis" };
            string[] y = { "Jansons", "Petersons", "Arturovs", "Jurkalns", "Oskarsons", "Antonovs", "Aldinieks", "Niliņš", "Uldāns", "Kārliņš" };
            string[] z = new string[10];
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = (x[i] + " " + y[i]);
            }
            for (int i = 0; i < z.Length; i++)
            {
                Console.Write(z[i] + ", ");
            }
        }
        static void Task3()
        {
            int[] x = { 4, 68, 7, 12, 56, 33, 1, 90, 4 };
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 15)
                {
                    count++;
                }
            }
            int[] y = new int[count];
            List<int> z = new List<int>();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 15)
                {
                    z.Add(x[i]);
                }
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(z[i] + ", ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet uzdevuma nummuru 1 - 6");
            String x = Console.ReadLine();
            switch (x.Trim())
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

               /* case "3":
                    Task3();
                    break;

                case "4":
                    Task4();
                    break;

                case "5":
                    Task5();
                    break;

                case "6":
                    CietaisRieksts();
                    break;*/

                default:
                    Console.WriteLine("skaitlis arpus robezam");
                    break;

            }
        }
    }
}
