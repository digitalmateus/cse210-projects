using System;
namespace Goal
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        // public override void RecordEvent()
        // {
        //     _amountCompleted++;
        //     Console.WriteLine("Event recorded for checklist goal: " + GetShortName());
        // }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"{base.GetDetailsString()}, Amount Completed: {_amountCompleted}, Target: {_target}, Bonus: {_bonus}";
        }

        public override string GetStringRepresentation()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} - {GetDetailsString()} (Completed: {_amountCompleted}/{_target})";
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            if (IsComplete())
            {
                Console.WriteLine($"Goal '{GetShortName()}' completed! You earned {GetPoints()} points and a bonus of {_bonus}!");
            }
            else
            {
                Console.WriteLine($"Event recorded for checklist goal: {GetShortName()}. You earned {GetPoints()} points.");
            }
        }
    }
}