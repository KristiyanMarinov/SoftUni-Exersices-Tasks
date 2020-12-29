using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowball = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger value = 0;
            for (int i = 0; i < snowball; i++)
            {
                int newsnowballSnow = int.Parse(Console.ReadLine());
                int newsnowballTime = int.Parse(Console.ReadLine());
                int newsnowballQuality = int.Parse(Console.ReadLine());
                BigInteger newValue = 0;
                newValue = BigInteger.Pow((newsnowballSnow / newsnowballTime), newsnowballQuality);
                if (newValue > value)
                {
                    snowballSnow = newsnowballSnow;
                    snowballTime = newsnowballTime;
                    snowballQuality = newsnowballQuality;
                    value = newValue;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"{ snowballSnow} : { snowballTime} = {value} ({ snowballQuality})");
        }
    }
}

