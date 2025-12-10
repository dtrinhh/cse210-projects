using System;

class ReceptionEvent : Event
{
    private string _eventRSVP;

    private int _confirmedRSVP;

    public ReceptionEvent(string title, string description, string date, string type ,string time, string address, string eventRSVP, int confirmedRSVP) : base(title, description, date, type, time, address)
    {
        _eventRSVP = eventRSVP;
        _confirmedRSVP = confirmedRSVP;
        
        StandardDetails();
        FullDetails();
        ReceptionDetails();
        ShortDescription();
    }

    public void ReceptionDetails()
    {
        Console.WriteLine($"Email RSVP: {_eventRSVP}\nConfirmed RSVP's: {_confirmedRSVP}");
        Console.WriteLine();
    }

}