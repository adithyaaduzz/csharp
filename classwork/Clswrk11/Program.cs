using System;
class Employee
{
    private double salary;
    public string Name { get; set; }
    public int ID { get; set; }

    public double Salary
    {
        get { return salary; }
        
            set{
                if (value > 0)
                {
                salary = value;
            }
            else
            {
                Console.WriteLine("Negative salary is not allowed.");
            }
               
            }
        }
    }
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Name = "John Doe";
        emp.ID = 12345;
        emp.Salary = 50000; 
        Console.WriteLine($"Employee Name: {emp.Name}, ID: {emp.ID}, Salary: {emp.Salary}");
       
    }

}

