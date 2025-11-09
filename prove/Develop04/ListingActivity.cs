using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private List<string> _listingPrompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public List<string> _promptResponses = new List<string>
    {
        
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        StartMessage();

        Console.WriteLine("Lets begin the the Listing exercise...");

        PauseAnimation(5);

        DisplayRandomPrompt();

        DisplayTotalEntries();

        EndMessage();
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(_listingPrompt.Count);

        string randomPrompt = _listingPrompt[randomNum];

        Console.WriteLine(randomPrompt);
        Console.Write("Starting in ...");
        PauseTimer(7);
        Console.WriteLine();

        Console.WriteLine("List as many things as you can! ");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        

        while (DateTime.Now < endTime)
        {
            string userEntry = Console.ReadLine();
            _promptResponses.Add(userEntry);
        }
    }

    public void DisplayTotalEntries()
    {
        int totalEntries = _promptResponses.Count;
        Console.WriteLine($"You managed to list {totalEntries} items! ");
    }
}