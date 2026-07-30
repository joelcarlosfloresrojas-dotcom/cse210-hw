class Customer
{
    private string _name1;
    private Address _address;

    public Customer(string name, Address address)
    {   
        _address=address;
        _name1=name;
    }

    public string GetName()
    {
        return _name1;
    }


    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public Boolean GetUSA()
    {
        return _address.IsInUSA();
    }

    
}