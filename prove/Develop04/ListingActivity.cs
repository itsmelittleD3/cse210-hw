using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt gratitude this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(0) { } // Default constructor

    public void Run()
    {
        StartMessage("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        PauseWithAnimation();
        Console.Write("");
        if (duration <= 0) 
        {
            Console.WriteLine("Duration must be greater than zero. Please try again.");
            return;
        }

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You will now begin listing items...");
        Thread.Sleep(2000); // Short delay to prepare user

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items. Great job!");
        EndMessage("Listing Activity");
    }
}
