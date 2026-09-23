using System;
using System.IO;

 class program
{
    static void Main()
    {
        try
        {
            DateTime CurrentDate = DateTime.Now;
            DateTime Futuredate = CurrentDate.AddDays(5);

            TimeSpan Difference = Futuredate - CurrentDate;
            int DaysLeft = Difference.Days;

            string result = $"Current Date: {CurrentDate}\nFuture Date: {Futuredate}\nDays Left: {DaysLeft}";
            Console.WriteLine("Result:\n" + result);
        
         File.WriteAllText("date_result.txt", result);

        Console.WriteLine("Calculation successful! Result saved to date_result.txt");
    }
        catch (Exception ex)
        {
           
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
       

    
