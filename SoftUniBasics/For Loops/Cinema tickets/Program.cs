using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;



namespace Exercise

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Dictionary<string, List<int>> massages = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();

            while (command!= "Statistics")
            {
                string[] tokens = command.Split("=");
                string currCommand = tokens[0];
                switch (currCommand)
                {
                    case "Add":
                        string username = tokens[1];
                        int sent = int.Parse(tokens[2]);
                        int received = int.Parse(tokens[3]);
                        if (!massages.ContainsKey(username))
                        {
                            massages.Add(username, new List<int> { sent, received });
                        }
                        break;
                    case "Message":
                        string sender = tokens[1];
                        string receiver = tokens[2];
                        
                        if (massages.ContainsKey(sender)&& massages.ContainsKey(receiver))
                        {
                            massages[sender][0] += 1;
                            massages[receiver][1] += 1;
                            if (massages[sender].Sum()>=n)
                            {
                                string key = "";
                                foreach (var item in massages)
                                {
                                    if (item.Key==sender)
                                    {
                                        key = item.Key;
                                    }
                                }
                                massages.Remove(sender);
                                Console.WriteLine($"{key} reached the capacity!");
                            }
                            if (massages[receiver].Sum()>=n)
                            {
                                string keyReceiver = "";
                                foreach (var item in massages)
                                {
                                    if (item.Key == receiver)
                                    {
                                        keyReceiver = item.Key;
                                    }
                                }
                                massages.Remove(receiver);
                                Console.WriteLine($"{keyReceiver} reached the capacity!");
                            }
                        }
                        break;
                    case "Empty":
                        string user = tokens[1];
                        
                        if (user!="All")
                        {
                            massages[user].Clear();
                        }
                        else
                        {
                            massages.Clear();
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {massages.Count}");
            foreach (var item in massages.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Sum()}");
            }
        }
    }
}


