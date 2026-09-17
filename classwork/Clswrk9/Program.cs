using System;
class product
{
    string ProductName;
    double Price;
    int Quantity;

    public product(string productName, double price, int quantity)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return Price * Quantity;
    }
    public string GetName()
    {
        return ProductName;
    }
}
class Program
{
    static void Main(string[] args)
    {
        product product1 = new product("Laptop", 1000.00, 2);
        product product2 = new product("Smartphone", 500.00, 3);
        Console.WriteLine($"Product: {product1.GetName()}, Total Price: {product1.GetTotalPrice()}");
        Console.WriteLine($"Product: {product2.GetName()}, Total Price: {product2.GetTotalPrice()}");
    }
}
