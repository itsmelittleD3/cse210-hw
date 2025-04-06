using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;
    public abstract double GetDistance(); 

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _lengthMinutes) * 60;
    }

    public virtual double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthMinutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
