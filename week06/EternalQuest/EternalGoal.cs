using System;
namespace Goal
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        public override void RecordEvent()
        {
            Console.WriteLine("Event recorded for eternal goal: " + GetShortName());
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"[ ] {GetShortName()} - {GetDetailsString()}";
        }
    }
}