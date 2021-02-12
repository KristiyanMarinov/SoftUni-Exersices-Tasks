
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class HolidaysBetweenTwoDates
{
    static void Main(string[] args)

    {
        string[] bannedWords = Console.ReadLine().Split(", ");
        string text = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            string replace = new string('*', word.Length);
            text = text.Replace(word, replace);
        }
        Console.WriteLine(text);
    }
}
