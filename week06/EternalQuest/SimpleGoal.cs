using System;
namespace Goal
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine("Event recorded for simple goal: " + GetShortName());
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            string status = _isComplete ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} - {GetDetailsString()}";
        }
    }
}