using System;

namespace RageExpensise
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    headsetCount += 1;
                }
                if (i % 3 == 0)
                {
                    mouseCount += 1;
                }
                if (i % 6 == 0)
                {
                    keyboardCount += 1;
                }
                if (i % 12 == 0)
                {
                    displayCount += 1;
                }
            }
            double expenses = headsetCount * headset + mouseCount * mouse +
                keyboardCount * keyboard + displayCount * display;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}

