using System;
using System.IO;

class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            string[] emails = File.ReadAllLines("emails.txt");
            using (StreamWriter writer = new StreamWriter("valid_emails.txt"))
            {
                foreach (string email in emails)
                {
                    try
                    {
                        if (IsValidEmail(email))
                        {
                            writer.WriteLine(email);
                        }
                        else
                        {
                            throw new InvalidEmailException($"Invalid email found: {email}");
                        }
                    }
                    catch (InvalidEmailException ex)
                    {
                        Console.WriteLine(ex.Message);
                        // Continue processing remaining emails
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Email validation completed");
        }
    }

    static bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}
