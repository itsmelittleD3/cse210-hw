class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredCompletions;
    private int bonusPoints;
    
    public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonusPoints) : base(name, description, points)
    {
        this.requiredCompletions = requiredCompletions;
        this.bonusPoints = bonusPoints;
        timesCompleted = 0;
    }
    
    public override void RecordProgress()
    {
        timesCompleted = timesCompleted + 1;
        if (timesCompleted >= requiredCompletions)
        {
            IsComplete = true;
            Console.WriteLine($"Completed: {Name} (+{Points + bonusPoints} points, Bonus!)");
        }
        else
        {
            Console.WriteLine($"Progress: {Name} {timesCompleted}/{requiredCompletions} (+{Points} points)");
        }
    }
    
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsComplete ? "X" : " ")} ] {Name} - {Description} ({Points} pts, { timesCompleted}/{requiredCompletions} completed)");
    }
    
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{timesCompleted},{requiredCompletions},{bonusPoints}";
    }
}