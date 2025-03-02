using System;
using System.Collections.Generic;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn from this experience?"
    };

    public ReflectingActivity() : base(0) { } 

    public void Run()
    {
        StartMessage("This is the reflecting activity", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        PauseWithAnimation();
        Console.Write("");
        
        
        if (duration <= 0) 
        {
            Console.WriteLine("Time must be greater than zero. Please try again.");
            return;
        }

        Random rand = new Random(); // random prompt generator
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("when you have something in mind, press enter to continue...");
        Console.ReadLine(); // enter to continue

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            Thread.Sleep(3000); //reflecting time
        }

        EndMessage("Reflecting Activity");
    }
}
