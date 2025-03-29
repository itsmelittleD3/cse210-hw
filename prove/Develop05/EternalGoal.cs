class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }
    
    public override void RecordProgress()
    {
        Console.WriteLine($"Recorded progress for: {Name} (+{Points} points)");
    }
    
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{Points}";
    }
}