using System;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int power = N;
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int count = 0;
            double temp = power * 0.5;
            while (power >= distance)
            {
                power -= distance;
                count += 1;
                if (power == temp && exhaustion != 0)
                {
                    power = power / exhaustion;
                }

            }
            Console.WriteLine(power);
            Console.WriteLine(count);

        }
    }
}

