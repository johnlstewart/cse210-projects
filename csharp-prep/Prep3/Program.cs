// C# Prep 3—Loops
// John Stewart
// CSE 210
// 5/1/24


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.Write("What is the Magic Number? (1-100) ");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess = -1; // Any 'ol value outside of the range we can use to initialize

        while (userGuess != magicNumber)
        {
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber) // Make sure it's actually checking for a different condition!
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            }
        }
    }
}