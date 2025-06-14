using System;
using Goal; 

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEternal Quest Menu:");
                Console.WriteLine("1. Display Player Info");
                Console.WriteLine("2. List Goal Names");
                Console.WriteLine("3. List Goal Details");
                Console.WriteLine("4. Create New Goal");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Save Goals");
                Console.WriteLine("7. Load Goals");
                Console.WriteLine("8. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.DisplayPlayerInfo();
                        break;
                    case "2":
                        manager.ListGoalNames();
                        break;
                    case "3":
                        manager.ListGoalDetails();
                        break;
                    case "4":
                        Console.Write("Enter goal type (simple, eternal, checklist): ");
                        string type = Console.ReadLine();
                        Console.Write("Enter short name: ");
                        string shortName = Console.ReadLine();
                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());

                        if (type.ToLower() == "checklist")
                        {
                            Console.Write("Enter target count: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Enter bonus points: ");
                            int bonus = int.Parse(Console.ReadLine());
                            manager.CreateGoal(type, shortName, description, points, target, bonus);
                        }
                        else
                        {
                            manager.CreateGoal(type, shortName, description, points);
                        }
                        break;
                    case "5":
                         var goalNames = manager.GetGoalNames(); // Implement this in GoalManager
                        if (goalNames.Count == 0)
                        {
                            Console.WriteLine("No goals to record.");
                            break;
                        }
                        Console.WriteLine("Select a goal to record:");
                        for (int i = 0; i < goalNames.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {goalNames[i]}");
                        }
                        Console.Write("Enter the number of the goal: ");
                        if (int.TryParse(Console.ReadLine(), out int goalNumber) &&
                            goalNumber >= 1 && goalNumber <= goalNames.Count)
                        {
                            manager.RecordEventByIndex(goalNumber - 1); // Implement this in GoalManager
                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        break;
                    case "6":
                        Console.Write("Enter filename to save: ");
                        string saveFile = Console.ReadLine();
                        manager.SaveGoals(saveFile);
                        Console.WriteLine("Goals saved.");
                        break;
                    case "7":
                        Console.Write("Enter filename to load: ");
                        string loadFile = Console.ReadLine();
                        manager.LoadGoals(loadFile);
                        break;
                    case "8":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using Eternal Quest!");
    }
}