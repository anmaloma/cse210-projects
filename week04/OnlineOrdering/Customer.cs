using System;


public class Customer
{
    private string _customerName;
    private Address _address;


    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool LiveInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }
}