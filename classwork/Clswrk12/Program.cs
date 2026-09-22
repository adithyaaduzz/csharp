using System;
using System.IO;
class program
{
    static void Main(string[]args)
    {
        Random random = new Random();
        int score = random.Next(0, 101);

        string performance;
        if(score>=0 && score<=39)
        {
            performance="fail";
        }
        else if(score>=40 && score<=59)
        {
            performance = "pass";
        }
        else if (score >= 60 && score <= 79)
        {
            performance = "good";
        }
        else
        {
            performance = "excellent";
        }

        string output=$"score: {score}- performance: {performance}";

        string filepath= "StudentPerformance.txt";
        File.WriteAllText(filepath, output);

        string filecontent = File.ReadAllText(filepath);
        Console.WriteLine("studentPerformance.txt");
        Console.WriteLine(filecontent);
    }
}