using System;
using System.Collections.Generic;
using System.Text;
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
            string[] z = new string[x.Length];
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
            List<int> z = new List<int>();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 15)
                {
                    z.Add(x[i]);
                }
            }
            int[] c = z.ToArray();
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + ", ");
            }
        }
        static void Task4()
        {
            string[] x = { "jānis", "pēteris", "andris", "sergejs", "antons" };
            char a = 'a';
            char b = 'ā';
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].Contains(a) || x[i].Contains(b))
                {
                    Console.Write(x[i] + ", ");
                }
            }
        }
        static void Task5()
        {
            int[] x = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 0 && x[i] <= 30)
                {
                    Console.Write(x[i] + ", ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 31 && x[i] <= 60)
                {
                    Console.Write(x[i] + ", ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 61 && x[i] <= 90)
                {
                    Console.Write(x[i] + ", ");
                }
            }
        }
        static void Task6()
        {
            int[,] x = new int[5, 5]{
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
            int i, j;
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 5; j++)
                {
                    Console.Write(x[i, j] + ", ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
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

                default:
                    Console.WriteLine("skaitlis ārpus robezam");
                    break;

            }
        }
    }
}
