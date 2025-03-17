using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Tech Review: Best Laptops 2025", "LTT", 720);
        video1.AddComment("Alice", "Great review! Very informative.");
        video1.AddComment("Dane", "I love the macbook pro. What do you think?");
        video1.AddComment("Charlie", "Would you recommend this for students?");

        Video video2 = new Video("How to Cook Good Pasta", "Chef Antoine", 480);
        video2.AddComment("David", "Tried this recipe, and it was amazing!");
        video2.AddComment("Emma", "What sauce would you recommend?");
        video2.AddComment("Frank", "Can you make a gluten-free version?");

        Video video3 = new Video("Top 10 Travel Destinations", "The Travelmonkey", 900);
        video3.AddComment("Grace", "Adding these to my bucket list!");
        video3.AddComment("Hank", "Beautiful locations. Thanks for sharing!");
        video3.AddComment("Isabel", "Which one was your favorite?");

        Video video4 = new Video("Beginners guide to coding", "Code Academy", 600);
        video4.AddComment("Jake", "This was super helpful. Thanks!");
        video4.AddComment("Lily", "Can you make a part 2 with more advanced topics?");
        video4.AddComment("Mike", "What IDE do you recommend for beginners?");

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}