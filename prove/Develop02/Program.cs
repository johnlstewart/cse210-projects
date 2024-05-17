using System;
using System.Runtime.CompilerServices; // Always used for a new .cs file

class Program
{                                           // Also creates the empty _entries, and _prompts lists
    static Journal journal = new Journal(); // tells the compiler that it needs to hold some memory in reserve when the program runs and among the first things it does should be to create that object and use the journal constructor to fill it. This happens implicitly at the start of main. (The compiler might put it of until later for efficiency reasons. Compiler optimization can do interesting things when it comes to code order. ) You can think of that actually happening at the start of main.
    static void Main() // Starts the core Logic where everything will take place.
    {
        while (true) // Main menu Display loop that will stick around 'forever'. The only way to 'escape' is closing the Console (Terminal) completely
        {
            DisplayMainMenu(); // Main Menu. (BE SURE TO ADD MY SPLASH PAGE ABOVE THE MENU OPTIONS)
        }
    }

    static void DisplayMainMenu() // Menu to display (and handle) the user's choices. You have to select the number, then hit 'enter' for it to work
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Show all entries");
        Console.WriteLine("3. Save entries to file");
        Console.WriteLine("4. Load entries from file");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: "); // Displayed on the same line because it's more aesthetic
        int choice = Convert.ToInt32(Console.ReadLine()); // Takes the user input, and converts it to a 32 bit integer (which is safer, by returning '0' in cases of null, rather than a FormatException error, which would break it more easily). 

        switch (choice) // Rather than "do (logic) while choice != 0", this is a: more readable, easier to maintain, and performance-friendly (in the case of a large number of choices. if-else statements are evaluated sequentially)
        {
            case 1:
                WriteNewEntry();
                break;
            case 2:
                ShowAllEntries();
                break;
            case 3:
                SaveEntriesToFile();
                break;
            case 4:
                LoadEntriesFromFile();
                break;
            case 5:
                Environment.Exit(0); // Calls up the Exit() method within the 'Environment' class from the system. The '0' parameter is the default exit code (any other number represents an error exiting)
                break;
            default:
                Console.WriteLine("Invalid option, please try again."); // Error-Handling for invalid input
                break;
        }
    }

    static void WriteNewEntry() // Method to create the new entry: Gets a randomized prompt, 
    {
        string prompt = journal.GetPrompt(); // Runs the 'GetPrompt()' method (function) within the Journal class, using the returned instantiated object and contains it within the variable 'journal' and, now, calls it the variable 'prompt' for this occasion
        Console.WriteLine(prompt); // Displays the prompt to the console (terminal)
        string userInput = Console.ReadLine(); // Reads the user's entered input and converts it over to the (string class) variable 'userInput'
        Entry entry = new Entry(prompt, userInput); // Instantiates an 'Entry' class object (by inserting the 'prompt' and 'userInput' variables as parameters), and calls that the Entry class variable named 'entry'
        journal.AddEntry(entry); // Opens up the instantiated 'journal' object-variable (which is empty, but knows what it needs) and runs the 'AddEntry' method (function) within the 'Journal' class, and uses the variable 'entry' (which contains the instance of the prompt and the userInput) as the Parameter
    }

    static void ShowAllEntries() // Straightforward method (function) that translates 1-1
    {
        journal.DisplayEntries(); // "All the work is over in the Journal class, just be sure to bring the 'journal' instance/object created here with you when you do it"
    }

    static void SaveEntriesToFile() // This method (function) adds a name to the instance-object-variable and submits it to SaveToFile() to be saved
    {
        Console.Write("Enter filename to save: "); // Displays instructions of what it's looking for (EG: the name that will be attached to the file)
        string filename = Console.ReadLine(); // "Whatever string you just entered, I'll call the file that"
        journal.SaveToFile(filename); // "This whole instance of the Journal Object will get slapped with the name [filename] and submitted to the SaveToFile() method (function) to do the work"
    }

    static void LoadEntriesFromFile() // This method (function) takes user input, inserts it into the filename and submits it as a parameter to the LoadFromFile() method (function), the results of which fills the '_entries' list and submits it (alongside the pre-filled _prompts list) to be the value for 'journal' for that instance-object 
    {
        Console.Write("Enter filename to load: "); // "What's the name of the file I should be looking for?"
        string filename = Console.ReadLine(); // "Whatever string you just entered, I'll call the file's name that"
        journal.LoadFromFile(filename); // "Take that filename and run it through the LoadFromFile method (function). Do whatever it tells you to do AS WELL AS load it all into our current value for the instance-object-variable (which should be the _entries list and the pre-filled _prompts list)
    }
}

