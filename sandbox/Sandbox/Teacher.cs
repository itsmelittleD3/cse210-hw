public class Teacher : Staff
{
    public Teacher(string first, string last, string gender, string room) : base(first, last, gender)
    {
        
        _room = room;
    }
    
    private string _room;

    public override void DispayName()
    {
        Console.WriteLine($"{_firstName} {_lastName} {_room}");
    }

}