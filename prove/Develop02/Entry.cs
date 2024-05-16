using System;


// ENTRY
/* 
1. Snapshot's DateTime, Takes Prompt, Takes Response to Prompt
2. Initializes values in a temporary object
3. Takes the fed values (pre-gen'd for prompt, typed in for userInput) and arranges it alongside contextual text
4. Converts it to a string and returns it anywhere outside the class when called upon
5. When the ShowAllEntries() in 'Program.cs' calls on DisplayEntries() in 'Journal.cs', it will call on Display() to display 'this' (the return from ToString())
6. When SaveEntriesToFile() in 'Program.cs' calls on SaveToFile() in 'Journal.cs', it will call on ToCSV() to uniquely format the variables and separate them with a unique separator and return it out
*/

public class Entry
{
    private DateTime _timeStamp; // This is where the timestamp will be stored
    private string _prompt; // The string used in the specific instance will go here
    private string _userInput; // This is where the unique string (body of the text) will go

    // There needs to be an initial establishment of an instance for the system to go off of
    public Entry(string prompt, string userInput) // When 'Entry' method (function) is going to be used
    { // make sure a Prompt and a userInput are put in as parameters (from 'Program.cs')
        _timeStamp = DateTime.Now; // The initial value of _timeStamp will use the constantly-updating 'Now' variable from the DateTime method (function) to snapshot the value
        _prompt = prompt; // The initial value of _prompt will be whatever the parameter 'prompt' is
        _userInput = userInput; // The user's System.ReadLine() will be the userInput Parameter fed into _userInput
    }

    public override string ToString() // all this does is convert the (f-string) elements to a string and returns it
    { // This method will be replace the method that the parent class uses
        return $"Timestamp: {_timeStamp.ToShortDateString()}\nPrompt: {_prompt}\n{_userInput}";
    } // 'ToShortDateString' = system's DateTime class' method to convert it to a string

    public void Display() // This is run within DisplayEntries() in Program.cs. a Foreach loop will use it.
    {
        Console.WriteLine(this); // Tells the Console (Terminal visual output) to display the entry generated
    }

    public string ToCsv() // This converts the individual entry to a CSV f-string with a unique separator
    {
        string customSeparator = "|-|"; // |-| is the unique combination I used
        return $"{_timeStamp.ToShortDateString()}{customSeparator}{_prompt}{customSeparator}{_userInput}";
    }

}