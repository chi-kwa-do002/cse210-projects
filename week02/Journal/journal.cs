using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            for (int i = 0; i < entries.Count; i++)
            {
                entries[i].Display();
            }
        }
    }

    public void SaveJournal(string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        for (int i = 0; i < entries.Count; i++)
        {
            writer.WriteLine(entries[i].GetFileLine());
        }

        writer.Close();
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');

            Entry entry = new Entry();
            entry.date = parts[0];
            entry.prompt = parts[1];
            entry.response = parts[2];

            entries.Add(entry);
        }
    }
}
