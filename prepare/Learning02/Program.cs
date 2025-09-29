using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        // Initializing new jobs with title, company name, start year and end year 
        Job job1 = new Job();
        job1._jobTitle = "NOC Engineer";
        job1._company = "NiCE";
        job1._startYear = 2023;
        // job1._endYear = 0;

        Job job2 = new Job();
        job2._jobTitle = "Dad";
        job2._company = "Home";
        job2._startYear = 2026;
        // job2._endYear = 0;

        // Initialized a new resume with name and jobs input from the Job class. Displays Name and jobs.
        Resume resume1 = new Resume();
        resume1._name = "Dustin Trinh";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.displayResume();
    }
}