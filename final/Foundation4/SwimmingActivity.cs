using System;
using System.Diagnostics;

class SwimmingActivity : Activity
{
    private double _lapAmount;
    private double _swimmingDistance;
    private double _swimmingSpeed;
    private double _swimmingPace;

    public override void DisplaySummary()
    {
        base.DisplaySummary();
        Console.WriteLine($"- Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile ");
        Console.WriteLine();
    }

    // Math Logic
    public override double GetDistance()
    {
        _swimmingDistance = _lapAmount * 50 / 1000 * 0.62;
        return _swimmingDistance;
    }
    public override double GetSpeed()
    {
        _swimmingSpeed = _swimmingDistance / GetActivityLength() * 60;
        return _swimmingSpeed;
    }
    public override double GetPace()
    {
        _swimmingPace = GetActivityLength() / _swimmingDistance;
        return _swimmingPace;
    }

    // Constructor and sets _lapAmount speed
    public SwimmingActivity(string activtyType, string activityDate, double activtyLength, double lapAmount) : base(activtyType, activityDate, activtyLength)
    {
        _lapAmount = lapAmount;
    }
}