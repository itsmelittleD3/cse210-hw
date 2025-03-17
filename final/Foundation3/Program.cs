using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "10001");
        Event event1 = new Lecture("Tech Talk", "A talk on AI advancements", "2025-06-15", "10:00 AM", address1, "Dr. Smith", 150);
        Address address2 = new Address("456 Grand Ave", "Los Angeles", "CA", "90012");
        Event event2 = new Reception("Networking Night", "An evening of professional networking", "2025-07-10", "6:00 PM", address2, "rsvp@example.com");
        Address address3 = new Address("789 Park Rd", "Denver", "CO", "80202");
        Event event3 = new OutdoorGathering("Music in the Park", "Live music festival", "2025-08-20", "4:00 PM", address3, "Sunny and warm");
        Event[] events = { event1, event2, event3 };
        
        foreach (var e in events)
        {
            Console.WriteLine(e.GetStandardDetails() + "\n");
            Console.WriteLine(e.GetFullDetails() + "\n");
            Console.WriteLine(e.GetShortDescription() + "\n");
        }
    }
}