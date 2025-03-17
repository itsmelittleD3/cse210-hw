class BreathingActivity : Activity
{
    public BreathingActivity() : base(0) { } 

    public BreathingActivity(int duration) : base(duration) { }

    public void Run()
    {
        StartMessage("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.\nClear your mind and focus on your breath.");

        PauseWithAnimation();
        Console.Write("");
        for (int i = 0; i < duration; i += 4)  
        {
            Countdown(3, "Breathe in...");
            Countdown(5, "Breathe out...");
        }

        EndMessage("Breathing Activity");
    }


        private void Countdown(int seconds, string message)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i}  "); // learned that \r moves cursor to the start
            Thread.Sleep(1000);
        }
        Console.Write("\r                 \r"); // Clears the line after countdown ends
    }

}
