using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2026, 02, 16), 30, 3.0),
            new Cycling(new DateTime(2026, 02, 17), 45, 15.0),
            new Swimming(new DateTime(2026, 02, 18), 40, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
