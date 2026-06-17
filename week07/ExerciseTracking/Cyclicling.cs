using System;

public class Cycling : Activity
{
    // Unique attribute strictly encapsulated here
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance (miles) = (speed * minutes) / 60
        return (_speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = 60 / speed
        return 60 / _speed;
    }
}