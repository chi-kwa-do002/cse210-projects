using System;


// EXCEEDING REQUIREMENTS:
// 1. Added a GratitudeActivity as an additional mindfulness activity.
// 2. Implemented an activity log that tracks how many times each activity was completed.
// 3. Reflection activity ensures no repeated questions until all questions have been used.
// 4. Structured program with strong encapsulation and reusable animation methods.
// 5. Clean inheritance design minimizing duplicated code.


class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity (Extra)");
            Console.WriteLine("5. Quit");
            Console.Write("\nSelect an option: ");

            choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    activity = new GratitudeActivity();
                    break;
            }

            if (activity != null)
            {
                activity.Run();
                Console.WriteLine("\nPress Enter to return to menu.");
                Console.ReadLine();
            }
        }

        Activity.DisplayLog();
        Console.WriteLine("\nThank you for using the Mindfulness Program!");
    }
}
