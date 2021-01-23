using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class HolidaysBetweenTwoDates
{
    static void Main()
    {

        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

        keyMaterials["shards"] = 0;
        keyMaterials["fragments"] = 0;
        keyMaterials["motes"] = 0;
        bool isTrue = true; ;



        while (isTrue)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i += 2)
            {
                int count = int.Parse(input[i]);
                string material = input[i + 1].ToLower();

                if (material == "shards" || material == "fragments" || material == "motes")
                {
                    keyMaterials[material] += count;
                    if (keyMaterials[material] >= 250)
                    {
                        isTrue = false;
                        break;
                    }
                }
                else if (junkMaterials.ContainsKey(material))
                {
                    junkMaterials[material] += count;
                }
                else if (!junkMaterials.ContainsKey(material))
                {
                    junkMaterials.Add(material, count);
                }
            }

        }


        if (keyMaterials["shards"] >= 250)
        {
            keyMaterials["shards"] -= 250;
            Console.WriteLine("Shadowmourne obtained!");
        }
        else if (keyMaterials["fragments"] >= 250)
        {
            keyMaterials["fragments"] -= 250;
            Console.WriteLine("Valanyr obtained!");
        }
        else if (keyMaterials["motes"] >= 250)
        {
            keyMaterials["motes"] -= 250;
            Console.WriteLine("Dragonwrath obtained!");
        }

        keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        Dictionary<string, int> my = junkMaterials.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        foreach (var item in keyMaterials)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in my)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}