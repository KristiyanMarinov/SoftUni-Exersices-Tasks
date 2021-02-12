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
        string word = Console.ReadLine();
        string newWord = Console.ReadLine();
        int index = newWord.IndexOf(word);
        while (index != -1)
        {

            newWord = newWord.Remove(index, word.Length);
            index = newWord.IndexOf(word);
        }

        Console.WriteLine(newWord);
    }
}
