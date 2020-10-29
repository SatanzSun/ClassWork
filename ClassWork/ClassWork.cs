using System;

namespace ClassWork
{
    class ClassWork
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
            Console.WriteLine("evadiet vardu");
            string x = Console.ReadLine();
            Console.WriteLine("evadiet uzvardu");
            string y = Console.ReadLine();
            x = x.Substring(0, 1).ToUpper();
            y = char.ToUpper(y[0]) + y.Substring(1);
            Console.WriteLine(x + ". " + y);
        }
        static void ExtraTask()
        {
            
        }

       public static void Main(string[] args)
        {

            Task1();
            /*Task2();*/
            /*Task3();*/
            /*Task4();*/
            /*Task5();*/
            /*ExtraTask();*/
        }

    }
}
