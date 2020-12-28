using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double totalCost = 0.0;
            int sixBelts = studentsNumber / 6;
            double zakryg = Math.Ceiling(studentsNumber * 1.1);
            totalCost = priceLightsabers * zakryg + priceBelts * (studentsNumber - sixBelts) + priceRobe * studentsNumber;

            if (totalCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money - totalCost):f2}lv more.");
            }

        }
    }
}
