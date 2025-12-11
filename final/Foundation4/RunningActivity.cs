using System;
using System.Diagnostics;

class RunningActivity : Activity
{
    private double _runningDistance;
    private double _runningSpeed;
    private double _runningPace;

    public override void DisplaySummary()
    {
        base.DisplaySummary();
        Console.WriteLine($"- Distance: {GetDistance()} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile ");
        Console.WriteLine();
    }

    // Math Logic
    public override double GetDistance()
    {
        return _runningDistance;
    }
    public override double GetSpeed()
    {
        _runningSpeed = _runningDistance / GetActivityLength() * 60;
        return _runningSpeed;
    }
    public override double GetPace()
    {
        _runningPace = 60 / _runningSpeed;
        return _runningPace;
    }

    // Constructor and sets _runningDistance
    public RunningActivity(string activtyType, string activityDate, double activtyLength, double distance) : base(activtyType, activityDate, activtyLength)
    {
        _runningDistance = distance;
    }
}
