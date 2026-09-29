using System;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class program
{
    static void Main()
    {
        Student[] person =new Student[]
            {
                new Student { Id = 1, Name = "Rajesh" },
                new Student { Id = 2, Name = "Rahul" },
                new Student { Id = 3, Name = "Sruthi" }
         };
        Console.Write("Enter student ID:");
        int InputId = Convert.ToInt32(Console.ReadLine());

        Student students = null;
        foreach (var p in person)
        {
            if (p.Id == InputId)
            {
                students = p;
                break;
            }
        }
        if (students != null)
        {
            Console.WriteLine("Student Name: " + students.Name);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}











