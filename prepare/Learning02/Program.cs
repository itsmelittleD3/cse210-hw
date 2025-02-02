using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine("1) Add new job");
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
            Console.Write("What is the name of the company");
            string company = Console.ReadLine();

            Console.Write("What is the position? ");
            string position = Console.ReadLine();

            Job newJob = new Job();
            newJob._company = company;
            newJob._title = position;
            newJob._startYear = "2005";
            newJob._endYear = "2025";

            theResume._jobs.Add(newJob);

        }
        if(choice == "2")
        {
            theResume.Display();
        }
        if(choice == "3")
        {
            keepRunning = false;
        }
        else{
            Console.WriteLine("Please choose one of the displayed choices.");
        }

       }
    }
    
    
}