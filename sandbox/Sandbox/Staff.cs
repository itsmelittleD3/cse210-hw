public class Staff {
    protected string _firstName;
    protected string _lastName;
    protected string _gender;

    public Staff(string first, string last, string gender)
    {
        _firstName = first;
        _lastName = last;
        _gender = gender;
    }

    public void SetName(string first, string last)
    {
        _firstName = first;
        _lastName = last;
    }
    public virtual void DispayName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }
}