using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList brands = new ArrayList();

        Console.WriteLine("Enter no.of brands(MAx 10):");
        int number=Convert.ToInt32(Console.ReadLine());

        if (number > 10)
        {
            Console.WriteLine("Maximum 10 brands allowed.");
            return;
        }

        for (int i=0;i<number;i++)
        {
            Console.WriteLine("Enter brand name:");
            string brand = Console.ReadLine();

            if(brand=="")
            {
                Console.WriteLine("Brand name cannot be empty");
                i--;
                continue;
            }
            brands.Add(brand);

            Console.WriteLine("Enter brand to search:");
            string searchBrand = Console.ReadLine();
             
            bool found = false;
             
            foreach(string b in brands)
            {
                if (b.Equals(searchBrand, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Available");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Brand not found.");
            }
        }


    }
}