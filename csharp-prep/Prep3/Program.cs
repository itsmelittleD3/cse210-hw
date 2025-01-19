using System;

class Program
{
    static void Main(string[] args)
    {
    string response;
    do 
    {
    Random randomGenerator = new Random();
    int secretNumber = randomGenerator.Next(1, 101);
    int guess=0;
    while (guess != secretNumber) {
    Console.WriteLine("Guess the secret number: ");
    guess = int.Parse(Console.ReadLine());
    if (secretNumber > guess){Console.WriteLine("Higher");}
    else if (secretNumber < guess){Console.WriteLine("Lower");}
    else if (secretNumber == guess){Console.WriteLine("You got it!");}
    }


    Console.Write("Do you want to continue? ");
    string responseraw = Console.ReadLine();
    response = responseraw.ToLower();
    } while(response == "yes");
    }
}