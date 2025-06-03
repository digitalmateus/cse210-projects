using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Alice", "Fractions", "7.3", "3-10, 20-21");
        Console.WriteLine(assignment.GetSummary());        
        Console.WriteLine(assignment.GetHomework());
    }
}