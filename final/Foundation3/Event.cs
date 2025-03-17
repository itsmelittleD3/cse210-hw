abstract class Event //used an abstact class for the base event
{
    protected string title, description, date, time;
    protected Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }
    public string GetStandardDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nLocation: {address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();
    public string GetShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {title}\nDate: {date}";
    }
}