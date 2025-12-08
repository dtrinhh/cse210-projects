using System;

public class Customer
{
    private string _customerName;

    private Boolean _usaCustomer;

    // public void CustomerAddress(Address address)
    // {
    //     if (address.GetCountry().ToLower() == "usa")
    //     {
    //         _usaCustomer = true;
    //     }
    //     else if (address.GetCountry().ToLower() != "usa")
    //     {
    //         _usaCustomer = false;
    //     }        
    // }
    public bool USACustomer()
    {
        return _usaCustomer;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    // Alt method to confirm USA customer
    // public Customer(string customerName, Address address)
    // {
    //     _customerName = customerName;
    //     _usaCustomer = false;

    //     if (address.GetCountry().ToLower() == "usa")
    //     {
    //         _usaCustomer = true;
    //     }
    //     else if (address.GetCountry().ToLower() == "us")
    //     {
    //         _usaCustomer = true;
    //     }
    //     Console.WriteLine($"{_customerName}\n{address.DisplayAddress()}");
    // }
    
    public Customer(string cusotmerName, string street, string city, string stateProvince, string country)
    {
        _customerName = cusotmerName;
        // _usaCustomer = false;

        Address address = new Address(street, city, stateProvince, country);
        
        if (country.ToLower() == "usa")
        {
            _usaCustomer = true;
        }
        else if (country.ToLower() == "us")
        {
            _usaCustomer = true;
        }
        else
        {
            _usaCustomer = false;
        }

        Console.WriteLine($"{_customerName}\n{address.DisplayAddress()}");

    }
}