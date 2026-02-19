using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": Save(); break;
                case "5": Load(); break;
            }
        }
    }

    static void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nScore: {score} points");
        Console.WriteLine($"Level: {GetLevel()} - {GetTitle()}");
    }

    static int GetLevel() => score / 1000 + 1;

    static string GetTitle()
    {
        int level = GetLevel();
        if (level < 3) return "Beginner Disciple";
        if (level < 5) return "Faithful Warrior";
        if (level < 10) return "Spiritual Champion";
        return "Legendary Saint";
    }

    static void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2")
            goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetName()}");
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = goals[index].RecordEvent();
        score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    static void Save()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (Goal g in goals)
                writer.WriteLine(g.GetSaveString());
        }
    }

    static void Load()
    {
        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "Simple")
                goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "Eternal")
                goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "Checklist")
                goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[4]), int.Parse(parts[5])));
        }
    }
}
