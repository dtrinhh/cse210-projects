using System;

class LectureEvent : Event
{
    private int _maxCapacity;

    private int _currentCapacity;

    private string _speakerName;

    public LectureEvent(string title, string description, string date, string type ,string time, string address, int maxCapacity, int currentCapacity, string speakerName) : base(title, description, date, type, time, address)
    {
        _maxCapacity = maxCapacity;
        _currentCapacity = currentCapacity;
        _speakerName = speakerName;

        StandardDetails();
        FullDetails();
        LectureDetails(_maxCapacity, _currentCapacity, _speakerName);
        ShortDescription();
    }

    public void LectureDetails(int maxCapacity, int currentCapacity, string speakerName)
    {
        Console.WriteLine($"Speaker: {_speakerName}\nCurrent capacity: {_currentCapacity}/{_maxCapacity}. Only {_maxCapacity-_currentCapacity} spots left! ");
        Console.WriteLine();
    }
}