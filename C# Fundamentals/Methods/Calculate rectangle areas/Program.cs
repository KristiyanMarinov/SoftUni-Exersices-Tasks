using System;
using System.Runtime.InteropServices.ComTypes;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Area(n1, n2));

            static int Area(int n1, int n2)
            {
                int area = n1 * n2;
                return area;
            }
        }
    }
}

