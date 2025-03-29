class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private string filePath = "mygoals.txt";
    
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    
    public void RecordGoalProgress(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordProgress();
        }
        else
        {
            Console.WriteLine("Not a goal.");
        }
    }
    
    public void DisplayGoals()
    {
        Console.WriteLine("\n--- GOALS ---");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write(i + 1 + ". ");
            goals[i].DisplayGoal();
        }
    }
    public int CalculateTotalPoints()

    {

        int totalPoints = 0;

        foreach (Goal goal in goals)
        {
            totalPoints += goal.GetPoints();
        }
        return totalPoints;
    }
      public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
     public void LoadGoals()// this part was a lot of trouble to get to work so I had Ai help me understand it.
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            goals.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                string[] data = parts[1].Split(',');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
                        break;
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
