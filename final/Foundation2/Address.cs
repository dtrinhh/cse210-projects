using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _streetAddress;

    private string _city;

    private string _stateProvince;

    private string _country;

    // Part of Alt method to confirm USA customer
    // public string GetCountry()
    // {
        
    //     return _country;
    // }
    
    public string DisplayAddress()
    {
        return $"{_streetAddress} {_city}, {_stateProvince}, {_country}";
    }

    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

}