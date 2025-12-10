using System;

class Address
{
    // Not needed for base program
    // List<string> _eventAddress = new List<string>();
    private string _eventAddress;

    public Address(string eventAddress)
    {
        _eventAddress = eventAddress;
    }

    public string Getaddress()
    {
        return _eventAddress;
    }
}