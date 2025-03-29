abstract class Goal
{
    protected string Name;
    protected string Description;
    protected int Points;
    protected bool IsComplete;
    
    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }
    
    public abstract void RecordProgress();
    public abstract string GetStringRepresentation();
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsComplete ? "X" : " ")} ] {Name} - {Description} ({Points} pts)");
    }
     public int GetPoints()
    {
        return IsComplete ? Points : 0;//also had help with this 
    }
}
