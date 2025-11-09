using System;

public class BreathingActivity : Activity
{
    // Is variable this needed?
    private int _programTimer;

    // private int 
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        StartMessage();

        _programTimer = duration;

        // Countdown for starting the breathing exercise
        Console.WriteLine("Lets begin the the Breathing exercise...");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        BreathingPrompt();

        EndMessage();
    }

// Is this needed?
    public void BreathingPrompt()
    {
        // Breathe in and breathe out countdowns based on user selection
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_programTimer);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            PauseTimer(5);
            Console.WriteLine();

            Console.Write("Breathe out...");
            PauseTimer(5);
            Console.WriteLine();
        }
    }
}