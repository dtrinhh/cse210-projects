using System;
using System.ComponentModel.DataAnnotations;

public class Goal
{
    private string _goalType;

    private string _goalName;

    private string _goalDescription;

    private int _goalPoints;

    // Adjust this from string to bool or int depending on how you want to display the symbol for completion, eternal(infinity symbol), or 1/2 (checklist)
    private string _goalCompleted;

    private bool _markedComplete;
    

    public Goal(string goalType, string goalName, string goalDescription, int goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalCompleted = " ";
    }

    // Second constructor to add if it is complete?!
    public Goal(string goalType, string goalName, string goalDescription, int goalPoints, string goalCompletion)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalCompleted = goalCompletion;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetName()
    {
        return _goalName;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    // is this proper? or should I use IsComplete() method somehow?
    public bool GetCompletionStatus()
    {
        return _markedComplete;
    }

    // public void DisplayPointTotals()
    // {

    // }

    // public void DisplayGoalList()
    // {
    //     Console.WriteLine($"This is the Goal!");
    //     Console.WriteLine($"GOAL TYPE: {_goalType}");
    //     Console.WriteLine($"GOAL NAME: {_goalName}");
    //     Console.WriteLine($"GOAL DESCRIPTION: {_goalDescription}");
    //     Console.WriteLine($"GOAL POINTS: {_goalPoints}");
    // }

    public virtual void RecordEvent()
    {
        _markedComplete = true;
    }
    
    public virtual string IsComplete()
    {
        _goalCompleted = " ";
        return _goalCompleted;
    }
}