using System;
using System.Reflection.Metadata.Ecma335;

class Event
{
    private string _eventTitle;

    private string _eventDescription;

    private string _eventDate;
    private string _eventType;
    private string _eventTime;
    private string _eventAddress;

    public void StandardDetails()
    {
        // ALL events will use this method to display, but the specfic details will be printed by those classes.
        Console.WriteLine("STANDARD DETAILS: ");
        Console.WriteLine($"Event: {_eventTitle}\nDescription: {_eventDescription}\n{_eventDate} at {_eventTime}\nLocation: {_eventAddress}");
        Console.WriteLine();
    }

    public void FullDetails()
    {
        // ALL events will use this method to display, but the specfic details will be printed by those classes.
        Console.WriteLine("FULL DETAILS: ");
        Console.WriteLine($"Event: {_eventTitle} {_eventType}\nDescription: {_eventDescription}\nDate: {_eventDate} at {_eventTime}\nLocation: {_eventAddress}");
    }

    public void ShortDescription()
    {
        // ALL events will use this method to display, but the specfic details will be printed by those classes.
        Console.WriteLine("SHORT DESCRIPTION: ");
        Console.WriteLine($"{_eventTitle} {_eventType}\n{_eventDate}");
        Console.WriteLine();
    }

    public Event(string title, string description, string date, string type ,string time, string address)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventType = type;
        _eventTime = time;
        _eventAddress = address;        
    }
}