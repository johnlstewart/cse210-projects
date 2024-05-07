// W 03 Prepare: Learning Activity: Abstraction: "Resume" file
// John Stewart
// CSE 210
// 5/7/24


// Diagram Area //

/* 
Class: Resume
Attributes:
*_name : string
*_jobs : List<Job>

Behaviors: 
* Display() : void

*/

using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: "); // I don't like the aesthetics of the display. I'd prefer Jobs: Job1 
                                     //                                                                                                   Job2
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
