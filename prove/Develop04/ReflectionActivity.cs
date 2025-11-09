using System;
using System.ComponentModel;

public class ReflectionActivity : Activity
{
    private List<string> _reflection = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _reflectionFollowUps = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // private List<string> _reflectionResponses;

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        StartMessage();
        
        Console.WriteLine("Lets begin the the Reflecting exercise...");

        PauseAnimation(5);

        DisplayRandomPrompt();

        DisplayFollowUps();

        EndMessage();
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(_reflection.Count);

        string randomPrompt = _reflection[randomNum];

        Console.WriteLine(randomPrompt);
        Thread.Sleep(8000);
    }

    public void DisplayFollowUps()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int randomNum = random.Next(_reflectionFollowUps.Count);

            string randomFollowUp = _reflectionFollowUps[randomNum];

            Console.Write(randomFollowUp);
            PauseAnimation(GetDuration() % 4);
            Console.WriteLine();
        }
    }
}