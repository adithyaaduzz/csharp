using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList books = new ArrayList();

        Console.Write("Enter number of books returned (maximum 8): ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 8)
        {
            Console.WriteLine("Maximum 8 books allowed.");
            return;
        }

        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            if (title == "")
            {
                Console.WriteLine("Title cannot be blank.");
                continue;
            }

            Console.Write("Enter author name: ");
            string author = Console.ReadLine();

            
            var book = Tuple.Create(title, author);

           
            books.Add(book);
        }

        Console.WriteLine("\nReturned Books:");

        foreach (var book in books)
        {
            var b = (Tuple<string, string>)book;

            Console.WriteLine("Title: " + b.Item1);
            Console.WriteLine("Author: " + b.Item2);
            Console.WriteLine();
        }

        Console.Write("Enter title to search: ");
        string searchTitle = Console.ReadLine();

        bool found = false;

        foreach (var book in books)
        {
            var b = (Tuple<string, string>)book;

            
            if (b.Item1.ToLower() == searchTitle.ToLower())
            {
                Console.WriteLine("\nBook found!");
                Console.WriteLine("Title: " + b.Item1);
                Console.WriteLine("Author: " + b.Item2);

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not returned today");
        }
    }
}