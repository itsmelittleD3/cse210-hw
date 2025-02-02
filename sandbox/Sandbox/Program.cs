using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine("1) Add new Job");
        Console.WriteLine("2) Display resume");
        Console.WriteLine("3) Quit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        bool keepRunning = true;
        Resume theResume = new Resume();
       while (keepRunning)
       {
        DisplayMenu();

        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            //add new job
        }
        if(choice == "2")
        {
            //display resume
        }
        if(choice == "3")
        {
            //quit
        }
        else{
            Console.WriteLine("Please choose one of the displayed choices.");
        }

       }
    }
    
    
}