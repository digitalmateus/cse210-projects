using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        // create the scripture
        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world that he gave his one and only Son";
        Scripture scripture = new Scripture(reference, verseText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText()); // show current state of scripture
            Console.WriteLine("\n Press Enter`to hide or type QUIT to end the program: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Press any key to exit.");
        Console.ReadKey();
    }
}