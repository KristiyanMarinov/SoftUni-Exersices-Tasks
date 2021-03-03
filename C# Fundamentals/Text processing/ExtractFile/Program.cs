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
            int lastindex = fileName.LastIndexOf("\\");
            int lastIndexOfExtension = fileName.LastIndexOf(".");
            string result = fileName.Substring(lastindex + 1, lastIndexOfExtension - lastindex - 1);
            string extension = fileName.Substring(lastIndexOfExtension + 1);
            Console.WriteLine($"File name: {result}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
