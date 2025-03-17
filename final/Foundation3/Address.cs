class Address
{
    private string street, city, state, zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    public string GetFullAddress()
    {
        return $"{street}, {city}, {state} {zipCode}";
    }
}