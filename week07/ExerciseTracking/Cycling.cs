using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double _speed;
        private double _distance;

        public Cycling(string date, int minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
            _distance = (_speed / 60) * GetMinutes();
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return GetMinutes() / _distance;
        }

        public override string GetSummary()
        {
            return base.GetSummary();
        }
    }
}