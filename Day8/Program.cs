using System;

namespace Day8
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
                    int[] intArray = { 3, 6, 5, 4, -5, 1, 10 };
                    Console.WriteLine(String.Join(",", intArray));
                    intArray = Task1.GetOnlySmallValues(intArray);
                    Console.WriteLine(String.Join(",", intArray));
                    break;


                case "2":
                  Console.WriteLine(PasswordValidator.ValidatePassword("123"));
                    Console.WriteLine(PasswordValidator.ValidatePassword("12345678"));
                    Console.WriteLine(PasswordValidator.ValidatePassword("123A45678"));
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
