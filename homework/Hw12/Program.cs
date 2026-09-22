using System;
using System.IO;
namespace productReview
{
    enum Ratingcategory
    {
        Poor = 1,
        Average = 2,
        Good = 3,
        VeryGood = 4,
        Excellent = 5
    }
    class program
    {
        static void Main(string[] args)
        {
            string[] Products = { "Phone", "Laptop", "Tablet", "Smartwatch", "Headphones" };
            Random random = new Random();

            string filepath = "product_reviews.txt";
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            string allReviews = "";
            foreach (string product in Products)
            {
                int ratingNumber = random.Next(1, 6); 
                Ratingcategory category = (Ratingcategory)ratingNumber;
                allReviews += $"Product: {product}, Rating: {ratingNumber}, Category: {category}{Environment.NewLine}";
            }
            File.WriteAllText(filepath, allReviews);

            Console.WriteLine("Contents of ProductReviews.txt:\n");
            Console.WriteLine(File.ReadAllText(filepath));

        }
    }
}
