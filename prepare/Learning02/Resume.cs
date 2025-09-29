using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void displayResume()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine("Jobs: ");
        foreach (Job n in _jobs)
        {
            Console.WriteLine($"{n._jobTitle} ");
        }
    }
}