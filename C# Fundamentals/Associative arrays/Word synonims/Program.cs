using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> adj = new Dictionary<string, List<string>>();

        for (int i = 1; i <= n; i++)
        {
            string word = Console.ReadLine();
            string adjective = Console.ReadLine();

            if (adj.ContainsKey(word))
            {
                adj[word].Add(adjective);
            }
            else
            {
                adj.Add(word, new List<string>() { adjective });
            }
        }
        foreach (var word in adj)
        {
            Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
        }

    }
}