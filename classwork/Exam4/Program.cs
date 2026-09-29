using System;
class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        return a / b;
    }
}

class Program
{
    static void Main()
    {

        Calculator calc = new Calculator();

        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Addition: " + calc.Add(num1, num2));
        Console.WriteLine("Subtraction: " + calc.Subtract(num1, num2));
        Console.WriteLine("Multiplication: " + calc.Multiply(num1, num2));
        Console.WriteLine("Division: " + calc.Divide(num1, num2));
    }
}
