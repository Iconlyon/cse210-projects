using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you stood up for someone."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "Would you do it again?"
    };

    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "Reflect on times when you have shown strength and resilience."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}