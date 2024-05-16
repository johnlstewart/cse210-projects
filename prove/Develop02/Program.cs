using System;

class Program
{
    static Journal journal = new Journal();

    static void Main() // Static is not passing in that object as the first thing because nothing has been set up.
    {
        while (true)
        {
            DisplayMainMenu();
        }
    }

    static void DisplayMainMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Show all entries");
        Console.WriteLine("3. Save entries to file");
        Console.WriteLine("4. Load entries from file");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
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
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }
    }

    static void WriteNewEntry()
    {
        string prompt = journal.GetPrompt();
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine();
        Entry entry = new Entry(prompt, userInput);
        journal.AddEntry(entry);
    }

    static void ShowAllEntries()
    {
        journal.DisplayEntries();
    }

    static void SaveEntriesToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadEntriesFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}

