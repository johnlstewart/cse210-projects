using System; // Always used for a new .cs file
using System.Collections.Generic; // Even though System is already in use, it takes extra care to call up the area in charge of generic collections <>
using System.IO; // Contains types that allow reading and writing to files and data streams, and types that provide basic file and directory support.

// JOURNAL
/* 

*/

public class Journal
{
    private List<Entry> _entries = new List<Entry>(); // Declares (and initializes) a list that will hold the object (unique instance of the variable value combination) created with Entry.cs
    private List<string> _prompts = new List<string> // Declares (and initializes) a list that will hold all the different prompt strings
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry(Entry entry) // Is going to take the resultant object that was made from the 'Entry()' method (function) (which is a uniquely-identified combination of the _timestamp, _prompt, and _userInput variables being impregnated with values)
    { // which was turned into the variable 'entry' in Program.cs, and use it as a parameter alongside AddEntry() add it to the _entries list variable
        _entries.Add(entry);
    } // Once it's done doing the action of adding it to the list, we don't need it anymore, so there's no return statement (It's a raw tool)

    public void DisplayEntries() // When ShowAllEntries() in 'Program.cs' calls it,
    {
        foreach (Entry entry in _entries) // it performs a foreach loop, going through each entry (could have had any name, like 'i', it's a temporary thing) in the _entries list here in 'Journal.cs'
        {
            entry.Display(); // and runs the Display() method (function) from 'Entry.cs' for it.
        }
    }

    public void SaveToFile(string filename) // When SaveEntriesToFile() in 'Program.cs' takes the variable 'filename' (which was read from user input), it runs 'SaveToFile' alongside it.
    {
        using (StreamWriter file = new StreamWriter(filename)) // 
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine(entry.ToCsv());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "|-|" }, StringSplitOptions.None);
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1].Trim(), parts[2].Trim());
                _entries.Add(entry);
            }
        }
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
