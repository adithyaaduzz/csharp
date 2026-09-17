using System;
class Vehicle
{
   public string Brand;
    public string Model;

    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
    class car : Vehicle
    {
        public double dailyRentalPrice;
        public car(string brand, string model, double price) : base(brand, model)
        {
            dailyRentalPrice = price;
        }
    }
    class sedan : car
    {
        public int seats;
        public sedan(string brand, string model, double price, int seats) : base(brand, model, price)
        {
            this.seats = seats;
        }
        public double CalculateRental(int days)
        {
            return dailyRentalPrice * days;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            sedan sedan1 = new sedan("Toyota", "Camry", 2000, 5);
            sedan sedan2 = new sedan("Honda", "City", 1500, 5);

            Console.WriteLine("Brand: " + sedan1.Brand);
            Console.WriteLine("Model: " + sedan1.Model);
            Console.WriteLine("Seats: " + sedan1.seats);
            Console.WriteLine("Total Rental Cost: " + sedan1.CalculateRental(5));

            Console.WriteLine();

            Console.WriteLine("Brand: " + sedan2.Brand);
            Console.WriteLine("Model: " + sedan2.Model);
            Console.WriteLine("Seats: " + sedan2.seats);
            Console.WriteLine("Total Rental Cost: " + sedan2.CalculateRental(5));
        }
    }

}