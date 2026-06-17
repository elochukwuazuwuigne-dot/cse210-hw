using System;

public abstract class Activity
{
    // Encapsulation: member variables use _underscoreCamelCase
    private string _date;
    private int _minutes;

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Properties to allow read-only access for derived classes and summary
    public string Date => _date;
    public int Minutes => _minutes;

    // Polymorphism: Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Polymorphism: Virtual method in the base class that utilizes the abstract methods
    public virtual string GetSummary()
    {
        // Formats data cleanly to match standard summary expectations
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}