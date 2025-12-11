using System;
using System.Diagnostics;

class BikingActivity : Activity
{
    private double _bikingDistance;
    private double _bikingSpeed;
    private double _bikingPace;

    public override void DisplaySummary()
    {
        base.DisplaySummary();
        Console.WriteLine($"- Distance: {GetDistance()} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile ");
        Console.WriteLine();
    }

    // Math Logic
    public override double GetDistance()
    {
        _bikingDistance = GetActivityLength() / 60 * _bikingSpeed;
        return _bikingDistance;
    }
    public override double GetSpeed()
    {
        return _bikingSpeed;
    }
    public override double GetPace()
    {
        _bikingPace = GetActivityLength() / _bikingDistance;
        return _bikingPace;
    }

    // Constructor and sets _biking speed
    public BikingActivity(string activtyType, string activityDate, double activtyLength, double speed) : base(activtyType, activityDate, activtyLength)
    {
        _bikingSpeed = speed;
    }
}