using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DataTypesAndViariables___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i < fileName.Length; i++)
            {
                char curr = fileName[i];
                char rename = (char)(curr + 3);
                result += rename;
            }
            Console.WriteLine(result);
        }
    }
}
