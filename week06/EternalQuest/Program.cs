using System;

// I added a simple level system. The user levels up every 1000 points.
// This adds a gamification feature beyond the core requirements.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}