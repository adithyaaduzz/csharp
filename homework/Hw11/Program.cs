using System;
class Book
{
    private int copies;
    public string Title { get; set; }
    public string Author { get; set; }

    public int Copies
    {
        get { return copies; }
        set
        {
            if (value > 0)
            {
                copies = value;
            }
            else
            {
                Console.WriteLine("No.Of Copies must be positive");
            }
        }
    } }

        class program
    {
        static void Main(string[]args)
        {
            Book book1 = new Book();
            book1.Title = "The Great Gatsby";
            book1.Author = "F. Scott Fitzgerald";
            book1.Copies = -5;

        Console.WriteLine($"Title: {book1.Title}, Author: {book1.Author}, Copies: {book1.Copies}");

    }
    }
    
     


