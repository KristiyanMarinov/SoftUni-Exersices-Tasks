using System;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            FirstHalf(n);
            SecondHalf(n);

            static void FirstHalf(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }

            static void SecondHalf(int n)
            {
                for (int i = n - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

