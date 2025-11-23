using System;

public class ChecklistGoal : Goal
{
    private int _goalRepetitions;

    private int _progressRepetitions;

    private int _progressPoints;

    public override void RecordEvent()
    {

    }

    public override void IsComplete()
    {

    }
    
    public ChecklistGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        Console.WriteLine("How many times would you likes to do this goal before it is complete?");
        _goalRepetitions = int.Parse(Console.ReadLine());

        Console.WriteLine("How many points should you earn each time you record an event for this goal? ");
        _progressPoints = int.Parse(Console.ReadLine());

    }

    // Is this getter necessary?
    public int GetRepetitions()
    {
        return _goalRepetitions;
    }

}