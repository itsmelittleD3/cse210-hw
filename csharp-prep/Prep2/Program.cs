using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade: ");
        string GradeInput = Console.ReadLine();
        int Grade = int.Parse(GradeInput);
        string letter;


        if (Grade >= 90) {letter = "A";}
        else if (Grade >= 80 && Grade <90) {letter = "B";}
        else if (Grade >= 70 && Grade <80) {letter = "C";}
        else if (Grade >= 60 && Grade <70) {letter = "D";}
        else {letter = "F";}
        Console.WriteLine($"Your grade is a {letter}");
        if (Grade >= 70) {Console.WriteLine("You passed!!");}
        else {Console.WriteLine("You Failed :(");}
    }
}