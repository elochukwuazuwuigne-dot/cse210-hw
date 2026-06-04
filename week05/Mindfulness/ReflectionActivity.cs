using System;
using System.Collections.Generic;
using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you showed strength.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What would you do differently?",
        "Why does this matter to you?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity helps you reflect on moments of strength.")
    {
    }

    public void Run()
    {
        Start();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        Console.WriteLine("Think about it...");
        ShowSpinner(3);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[_random.Next(_questions.Count)]);
            ShowSpinner(4);
        }

        End();
    }
}