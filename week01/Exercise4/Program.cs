using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.Write("---");

        List<int> numbers = new List<int>();

        Console.Write("Enter a number (zero to quit) :");

        int userInput = int.Parse(Console.ReadLine());
        int totalSum = 0;
        int count = 0;
        int average = 0;
        int largest = 0;

        while (userInput != 0)
        {
            numbers.Add(userInput);
            totalSum += userInput; // same as totalSum = totalSum + userInput;
            count++;
            if (userInput > largest)
            {
                largest = userInput;
            }
            Console.Write("Enter a number (zero to quit) :");
            userInput = int.Parse(Console.ReadLine());
        }

        if (count > 0)
        {
            average = totalSum / count;
            Console.WriteLine($"You entered {count} numbers.");
            Console.WriteLine($"Total Sum of numbers: {totalSum}");
            Console.WriteLine($"Average of numbers: {average}");
            Console.WriteLine($"Largest number entered: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}