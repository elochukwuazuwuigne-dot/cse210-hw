using System;

public class Running : Activity
{
    // Unique attribute strictly encapsulated here
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Overriding abstract base methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return Minutes / _distance;
    }
}