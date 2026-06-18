using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Jan 2025", 10, 6.8));
        activities.Add(new Cycling("04 Jan 2025", 35, 10.0));
        activities.Add(new Swimming("05 Jan 2025", 20, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}