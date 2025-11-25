using System;

public class SimpleGoal : Goal
{
    private string _goalCompleted;

    // private bool _markedComplete;
    // public override void RecordEvent()
    // {

    // }

    public override string IsComplete()
    {
        _goalCompleted = " ";
        if (base._markedComplete == true)
        {
            _goalCompleted = "x";
        }
        
        return _goalCompleted;
    }

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public SimpleGoal(string type, string name, string description, int points, string completion) : base(type, name, description, points, completion)
    {
        
    }
}