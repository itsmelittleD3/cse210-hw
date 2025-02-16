using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyScripture
{
    class Program
    {
        static void Main()
        {
            Scripture scripture = new Scripture(new Reference("3 Nephi", 5, 13), "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.");
            Console.Clear();
            scripture.Display(); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWords(2))
                {
                    Console.WriteLine("\nYou got it! You memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}
