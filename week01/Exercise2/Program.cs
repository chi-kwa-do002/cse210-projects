using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you score? ");
        int scoreInput = int.Parse(Console.ReadLine());
        string letter = "";
        if (scoreInput >= 93)
        {
            letter = "A";
        }
        else if (scoreInput >= 90)
        {
            letter = "A-";
        }
        else if (scoreInput >= 87)
        {
            letter = "B+";
        }
        else if (scoreInput >= 83)
        {
            letter = "B";
        }
        else if (scoreInput >= 80)
        {
            letter = "B-";
        }
        else if (scoreInput >= 77)
        {
            letter = "C+";
        }
        else if (scoreInput >= 73)
        {
            letter = "C";
        }
        else if (scoreInput >= 70)
        {
            letter = "C-";
        }
        else if (scoreInput >= 67)
        {
            letter = "D+";
        }
        else if (scoreInput >= 63)
        {
            letter = "D";
        }
        else if (scoreInput >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}.");
        
        if (letter == "A" || letter == "B" || letter == "C" || letter == "D")
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}