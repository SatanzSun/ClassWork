using System;


namespace ClassWork2
{
    class ClassWork2
    {
        static void Task1()
        {
            string vards = "Reinis";
            string uzvards = "Virsnieks";
            Console.WriteLine(vards + " " + uzvards);

        }
        static void Task2()
        {
            int a = 2;
            double b = 2.567;
            bool c;
            string d;
            c = true;
            d = "abc";
            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
        static void Task3()
        {
            int x;
            int y;
            x = 10;
            y = 15;
            int z = x + y;
            Console.WriteLine(z);
        }
        static void Task4()
        {
            Console.WriteLine("evadiet savu vardu");
            string x = Console.ReadLine();
            Console.WriteLine(x);
        }
        static void Task5()
        {
            Console.WriteLine("ievadiet vardu");
            string x = Console.ReadLine();
            Console.WriteLine("ievadiet uzvardu");
            string y = Console.ReadLine();
            x = x.Substring(0, 1).ToUpper();
            y = char.ToUpper(y[0]) + y.Substring(1);
            Console.WriteLine(x + ". " + y);
        }
        static void ExtraTask()
        {
            String x;
            String y;
            Console.WriteLine("ievadiet pirmo skaitli");
            x = Console.ReadLine();
            Console.WriteLine("ievadiet otro skaitli");
            y = Console.ReadLine();
            String z = x;
            x = y;
            y = z;
            Console.WriteLine(x + " " + y);
        }

        public static void Main(string[] args)
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
                    ExtraTask();
                    break;

                default:
                    Console.WriteLine("skaitlis arpus robezam");
                    break;
            }

        }

    }

}

