using System;

class Program
{
    static void Main(string[] args)
    {
    List<int> numbers = new List<int>();
    int userNumber = -1;
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    while (userNumber != 0)
    {
        Console.WriteLine("Enter a number: ");
            
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }

    }
    int total = 0;
    foreach (int numb in numbers)
        {
            total += numb;
        }

    Console.WriteLine($"The total is: {total}");
    float avg = ((float)total) / numbers.Count;
    Console.WriteLine($"The average is: {avg}");
    int max = numbers[0];

    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }

    }
    Console.WriteLine($"The max is: {max}");
    




    }
}