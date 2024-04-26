// C# Prep 2—Conditionals
// John Stewart
// CSE 210
// 4/26/2024

// Teacher / Grader Note:
// I've included the A and F exceptions because I wanted to be thorough with my understanding.

using System;

class Program
{
    static void Main(string[] args)
    {
        // You must display the prompt first before working with the input
        Console.Write("What percent grade did you get? ");
        // Converted integer = input string, run through the 'read line' method, then 'parsed' (interpreted) as an integer.
        int percentage = int.Parse(Console.ReadLine());

        // We're going to use a variable (called 'letter'), which is initially will be a blank space
        // The reason that you can't have warnings/errors with 'uninitialized variables' and a blank space is a valid character
        char letter = ' ';
        // Double Quotes "" are for strings, while single quotes are for individual characters ''
        // Can have nothing in there because the modifier isn't there by default and aids in concatenation
        string modifier = "";

        // Letter Scores

        // The condition of if statements are always in parentheses, the 'body' of it is between curly braces
        if (percentage >= 90) // NO Colons for C# blocks
        {
            letter = 'A';
        }
        else if (percentage >= 80)
        {
            letter = 'B';
        }
        else if (percentage >= 70)
        {
            letter = 'C';
        }
        else if (percentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Determining modifiers

        // Declare the variables you'll be working with
        int plusMinus = percentage % 10;

        // Now do the logic

        // As long as the letter isn't an F, proceed
        if (letter != 'F')
        {
            if (plusMinus >= 7)
            {
                modifier = "+";
            }
            else if (plusMinus <= 3)
            {
                modifier = "-";
            }
        }

        // Exceptions for A and F Grades:
        if (percentage >= 93)
        {
            modifier = "";
        }
        if (letter == 'F')
        {
            modifier = "";
        }

        // Output the results
        Console.WriteLine($"Your grade is: {letter}{modifier}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course!");
        }
        else
        {
            Console.WriteLine("Good practice for next time...");
        }
    }
}