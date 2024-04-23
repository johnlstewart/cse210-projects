// C# Prep 1—Variables and Input/Output
// John Stewart
// CSE 210
// 4/23/2024

// I've preserved the code already on the screen in this "Program.cs" file, just in case it's important, even if it's ok to go without it. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }

    
}
