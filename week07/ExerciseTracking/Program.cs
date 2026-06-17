using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Functionality: Putting instances of different activities into the same list
        List<Activity> activities = new List<Activity>();

        // Creating instances with sample data matching assignment guidelines
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 30, 20);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        Console.WriteLine("--- Exercise Tracking Summary --- \n");

        // Iterating and printing the summary using polymorphism
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}