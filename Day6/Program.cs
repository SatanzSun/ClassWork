using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet uzdevuma nr. vai exit, lai izietu.");

            string taskNr = Console.ReadLine();
            switch (taskNr.Trim())
            {
                case "1":
                    Task1.PrintGreeting();
                    Task1.PrintGreeting();
                    Task1.PrintGreeting();
                    break;

                case "2":
                    Task2.PrintMyName("Name", "Sruname");
                    break;

                case "3":
                    Task3.PrintNameSurname(Task3.GetNameSurname());
                    break;

                case "4":
                    CietaisRieksts.();
                    break;

                case "exit":
                    break;

                default:
                    Console.WriteLine("skaitlis arpus robezam");
                    break;

            }
        }
    }
}
