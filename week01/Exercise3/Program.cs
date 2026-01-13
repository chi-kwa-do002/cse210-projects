using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.Write("Guess the magic number (between 1 and 100): ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the magic number!");
            }
        }
    }
}