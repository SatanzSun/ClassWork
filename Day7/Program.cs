using System;

namespace Day7
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
                    TicTacToe.Program.Main(new string[0]);
                    break;


                case "2":
                    Console.WriteLine("Ievadiet Vardu");
                    string name = Console.ReadLine();
                    Console.WriteLine("Ievadiet uzvardu");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Ievadiet vecumu");
                    string age = Console.ReadLine();
                    string nameSurname = name + " " + surname;
                    Task2.PrintNameSurname(nameSurname);
                    Task2.PrintNameSurname(name, surname);
                    Task2.PrintNameAge(name);
                    break;

                case "3":
                    int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    string[] let = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
                    Task3.PrintArrayValues(num);
                    Task3.PrintArrayValues(let);
                    break;

                case "4":
                    string[] names = { "Jānis", "", "Pēteris", "Antons", "", "Andris" };
                    Task3.PrintArrayValues(names);
                    string[] editedArray = Task4.GetNonEmtyArray(names);
                    Console.WriteLine();
                    Task3.PrintArrayValues(editedArray);
                    break;

                case "5":
                    while (true)
                    {
                        Console.WriteLine("Ievadat skaitļus kurus vēlaties saskaitīt. Lai beigtu ievadat pirmā skaitļa vietā 'exit'");
                        Console.WriteLine("Ievadat pirmo skaitli:");

                        string a = Console.ReadLine();
                        if (a == "exit")
                        {
                            break;
                        }
                        int x = Convert.ToInt32(a);
                        Console.WriteLine("Ievadat otro skaitli:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Skaitļu summa ir " + Task5.CalculateSum(x, y));
                    }
                    break;

                case "6":

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