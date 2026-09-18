using System;
using System.Runtime.ConstrainedExecution;

class Vehicle
{
    public string brand { get; set; }

    public Vehicle()
        {
        brand= "unknown";
    }
    public virtual string GetDetails()
    {
        return "Brand: " + brand;
    }

}
class car : Vehicle
{
    public string model { get; set; }
    public car(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }
    public override string GetDetails()
    {
        return "Car Brand: " + brand + ", Model: " + model;
    }
}
class Truck : Vehicle
{
    public double LoadCapacity { get; set; }

    // Constructor
    public Truck(string brand, double loadCapacity)
    {
        this.brand = brand;
        this.LoadCapacity = loadCapacity;
    }

    // Override method
    public override string GetDetails()
    {
        return "Truck Brand: " + brand +
               ", Load Capacity: " + LoadCapacity + " tons";
    }
}
class Program
{
    static void Main(string[] args)
    {
        car car = new car("Toyota", "Corolla");

        Truck truck = new Truck("Volvo", 15.5);

        Console.WriteLine(car.GetDetails());
        Console.WriteLine(truck.GetDetails());
    }
}




