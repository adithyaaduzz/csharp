using System;
using System.IO;

class GroceryBillCalculator
{
    static void Main()
    {
        try
        {
            
            Console.WriteLine("Enter the price of item 1:");
            double item1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the price of item 2:");
            double item2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the price of item 3:");
            double item3 = Convert.ToDouble(Console.ReadLine());

            
            double total = item1 + item2 + item3;

           
            double tax = total * 0.18;
            double finalAmount = total + tax;

            
            double roundedAmount = Math.Round(finalAmount);

            
            string bill = $"Date: {DateTime.Now}\nFinal Amount: {roundedAmount}";
            File.WriteAllText("grocery_bill.txt", bill);

            Console.WriteLine("Bill calculated successfully!");
            Console.WriteLine(bill);
        }
        catch (FormatException)
        {
            Console.WriteLine(" Error: Please enter numeric values only for item prices.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(" An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine(" Program finished. Thank you for shopping!");
        }
    }
}

