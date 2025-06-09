using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option (1-4): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye! Have a mindful day.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static int GetDurationFromUser()
    {
        Console.Write("Enter the duration in seconds for this activity: ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number for duration: ");
        }
        return duration;
    }

    static void RunBreathingActivity()
    {
        Console.Clear();
        int duration = GetDurationFromUser();
        BreathingActivity breathing = new BreathingActivity(duration);
        breathing.Run();
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    static void RunReflectionActivity()
    {
        Console.Clear();
        int duration = GetDurationFromUser();

        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        ReflectingActivity reflection = new ReflectingActivity(duration, prompts, questions);
        reflection.Run();
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    static void RunListingActivity()
    {
        Console.Clear();
        int duration = GetDurationFromUser();

        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        ListingActivity listing = new ListingActivity(duration, prompts);
        
        listing.DisplayStartMessage();
        listing.ShowSpinner(5);
        Console.Clear();

        listing.GetRandomPrompt();
        listing.ShowCountdown(5);
        Console.Clear();

        // Collect user input for the listing activity
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        List<string> userList = new List<string>();

        Console.WriteLine("Start listing your items! Type one item per line. Press Enter after each item.");
        Console.WriteLine("You have limited time. Go!");
        
         while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userList.Add(input);
            }
            if (DateTime.Now >= endTime)
                break;
        }

        Console.WriteLine($"You listed {userList.Count} item(s)!");
        Console.WriteLine("Items you listed:");
        foreach (string item in userList)
        {
            Console.WriteLine($"- {item}");
        }

        listing.DisplayEndMessage();
        Console.WriteLine("\n Press Enter to hide or type QUIT to end the program: ");
        Console.ReadLine();
    }
}