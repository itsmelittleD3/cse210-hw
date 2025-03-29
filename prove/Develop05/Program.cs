class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            int totalPoints = manager.CalculateTotalPoints();
            Console.WriteLine($"\nTotal Points: {totalPoints} points");
            Console.WriteLine("\n---GOAL TRACKER ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nEnter your choice 1-6: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());
                    manager.AddGoal(new SimpleGoal(name, description, points));
                    Console.WriteLine("Goal added.");
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.SaveGoals();
                    break;
                case "4":
                    manager.LoadGoals();
                    break;
                case "5":
                    manager.DisplayGoals();
                    Console.Write("Enter goal number to update: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalProgress(index);
                    break;
                case "6":
                    Console.WriteLine("byebye!");
                    return;
                default:
                    Console.WriteLine("Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
