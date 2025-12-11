using System;

class Activity
{
    private List<Activity> _activityLog = new List<Activity>();

    private string _activtyType;

    private string _activityDate;

    private double _activityLength;

    public double GetActivityLength()
    {
        return _activityLength;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public List<Activity> GetActivityList()
    {
        return _activityLog;
    }
    
    public void AddActivity(Activity activity)
    {
        _activityLog.Add(activity);
    }

    public virtual void DisplaySummary()
    {
        Console.Write($"{_activityDate} {_activtyType:F2} ({_activityLength:F2} minutes) ");
    }

    // Constructor and sets _activityType, _activityDate, and _activityLength
    public Activity(string activtyType, string activityDate, double activtyLength)
    {
        _activtyType = activtyType;
        _activityDate = activityDate;
        _activityLength = activtyLength;
    }
}