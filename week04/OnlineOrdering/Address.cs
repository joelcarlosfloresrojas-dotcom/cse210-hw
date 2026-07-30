class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string w,string x,string y,string z)
    {
     _street=w;
     _city=x;
     _state=y;
     _country=z;   
    }

    public Boolean IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        
        return $"{_street}\n{_city},{_state},{_country}";
    }
    
}