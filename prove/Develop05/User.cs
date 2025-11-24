using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class User
{
    
    // Protected or private for list?
    private List<Goal> _goalList = new List<Goal>();

    private int _userPoints = 0;
    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
    }

    public void ListGoals()
    {
        int _listCounter = 0;
        
        Console.WriteLine("The goals are: ");

        foreach (Goal g in _goalList)
        {
            _listCounter++;
            
            Console.WriteLine($"{_listCounter}. [{g.IsComplete()}] {g.GetName()} ({g.GetDescription()})");
            // Console.WriteLine($"{_listCounter}. [{g.GetCompletionStatus()}] {g.GetName()} ({g.GetDescription()})");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What would you like to name this file?");
        string goalFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"{goalFile}.txt"))
        {

            foreach (Goal g in _goalList)
            {
                outputFile.WriteLine($"{g.GetGoalType()}:~{g.GetName()}~{g.GetDescription()}~{g.GetPoints()}~{g.GetCompletionStatus()}");
            }
        }
    }
    
    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the goals file you'd like to load?");
        string goalFile = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines($"{goalFile}.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int goalPoints = int.Parse(parts[3]);

            Goal loadGoal = new Goal(goalType, goalName, goalDescription, goalPoints);
            _goalList.Add(loadGoal);
        }
    }

    public void UpdateGoal(int goalItem)
    {
        // foreach (Goal g in _goalList)
        //     {
        //         _goalList[goalItem].RecordEvent();
        //     }
        _goalList[goalItem-1].RecordEvent();
        _goalList[goalItem-1].IsComplete();
    }
    public void UserPoints()
    {
        int _totalPoints = 0;
        
        foreach (Goal g in _goalList)
        {
            bool completionStatus = g.GetCompletionStatus();
            if (completionStatus == true)
            {
                // _userPoints += g.GetPoints();
                _totalPoints = g.GetPoints();
            }
        }
        _userPoints += _totalPoints;
    }

    public string DisplayUserPoints()
    {
        return $"You have {_userPoints} points";
    }
}