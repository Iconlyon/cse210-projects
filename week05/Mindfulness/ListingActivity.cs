using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "List as many positive things as you can."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        Console.Write("\nBegin in: ");
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");

        DisplayEndingMessage();
    }
}