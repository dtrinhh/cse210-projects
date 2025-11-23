using System;

public class SimpleGoal : Goal
{
    public override void RecordEvent()
    {

    }

    public override void IsComplete()
    {

    }

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public SimpleGoal(string type, string name, string description, int points, string completion) : base(type, name, description, points, completion)
    {
        
    }
}