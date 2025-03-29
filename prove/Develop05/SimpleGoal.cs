class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }
    
    public override void RecordProgress()
    {
        IsComplete = true;
        Console.WriteLine($"Completed: {Name} (+{Points} points)");
    }
    
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{IsComplete}";
    }
}