using System;


class Program
{
    static void Main(string[] args)
    {
        string Choice = "";
        BreathingActivity breather = new BreathingActivity();
        ListingActivity lister = new ListingActivity();
        ReflectingActivity reflector = new ReflectingActivity();
        while (Choice != "4")
        {
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Enter choice: ");
            Choice = Console.ReadLine();
            if(Choice == "1")
            {
                breather.Run();
            }
            else if(Choice == "2")
            {
                reflector.Run();
            }
            else if(Choice == "3")
            {
                lister.Run();
            }
            else if(Choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        



    }
}