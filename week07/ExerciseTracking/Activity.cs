using System;

public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} - {GetType().Name}: {_minutes} minutes";
    }

    public virtual string GetTypeName()
    {
        return GetType().Name;
    }

    public virtual string GetDistanceString()
    {
        return "0.0 km";
    }

    public virtual string GetSpeedString()
    {
        return "0.0 km/h";
    }

    public virtual string GetPaceString()
    {
        return "0:00 min/km";
    }

    public virtual string GetSummaryString()
    {
        return $"{GetDate()} {GetTypeName()} ({GetMinutes()} min): " +
            $"Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}