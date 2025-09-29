using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "NOC Engineer";
        job1._company = "NiCE";
        job1._startYear = 2023;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Dad";
        job2._company = "Home";
        job2._startYear = 2026;
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Dustin Trinh";
        // Console.WriteLine("Jobs: ");
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.resumeDetails();
    }
}