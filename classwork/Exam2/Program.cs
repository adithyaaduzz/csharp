using System;
class PatternProgram
{
    public static void Main()
    {
        int N = 3;
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}