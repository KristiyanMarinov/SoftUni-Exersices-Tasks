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
            string product = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    Coffee(count);
                    break;
                case "water":
                    Water(count);
                    break;
                case "coke":
                    Coke(count);
                    break;
                case "snacks":
                    Snacks(count);
                    break;

                    static void Coffee(double count)
                    {
                        double n = count * 1.5;
                        Console.WriteLine("{0:f2}", n);
                    }
                    static void Water(double count)
                    {
                        double n = count * 1.0;
                        Console.WriteLine("{0:f2}", n);
                    }
                    static void Coke(double count)
                    {
                        double n = count * 1.4;
                        Console.WriteLine("{0:f2}", n);
                    }
                    static void Snacks(double count)
                    {
                        double n = count * 2.0;
                        Console.WriteLine("{0:f2}", n);
                    }
            }
        }
    }
}

