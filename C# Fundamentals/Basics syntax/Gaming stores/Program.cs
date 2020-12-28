using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = double.Parse(input);
            string game = Console.ReadLine();
            double spend = 0;
            while (!game.Equals("Game Time"))
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (money < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            money -= 39.99;
                            spend += 39.99;
                            break;
                        }
                    case "CS: OG":
                        if (money < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            money -= 15.99;
                            spend += 15.99;
                            break;
                        }
                    case "Zplinter Zell":
                        if (money < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            money -= 19.99;
                            spend += 19.99;
                            break;
                        }
                    case "Honored 2":
                        if (money < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            money -= 59.99;
                            spend += 59.99;
                            break;
                        }
                    case "RoverWatch":
                        if (money < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            money -= 29.99;
                            spend += 29.99;
                            break;
                        }
                    case "RoverWatch Origins Edition":
                        if (money < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {game}");
                            money -= 39.99;
                            spend += 39.99;
                            break;
                        }
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${money:f2}");
        }
    }
}
