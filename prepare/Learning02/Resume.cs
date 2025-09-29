using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine("Jobs: ");

        foreach (Job n in _jobs)
        {
            // My original code, but I didn't even realize I left out the other pieces of data. This code only printed the job titles. 
            // Console.WriteLine($"{n._jobTitle} ");

            // Sample Solution. I had a momentary lapse, but moving forward will make sure to re-read all the requirements.
            n.DisplayJobDetails();
        }
    }
}