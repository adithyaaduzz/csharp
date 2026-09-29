using System;
public class swap
{
    public static void Main(string[] args)
    {
    Console.Write("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Sec number:");
    int b = Convert.ToInt32(Console.ReadLine());
    int temp;
    temp = a;
    a = b;
    b = temp;
    Console.WriteLine("After swapping: ");
    Console.WriteLine("First number: " + a);
    Console.WriteLine("Second number: " + b);

}
}