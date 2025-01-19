using System;

class Program
{
    static void Main(string[] args)
    {
        //
        string adjective = getAdjective();
        string noun = getNoun();
        
        int number = Multiply(3,4);
        Console.WriteLine($"I looked out the window saw {number} {adjective} {noun}");
    }
    static int Multiply(int number1,int number2){
       return number1 * number2;
    }
    static string getAdjective()
    {
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("yellow");
        words.Add("big");
        words.Add("small");

        string adjective = "blue";

        return adjective;

        
    }

    static string getNoun(){
        string noun = "bird";
        return noun;

    }
}