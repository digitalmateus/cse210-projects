using System;
namespace Goal
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        public virtual void RecordEvent()
        {
            Console.WriteLine("Event recorded for goal: " + _shortName);
        }

        public virtual bool IsComplete()
        {
            return false;
        }

        public virtual string GetDetailsString()
        {
            return $"Goal: {_shortName}, Description: {_description}, Points: {_points}";
        }

        public virtual string GetStringRepresentation()
        {
            return $"{_shortName} - {_description} - {_points}";
        }

        public string GetShortName()
        {
            return _shortName;
        }

        public int GetPoints()
        {
            return _points;
        }
    }
}