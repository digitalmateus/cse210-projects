using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your Grade: "); 
        string grade = Console.ReadLine();
        string letter = "";

        if (int.Parse(grade) >= 90)
        {
            letter = "A";
        }
        else if (int.Parse(grade) >= 80)
        {
            letter = "B";
        }
        else if (int.Parse(grade) >= 70)
        {
            letter = "C";
        }
        else if (int.Parse(grade) >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine ($"Your grade is: {letter}");

        if (int.Parse(grade) >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You failed the class. Try again, don't give up!");
        }
    }
}