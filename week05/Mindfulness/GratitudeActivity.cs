using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude Activity", "This activity helps you focus deeply on one thing you are grateful for.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nThink of one thing you are truly grateful for.");
        ShowSpinner(5);

        Console.WriteLine("\nWhy does this matter to you?");
        ShowSpinner(5);

        Console.WriteLine("\nHow would your life be different without it?");
        ShowSpinner(5);
    }
}
