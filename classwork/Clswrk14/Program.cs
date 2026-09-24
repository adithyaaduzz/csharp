using System;

using System.Threading;
class program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
    static void PrintLetters()
    {
        for (char j = 'A'; j <= 'E'; j++)
        {
            Console.WriteLine(j);
            Thread.Sleep(1000);
        }
    }
    static void Main()
    {
        try
        {
            Thread Num = new Thread(PrintNumbers);
            Thread Letter = new Thread(PrintLetters);
            Num.Start();
            Letter.Start();

            Num.Join();
            Letter.Join();

        }
    catch(Exception Ex)
    {
            Console.WriteLine("An error occurred: " + Ex.Message);
        }finally{
            Console.WriteLine("Execution completed.");

        }
    }

}

