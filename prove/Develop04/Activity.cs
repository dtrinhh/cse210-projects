using System;
using System.Reflection.Metadata.Ecma335;

public class Activity
{
    private string _name;

    private string _description;

    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

        new Activity(_name, _description, _duration);
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n{_description}\nHow long,in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void EndMessage()
    {
        Console.WriteLine($"Good job! You completed {_duration} seconds of the {_name}. ");
        // Console.WriteLine($"Good job! You completed {_duration} seconds of {_description}. ");
    }
    public void PauseAnimation(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void PauseTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

}