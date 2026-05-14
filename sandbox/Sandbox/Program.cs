using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("This is in C#.");

        Console.WriteLine("What is your favorite color?  ");
        string color = Console.ReadLine();
        Console.WriteLine("Your favorite color is: " + color);
        Console.Write(color);
        Console.WriteLine($"{color} Wow that's a nice color!"); // String interpolation')

    }
}