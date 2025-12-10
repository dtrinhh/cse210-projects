using System;

class OutdoorEvent : Event
{
    private string _weatherForecast;

    public OutdoorEvent(string title, string description, string date, string type ,string time, string address, string weatherForecast) : base(title, description, date, type, time, address)
    {
        _weatherForecast = weatherForecast;

        StandardDetails();
        FullDetails();
        OurdoorEventDetails();
        ShortDescription();
    }

    public void OurdoorEventDetails()
    {
        Console.WriteLine($"Weather: {_weatherForecast}");
        Console.WriteLine();
    }

}