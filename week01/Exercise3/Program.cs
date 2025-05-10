using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int computerNumber = randomGenerator.Next(1, 51);
        int userGuess = 0;

        while (userGuess != computerNumber)
        {
            Console.Write("Enter a number between 1 and 50: ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (userGuess < computerNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (userGuess > computerNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number {computerNumber}.");
            }
        }
    }
}