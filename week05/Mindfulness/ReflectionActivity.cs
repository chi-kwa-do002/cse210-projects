using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?"
    };

    private List<string> _unusedQuestions;
    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity helps you reflect on times you showed strength and resilience.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("\n" + _prompts[_random.Next(_prompts.Count)]);
        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        _unusedQuestions = new List<string>(_questions);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (_unusedQuestions.Count == 0)
                _unusedQuestions = new List<string>(_questions);

            int index = _random.Next(_unusedQuestions.Count);
            string question = _unusedQuestions[index];
            _unusedQuestions.RemoveAt(index);

            Console.WriteLine($"\n> {question}");
            ShowSpinner(4);
        }
    }
}
