using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.Write($"{_jobTitle} ");
        Console.Write($"{_company} ");
        Console.Write($"{_startYear} ");
        Console.WriteLine($"{_endYear} ");
    } 
}