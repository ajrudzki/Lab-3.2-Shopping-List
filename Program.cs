using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lab_3._2_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cart = new ArrayList();
            ArrayList cost = new ArrayList();
            Dictionary<string, double> items = new Dictionary<string, double>();
            items["Apple"] = 0.99;
            items["Banana"] = 0.59;
            items["Cauliflower"] = 1.59;
            items["Dragonfruit"] = 2.19;
            items["Elderberry"] = 1.79;
            items["Figs"] = 2.09;
            items["Grapefruit"] = 1.99;
            items["Honeydew"] = 3.49;

            bool running = true;
            while (running)
            {

                Console.WriteLine($"Welcome to Guenther's Market!\n");
                Console.WriteLine($"{"Item",-20}{"Price",-20}");
                Console.WriteLine($"==============================");
                foreach (KeyValuePair<string, double> item in items)
                {
                    Console.WriteLine($"{item.Key,-20}${item.Value,-20}");
                }

                Console.WriteLine();
                Console.Write($"What item would you like to order?: ");
                string entry = Console.ReadLine();
                while (!items.ContainsKey(entry))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Sorry, we don't have those. Please try again.");
                    Console.WriteLine();
                    Console.Write($"What item would you like to order?: ");
                    entry = Console.ReadLine();
                }
                cart.Add(entry);
                cost.Add(items[entry]);
                Console.WriteLine();
                Console.WriteLine($"{entry} has been added to your order at ${items[entry]}");
                
                Console.WriteLine();
                Console.WriteLine($"Would you like to order anything else? (y/n): ");
                string cont = Console.ReadLine();
                if (cont == "yes" || cont == "Yes" || cont == "y" || cont == "Y")
                {
                    running = true;
                    {
                        Console.Clear();
                    }
                }
                else if (cont == "no" || cont == "No" || cont == "n" || cont == "N")
                {
                    running = false;
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Thanks for your order!");
                        Console.WriteLine($"Here's what you got:");

                        //for loop with arrays cart.Count

                        double sum = 0;

                        for (int index = 0; index<cart.Count; index++)
                        {
                            Console.WriteLine($"{cart[index],-20}${cost[index],-20}");
                            sum = sum + (double)cost[index];
                        }

                        sum /= cost.Count;
                        
                        Console.WriteLine($"Average price per item in order was: ${sum:N2}");
                        Console.WriteLine($"Press any key to continue . . .");

                    }
                }
            }
        }
    }
}
