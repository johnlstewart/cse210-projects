// C# Prep 5—Functions
// John Stewart
// CSE 210
// 5/1/24

using System;

class Program
{
    static void Main(string[] args)
    { // Take note that the 'Main' function starts here and has an ending point just like Python
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    } // Take note that the 'Main' function does not encapsulate everything, just what's going to execute

    static void DisplayWelcome() // This function is void because there's no 'return' value
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() // Note that a string is bring returned here
    {
        Console.WriteLine("What is your Username?");
        return Console.ReadLine(); // Just like Python, I can return whatever I like. Doesn't have to be a variable
    }

    static int PromptUserNumber() // The return is an integer, so it must be defined at the beginning
    {
        Console.WriteLine("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number) // I want an int, but there's a double baked into the 'Math' class
    {
        return (int)Math.Pow(number, 2); // That Math.Pow is naturally a double, the (int) type casts it back
    }

    static void DisplayResult(string userName, int square) // No return statement = 'void' function
    {
        Console.WriteLine($"{userName}, the square of your number is {square}"); // $ = f-string
    }
}
