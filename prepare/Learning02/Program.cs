// W 03 Prepare: Learning Activity: Abstraction
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
*startYear: int
*_endYear: int

Display:
* Display() : void
*/

using System;

class Program
{
    // Running the main method (function)
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Novarad";
        job1._jobTitle = "Market Development Specialist";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Powur Energy";
        job2._jobTitle = "Independent Consultant";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume johnResume = new Resume();
        johnResume._name = "John Stewart";
        johnResume._jobs.Add(job1);
        johnResume._jobs.Add(job2);

        johnResume.Display();
    }
}