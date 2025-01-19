using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string Name = AskName();
        int Number = AskNumber();
        int squaredNumber = SquareNumber(Number);
        Final(Name, squaredNumber);
    }

    static void WelcomeMessage()
    {
        Console.Write("Welcome to the program!");
    }
    static string AskName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name; 
    }
    static int AskNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int name = int.Parse(Console.ReadLine());
        return name; 
    }
    static int SquareNumber(int number)
    {
        int square = number* number;
        return square;
    }
    static void Final(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}