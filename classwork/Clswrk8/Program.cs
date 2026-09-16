using System;
class Student
{
    static void IntroduceStudent(string name, string course, string city)
    {
        Console.WriteLine($"Name: {name}, Course: {course}, City: {city}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO STUDENT INTRODUCTION PROGRAM");
        IntroduceStudent(name: "Mariya", course: "Computer Science", city: "TVM");
        IntroduceStudent(name: "Rohit", course: "Mathematics", city: "Kottayam");
    }
}