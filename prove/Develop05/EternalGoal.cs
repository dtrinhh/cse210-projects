using System;

public class EternalGoal : Goal
{
    public override void RecordEvent()
    {

    }

    public override void IsComplete()
    {

    }

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public EternalGoal(string type, string name, string description, int points, string completion) : base(type, name, description, points, completion)
    {
        
    }

}