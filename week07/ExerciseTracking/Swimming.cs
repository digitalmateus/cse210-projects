using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps;
        private const double LapLengthMeters = 50;

        public Swimming(string date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
        
            return (_laps * LapLengthMeters) / 1000.0;
        }

        public override double GetSpeed()
        {
            return GetDistance() / GetMinutes() * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistance();
        }

        public override string GetSummary()
        {
            return base.GetSummary();
        }
    }
}
