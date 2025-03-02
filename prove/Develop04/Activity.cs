using System;
using System.Diagnostics;

class Activity
{
    protected int duration;

    public Activity(int time)
    {
        duration = time;
    }

    public void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"\nStarting {activityName}...");
        Console.WriteLine(description);

        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int inputDuration) && inputDuration > 0)
            {
                duration = inputDuration;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        Console.Write("Get ready...");
        Thread.Sleep(1000);
    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine($"\nWell done! You completed the {activityName} for {duration} seconds.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); 
    }

    public void PauseWithAnimation()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine("\rLet's begin! ");
    }
    
}
