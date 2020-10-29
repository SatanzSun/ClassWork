using System;

namespace Day4
{
    class Program
    {
        static void Task1()
        {
            string[] x = { "Janis", "Peteris", "Arturs", "Juris", "Oskars", "Antons" };
            int i = 0;
            do 
            {
                Console.Write(x[i] + ", ");
                i++;
            }while (i < x.Length);
        }
        static void Task2()
        {
            int[] numbers = { 1, 3, 4, 8, 0, 23 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 5)
                Console.Write(numbers[i] + ", ");
            }
        }
        static void Task3()
        {
            string[] x = { "Janis", "Peteris", "Arturs", "Juris", "Oskars", "Antons" };
            for (int i = 0; i < x.Length; i++)
            {
                var j = x[i].Trim().Substring(0, 1).ToLower();
                if (j == "j")
                    Console.Write(x[i] + ", ");
            }
        }
        static void Task4()
        {
            int[] x = new int[10];

            for(int i = 0; i < x.Length; i++)
            {
                x[i] = i;
            }
        }
        static void CietaisRieksts()
        {
            string x = Console.ReadLine();

            for (int i =  x.Length; i > 0; i--)
            {
                Console.Write(x[i] + ", ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet uzdevuma nummuru 1 - 5");
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
                    CietaisRieksts();
                    break;

                default:
                    Console.WriteLine("skaitlis arpus robezam");
                    break;
            }
            }
    }
}
