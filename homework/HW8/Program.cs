using System;

class Customer

{
    static void WelcomeCustomer(string name, string product, string city)
    {
        Console.WriteLine($"Welcome {name} from {city}! Your order for {product} has been received.");
    }

    static string GetDiscountMessage(string name)
    {
        return $"Thanks {name}! You have received a 10% discount.";
    }

    static void Main(string[] args)
    {
        WelcomeCustomer(name: "John", product: "Laptop", city: "New York");
        Console.WriteLine(GetDiscountMessage("John"));
        Console.WriteLine();

        WelcomeCustomer(name: "Alice", product: "Smartphone", city: "Los Angeles");
        Console.WriteLine(GetDiscountMessage("Alice"));
        Console.WriteLine();

        WelcomeCustomer(name: "Bob", product: "Tablet", city: "Chicago");
        Console.WriteLine(GetDiscountMessage("Bob"));
        Console.WriteLine();
    }
    }

