using System;
namespace Goal
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Eternal Quest!");
            Console.WriteLine("You can create goals, record events, and track your progress.");
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine("Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        public void ListGoalNames()
        {
            Console.WriteLine("Available Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("Goal Details:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal(string type, string shortName, string description, int points, int target = 0, int bonus = 0)
        {
            Goal newGoal;
            switch (type.ToLower())
            {
                case "simple":
                    newGoal = new SimpleGoal(shortName, description, points);
                    break;
                case "eternal":
                    newGoal = new EternalGoal(shortName, description, points);
                    break;
                case "checklist":
                    newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }
            _goals.Add(newGoal);
            Console.WriteLine($"Goal '{shortName}' created successfully.");
        }

        public void RecordEvent(string shortName)
        {
            var goal = _goals.FirstOrDefault(g => g.GetShortName() == shortName);
            if (goal != null)
            {
                goal.RecordEvent();
                if (goal.IsComplete())
                {
                    _score += goal.GetPoints();
                    Console.WriteLine($"Goal '{shortName}' completed! You earned {goal.GetPoints()} points.");
                }
                else
                {
                    Console.WriteLine($"Event recorded for goal '{shortName}'.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{shortName}' not found.");
            }
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score); // Save score first
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        public void LoadGoals(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(" - ");
                    if (parts.Length < 3)
                    {
                        Console.WriteLine("Invalid goal format in file.");
                        continue;
                    }

                    string type = parts[0].ToLower();
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal goal;
                    switch (type)
                    {
                        case "simple":
                            goal = new SimpleGoal(shortName, description, points);
                            break;
                        case "eternal":
                            goal = new EternalGoal(shortName, description, points);
                            break;
                        case "checklist":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            goal = new ChecklistGoal(shortName, description, points, target, bonus);
                            break;
                        default:
                            Console.WriteLine("Unknown goal type in file.");
                            continue;
                    }
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }

        public List<string> GetGoalNames()
        {
            return _goals.Select(g => g.GetShortName()).ToList();
        }

        public void RecordEventByIndex(int index)
        {
            if (index >= 0 && index < _goals.Count)
            {
                var goal = _goals[index];
                RecordEvent(goal.GetShortName());
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }
    }
}