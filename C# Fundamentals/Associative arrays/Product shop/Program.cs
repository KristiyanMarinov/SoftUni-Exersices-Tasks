using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count_same_values_in_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while (command!="Revision")
            {
                string[] input = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
                command = Console.ReadLine();
            }
            foreach (var item in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
