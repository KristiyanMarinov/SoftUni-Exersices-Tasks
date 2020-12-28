using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int a = number % 10;
                int b = 1;
                for (int j = 1; j <= a; j++)
                {
                    if (j == a)
                    {
                        break;
                    }
                    b = b * (j + 1);
                }
                sum += b;
                number = (number - a) / 10;
            }
            if (sum == int.Parse(input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

