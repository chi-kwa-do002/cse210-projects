using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What made me smile today?");

        bool quitProgram = false;

        while (quitProgram == false)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string userChoice = Console.ReadLine();
            Console.WriteLine();

            if (userChoice == "1")
            {
                Random random = new Random();
                int index = random.Next(prompts.Count);
                string selectedPrompt = prompts[index];

                Console.WriteLine(selectedPrompt);
                Console.Write("> ");
                string userResponse = Console.ReadLine();

                Entry entry = new Entry();
                entry.date = DateTime.Now.ToShortDateString();
                entry.prompt = selectedPrompt;
                entry.response = userResponse;

                myJournal.AddEntry(entry);
            }
            else if (userChoice == "2")
            {
                myJournal.DisplayJournal();
            }
            else if (userChoice == "3")
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine();
                myJournal.SaveJournal(fileName);
                Console.WriteLine("Journal saved.\n");
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter file name: ");
                string fileName = Console.ReadLine();
                myJournal.LoadJournal(fileName);
                Console.WriteLine("Journal loaded.\n");
            }
            else if (userChoice == "5")
            {
                quitProgram = true;
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}
