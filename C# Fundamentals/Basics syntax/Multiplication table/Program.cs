using System;
using System.Net.Http.Headers;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplayer = int.Parse(Console.ReadLine());
            int count = 0;
            if (multiplayer > 10)
            {
                Console.WriteLine($"{n} X {multiplayer} = {n * multiplayer}");
            }
            else
            {

                for (int i = multiplayer; i <= 10; i++)
                {

                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }
    }
}

