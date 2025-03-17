class Address
{
    private string street, city, state, country;
    
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }
    
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}