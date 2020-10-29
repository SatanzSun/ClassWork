using System;

namespace Day2
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Ievadiet skaitli robežās no 0-20.");
            string x = Console.ReadLine();
            Console.WriteLine("Ievadiet skaitli robežās no 30 - 50.");
            string y = Console.ReadLine();

            while (Convert.ToInt32(x) > 20 || Convert.ToInt32(x) < 0)
            {
                Console.WriteLine("Pirmais ievadais skaitis nav robežās no 0-20.");
                x = Console.ReadLine();
            }
            while (Convert.ToInt32(y) > 50 || Convert.ToInt32(y) < 30)
            {
                Console.WriteLine("Pirmais ievadais skaitis nav robežās no 30-50.");
                y = Console.ReadLine();
            }

            Console.WriteLine("skaitļu summa ir " + (Convert.ToInt32(x) + Convert.ToInt32(y)));
        }
        static void Task2()

        {
            bool end = false;
            string item;
            while (end == false)
            {
                Console.WriteLine("Ievadiet preikšmetus, lai noteiktu kurā stāvā tos jānovieto, kad beidzat ievadat 'end'");
                item = Console.ReadLine();
                if (item == "end")
                {
                    end = true;
                    break;
                }
                item = item.Trim().Substring(0, 1).ToLower();
                if (item == "a" || item == "b" || item == "c" || item == "d")
                {
                    Console.WriteLine("priekšmets jānovieto 1. stāvā.");
                }
                else if (item == "e" || item == "f" || item == "g" || item == "h")
                {
                    Console.WriteLine("priekšmets jānovieto 2. stāvā.");
                }
                else if (item == "i" || item == "j" || item == "k" || item == "l")
                {
                    Console.WriteLine("piekšmets jānovieto 3. stāvā.");
                }
                else if (item == "m" || item == "n" || item == "o" || item == "p")
                {
                    Console.WriteLine("piekšmets jānovieto 4. stāvā.");
                }
                else if (item == "q" || item == "r" || item == "s" || item == "t")
                {
                    Console.WriteLine("piekšmets jānovieto 5. stāvā.");
                }
                else
                {
                    Console.WriteLine("piekšmets jānovieto pagrabā");
                }
            }

        }
        static void Task3()
        {
            bool tips = false;
            bool tips2 = false;
            while (tips2 == false)
            {
                Console.WriteLine("Ievadiet eglītes aprakstu, lai noteiktu kurā istabā tā jānovieto.");
                Console.Write("Vai šī ir 'Sudrebegle'? j : n");
                while (tips == false)
                {
                    string atbilde = Console.ReadLine();
                    if (atbilde != null && atbilde == "j")
                    {
                        tips = true;
                        tips2 = true;
                        break;
                    }
                    else if (atbilde != null && atbilde == "n")
                    {
                        tips = false;
                        break;
                    }
                    else
                    {
                        Console.Write("pieļaujama tikai j vai n atbilde.");
                    }
                }
                if (tips == true)
                {
                    Console.WriteLine("Egle jānovieto Kamīnzālē.");
                    break;
                }
                Console.WriteLine("Ievadiet eglītes garumu 'cm'");
                string x = Console.ReadLine();
                int augstums = Convert.ToInt32(x);
                Console.WriteLine("Ievadiet eglītes zaru diametru 'cm'");
                string y = Console.ReadLine();
                int diametrs = Convert.ToInt32(y);

                if ((50 <= augstums && augstums < 100) && (100 <= diametrs && diametrs < 150))
                {
                    Console.WriteLine("Egle jānovieto viesistabā 1.");
                }
                else if ((100 <= augstums && augstums < 150) && (150 <= diametrs && diametrs < 200))
                {
                    Console.WriteLine("Egle jānovieto viesistabā 2.");
                }
                else if ((50 <= augstums && augstums <= 300) && (200 <= diametrs && diametrs <= 300))
                {
                    Console.WriteLine("Egle jānovieto Kamīnzālē.");
                }
                else
                {
                    Console.WriteLine("Tadu egli var mest miskastē!");
                }
                break;
            }
        }
        static void CietaisRieksts()
        {
            string player1;
            string player2;
            Console.WriteLine("Ievadiet pirma spelētāja vārdu");
            player1 = Console.ReadLine();
            Console.WriteLine("Ievadiet otrā spelētāja vārdu");
            player2 = Console.ReadLine();
            Console.WriteLine("Ievadiet pirmā spelētāja pirmā rauda punktus");
            int p1r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet pirmā spelētāja otrā rauda punktus");
            int p1r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet pirmā spelētāja trešā rauda punktus");
            int p1r3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otrā spelētāja pirmā rauda punktus");
            int p2r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otrā spelētāja otrā rauda punktus");
            int p2r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otrā spelētāja trešā rauda punktus");
            int p2r3 = Convert.ToInt32(Console.ReadLine());
            if ((p1r1 + p1r2 + p1r3) > (p2r1 + p2r2 + p2r3))
            {
                Console.WriteLine("Uzvarētājs ir " + player1);
            }
            else if ((p1r1 + p1r2 + p1r3) < (p2r1 + p2r2 + p2r3))
            {
                Console.WriteLine("Uzvarētājs ir " + player2);
            }
            else
            {
                Console.WriteLine("Uzvarētājs ir Draudzība(neizšķirts)!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ievadiet uzdevuma nummuru 1 - 4");
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
                    CietaisRieksts();
                    break;

                default:
                    Console.WriteLine("skaitlis arpus robezam");
                    break;
            }
        }
    }
}
