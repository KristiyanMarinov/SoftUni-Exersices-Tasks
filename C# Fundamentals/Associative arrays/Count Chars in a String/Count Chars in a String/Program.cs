using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

class HolidaysBetweenTwoDates
{
    static void Main()
    {

        char[] text = Console.ReadLine().ToCharArray();
        Dictionary<char, int> chars = new Dictionary<char, int>();

        foreach (var symbol in text)
        {
            if (symbol != ' ')
            {
                if (chars.ContainsKey(symbol))
                {
                    chars[symbol] += 1;
                }
                else
                {
                    chars.Add(symbol, 1);
                }
            }

        }
        foreach (var pair in chars)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}