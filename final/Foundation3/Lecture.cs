class Lecture : Event
{
    private string Speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string Speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.Speaker = Speaker;
        this.capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {capacity}";
    }
}