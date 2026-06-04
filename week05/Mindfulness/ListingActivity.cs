using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you are grateful for:",
        "List your strengths:",
        "List things that make you happy:",
        "List people you helped recently:"
    };

    public ListingActivity()
        : base("Listing Activity",
        "This activity helps you list positive things in your life.")
    {
    }

    public void Run()
    {
        Start();

        int duration = GetDuration();
        Random random = new Random();

        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("You may begin...");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items.");

        End();
    }
}