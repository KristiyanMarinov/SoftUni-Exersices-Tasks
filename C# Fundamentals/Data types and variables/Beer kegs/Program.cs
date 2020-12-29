using System;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double firstvolume = 1;
            string biggestKeg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string typeKeg = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double newVolume = 3.14 * r * r * h;
                if (newVolume > firstvolume)

                {
                    firstvolume = newVolume;
                    biggestKeg = typeKeg;

                }

            }
            Console.WriteLine(biggestKeg);

        }
    }
}

