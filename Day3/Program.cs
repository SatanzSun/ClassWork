using System;

namespace Day3
{
    class Program
    {
        static void Task1()
        {
            int[] x = { 1, 6, 7, 78, 9, 9 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ", ");
            }
        }

        static void Task2()
        {
            Console.WriteLine("Vai jus velaties pusdienas? True : False");
            bool x = bool.Parse(Console.ReadLine());
            if (x)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas");
            }
            else
            {
                Console.WriteLine("Jums pusdienas nebūs");
            }
        }

        static void Task3()
        {
            int y = 0;
            bool x = true;
            while (x)
            {
                y++;
                if (y == 20)
                {
                    x = false;
                }

            }
        }

        static void Task4()
        {
            Console.WriteLine("Ievadiewt skaitli");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Hello world");
            }
        }
        static void Task5()
        {
            int[] x = { 100, 200, 233, 66, 77, 98 };
            Console.WriteLine(x[0] + " " + x[^1]);

        }
        static void Task6()
        {

            int[] x = { 7, 4, 7, 3, 6, 9, 2 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + ", ");
            }
            Console.WriteLine(" ");
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] == 3)
                {
                    y[i] = 10;
                    continue;
                }
                y[i] = x[i];
            }
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + ", ");
            }
        }
        static void Task7()
        {
            string[] x = { "Jānis", "Pēteris", "Andris" };
            Console.WriteLine(x[1]);
            x[2] = "Jēkabs";
        }

        static void Task8()
        {
            var z = (DayOfWeek)4;
            Console.WriteLine(z);
        }
        enum DayOfWeek
        {
            Monday,
            Tuesdayr,
            Wednsday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void CietaisRieksts()
        {
            Console.WriteLine("Ievadiet skaitli līdz 20.");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x > 20)
            {
                Console.WriteLine("Ievaditais skaitlis ir lielaks par 20, meģinat vēlreiz.");
                x = Convert.ToInt32(Console.ReadLine());
            }
            int z = 1;
            while (z <= x)
            {
                Console.WriteLine(" ");
                for (int i = 1; i <= x; i++)
                {
                    Console.Write(i * z + " ");
                }
                z++;
                continue;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("ievadiet uzdevuma nummuru 1 - 9");
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

                case "7":
                    Task7();
                    break;

                case "8":
                    Task8();
                    break;

                case "9":
                    CietaisRieksts();
                    break;

                default:
                    Console.WriteLine("skaitlis arpus robezam");
                    break;

            }
        }
    }
}
