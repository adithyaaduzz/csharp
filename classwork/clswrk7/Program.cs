
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> GroceryItems = new List<string>(){};
        Console.WriteLine("Enter the grocery items you want to add to the list (type 'done' when finished):");

        while (true)
        {
            string Item = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(Item))
            {
                continue;

            }
            if (Item.ToLower() == "done")
            {
                break;

            }
                    GroceryItems.Add(Item);
                }
                Console.WriteLine("Enter the grocery items to be removed");
                string RemovedItem = Console.ReadLine().Trim();

                if(GroceryItems.Contains(RemovedItem))
                {
                    GroceryItems.Remove(RemovedItem);
                    Console.WriteLine($"Removed {RemovedItem} from the list.");
                }
                else
                {
                    Console.WriteLine($"{RemovedItem} is not in the list.");
                } 
                Console.WriteLine("Remaining grocery Items:");
                foreach (string item in GroceryItems)
                {
                    Console.WriteLine($"- {item}");
                } 
            }

        }

    