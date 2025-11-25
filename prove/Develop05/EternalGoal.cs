using System;

public class EternalGoal : Goal
{
    private string _goalCompleted;
    // public override void RecordEvent()
    // {

    // }

    public override string IsComplete()
    {
        _goalCompleted = " ";

        if (base._markedComplete == true)
        {
            string infinitySymbol = "\u221E";
            _goalCompleted = $"{infinitySymbol}";
        }

        return _goalCompleted;
    }

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public EternalGoal(string type, string name, string description, int points, string completion) : base(type, name, description, points, completion)
    {
        
    }

}