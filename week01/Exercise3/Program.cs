using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "";
        int userGuess = -1;
        do
        {
            int randomNumber = randomGenerator.Next(1, 101); 
            userGuess = -1;
            
            while (userGuess != randomNumber)
            {
                Console.Write("Guess a number between 1 and 100: ");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the number!");
                }
            }
            Console.Write("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();
        }while (playAgain == "yes");
        
        if (playAgain != "yes")
        {
            Console.WriteLine("Goodbye! Thank you for playing");
        }

    }
}