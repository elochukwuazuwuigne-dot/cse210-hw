using System;

public class Swimming : Activity
{
    // Unique attribute strictly encapsulated here
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (miles) = laps * 50 meters / 1000 / 1.60934 (to miles)
        return _laps * 50 / 1000.0 * 0.621371;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return Minutes / GetDistance();
    }
}