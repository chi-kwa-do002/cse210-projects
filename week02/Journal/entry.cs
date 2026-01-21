using System;

public class Entry
{
    public string date;
    public string prompt;
    public string response;

    public void Display()
    {
        Console.WriteLine("Date: " + date);
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine();
    }

    public string GetFileLine()
    {
        string line = date + "|" + prompt + "|" + response;
        return line;
    }
}
