// W 03 Prepare: Learning Activity: Abstraction: "Job" file
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

Class: Job
Attributes:
*_company: string
*_jobTitle: string
*_startYear: int
*_endYear: int

Display:
* Display() : void
*/

using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Constructor method//
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear}-{_endYear}");
    }
}