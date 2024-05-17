using System; // Always used for a new .cs file
using System.Collections.Generic; // Even though System is already in use, it takes extra care to call up the area in charge of generic collections <>
using System.IO; // Contains types that allow reading and writing to files and data streams, and types that provide basic file and directory support.

// JOURNAL
/* 
Besides making (and initializing) 2 lists (_entries, and _prompts), This Class does the bidding of 'Program.cs'. This is, mostly, the workhorse class.
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
        using (StreamWriter file = new StreamWriter(filename)) // Creates a StreamWriter object to write to the specified file
        {
            foreach (Entry entry in _entries) // Iterates through each Entry object in the _entries list.
            {
                file.WriteLine(entry.ToCsv()); // Writes the CSV representation of each entry to the file.
            } // The StreamWriter is automatically closed at the end of the using block.
        }
    }

    public void LoadFromFile(string filename) // When LoadEntriesFromFile() from 'Program.cs' is invoked, the console takes the user input and calls it 'filename', which is fed into LoadFromFile() as a parameter
    {
        _entries.Clear();  // Wipes out all the entries from the _entries list here on 'Journal.cs'
        string[] lines = File.ReadAllLines(filename); // Looks locally for a file called [filename] that you typed in from 'Program.cs' and opens it up to read all the lines from it. It then saves them to a local list, temporarily called 'lines'
        foreach (string line in lines) // Opens up 'lines' with a foreach loop, going over each individual line and naming it the variable 'line'
        {
            string[] parts = line.Split(new string[] { "|-|" }, StringSplitOptions.None); // Performs the 'Split' method to it (taking into account the parameters of "|-|" to be the separator, and doesn't have any additional special rules)
            if (parts.Length == 3) // says "If the line you just split (using that special separator) is exactly equal to 3 parts)
            {
                Entry entry = new Entry(parts[1].Trim(), parts[2].Trim()); // Performs the 'Entry()' method (function) on it (using the 'parts' list in the 2nd and 3rd position as the parameters and trims anything extra around them), resulting in an 'Entry' class object
                _entries.Add(entry);  // adds that object (now, temporarily called 'entry') as a variable within the _entries list
            }
        }
    }

    public string GetPrompt() // When GetNewEntry() in 'Program.cs' is invoked, it calls upon this method (function) to get a random one to return it as 'prompt'.
    {
        Random rand = new Random(); // Initializes a new object (somehow, randomly generated), and calls it the temporary variable 'rand'
        return _prompts[rand.Next(_prompts.Count)]; // Performs a count of the _prompts list, and inserts it as a parameter for the 'Next' method, which is being used on the 'rand' temporary variable. Whatever that value is (0-maxValue),
                                                    // is the selected prompt that is returned as a variable.
    }
}
